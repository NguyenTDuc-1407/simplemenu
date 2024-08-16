int choice = 1;
do
{
     Console.WriteLine("Menu");
     Console.WriteLine("1. Draw the triangle");
     Console.WriteLine("2. Draw the square");
     Console.WriteLine("3. Draw the rectangle");
     Console.WriteLine("0. Exit");
     Console.WriteLine("Enter your choice: ");
     choice = Convert.ToInt16(Console.ReadLine());
     switch (choice)
     {
          case 1:
               {
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                    choice = Convert.ToInt16(Console.ReadLine());
                    break;
               }

          case 2:
               Console.WriteLine("Draw the square");
               Console.WriteLine("* * * * * *");
               Console.WriteLine("* * * * * *");
               Console.WriteLine("* * * * * *");
               Console.WriteLine("* * * * * *");
               Console.WriteLine("* * * * * *");
               Console.WriteLine("* * * * * *");
               choice = Convert.ToInt16(Console.ReadLine());
               break;
          case 3:
               Console.WriteLine("Draw the rectangle");
               Console.WriteLine("* * * * * *");
               Console.WriteLine("* * * * * *");
               Console.WriteLine("* * * * * *");
               choice = Convert.ToInt16(Console.ReadLine());
               break;
          case 0:
               Console.WriteLine("out");
               break;
          default:
               Console.WriteLine("No choice!");
               break;
     }
} while (choice != 0);



