namespace WorkerService.API.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}