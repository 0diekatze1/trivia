using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UglyTrivia;

namespace Trivia
{
    public class GameRunner
    {

        private static bool notAWinner;

        public static void Main(String[] args)
        {
            int sid;
            sid = 1;
            Game aGame;

            while (sid < 101)
            {
                aGame = new Game();

                aGame.add("Chet");
                aGame.add("Pat");
                aGame.add("Sue");
                Random rand = new Random(sid);

                do
                {

                    aGame.roll(rand.Next(5) + 1);

                    if (rand.Next(9) == 7)
                    {
                        notAWinner = aGame.wrongAnswer();
                    }
                    else
                    {
                        notAWinner = aGame.wasCorrectlyAnswered();
                    }

                    
                } while (notAWinner);
                aGame = null;
                sid++;

            }
            
        }


    }

}

