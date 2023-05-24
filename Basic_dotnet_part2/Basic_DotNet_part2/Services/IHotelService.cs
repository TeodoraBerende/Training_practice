namespace WebApplication1.Services
{
    using WebApplication1.DataTransferObject;

    public interface IHotelService
    {
        public Task AddHotel(HotelDto hotelDto);

        public Task<HotelDto> GetHotelById(int id);

        public Task RemoveHotelById(int id);
    }
}
