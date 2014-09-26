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

        private int _guessesMade = 0;
        private int[] _guessedNumbers = new int[7];
        private int _number = 42;
        private int _count = 0;
        private bool _correctNumberGuessed = false;
        public const int MaxNumberOfGuesses = 7;

        #endregion

        #region Autoimplementerade egenskaper

        #endregion

        #region Egenskaper

        public bool CanMakeGuess
        {
            get
            {
                if (Count < 7 && _correctNumberGuessed == false)
                {
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
            get
            {
                //if (_count < 8)
                //{
                //    _count++;
                //}

                //return _count-1;
                return _count;
            }

            private set
            {
                _count = value;
            }
        }

        public int GuessesLeft
        {
            get {
                if (0 == _count)
                {
                    return 7;
                }
                return ((MaxNumberOfGuesses + 1) - _count); }

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
            //for (int i = 0; i < _guessedNumbers.Length; i++)
            //{
            //    _guessedNumbers[i] = 0;
            //}

            //foreach (int i in _guessedNumbers)
            //{
            //    _guessedNumbers[i] = 0;
            //}

            _correctNumberGuessed = false;

            Array.Clear(_guessedNumbers, 0, _guessedNumbers.Length);

            _count = 0;

            Random random = new Random();
            _number = random.Next(1, 100);

            _guessesMade = 0;
        }

        public bool MakeGuess(int number)
        {
            bool alreadyGuessed = false;
            bool toHigh = false;
            bool toLow = false;

            _guessesMade++;

            if (_guessesMade > 7)
            {
                throw new ApplicationException();
            }

            //_guessedNumbers[Count] = number;

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            //foreach (int guessedNumber in _guessedNumbers)
            //{
            //    if (number == guessedNumber)
            //    {
            //        Console.WriteLine(Strings.old_guess_prompt, number);
            //        return false;
            //    }
            //}

            for (int i = 0; i < _guessedNumbers.Length; i++)
            {
                if (_guessedNumbers[i] == number)
                {
                    Console.WriteLine(Strings.old_guess_prompt, number);
                    alreadyGuessed = true;
                    //return false;
                }
            }

            _guessedNumbers[Count] = number;

            if (alreadyGuessed == false)
            {
                Count++;    
            }
            

            if (number < _number)
            {
                toLow = true;
            }
            if (number > _number)
            {
                toHigh = true;
            }

            //if (alreadyGuessed == false)
            //{
            //    Count++;
            //}

            if (number == _number)
            {
                _correctNumberGuessed = true;
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
