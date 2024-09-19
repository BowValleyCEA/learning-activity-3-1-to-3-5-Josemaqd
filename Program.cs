// See https://aka.ms/new-console-template for more information
ClassActivity1();
LearningActivity31();
LearningActivity32();
LearningActivity33();
LearningActivity34();
LearningActivity35();

void ClassActivity1()
{
    string userInput = "";
    Console.WriteLine("Hi! Do you want candy, if so enter the van.");
    Console.WriteLine("Answer with y or n");
    while (userInput != "y")
    {
        /*userInput = Console.ReadLine();
        if (userInput == "n")
        {
            Console.WriteLine("Come on, you want to.");
        }
        else if (userInput == "y")
        {
            break;
        }
        else
        {
            Console.WriteLine("try again");
        }*/
        userInput = Console.ReadLine();
        if(userInput == "n")
        {
            Console.WriteLine("Come on, you want to.");
            continue;
        }
        else if(userInput == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("WHAT?");
            continue;
        }
    }
    Console.WriteLine("You died!");

}
void LearningActivity31()
{
    Console.WriteLine("This is the function for Learning Activity 3.1!");
}
void LearningActivity32()
{
    Console.WriteLine("This is the function for Learning Activity 3.2!");
}
void LearningActivity33()
{
    Console.WriteLine("This is the function for Learning Activity 3.3!");
}

void LearningActivity34()
{
    int number;
    bool success = int.TryParse(Console.ReadLine(), out number); //example code
    Console.WriteLine("This is the function for Learning Activity 3.4!");
}

void LearningActivity35()
{
    int[] highScores = { 1272700, 1271100, 1243000, 1218000, 1214300, 1210800, 1210400, 1206800, 1178400 };
    Console.WriteLine("This is the function for Learning Activity 3.5!");
}

