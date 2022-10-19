using System;

class Point {
     
    int startDigit = 300;

    public void displayDigit () {
        Console.WriteLine($"{startDigit}");
    }

    public void ScoreCalc(int secondNum, int randomNum, string Hilo){
        if (Hilo == "h" && secondNum > randomNum) {
            startDigit += 100;
        }
        else if (Hilo == "h" && secondNum < randomNum) {
            startDigit -= 75;
        }
        else if(Hilo == "l" && randomNum > secondNum) {
            startDigit += 100;
        }
        else if(Hilo == "l" && randomNum < secondNum) {
            startDigit -= 75;
        }
        Console.WriteLine("Your score is " + startDigit);

    }

}