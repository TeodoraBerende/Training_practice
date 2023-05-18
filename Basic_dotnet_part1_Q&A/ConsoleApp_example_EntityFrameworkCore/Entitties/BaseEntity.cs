namespace HotelManagement.Entitties
{
    public class BaseEntity
    {
        public int Id { get; set; } = default!;
        public bool IsDeleted { get; set; } = default!;
    }
}
