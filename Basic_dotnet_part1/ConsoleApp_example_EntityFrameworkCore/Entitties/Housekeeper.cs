namespace HotelManagement.Entitties
{
    public class Housekeeper
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;

        // list of rooms
        public List<Room> Rooms { get; set; } = new List<Room>();

    }
}
