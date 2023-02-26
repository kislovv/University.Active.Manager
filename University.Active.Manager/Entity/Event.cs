using System;
using System.Collections.Generic;

namespace University.Active.Manager.Entity;

public class Event
{
    public Guid EventId { get; set; }
    public uint Quota { get; set; }
    public ICollection<Student> Members { get; set; }
    public bool IsDone { get; set; }
    public uint Score { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public string Place { get; set; }
    public string Name { get; set; }
} 