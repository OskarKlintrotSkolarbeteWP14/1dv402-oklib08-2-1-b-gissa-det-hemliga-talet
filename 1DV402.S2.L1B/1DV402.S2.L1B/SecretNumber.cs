using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1B
{
    public class SecretNumber
    {
        #region fält

        private int[] _guessedNumbers = new int[7];
        private int _number = 42;
        private int _count = 0;
        public const int MaxNumberOfGuesses = 7;

        #endregion

        #region Autoimplementerade egenskaper

        #endregion

        #region Egenskaper

        public bool CanMakeGuess
        {
            get
            {
                if ( Count < 7) {
                    return true;
                }
                else {
                    return false;
                }
            }

            private set { }
        }

        public int Count
        {
            get { return _count; }

            private set { _count += value; }
        }

        public int GuessesLeft
        {
            get { return (MaxNumberOfGuesses - Count); }

            private set { }
        }

        #endregion

        #region Konstruktorer

        #endregion

        #region Metoder
        /// <summary>
        /// Cleans the array _guessedNumbers, sets _count to 0 and _number to a random number between 1-100.
        /// </summary>
        public void Initialize()
        {
            for (int i = 0; i < 7; i++)
            {
                _guessedNumbers[i] = 0;
            }

            _count = 0;

            Random random = new Random();
            _number = random.Next(0, 101);
        }

        public bool MakeGuess(int number)
        {
            bool alreadyGuessed = false;
            bool toHigh = false;
            bool toLow = false;

            _guessedNumbers[_count] = number;

            for (int i = 0; i < 7; i++)
            {
                if (_guessedNumbers[i] == number)
                {
                    alreadyGuessed = true;
                }
            }

            if (number < _number)
            {
                toLow = true;
            }
            else if (number > _number)
            {
                toHigh = true;
            }

            if (number == _number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SecretNumber()
        {

        }

        #endregion
    }
}
