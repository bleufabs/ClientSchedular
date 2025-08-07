namespace AndysApp.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime RequestedDateTime { get; set; }
        public string ServiceRequested { get; set; } = "";
        public string Status { get; set; } = "Pending"; // Pending, Approved, Declined
    }
}
