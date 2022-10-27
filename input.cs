using System;


class Input {

    // public Input() {
        
    // }

    public string GetInput(int Card) {

        string guess;
        Console.WriteLine("The card is: " + Card);
        Console.Write("Higher or lower? [h/l] ");
        guess = Console.ReadLine();
        // Console.WriteLine("You guessed " + guess;
        return guess;

    }

    public bool PlayAgain() {
        string replay;
        Console.Write("Play again? [y/n] ");
        replay = Console.ReadLine();
        if (replay == "y") {
            return true;
        }
        else if (replay == "n") {
            Console.WriteLine("Thank you for playing, have a nice day:)!!!");
            return false;
        }
        else{
            return false;
        }
    }

}