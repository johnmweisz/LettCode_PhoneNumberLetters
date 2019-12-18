using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettCode_PhoneNumberLetters
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        private readonly Dictionary<char, string> _phone = new Dictionary<char, string>()
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

        private List<string> _result = new List<string>() {""};

        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0) return _result;
            foreach (var digit in digits)
            {
                var resMaker = new List<string>();
                foreach (var str in _result)
                {
                    foreach (var letter in _phone[digit])
                    {
                        resMaker.Add(str + letter);
                    }
                }

                _result = resMaker;
            }

            return _result;
        }
    };

}
