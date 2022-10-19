using System;
using System.IO;
class Program {

    static void Main(string[] args) {
        // This is our director. It will guide program flow and the process of the game. 

        
        
        
        
        /*THIS IS THE DEMO
        * 
        *
        *
        */
        DisplayWelcomeMessage();

        // Console.WriteLine("The cars is: {}")

        // // Create a new Deck object
        Deck deckOfCards = new Deck();

        // // Loop continuously until the deck no longer has any cards
        while (deckOfCards.HasMoreCards()) {

        //     // Draw a random card from the deck
            Card randomCard = deckOfCards.DrawRandomCard();
            Random generator = new Random();
            Input input = new Input();

            int randomNum = generator.Next(1, 13);
            string guess = input.GetInput(randomNum);
            
            int secondNum = generator.Next(1, 13);
            Console.WriteLine("Next card was: " + secondNum);
            Point points = new Point();
            points.ScoreCalc(secondNum, randomNum, guess);





            
        //     // Print the card description to the console
        // Console.WriteLine(randomCard.Description());

        //     // Wait .25 seconds so that this process goes slowly
        Thread.Sleep(250);
        
        // if (deckOfCards.HasMoreCards() = false) {
        // }
        
        }

        Console.WriteLine("");
        Console.WriteLine("The Deck is now out of cards...");
        Console.WriteLine("This concludes our demo. Have a nice day!");
    }

    static void DisplayWelcomeMessage() {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("############################");
        Console.WriteLine("Let the game begin!!!");
        Console.WriteLine("############################");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    }

}