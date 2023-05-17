namespace HotelManagement.Entitties
{
    public class Reservation
    {
        public int Id { get; set; } = default!; 
        public string CustomerName { get; set; } = default!;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Room Room { get; set; } = default!;
        public int RoomId { get; set; } = default!;
    }
}
