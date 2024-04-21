
//Welcome User
Console.WriteLine("Welcome to the Newsletter, please enter your information to get started");

//Name 
Console.WriteLine("Please tell us your name:");
string name = Console.ReadLine();

//Age
Console.WriteLine("Please tell us your age:");
int age = Int32.TryParse(Console.ReadLine(), out age) ? age : 21;

//Does user wants to join
Console.WriteLine("Would you like to subsrcibe to our newsletter? (Y/N)");
bool subscribetonewsletter = SubscribeToNewsletter(Console.ReadLine());

//Simulating an API call or something loading
Console.WriteLine("Verifying information, please wait...");

//Using main method
FunctionWithGuardClauses();


//Methods:

void FunctionWithGuardClauses()
{
    // "Fail Fast" Approach, avoids
    // child elements and reduces complexitiy
    if(age < 21)
    {
        Console.WriteLine("You need to be 21 or older to access this service");
    }
    if (!subscribetonewsletter)
    {
        Console.WriteLine("You have choosed not to subscribe, thanks for visiting!");
    }
    Console.WriteLine("You have successfully subscribed to our newsletters!");

}

void FunctionWithChildElements()
{
    // Using child elements, this can get hard to read / debug
    // when the conditions gets too complex

    if (subscribetonewsletter)
    {

        if (age >= 21)
        {
            Console.WriteLine("You have successfully subscribed to our newsletters!");
        }
        else
        {
            Console.WriteLine("You need to be 21 or older to access this service");
        }
    }
    else
    {
        Console.WriteLine("You have choosed not to subscribe, thanks for visiting!");
    }

}


bool SubscribeToNewsletter(string userinput)
{
    switch (userinput.ToLower())
    {
        case "y":
            return true;
        case "n":
            return false;
        default:
            Console.WriteLine("The value is diferent from y or n");
            Environment.Exit(0);
            return false;
    }
}