using System;
using BeATeacher.Models;

namespace BeATeacher
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Epicodus!");
      Console.WriteLine("Please Write your name here");
      string yourName = Console.ReadLine();  // <-- New code
      Console.WriteLine("And select a class your here to teach");
      string yourClassRoom = Console.ReadLine();  // <-- New code
      
      Teacher you = new Teacher(yourName, yourClassRoom);

      Console.WriteLine("Hello class! You have a new teacher, " + you.Name);
      System.Threading.Thread.Sleep(5000);
      Console.WriteLine("A student raises their hand- Wait, what class is this again? ");
      System.Threading.Thread.Sleep(5000);
      Console.WriteLine("The principle smiles. Great Question! I believe its.. ");
      System.Threading.Thread.Sleep(5000);
      Console.WriteLine("Principle looks down at his notes...");
      System.Threading.Thread.Sleep(5000);
      Console.WriteLine("Principle- *cough* hey..."+ you.Name + "... What class was this again?");
      System.Threading.Thread.Sleep(5000);
      Console.WriteLine(you.Name + ": ..." + you.ClassRoom);
      System.Threading.Thread.Sleep(5000);
    }
  }
}
