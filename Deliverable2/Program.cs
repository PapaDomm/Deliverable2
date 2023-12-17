using System;


public class Deliverable2
{
    public static void Main()
    {
        Random random = new Random();

        string player_name = "";
        string coin_flip_user = "";
        string coin_face = "";
        string player_guess = "";
        int player_points = 0;

        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!!!");
        Console.WriteLine("What is your name?: ");
        player_name = Console.ReadLine();

        while (coin_flip_user.ToUpper() != "Y" && coin_flip_user.ToUpper() != "N")
        {
            Console.WriteLine();
            Console.WriteLine("Welcome " + player_name + ". Do you want to do the Coin Flip Challenge? (Y/N): ");
            coin_flip_user = Console.ReadLine();
        } 

        if (coin_flip_user.ToUpper() == "N")
        {
            Console.WriteLine();
            Console.WriteLine("You're a coward " + player_name + ". Get lost!");
            System.Environment.Exit(0);
        }

        while (coin_flip_user.ToUpper() == "Y")
        {
            player_points = 0;
            for (int i = 0; i < 5; i++)
            {
                int coin_side = random.Next(0, 2);

                if (coin_side == 0)
                {
                    coin_face = "HEADS";
                }
                else if (coin_side == 1)
                {
                    coin_face = "TAILS";
                }

                Console.WriteLine();
                Console.WriteLine("Heads or Tails?");
                player_guess = Console.ReadLine();

                if (player_guess.ToUpper() == coin_face)
                {
                    player_points++;
                    Console.WriteLine();
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Thank you " + player_name + ". You got a score of " +  player_points + " points!");
            Console.WriteLine();
            Console.WriteLine("Would you like to play again? (Y/N): ");
            coin_flip_user = Console.ReadLine();

            if (coin_flip_user.ToUpper() == "N") 
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
            }
            else if (coin_flip_user.ToUpper() == "Y")
            {
                Console.WriteLine();
                Console.WriteLine("Let's get back to it then!");
            }
        }
    }
}
