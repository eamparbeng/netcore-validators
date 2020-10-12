using System;
using System.Collections;
using System.Linq;

namespace NamesValidator
{
    public class NamesValidatorImplementation
    {
        private const int MIN_ACCEPTABLE_REPEATED_CONSONANTS_OR_VOWELS = 2;

        private Func<char, bool> isVowel = (char ch) =>
            ch == 'A' || ch == 'a' || ch == 'e' || ch == 'E'
            || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O'
            || ch == 'u' || ch == 'U';

        public bool IsValidName(string nameCandidate)
        {
            if (HasRepeatedConsonants(nameCandidate))
                return false;

            if (HasRepeatedVowels(nameCandidate))
                return false;

            return true;
        }

        private bool HasRepeatedConsonants(string nameCandidate)
        {
            for (var i = 0; i < nameCandidate.Length; i++)
            {
                int consonantCount = 0;
                for (var j = i; j < nameCandidate.Length; j++)
                {
                    if (!isVowel(nameCandidate[j]))
                        consonantCount++;
                    else
                        break;
                }
                if (consonantCount > MIN_ACCEPTABLE_REPEATED_CONSONANTS_OR_VOWELS)
                    return true;
            }

            return false;
        }

        private bool HasRepeatedVowels(string nameCandidate)
        {
            for (var i = 0; i < nameCandidate.Length; i++)
            {
                int vowelCount = 0;
                for (var j = i; j < nameCandidate.Length; j++)
                {
                    if (isVowel(nameCandidate[j]))
                        vowelCount++;
                    else
                        break;
                }
                if (vowelCount > MIN_ACCEPTABLE_REPEATED_CONSONANTS_OR_VOWELS)
                    return true;
            }

            return false;
        }
    }
}
