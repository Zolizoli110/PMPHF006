using System;

namespace PMPHF006
{
  class Program
  {
    static int[] array;
    static int moves;

    static void Main()
    {
      ReadIn();
      Sort();
      WriteOut();
      Console.WriteLine(moves);
    }

    public static void WriteOut()
    {
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write(array[i] + " ");
      }
      Console.WriteLine();
    }

    public static void ReadIn()
    {
      string line = Console.ReadLine();
      string[] items = line.Split(',');
      array = new int[items.Length];
      for (int i = 0; i < items.Length; i++)
      {
        array[i] = int.Parse(items[i]);
      }
    }

    public static void Sort()
    {
      for (int i = 0; i < array.Length; i++)
      {
        int j = array.Length - 1;
        while (j > i && array[i] == 1) 
        {
          if (array[j] == 0)
          {
            int tmp = array[j];
            array[j] = array[i];
            array[i] = tmp;
            moves++;
          }
          j--;
        }
      }
    }
  }
}
