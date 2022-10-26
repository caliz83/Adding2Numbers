//Peer Reviewed by:Amir Smith

//Peer comment:Works well



bool letsPlay = true;

while(letsPlay == true)
{
int num1;
int num2;


Console.WriteLine("Pick a number.");
num1 = Convert.ToInt32(Console.ReadLine());
//convert to int
Console.WriteLine("Pick a second number.");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of your numbers is {num1 + num2}");

//string playAgain = "";
Console.WriteLine("Do you want to play again? Y/N");
string playAgain = Console.ReadLine().ToUpper();
if(playAgain == "Y")
{
    letsPlay = true;
}
else if(playAgain == "N")
{
    letsPlay = false;
    Console.WriteLine("Goodbye.");
}
else
{
    Console.WriteLine("Please enter a valid option: Y or N");
}
}