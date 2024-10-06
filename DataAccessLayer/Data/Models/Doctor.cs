namespace day2withDB.Data.Models
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Specialization { get; set; }
        public int PerformanceRate { get; set; }
    }
}
