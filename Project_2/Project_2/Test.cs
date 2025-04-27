//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Project_2
//{
//    internal class Test
//    {
//        static void Main(string[] args)
//        {
//            List<PCB> processes = new List<PCB>
//            {
//                new PCB(1, arrivalTime: 0, burstTime: 5, remainingTime: 5, priority: 2, startTime: 0, endTime: 0, ready: false),
//                new PCB(2, arrivalTime: 2, burstTime: 3, remainingTime: 3, priority: 1, startTime: 0, endTime: 0, ready: false),
//                new PCB(3, arrivalTime: 4, burstTime: 1, remainingTime: 1, priority: 3, startTime: 0, endTime: 0, ready: false)
//            };

//            // Sort by arrival time (FCFS)
//            processes = processes.OrderBy(p => p.arrivalTime).ToList();

//            int currentTime = 0;

//            foreach (var process in processes)
//            {
//                if (currentTime < process.arrivalTime)
//                    currentTime = process.arrivalTime;

//                process.startTime = currentTime;
//                process.endTime = currentTime + process.burstTime;
//                currentTime = process.endTime;
//            }

//            Console.WriteLine("FCFS Scheduling Simulation:\n");

//            foreach (var process in processes)
//            {
//                Console.WriteLine(process);
//                Console.WriteLine($"Turnaround Time: {process.turnaroundTime}");
//                Console.WriteLine($"Waiting Time: {process.waitingTime}");
//                Console.WriteLine(new string('-', 40));
//            }
//        }
//    }
//}


/*
  // Schedules processes using SRTF algorithm
        public void SRTF(List<PCB> list)
        {
            if (list == null || list.Count == 0) return;
            List<PCB> ready = new List<PCB>(); // ready queue
            List<PCB> done = new List<PCB>();
            //PCB process = list[0];
            PCB process = null;
            int currentTime = 0;
            int totalTime = 0;
            int totalBT = 0;
            int avgTAT = 0;
            int avgWT = 0;
            float cpuUtilization = 0;
            float throughput = 0;

            while (done.Count < list.Count) // Loop until processes completed
            {
                foreach (PCB p in list)
                {
                    if (p.ready == false && currentTime >= p.arrivalTime)
                    {
                        p.ready = true;
                        ready.Add(p);
                    }
                }

                
                //if (ready.Count > 0) 
                //{
                    //foreach (PCB p in ready)
                    //{
                        //if (process.remainingTime > p.remainingTime) 
                            //process = p;
                    //}
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
    //if (complete == list.Count)
    //{
        //totalTime = process.endTime;
    //}
    //else
    //{
        //process = ready.First();
    //}
}
                }
                else
{
    currentTime++;
}
            }

            totalTime = done.Max(p => p.endTime);
totalBT = done.Sum(p => p.burstTime);
avgTAT = (done.Sum(p => p.turnaroundTime)) / done.Count;
avgWT = (done.Sum((p) => p.waitingTime)) / done.Count;
cpuUtilization = ((float)totalBT / totalTime) * 100;
throughput = (float)done.Count / totalTime;
// performance metrics

Console.WriteLine("SRTF Results");
Console.WriteLine("Average Turnaround Time: {0}\nAverage Wait Time: {1}\nCPU Utilization: {2:F2}%\nThroughput (Processes per Second): {3:F4}", avgTAT, avgWT, cpuUtilization, throughput);
Console.WriteLine(new string('-', 50));

foreach (PCB p in done) // Print each process's metrics
{
    Console.WriteLine(p);
    Console.WriteLine(new string('-', 50));
}
        }
 */