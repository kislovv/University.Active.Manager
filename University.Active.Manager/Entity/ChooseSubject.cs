using System.ComponentModel.DataAnnotations;

namespace University.Active.Manager.Entity;

public class ChooseSubject
{
    public Subject Subject { get; set; }

    public uint Score { get; set; }
}
