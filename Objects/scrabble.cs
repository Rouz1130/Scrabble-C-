using System;
using System.Collections.Generic;

namespace ScrabbleGame.Objects
{
  public class Scrabble
  {
    private string _input;

    public Scrabble(string input)
    {
      _input = input;
    }

    public string GetInput()
    {
      return _input;
    }

    public void SetInput(string newInput)
    {
      _input = newInput;
    }

    public int ScrabbleGame()
    {
      string userInput = this.GetInput();
      string userInputUpper = userInput.ToUpper();
      int runningScore = 0;
      foreach (char letter in userInputUpper)
      {
        if( Letter == "A" || Letter == "E" || Letter == "I" || Letter == "O" || Letter == "U" || Letter == "L" || Letter == "N" || Letter == "R" || Letter == "S" || Letter == "T")
        {
          runningScore += 1;
        }
        else if (letter =="D"|| letter == "G")
        {
          runningScore +=2;
        }
        else if (letter =="B" || letter == "C" || letter == "M" || letter == "P")
        {
          runningScore +=3;
        }
        else if (letter == "F" || letter =="H" || letter == "V" || letter == "w" || letter == "y")
        {
          runningScore +=4;
        }
        else if (letter == "K")
        {
          runningScore +=5;
        }
        else if (letter == "J" || letter == "X")
        {
          runningScore +=8;
        }
        else if (letter == "Z" || letter == "Z")
        {
          runningScore +=10;
        }
        else
        {
          return 0;
        }
      } return runningScore;

    }
  }
}
