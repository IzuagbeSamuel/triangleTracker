namespace Triangle
{
  public class TriangleTracker
  {
    public bool IsEquilateral(int number1, int number2, int number3)
    {
      return number1 == number2 && number2 == number3 && number3 == number1 && number2 == number1 &&number3 == number2 && number1 == number3;
    }

    public bool IsIsosceles(int number1, int number2, int number3)
    {
      return number1 > number2 || number2 > number1 || number3 > number1 || number1 > number3 || number2 > number3 || number3 > number2 && number1 == number2 || number2 == number3 || number3 == number1 || number2 == number1 || number3 == number2 || number1 == number3;
    }

    public bool IsScalene(int number1, int number2, int number3)
    {
      int no1 = number1 + number2;
      int no2 = number2 + number3;
      int no3 = number3 + number1;
      return no1 > number3 || no2 > number1 || no3 > number2 && number1 != number2 || number2 != number3 || number3 != number1;
    }
  }
}