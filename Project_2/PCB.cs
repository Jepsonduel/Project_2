
// Process control block
namespace Project_2
{
    class PCB
    {
        public int ID { get; set; }
        public int arrivalTime { get; set; }
        public int burstTime { get; set; }
        public int remainingTime { get; set; }
        public int priority { get; set; }
        public int startTime { get; set; }
        public int endTime { get; set; }
        public int turnaroundTime => endTime - arrivalTime;
        public int waitingTime => turnaroundTime - burstTime;
        public bool ready { get; set; }

        public PCB() { }

        public PCB(int iD, int arrivalTime, int burstTime, int remainingTime, int priority, int startTime, int endTime, bool ready)
        {
            ID = iD;
            this.arrivalTime = arrivalTime;
            this.burstTime = burstTime;
            this.remainingTime = remainingTime;
            this.priority = priority;
            this.startTime = startTime;
            this.endTime = endTime;
            this.ready = ready;
        }

        public override string ToString()
        {
            return $"Process: {ID}\nArrival: {arrivalTime}\nBurst: {burstTime}\nPriority: {priority}\nStart: {startTime}\nEnd: {endTime}\nTurnaround: {turnaroundTime}\nWait: {waitingTime}";
        }
    }
}