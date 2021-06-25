using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame
{
    class Die
    {
        // Attributes
        private int maxEyes;
        private int eyes;

        /**
         * Constructor
         */
        public Die()
        {
            maxEyes = 6;
            eyes = 1;
        }

        /**
         * This methode will randomize the dice.
         * You can get the randomized eyes by using the GetEyes() method
         */
        public void ThrowDice()
        {
            Random rnd = new Random();
            
            int dice   = rnd.Next(1, (maxEyes+1));
            eyes = dice;
         
        }

        public int GetEyes()
        {
            return eyes;
        }
    }
}
