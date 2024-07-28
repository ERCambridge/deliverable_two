int userScore = 0;
Console.WriteLine("Welcome to the coin flip challenge!");
Console.WriteLine("Please enter your name.");
string userName = Console.ReadLine();
Console.WriteLine("Welcome " + userName + ". Would you like to do the coin flip challenge? Yes/No");
string challengeAccept = Console.ReadLine();    
if (challengeAccept == "No" || challengeAccept == "no")
{
    Console.WriteLine("You are a coward " + userName + ".");
}
else if(challengeAccept == "Yes" || challengeAccept == "yes" )
{
    for(int i = 1; i <= 5; i++)
    {
        Random coinFlip = new Random();
        int flipResult = coinFlip.Next(0,2);
        //Console.WriteLine("Flip Result: " + flipResult);
        Console.WriteLine("Round " + i + "/5");
        Console.WriteLine("Heads or Tails?");
        string userAnswer = Console.ReadLine();
        if((userAnswer == "Heads" && flipResult == 1) || (userAnswer == "Tails" && flipResult == 0))
        {
            Console.WriteLine("Correct!");
            userScore +=1;

        }else if((userAnswer == "Heads" && flipResult == 0) || (userAnswer == "Tails" && flipResult == 1))
        {
            Console.WriteLine("Wrong!");
        }
        else
        {
            Console.WriteLine("Response invalid");
        }
        if(i == 5)
        {
            Console.WriteLine("Thank you for playing " + userName + ". You got a score of " + userScore +"!");
        }
    }
}
else
{
    Console.WriteLine("Response invalid");
}