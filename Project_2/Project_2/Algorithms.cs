using System;
using System.Collections.Generic;
using System.Linq;
using Project_2;

//Shortest Remaining Time First (SRTF) and Multi-Level Feedback Queue (MLFQ)

namespace Project_2
{
    internal class Algorithms
    {
        /*
             This method schedules processes using Shortest Remaining Time First algorithm
             */
        public void SRTF(List<PCB> list)
        {
            if (list == null || list.Count == 0) return;
            List<PCB> ready = new List<PCB>(); // List of ready processes
            List<PCB> done = new List<PCB>(); // List of terminated processes
            PCB process = null;
            int currentTime = 0;

            while (done.Count < list.Count) // Loop until processes completed
            {
                foreach (PCB p in list) // Add arrived processes to ready queue
                {
                    if (p.ready == false && currentTime >= p.arrivalTime)
                    {
                        p.ready = true;
                        ready.Add(p);
                    }
                }


                if (ready.Count > 0)
                {
                    process = ready.OrderBy(p => p.remainingTime).ThenBy(p => p.arrivalTime).First(); // Arrived process list ordered from least to greatest remaining and arrival time to break ties

                    if (process.remainingTime == process.burstTime) // Initialize process start time
                        process.startTime = currentTime;
                    process.remainingTime--;
                    currentTime++; // Time unit incremented
                    if (process.remainingTime == 0) // Process Completes execution
                    {
                        process.endTime = currentTime;
                        ready.Remove(process);
                        done.Add(process);
                    }
                }
                else
                {
                    currentTime++;
                }
            }

            // performance metrics
            int totalTime = done.Max(p => p.endTime);
            int totalBT = done.Sum(p => p.burstTime);
            int avgTAT = (done.Sum(p => p.turnaroundTime)) / done.Count;
            int avgWT = (done.Sum((p) => p.waitingTime)) / done.Count;
            float cpuUtilization = ((float)totalBT / totalTime) * 100;
            float throughput = ((float)done.Count / totalTime);

            Console.WriteLine("SRTF Results");
            Console.WriteLine("Average Turnaround Time: {0}\nAverage Wait Time: {1}\nCPU Utilization: {2:F2}%\nThroughput (Processes per Second): {3:F4}", avgTAT, avgWT, cpuUtilization, throughput);
            Console.WriteLine(new string('-', 50));

            foreach (PCB p in done) // Print each process's metrics
            {
                Console.WriteLine(p);
                Console.WriteLine(new string('-', 50));
            }
        }

        /*
        This method schedules processes using a Multi-Level Feedback Queue algorithm
        Algorithms implemented include Round-Robin Scheduling and FCFS
         */
        public void MLFQ(List<PCB> list)
        {
            if (list == null || list.Count == 0) return;
            Queue<PCB> queue1 = new Queue<PCB>(); // Highest priority RR scheduling, TQ = 6
            Queue<PCB> queue2 = new Queue<PCB>(); // Mid-level priority RR scheduling, TQ = 12
            Queue<PCB> queue3 = new Queue<PCB>(); // Lowest priority scheduling, FCFS
            List<PCB> done = new List<PCB>();
            PCB process = null;
            int TQ = 0; // Time Quantum
            int currentTime = 0;

            list = list.OrderBy(p => p.arrivalTime).ThenBy(p => p.priority).ToList(); // Sort list from smallest to largest arrival time, use priority to break ties
            while (done.Count < list.Count)
            {
                foreach (PCB p in list)
                {
                    if (p.arrivalTime <= currentTime && p.ready == false)
                    {
                        p.ready = true;
                        queue1.Enqueue(p);
                    }
                } // Place ready processes in first priority queue

                if (queue1.Count > 0) // RR scheduling, TQ = 6
                {
                    TQ = 6;
                    process = queue1.First();
                    process.startTime = currentTime;
                    if (process.burstTime <= TQ)
                    {
                        
                        currentTime += process.burstTime;
                        process.endTime = currentTime;
                        process.remainingTime = 0;
                        done.Add(process); // Process finishes
                        queue1.Dequeue();
                    }
                    else // Demotion case
                    {
                        currentTime += TQ;
                        process.remainingTime -= TQ;
                        queue1.Dequeue();
                        queue2.Enqueue(process);
                    }
                }

                if (queue2.Count > 0 && queue1.Count == 0) // RR scheduling, TQ = 12
                {
                    TQ = 12;
                    process = queue2.First();
                    if (process.remainingTime <= TQ)
                    {
                        currentTime += process.remainingTime;
                        process.endTime = currentTime;
                        process.remainingTime = 0;
                        done.Add(process);
                        queue2.Dequeue();
                    }
                    else
                    {
                        currentTime += TQ;
                        process.remainingTime -= TQ;
                        queue2.Dequeue();
                        queue3.Enqueue(process);
                    }
                }

                if (queue3.Count > 0 && queue1.Count == 0 && queue2.Count == 0) // FCFS
                {
                    process = queue3.First();
                    currentTime += process.remainingTime;
                    process.endTime = currentTime;
                    process.remainingTime = 0;
                    done.Add(process);
                    queue3.Dequeue();
                }

                if (queue1.Count == 0 && queue2.Count == 0 && queue3.Count == 0)
                {
                    currentTime++;
                }
            }

            // performance metrics
            int totalTime = done.Max(p => p.endTime);
            int totalBT = done.Sum(p => p.burstTime);
            int avgTAT = (done.Sum(p => p.turnaroundTime)) / done.Count;
            int avgWT = (done.Sum((p) => p.waitingTime)) / done.Count;
            float cpuUtilization = ((float)totalBT / totalTime) * 100;
            float throughput = (float)done.Count / totalTime;

            Console.WriteLine("MLFQ Results");
            Console.WriteLine("Average Turnaround Time: {0}\nAverage Wait Time: {1}\nCPU Utilization: {2:F2}%\nThroughput (Processes per Second): {3:F4}", avgTAT, avgWT, cpuUtilization, throughput);
            Console.WriteLine(new string('-', 50));

            foreach (PCB p in done) // Print each process's metrics
            {
                Console.WriteLine(p);
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}