using System;

class Program {
  public static void Main (string[] args) {
    int num;
    string user_input;
    
    do
      {
        Console.Write("Enter a number: ");
        user_input = Console.ReadLine();
        
        if (int.TryParse(user_input, out num))
          {
            if (num == 0)
              {
                break;
              }
            
            else
              {
                for (int i = 1; i <= num; i++)
                  {
                    for (int j = 1; j <= (num - i); j++)
                        Console.Write(" ");

                    for (int k = 1; k < i * 2; k++)
                        Console.Write("*");
                    Console.WriteLine();
                   }
                Console.ReadLine();
              }
          }
        else
          {
            Console.WriteLine("Invalid value: " + user_input);
            continue;
          }
      }
    while (num != 0);
      Console.WriteLine("Closing program...");
  }
}