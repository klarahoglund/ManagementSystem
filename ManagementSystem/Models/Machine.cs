namespace ManagementSystem.Models
{
    public class Machine
    {


        public string MachineName { get; set; } = string.Empty;
        public int Id { get; set; }
        public MachineStatus Status { get; set; }

    }
}
