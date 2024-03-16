using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int num = 5;
      int num2 = 10;
      Console.WriteLine(num+num2);

      if (num2>num) {
        Console.WriteLine(num2);
      }
      else{
        Console.WriteLine(num);
      }

      for (int i=0; i<num;i++){
        Console.WriteLine(i);
      }

      int[] array = {1,2,3,4,5};
      for (int i = 0; i < array.Length; i++)
      {
          Console.WriteLine(array[i]);
      }
    }
  }
}