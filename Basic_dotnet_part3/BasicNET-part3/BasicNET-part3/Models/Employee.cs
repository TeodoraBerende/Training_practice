using System.ComponentModel.DataAnnotations.Schema;

namespace BasicNET_part3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Department Department { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Role + " " + Department.Name;
        }
    }
}
