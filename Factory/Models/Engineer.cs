using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public string EngineerSkill { get; set; }
    public DateTime HireDate { get; set; }
    public ICollection<EngineerMachine> Machine { get; set; }
  }
}