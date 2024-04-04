using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnal7_1302223039
{
    public class DataMahasiswa_1302223039
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public CourseList matkul { get; set; }

        
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:\\Kuliah\\semester 4\\P_Konstruksi Perangkat Lunak\\Minggu 7\\jurnal7_1_1302223039.json");

            DataMahasiswa_1302223039 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302223039>(jsonString);
            Console.WriteLine($"Name    : {mahasiswa.firstName} {mahasiswa.lastName}");
            Console.WriteLine($"Gender  : {mahasiswa.gender}");
            Console.WriteLine($"Umur    : {mahasiswa.age} ");
            Console.WriteLine($"Alamat  : {mahasiswa.address.streetAddress}, {mahasiswa.address.state}, {mahasiswa.address.city}");

            int index = 1;
            foreach (var course in mahasiswa.matkul.Courses)
            {
                Console.WriteLine($"MK {index} {course.code} - {course.name}");
                index++;
            }

        }

    }

    public class Address
    {
       
        public String streetAddress { get; set; }

        
        public String city { get; set; }

        
        public String state { get; set; }

    }
    public class CourseList
    {
        
        public List<Course> Courses { get; set; }
    }

    public class Course
    {
        
        public string code { get; set; }
       
        
        public string name { get; set; }

    }

}

