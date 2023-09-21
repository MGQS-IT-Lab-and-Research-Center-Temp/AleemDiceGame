// See https://aka.ms/new-console-template for more information
//Build Dice Game/
using System.Diagnostics;
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("=== Mystic Dice Game===\nType'Start' or 'S' to Start the game");
string startGame = Console.ReadLine()!;

while(!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase)||startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))

{
    Console.WriteLine("Type 'Start' or 's'  to proceed with the game instantly ");
    return;
}
Random random = new();
int firstDice = random.Next(1,7);
int secondDice = random.Next(1,7);
int thirdDice = random.Next(1,7);
int originalResult = firstDice + secondDice + thirdDice;
const int DOUBLE_COMBO = 2;
const int TRIPLE_COMBO = 6;
int totalPoint = originalResult;

if (firstDice == secondDice && secondDice == thirdDice)
{
    totalPoint +=TRIPLE_COMBO;

    Console.WriteLine($"Dice One{firstDice}\nDice Two: {secondDice}\nDiceThree: {thirdDice}.\nWOW!!You rolled a triple combo! You have a total of{totalPoint} points");
}
if (firstDice == secondDice || secondDice == thirdDice || firstDice == thirdDice)
{
    totalPoint += DOUBLE_COMBO;

    Console.WriteLine($"Dice One:{firstDice}\nDice Two:{secondDice}\nDice Three:{thirdDice}.\nBREATH-TAKING!!! You rolled a double combo! You have a total of {totalPoint} points ");
}
else
{
    Console.WriteLine($"Dice One: {firstDice}\nDice Two: {secondDice}\n Dice Three: {thirdDice}.\nYou have total of {totalPoint} points  ");
}
if (totalPoint >= 10 && totalPoint <= 13)
{
    Console.WriteLine ("Congratulations!, you won a pen!");
}

if (totalPoint >= 14 && totalPoint <= 16)
{
    Console.WriteLine ("Congratulations!, you won a Book!");
}   
if (totalPoint == 17)
{
       Console.WriteLine ("Congratulations!, you won a 5000maH power bank!");
}  
    
    if (totalPoint == 21)
    {
        Console.WriteLine ("Wow!, you won a Samsung Smartphone");
}   
if(totalPoint >= 18 && totalPoint <= 20 )
{
Console.WriteLine("Bravo!!!,You won a ticket to Silverbird Concert at Victoria Island Lagos");
}
if (totalPoint >= 22 && totalPoint <= 24 )
{
    Console.WriteLine("Whoa!!!, You have just won all Gifts");
}
if (totalPoint < 10)
{
    Console.WriteLine("Sorry, Your score is too low for you to attain a Gift. Please close this tab and try again later.Thank You!!!");
}
    
    Console.WriteLine("Thank you for choosing Mystic Studios");
    

