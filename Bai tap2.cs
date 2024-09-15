using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Tạo danh sách các đối tượng Student
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "An", Age = 17 },
            new Student { Id = 2, Name = "Bách", Age = 16 },
            new Student { Id = 3, Name = "Cường", Age = 18 },
            new Student { Id = 4, Name = "Danh", Age = 14 },
            new Student { Id = 5, Name = "Anh", Age = 19 }
        };

        // a. In danh sách toàn bộ học sinh
        Console.WriteLine("Danh sách toàn bộ học sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
        Console.WriteLine();

        // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
        var studentsInAgeRange = students.Where(s => s.Age >= 15 && s.Age <= 18);
        Console.WriteLine("Danh sách học sinh có tuổi từ 15 đến 18:");
        foreach (var student in studentsInAgeRange)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
        Console.WriteLine();

        // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
        var studentsWithNameA = students.Where(s => s.Name.StartsWith("A"));
        Console.WriteLine("Danh sách học sinh có tên bắt đầu bằng chữ 'A':");
        foreach (var student in studentsWithNameA)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
        Console.WriteLine();

        // d. Tính tổng tuổi của tất cả học sinh
        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"Tổng tuổi của tất cả học sinh: {totalAge}");
        Console.WriteLine();

        // e. Tìm và in ra học sinh có tuổi lớn nhất
        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        if (oldestStudent != null)
        {
            Console.WriteLine("Học sinh có tuổi lớn nhất:");
            Console.WriteLine($"Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");
        }
        Console.WriteLine();

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
        var sortedStudents = students.OrderBy(s => s.Age);
        Console.WriteLine("Danh sách học sinh sắp xếp theo tuổi tăng dần:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}
