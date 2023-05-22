using System;
Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
}

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

void AskQuestion(string question, string yesAnswer, string noAnswer) //refactored code for Phase 9; setting up the format for each AskQuestion.
{
    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays(yesAnswer);
    }
    else{
        MooseSays(noAnswer);
    }
}

void CanadaQuestion()
{
    AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
}

void EnthusiasticQuestion()
{
    AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
}

void LoveCSharpQuestion()
{
    AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
}

void SecretQuestion()
{
    AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}

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