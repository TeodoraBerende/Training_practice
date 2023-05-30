using BasicNET_part3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BasicNET_part3
{
    public class Linq
    {
        private string connectionString = "Server=EN1410586\\SQLEXPRESS;Database=Company;Trusted_Connection=True;";

        public Linq()
        {
            
            // NuGet packages needs to be added to the project:
            // Microsoft.Extensions.Configuration.Binder
            // Microsoft.Extensions.Configuration.Json
            var MyConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            connectionString = MyConfig.GetConnectionString("Company");

            var appName = MyConfig.GetValue<string>("APP_Name");
            var intExample = MyConfig.GetValue<int>("AppSettings:SampleIntValue");
            var stringExample = MyConfig.GetValue<string>("AppSettings:SampleStringValue");
            
        }

        public void UsingAdoNet()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Create the command  
                SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE DepartmentId = @id", conn);
                // Add the parameters.  
                command.Parameters.Add(new SqlParameter("id", 1));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Id\tName\t\tRole\t\tDeparment\t\tAddress\t");
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3} \t | {4} ",
                        reader[0], reader[1], reader[2], reader[3], reader[4]));
                    }
                }
            }
        }

        public void UsingEntityFramework()
        {
            CompanyContext context = new CompanyContext();

            var employees = context.Employees.Where(x => x.Department.Name == "Development")
                .Include(x => x.Department);

            foreach(var e in employees)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void UsingList()
        {
            List<Room> rooms = new List<Room>()
            {
                new Room
                {
                    Id =1,
                    Name="Room1",
                    Capacity = 100
                },
                new Room
                {
                    Id =2,
                    Name="Room Space Galaxy",
                    Capacity = 500
                },
                new Room
                {
                    Id =3,
                    Name="Room Tiny",
                    Capacity = 30
                },
                new Room
                {
                    Id =4 ,
                    Name="Room2",
                    Capacity = 100
                }
            };

            var rooms100 = from room in rooms
                    where room.Capacity == 100
                    orderby room.Name
                    select room;

            var rooms100_second = rooms.Where(x => x.Capacity == 100).OrderBy(x => x.Name);

            var firstRoom = rooms.FirstOrDefault(x=>x.Capacity== 100);
            firstRoom = rooms.FirstOrDefault(x => x.Capacity == 500);
            firstRoom = rooms.FirstOrDefault(x => x.Capacity == 50);

            var howManyRooms = rooms.Count();
            howManyRooms = rooms.Where(x=>x.Capacity==100).Count();

            var anyRoom = rooms.Any(x => x.Capacity == 100);
            anyRoom = rooms.Any(x => x.Capacity == 50);

            var groupByRooms = rooms.GroupBy( x => x.Capacity, 
                (key, g) => new { Capacity = key, Rooms = g.ToList() });

            var orderedRooms = rooms.OrderBy(x => x.Name);
            orderedRooms = rooms.OrderByDescending(x => x.Name);

            var selectRooms = rooms.Select(x => x.Name + " " + x.Capacity);

            var distinctRoom = rooms.Select(x => x.Capacity).Distinct();

            var numbers = new List<int>() { 2, 3, 2, 2, 3, 2, 5 };
            var distinctNumbers = numbers.Distinct();
        }

    }
}
