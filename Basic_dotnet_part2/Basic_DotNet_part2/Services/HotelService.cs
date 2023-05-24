namespace WebApplication1.Services
{
    using WebApplication1.DataAccessLayer.Repositories;
    using WebApplication1.DataTransferObject;
    using WebApplication1.Entities;
    using WebApplication1.Exceptions;

    public class HotelService : IHotelService
    {
        private readonly IHotelRepository hotelRepository;

        public HotelService(IHotelRepository hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }

        public async Task AddHotel(HotelDto hotelDto)
        {
            var mappedData = this.MapHotelData(hotelDto);

            await this.hotelRepository.AddAsync(mappedData);
        }

        public async Task<HotelDto> GetHotelById(int id)
        {
            var hotel = await this.hotelRepository.GetByIdAsync(id);
            if (hotel is null)
            {
                throw new NotFoundException($"The hotel with the given id: '{id}' was not found");
            }

            var mappedData = this.MapHotelData(hotel);
            return mappedData;
        }

        public async Task RemoveHotelById(int id)
        {
            var hotel = await this.hotelRepository.GetByIdAsync(id);
            if (hotel is null)
            {
                throw new NotFoundException($"The hotel with the given id: '{id}' was not found");
            }

            await this.hotelRepository.DeleteAsync(hotel);
        }

        private Hotel MapHotelData(HotelDto hotelDto)
        {
            return new Hotel
            {
                Name = hotelDto.Name,
                City = hotelDto.City,
                Country = hotelDto.Country,
                Description = hotelDto.Description,
                Stars = hotelDto.Stars
            };
        }

        private HotelDto MapHotelData(Hotel hotel)
        {
            return new HotelDto
            {
                Name = hotel.Name,
                City = hotel.City,
                Country = hotel.Country,
                Description = hotel.Description,
                Stars = hotel.Stars
            };
        }
    }
}
