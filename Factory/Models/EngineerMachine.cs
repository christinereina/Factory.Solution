namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachinetId { get; set; }
    public int EngineerId { get; set; }
    public int MachineId { get; set; }
    public Engineer Engineer { get; set; }
    public Machine Machine { get; set; }
  }
}