using System;
// Topshiriq 1
Console.Write("Enter your name:");
string name = Console.ReadLine();
System.Console.WriteLine($" Hello {name}");
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
string masage =
    name.Length > number
        ? name.ToUpper()
        : name.ToLower();
Console.WriteLine(masage);


//Topshiriq 2
int x = 15;
int y = 10;
if (x > y)
{
  Console.WriteLine(" x is greater than y");
}
else
{
  if (x < y)
    {
       Console.WriteLine("x is less than y");
    }
  else
    {
        if(x == y)
          {
            Console.WriteLine(" x is equal to y");
          }
        else
          {
            Console.WriteLine("x and y are not comparable");
          }
    }
}


//Topshiriq 3
  Console.Write("Bugun nima kun: ");
 string kun = Console.ReadLine();
 string days = kun.ToLower() switch
 {
    "dushanba"  => "Monday",
    "seshanba"  => "Tuesday",
    "chorshanba" => "Wednesday",
    "payshanba"  => "Thursday",
    "juma" => "Friday",
    "shanba" => "Saturday",
    "yakshanba" => "Sunday",
    _ => "Enter a wrong value"

 };
Console.WriteLine(days);
        