
Int32 totalEggs;
Int32 ducksEggs;
Int32 numSisters = 4;
Boolean quitProgram = false;

while (quitProgram == false){ 

    Console.WriteLine("How many eggs did you collect today?");
    totalEggs = Convert.ToInt32(Console.ReadLine());

    Int32 eggsEach;
    eggsEach = totalEggs / numSisters;
    ducksEggs = totalEggs % numSisters;

    Console.WriteLine($"Each sister gets {eggsEach} eggs today.");
    Console.WriteLine($"The duck gets {ducksEggs} today.");

    Console.WriteLine();
    Console.WriteLine("Enter 1 to quit program. Enter 0 to continue.");

    quitProgram = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

};





