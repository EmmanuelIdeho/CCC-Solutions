//My solution for CCC 2022-J2

using System;

public class Testing
{
    public static void Main(string[] args)
    {
        //the total number of players
        Console.WriteLine("How many players? ");
        int N = int.Parse(Console.ReadLine());

        //the player's score
        int S;

        //the players number of fouls
        int F;

        //a player's score rating
        int R;

        //number of players that that have a star rating above 40
        int total = 0;

        for(int i = 0; i < N; i++){
         Console.WriteLine("What is this player's score? ");
          S = int.Parse(Console.ReadLine());
          Console.WriteLine("How many fouls did this player commit? ");
          F = int.Parse(Console.ReadLine());
          R = 5*S - 3*F;
          if(R > 40){
            total += 1;
          }
        }
        Console.WriteLine(total);
    }
}
