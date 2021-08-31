using System;
using Triangle;
namespace Triangle.Program
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Triangle Tracker");
      Console.WriteLine("\n");
      Console.WriteLine("Enter three numbers to know if it form either a:\n Equilateral Triangle\n Isosceles Triangle\n Scalene Triangle");
      string stringFirstNumber = Console.ReadLine();
      string stringSecondNumber = Console.ReadLine();
      string stringThirdNumber = Console.ReadLine();
      int firstNumber = int.Parse(stringFirstNumber);
      int secondNumber = int.Parse(stringSecondNumber);
      int thirdNumber = int.Parse(stringThirdNumber);
      TriangleTracker triangle = new TriangleTracker();
      if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
      {
        Console.WriteLine("0 can't form any side");
      } 
      else if (triangle.IsEquilateral(firstNumber, secondNumber, thirdNumber))
      {
        Console.WriteLine("Equilateral Triangle, all sides are Equal");
      }
      else if (triangle.IsIsosceles(firstNumber, secondNumber, thirdNumber))
      {
        Console.WriteLine("Isosceles Triangle, two sides are Equal");
      }
      else if (triangle.IsScalene(firstNumber, secondNumber, thirdNumber))
      {
        Console.WriteLine("Scalene Triangle, all side are not Equal");
      }
      else {
        Console.WriteLine("Cannot form a Triangle, Not all combinations make valid triangles. If any side is longer than the other two sides combined, the lengths cannot form a triangle.");
      }
      Main();
    }
  }
}