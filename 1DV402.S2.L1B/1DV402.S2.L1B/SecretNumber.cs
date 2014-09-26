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
                return (MaxNumberOfGuesses - Count); }

            private set { }
        }

        #endregion

        #region Konstruktorer
        public SecretNumber()
        {
            Initialize();
        }

        #endregion

        #region Metoder
        /// <summary>
        /// Cleans the array _guessedNumbers, set _correctNumberGuessed to false, _count to 0 and _number to a random number between 1-100.
        /// </summary>
        public void Initialize()
        {
            _correctNumberGuessed = false;

            Array.Clear(_guessedNumbers, 0, _guessedNumbers.Length);

            _count = 0;

            Random random = new Random();
            _number = random.Next(1, 100);
        }

        public bool MakeGuess(int number)
        {
            bool alreadyGuessed = false;

            if (Count >= 7)
            {
                throw new ApplicationException();
            }

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            foreach (int guessedNumber in _guessedNumbers)
            {
                if (number == guessedNumber)
                {
                    //Console.WriteLine(Strings.old_guess_prompt, number);
                    alreadyGuessed = true;
                }
            }

            _guessedNumbers[Count] = number;

            if (alreadyGuessed == true)
            {
                Console.WriteLine(Strings.old_guess_prompt, number);
                return false;
            }

            if (alreadyGuessed == false)
            {
                Count++;    
            }

            if (number < _number)
            {
                Console.WriteLine(Strings.to_low_prompt, number, GuessesLeft);
            }
            if (number > _number)
            {
                Console.WriteLine(Strings.to_high_prompt, number, GuessesLeft);
            }

            if (number == _number)
            {
                Console.WriteLine(Strings.right_prompt, Count);
                _correctNumberGuessed = true;
                return true;
            }
            
            if (Count >= 7)
            {
                Console.WriteLine(Strings.wrong_prompt, _number);
            }
            
            //else
            //{
                return false;
            //}
        }

        #endregion
    }
}
