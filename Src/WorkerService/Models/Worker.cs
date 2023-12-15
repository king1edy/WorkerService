namespace WorkerService.API.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Shift> Shifts { get; set; }
    }
}
