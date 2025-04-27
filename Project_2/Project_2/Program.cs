using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Project_2;

namespace Project_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Algorithms a = new Algorithms();

            Console.WriteLine("WORKLOAD 1:"); // First workload test
            List<PCB> processes = new List<PCB>
            {
                new PCB(1, arrivalTime: 0,  burstTime: 8,  remainingTime: 8,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(2, arrivalTime: 1,  burstTime: 4,  remainingTime: 4,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(3, arrivalTime: 2,  burstTime: 9,  remainingTime: 9,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(4, arrivalTime: 3,  burstTime: 5,  remainingTime: 5,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(5, arrivalTime: 6,  burstTime: 2,  remainingTime: 2,  priority: 1, startTime: 0, endTime: 0, ready: false),
            };

            a.SRTF(processes);
            Console.WriteLine("\n\n");

            processes = new List<PCB>
            {
                new PCB(1, arrivalTime: 0,  burstTime: 8,  remainingTime: 8,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(2, arrivalTime: 1,  burstTime: 4,  remainingTime: 4,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(3, arrivalTime: 2,  burstTime: 9,  remainingTime: 9,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(4, arrivalTime: 3,  burstTime: 5,  remainingTime: 5,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(5, arrivalTime: 6,  burstTime: 2,  remainingTime: 2,  priority: 1, startTime: 0, endTime: 0, ready: false),
            };

            a.MLFQ(processes);
            Console.WriteLine("\n\n");

            Console.WriteLine("WORKLOAD 2:"); // Second workload test
            processes = new List<PCB>
            {
                new PCB(1,  arrivalTime: 8,  burstTime: 12, remainingTime: 12, priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(2,  arrivalTime: 0,  burstTime: 6,  remainingTime: 6,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(3,  arrivalTime: 17, burstTime: 1,  remainingTime: 1,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(4,  arrivalTime: 5,  burstTime: 15, remainingTime: 15, priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(5,  arrivalTime: 33,  burstTime: 3,  remainingTime: 3,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(6,  arrivalTime: 13, burstTime: 10, remainingTime: 10, priority: 5, startTime: 0, endTime: 0, ready: false),
                new PCB(7,  arrivalTime: 0,  burstTime: 4,  remainingTime: 4,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(8,  arrivalTime: 9,  burstTime: 7,  remainingTime: 7,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(9,  arrivalTime: 20,  burstTime: 9,  remainingTime: 9,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(10, arrivalTime: 11, burstTime: 2,  remainingTime: 2,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(11, arrivalTime: 6,  burstTime: 13, remainingTime: 13, priority: 5, startTime: 0, endTime: 0, ready: false),
                new PCB(12, arrivalTime: 15, burstTime: 5,  remainingTime: 5,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(13, arrivalTime: 4,  burstTime: 1,  remainingTime: 1,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(14, arrivalTime: 7,  burstTime: 8,  remainingTime: 8,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(15, arrivalTime: 14, burstTime: 11, remainingTime: 11, priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(16, arrivalTime: 16, burstTime: 4,  remainingTime: 4,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(17, arrivalTime: 18, burstTime: 3,  remainingTime: 3,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(18, arrivalTime: 10, burstTime: 6,  remainingTime: 6,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(19, arrivalTime: 16, burstTime: 9,  remainingTime: 9,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(20, arrivalTime: 19, burstTime: 5,  remainingTime: 5,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(21, arrivalTime: 21, burstTime: 2,  remainingTime: 2,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(22, arrivalTime: 31, burstTime: 14, remainingTime: 14, priority: 5, startTime: 0, endTime: 0, ready: false),
                new PCB(23, arrivalTime: 22, burstTime: 7,  remainingTime: 7,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(24, arrivalTime: 25, burstTime: 6,  remainingTime: 6,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(25, arrivalTime: 45, burstTime: 3,  remainingTime: 3,  priority: 3, startTime: 0, endTime: 0, ready: false)
            };
            a.SRTF(processes);
            Console.WriteLine("\n\n");

            processes = new List<PCB>
            {
                new PCB(1,  arrivalTime: 8,  burstTime: 12, remainingTime: 12, priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(2,  arrivalTime: 0,  burstTime: 6,  remainingTime: 6,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(3,  arrivalTime: 17, burstTime: 1,  remainingTime: 1,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(4,  arrivalTime: 5,  burstTime: 15, remainingTime: 15, priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(5,  arrivalTime: 33,  burstTime: 3,  remainingTime: 3,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(6,  arrivalTime: 13, burstTime: 10, remainingTime: 10, priority: 5, startTime: 0, endTime: 0, ready: false),
                new PCB(7,  arrivalTime: 0,  burstTime: 4,  remainingTime: 4,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(8,  arrivalTime: 9,  burstTime: 7,  remainingTime: 7,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(9,  arrivalTime: 20,  burstTime: 9,  remainingTime: 9,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(10, arrivalTime: 11, burstTime: 2,  remainingTime: 2,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(11, arrivalTime: 6,  burstTime: 13, remainingTime: 13, priority: 5, startTime: 0, endTime: 0, ready: false),
                new PCB(12, arrivalTime: 15, burstTime: 5,  remainingTime: 5,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(13, arrivalTime: 4,  burstTime: 1,  remainingTime: 1,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(14, arrivalTime: 7,  burstTime: 8,  remainingTime: 8,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(15, arrivalTime: 14, burstTime: 11, remainingTime: 11, priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(16, arrivalTime: 16, burstTime: 4,  remainingTime: 4,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(17, arrivalTime: 18, burstTime: 3,  remainingTime: 3,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(18, arrivalTime: 10, burstTime: 6,  remainingTime: 6,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(19, arrivalTime: 16, burstTime: 9,  remainingTime: 9,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(20, arrivalTime: 19, burstTime: 5,  remainingTime: 5,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(21, arrivalTime: 21, burstTime: 2,  remainingTime: 2,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(22, arrivalTime: 31, burstTime: 14, remainingTime: 14, priority: 5, startTime: 0, endTime: 0, ready: false),
                new PCB(23, arrivalTime: 22, burstTime: 7,  remainingTime: 7,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(24, arrivalTime: 25, burstTime: 6,  remainingTime: 6,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(25, arrivalTime: 45, burstTime: 3,  remainingTime: 3,  priority: 3, startTime: 0, endTime: 0, ready: false)
            };
            a.MLFQ(processes);
            Console.WriteLine("\n\n");

            Console.WriteLine("WORKLOAD 3:"); // Third workload test
            processes = new List<PCB>
            {
                new PCB(1, arrivalTime: 0,  burstTime: 3,  remainingTime: 3,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(2, arrivalTime: 5,  burstTime: 2,  remainingTime: 2,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(3, arrivalTime: 10, burstTime: 1,  remainingTime: 1,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(4, arrivalTime: 20, burstTime: 5,  remainingTime: 5,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(5, arrivalTime: 35, burstTime: 4,  remainingTime: 4,  priority: 5, startTime: 0, endTime: 0, ready: false),
                new PCB(6, arrivalTime: 50, burstTime: 2,  remainingTime: 2,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(7, arrivalTime: 60, burstTime: 3,  remainingTime: 3,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(8, arrivalTime: 75, burstTime: 1,  remainingTime: 1,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(9, arrivalTime: 90, burstTime: 2,  remainingTime: 2,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(10, arrivalTime: 105, burstTime: 6, remainingTime: 6,  priority: 5, startTime: 0, endTime: 0, ready: false)
            };
            a.SRTF(processes);
            Console.WriteLine("\n\n");

            processes = new List<PCB>
            {
                new PCB(1, arrivalTime: 0,  burstTime: 3,  remainingTime: 3,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(2, arrivalTime: 5,  burstTime: 2,  remainingTime: 2,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(3, arrivalTime: 10, burstTime: 1,  remainingTime: 1,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(4, arrivalTime: 20, burstTime: 5,  remainingTime: 5,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(5, arrivalTime: 35, burstTime: 4,  remainingTime: 4,  priority: 5, startTime: 0, endTime: 0, ready: false),
                new PCB(6, arrivalTime: 50, burstTime: 2,  remainingTime: 2,  priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(7, arrivalTime: 60, burstTime: 3,  remainingTime: 3,  priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(8, arrivalTime: 75, burstTime: 1,  remainingTime: 1,  priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(9, arrivalTime: 90, burstTime: 2,  remainingTime: 2,  priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(10, arrivalTime: 105, burstTime: 6, remainingTime: 6,  priority: 5, startTime: 0, endTime: 0, ready: false)
            };
            a.MLFQ(processes);
            Console.WriteLine("\n\n");

            Console.WriteLine("WORKLOAD 4:"); // Fourth workload test
            processes = new List<PCB>
            {
                new PCB(1, arrivalTime: 0, burstTime: 18, remainingTime: 18, priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(2, arrivalTime: 2, burstTime: 4, remainingTime: 4, priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(3, arrivalTime: 5, burstTime: 2, remainingTime: 2, priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(4, arrivalTime: 8, burstTime: 1, remainingTime: 1, priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(5, arrivalTime: 10, burstTime: 20, remainingTime: 20, priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(6, arrivalTime: 12, burstTime: 3, remainingTime: 3, priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(7, arrivalTime: 15, burstTime: 1, remainingTime: 1, priority: 5, startTime: 0, endTime: 0, ready: false),
                new PCB(8, arrivalTime: 20, burstTime: 5, remainingTime: 5, priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(9, arrivalTime: 22, burstTime: 2, remainingTime: 2, priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(10, arrivalTime: 30, burstTime: 8, remainingTime: 8, priority: 2, startTime: 0, endTime: 0, ready: false)
            };
            a.SRTF(processes);
            Console.WriteLine("\n\n");

            processes = new List<PCB>
            {
                new PCB(1, arrivalTime: 0, burstTime: 18, remainingTime: 18, priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(2, arrivalTime: 2, burstTime: 4, remainingTime: 4, priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(3, arrivalTime: 5, burstTime: 2, remainingTime: 2, priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(4, arrivalTime: 8, burstTime: 1, remainingTime: 1, priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(5, arrivalTime: 10, burstTime: 20, remainingTime: 20, priority: 1, startTime: 0, endTime: 0, ready: false),
                new PCB(6, arrivalTime: 12, burstTime: 3, remainingTime: 3, priority: 2, startTime: 0, endTime: 0, ready: false),
                new PCB(7, arrivalTime: 15, burstTime: 1, remainingTime: 1, priority: 5, startTime: 0, endTime: 0, ready: false),
                new PCB(8, arrivalTime: 20, burstTime: 5, remainingTime: 5, priority: 3, startTime: 0, endTime: 0, ready: false),
                new PCB(9, arrivalTime: 22, burstTime: 2, remainingTime: 2, priority: 4, startTime: 0, endTime: 0, ready: false),
                new PCB(10, arrivalTime: 30, burstTime: 8, remainingTime: 8, priority: 2, startTime: 0, endTime: 0, ready: false)
            };

            a.MLFQ(processes);
            Console.WriteLine("\n\n");
        }
    }
}