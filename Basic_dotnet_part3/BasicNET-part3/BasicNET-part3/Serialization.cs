using BasicNET_part3.Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BasicNET_part3
{
    public class Serialization
    {
        static readonly string path = "C:\\Users\\tberende\\OneDrive - ENDAVA\\Course testing\\BasicNET-part3\\BasicNET-part3\\";
        private List<Room> rooms = new List<Room>()
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
        public void JsonSerialization()
        {
            string jsonString = JsonSerializer.Serialize(rooms[0]);
            Console.WriteLine(jsonString);

            string fileName = path + "Rooms.json";
            jsonString = JsonSerializer.Serialize(rooms);
            File.WriteAllText(fileName, jsonString);
        }

        public void JsonDeserialization()
        {            
            string jsonString = "{\"Id\":1,\"Name\":\"Room1\",\"Capacity\":100}";
            var myRoom = JsonSerializer.Deserialize<Room>(jsonString);

            string fileName = path+"Rooms.json";
            jsonString = File.ReadAllText(fileName);
            var myRooms = JsonSerializer.Deserialize<List<Room>>(jsonString);            
        }

        //Old way, but now the class is obselete. It works for .net 3 and under versions
        public void OldWayBinarySerialization()
        {
            string filename = path + "rooms.dat";
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(fs, rooms);
            }

            FileStream fs2 = new FileStream(filename, FileMode.Open);
            List<Room> myRooms = (List<Room>)formatter.Deserialize(fs2);
        }

        public void BinarySerialization()
        {
            string fileName = path + "bynaryRooms.dat";
           // var bytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(rooms));

            var bytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(rooms, GetJsonSerializerOptions()));
            File.WriteAllBytes(fileName, bytes);
        }
        public void BinaryDeserialization()
        {
            string fileName = path + "bynaryRooms.dat";
            var bytes = File.ReadAllBytes(fileName);
            var myRooms = JsonSerializer.Deserialize<List<Room>>(bytes);
            //var myRooms = JsonSerializer.Deserialize<List<Room>>(bytes, GetJsonSerializerOptions());
        }

        private static JsonSerializerOptions GetJsonSerializerOptions()
        {
            return new JsonSerializerOptions()
            {
                PropertyNamingPolicy = null,
                WriteIndented = true,
                AllowTrailingCommas = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            };
        }
    }
}
