double myBase;
double height;

Console.WriteLine("What is the dimension of the base of your triangle?");
myBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the height of your triangle?");
height = Convert.ToDouble(Console.ReadLine());

double area;

area = (myBase * height) / 2;

Console.WriteLine($"The area of your triangle is {area} units.");