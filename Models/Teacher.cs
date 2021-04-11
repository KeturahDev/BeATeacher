using System.Collections.Generic;

namespace BeATeacher.Models
{
  public class Teacher
  {
    public string Name { get; set; }
    public List<string> students = new List<string> {};
    public string ClassRoom { get; set; }

    public Teacher(string name, string classRoom)
    {
      Name = name;
      ClassRoom = classRoom;
    }

    public void AddStudent(string nameOfStudent)
    {
      students.Add(nameOfStudent);
    }
  }
}