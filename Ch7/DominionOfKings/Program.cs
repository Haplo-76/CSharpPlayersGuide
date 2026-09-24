
Int32 provinces;
Int32 duchies;
Int32 estates;


Console.WriteLine("How many provinces do you have?");
provinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies do you have?");
duchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many estates do you have?");
estates = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You have {provinces * 6 + duchies * 3 + estates * 1} points. Well done!");