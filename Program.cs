using System;

namespace Tennis
{
    public class Program
    {
        static (int A, int B, int? W) game = (0, 0, null);
        static string[] playersNames = { "Alice", "Bob" };

        static void Main(string[] args)
        {
         
            Console.WriteLine("Start the game by pressing `Enter`");
            Console.ReadLine();
            do
            {
                Console.WriteLine(GameStatus(game));
                Console.ReadLine();
                game = NextRound(game);
            } while (game.W == null);

            Console.WriteLine(GameStatus(game));

            Console.ReadLine();
        }


        //Return the differents results score of the given tuple
        static String GameStatus((int A, int B, int? W) game)
        {
            switch (game)
            {
                case var scenario_0 when game.W.HasValue: return $"The winners is {playersNames[game.W.Value]}";
                case var scenario_1
                        when scenario_1.A + scenario_1.B >= 3 && scenario_1.A == scenario_1.B:
                    return "Douce";
                case var scenario_2
                        when scenario_2.B >= 3 && Math.Abs(scenario_2.A - scenario_2.B) == 1 && scenario_2.A > scenario_2.B:
                    return $"Advantage - {NameScore(game.B)}";
                case var scenario_3
                         when scenario_3.B >= 3 && Math.Abs(scenario_3.A - scenario_3.B) == 1 && scenario_3.A > scenario_3.B:
                    return $"{NameScore(game.A)} - Advantage";
                default: return $"{NameScore(game.A)} - {NameScore(game.B)}";
            }
        }

        //Returns the score points using the tennis scoring system
        static String NameScore(int score)
        {
            switch (score)
            {
                case 0: return "Love";
                case 1: return "Fifteen";
                case 2: return "Thirty";
                case 3: return "Forty";
                default:
                    return score.ToString();
            }
        }

        //Computes a new round of the match returning a new tuple updated accordingly
        static (int A, int B, int? W) NextRound((int A, int B, int? W) game)
        {
            Random r = new Random();
            if (r.Next(2) > 0)
                game.A++;
            else
                game.B++;

            if ((game.A >= 4 || game.B >= 4) && Math.Abs(game.A - game.B) >= 2)
                game.W = (game.A > game.B) ? 0 : 1;

            return game;
        }


    }
}
