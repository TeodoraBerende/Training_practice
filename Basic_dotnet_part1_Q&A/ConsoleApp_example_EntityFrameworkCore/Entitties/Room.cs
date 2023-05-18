namespace HotelManagement.Entitties
{
    public class Room
    {
        public int Id { get; set; } = default!; 
        public int Number { get; set; } = default!;
        public string? Description { get; set; }
        public int HotelId { get; set; } = default!;
        public Reservation Reservation { get; set; } = default!;
        // list of housekeeper
        public List<Housekeeper> Housekeepers { get; set; } = default!;
    }
}
