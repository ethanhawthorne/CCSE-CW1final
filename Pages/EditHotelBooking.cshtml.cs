using My_Pacific_Tour_App.Models;
using My_Pacific_Tour_App.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
//This is responsible for editing the Hotel bookings
namespace My_Pacific_Tour_App.Pages
{
    public class EditHotelBookingModel : PageModel
    {
        //This binds data here to the razor form
        [BindProperty]
        public EditBookingModel EditBooking { get; set; }
        //This accesses the data storage in the database
        private readonly ApplicationDbContext _dbContext;
        // This so its a user access page
        private readonly UserManager<User> _userManager;

        public EditHotelBookingModel(ApplicationDbContext dbContext, UserManager<User> userManager)
        {
            EditBooking = new EditBookingModel();
            _dbContext = dbContext;
            _userManager = userManager;
        }
        //This allows for editing the The bookings
        public class EditBookingModel
        {
            [Required(ErrorMessage = "Select a check-in date")]
            [DataType(DataType.DateTime)]
            [Display(Name = "Check-in date")]
            public DateTime CheckInDate { get; set; }

            [Required(ErrorMessage = "Select a check-out date")]
            [DataType(DataType.DateTime)]
            [Display(Name = "Check-out date")]
            public DateTime CheckOutDate { get; set; }

            public string RoomType { get; set; }

            public List<Hotel> HotelsList { get; set; } = new List<Hotel>();
            public string ErrorMessage { get; set; }
            public string HotelBookingId { get; set; }

        }
        // Retrieves the query parameters and populates the model with relevent data
        public async Task<IActionResult> OnGet()
        {
            var HotelBookingIdValue = Request.Query["hotelBookingId"];
            var HotelBookingId = new Guid(HotelBookingIdValue.ToString());

            var hotelBooking = await _dbContext.HotelBookings
                .Where(hb => hb.HotelBookingId == HotelBookingId)
                .Include(hb => hb.Hotel)
                .FirstOrDefaultAsync();

            EditBooking.CheckInDate = hotelBooking.CheckInDate;
            EditBooking.CheckOutDate = hotelBooking.CheckOutDate;
            EditBooking.RoomType = hotelBooking.Hotel.RoomType;
            EditBooking.HotelsList.Add(hotelBooking.Hotel);

            EditBooking.HotelBookingId = HotelBookingIdValue;

            return Page();
        }
        //Checks that there is availability of hotelsfor users choice
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            EditBooking.ErrorMessage = null;
            // takes hotel booking ID from query
            var HotelBookingIdValue = Request.Query["hotelBookingId"];
            var HotelBookingId = new Guid(HotelBookingIdValue.ToString());
            //Finds the relevent booking
            var HotelBooking = await _dbContext.HotelBookings
                .Where(hb => hb.HotelBookingId == HotelBookingId)
                .Include(hb => hb.Hotel)
                .FirstOrDefaultAsync();
            //Gets the current user
            var CurrentUser = await _userManager.GetUserAsync(User);
            //checks availability
            var HotelAvailability = await _dbContext.HotelAvailabilities
                .Where(ha =>
                    ha.HotelId == HotelBooking.HotelId &&
                    ha.AvailableFrom <= EditBooking.CheckInDate &&
                    ha.AvailableTo >= EditBooking.CheckOutDate)
                .Select(ha => ha.Hotel)
                .Distinct()
                .ToListAsync();
            //This for if the availability has one spcae
            if (HotelAvailability.Count == 1)
            {
                HotelBooking.CheckInDate = EditBooking.CheckInDate;
                HotelBooking.CheckOutDate = EditBooking.CheckOutDate;
                //update the hotel booking in the databse
                _dbContext.HotelBookings.Update(HotelBooking);
                await _dbContext.SaveChangesAsync();
                //Takes you to the payment page
                return RedirectToPage("/Payment", new
                {
                    bookingId = HotelBookingIdValue,
                    bookingType = "hotel"
                });
            }
            else
            //if theres no spaces available
            {
                EditBooking.ErrorMessage = "Hotels not available for selected dates";
                //change model to give most recent info
                EditBooking.HotelsList.Add(HotelBooking.Hotel);
                EditBooking.CheckInDate = EditBooking.CheckInDate;
                EditBooking.CheckOutDate = EditBooking.CheckOutDate;
                EditBooking.RoomType = HotelBooking.Hotel.RoomType;

                return Page();
            }
        }
    }
}
