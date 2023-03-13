namespace University.Active.Manager.Contracts.Event
{
    public class Event
    {
        public uint Quota { get; set; }
        public bool IsDone { get; set; }
        public uint Score { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Place { get; set; }
        public string Name { get; set; }
    }    
}

