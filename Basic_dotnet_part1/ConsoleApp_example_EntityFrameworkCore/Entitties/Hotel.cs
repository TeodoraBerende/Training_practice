namespace HotelManagement.Entitties
{
    public class Hotel
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!; 
        /* ! is null forgiving operator introduced in C# 8
            It marks things as never being null and instructs the compiler to skip null checks so you don't get a "can be null" warning.
        */

        public int Stars { get; set; } = default!;  
        public string City { get; set; } = default!;
        public string Country { get; set; } = default!;
        public string? Description { get; set; }

        public List<Room> Rooms { get; set; } = new List<Room>();

        public bool IsDeleted { get; set; } //TODO: soft delete
    }
}
