using System;


/* 

    Boolean with the assigned variable name MooseAsks (string? question?) 
    console.log the question and (Y/N):

*/
bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): "); //Print in the console whatever is declared as question and then (Y/N):
    string answer = Console.ReadLine().ToLower(); // Reads (looks?) the answer as a string and will also read lowercase?

    while (answer != "y" && answer != "n") //If the user does not type y or n, then it just repeats the question
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y") //If the user answers with the letter y, the value of "true" will print in the console
    {
        return true;
    }
    else
    {
        return false; //If the user answers with the letter n, the value of "false" will print in the console
    }
}

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
// Let the moose speak!
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");

// As a question
bool isTrue = MooseAsks("Is Canada real?");
Console.WriteLine(isTrue);

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}