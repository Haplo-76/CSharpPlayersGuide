

Console.Title = "Defense of Consolas";


Console.WriteLine("Our city is under attack! We need to deploy the magical barrier!\n");

// use Write instead of WriteLine if you want user to enter digit on same line as question
Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Target column? ");
int targetCol = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Red;

// now i do want new lines by default, so use WriteLine
Console.WriteLine("\nDeploy to:");
Console.WriteLine($"({targetRow},{targetCol - 1})");
Console.WriteLine($"({targetRow-1},{targetCol})");
Console.WriteLine($"({targetRow},{targetCol + 1})");
Console.WriteLine($"({targetRow+1},{targetCol})");

Console.Beep(440,1000);
