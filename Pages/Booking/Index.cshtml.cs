using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndysApp.Data;
using AndysApp.Models;

namespace AndysApp.Pages.Booking
{
    public class IndexModel : PageModel
    {
        private readonly BookingDbContext _context;

        public IndexModel(BookingDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Appointment Appointment { get; set; } = new();

        public string? SuccessMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            Appointment.Status = "Pending";
            _context.Appointments.Add(Appointment);
            _context.SaveChanges();

            SuccessMessage = "Appointment request submitted successfully!";
            ModelState.Clear();
            Appointment = new(); // reset form
            return Page();
        }
    }
}
