using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccessLayer;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/hotels")]
    public class HotelController : ControllerBase
    {
        private readonly DataContext _dbContext = new DataContext();

        public HotelController()
        {

        }

        // Create new hotel method
        [HttpPost]
        public async Task<IActionResult> CreateHotel([FromBody] Hotel hotel)
        {
            _dbContext.Hotels.Add(hotel);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateHotel), new { id = hotel.Id }, hotel);
        }

        // Get a specific hotel based on id
        [HttpGet]
        [Route("{id}")]  // api/hotel/1
        public async Task<IActionResult> GetHotelById(int id)
        {
            var hotel = await _dbContext.Hotels.FirstOrDefaultAsync(h => h.Id == id);

            if (hotel is null)
            {
                return NotFound($"The hotel with id {id} does not exists.");
            }

            return Ok(hotel);
        }

        // Get all hotels
        [HttpGet]
        public async Task<IActionResult> GetAllHotels()
        {
            var hotels = await _dbContext.Hotels.ToListAsync();

            return Ok(hotels);
        }

        // Get hotels with rooms
        [HttpGet]
        [Route("rooms")] //api/hotels/rooms
        public async Task<IActionResult> GetHotelsWithRooms()
        {
            var hotels = await _dbContext.Hotels.Include(h => h.Rooms).ToListAsync();

            return Ok(hotels);
        }

        // Update a specific hotel

        [HttpPut]
        public async Task<IActionResult> UpdateHotel(int hotelId, [FromBody] Hotel hotelUpdated)
        {
            var hotel = await _dbContext.Hotels.FirstOrDefaultAsync(h => h.Id == hotelId);

            // check if the hotel is not null
            if (hotel is null) // hotel == null
            {
                return NotFound($"The hotel with id {hotelId} does not exists.");
            }

            hotel.Stars = hotelUpdated.Stars;
            hotel.Name = hotelUpdated.Name;
            hotel.City = hotelUpdated.City;

            _dbContext.Hotels.Update(hotel);
            await _dbContext.SaveChangesAsync();
            
            return NoContent();
        }

        // Delete a specific hotel
        [HttpDelete]
        public async Task<IActionResult> DeleteHotel(int hotelId)
        {
            var hotel = await _dbContext.Hotels.FirstOrDefaultAsync(h => h.Id == hotelId);

            // check if the hotel is not null
            if (hotel is null) // hotel == null
            {
                return NotFound($"The hotel with id {hotelId} does not exists.");
            }

            _dbContext.Hotels.Remove(hotel);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }


    }
}
