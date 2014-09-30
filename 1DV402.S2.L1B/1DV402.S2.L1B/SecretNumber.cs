using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1B
{
    public class SecretNumber
    {
        #region Fields

        private int[] _guessedNumbers;
        private int _number;
        private bool _correctNumberGuessed;
        public const int MaxNumberOfGuesses = 7;

        #endregion

        #region Properties
        /// <summary>
        /// Checks if the user is allowed to make any guesses.
        /// </summary>
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
        /// <summary>
        /// Counts how many tries the user had.
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// How many guesses that the user have remaining.
        /// </summary>
        public int GuessesLeft
        {
            get {
                return (MaxNumberOfGuesses - Count); 
            }

            private set { }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Uses the method Initialize in order to reset the program.
        /// </summary>
        public SecretNumber()
        {
            _guessedNumbers = new int[7];
            
            Initialize();
        }

        #endregion

        #region Methods
        /// <summary>
        /// Cleans the array _guessedNumbers, set _correctNumberGuessed to false, _count to 0 and _number to a random number between 1-100.
        /// </summary>
        public void Initialize()
        {
            _correctNumberGuessed = false;

            Array.Clear(_guessedNumbers, 0, _guessedNumbers.Length);

            Count = 0;

            Random random = new Random();
            _number = random.Next(1, 100);
        }
        /// <summary>
        /// Let's the user try to find the secret number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>bool</returns>
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
            
            return false;

        }

        #endregion
    }
}
