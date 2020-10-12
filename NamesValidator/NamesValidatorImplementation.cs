using System;
using System.Collections;
using System.Linq;

namespace NamesValidator
{
    public class NamesValidatorImplementation
    {
        private const int MAX_ACCEPTABLE_REPEATED_CONSONANTS_OR_VOWELS = 3;
        private const int MAX_ACCEPTABLE_REPEATED_DIGITS = 0;
        private const int MIN_ACCEPTABLE_NAME_LENGTH = 2;

        private Func<char, bool> isVowel = (char ch) =>
            ch == 'A' || ch == 'a' || ch == 'e' || ch == 'E'
            || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O'
            || ch == 'u' || ch == 'U';
        private Func<char, bool> isUpperCase = (char ch) =>
            ch >= 'A' && ch <= 'Z';
        private Func<char, bool> isNumeric = (char ch) =>
            ch >= '0' && ch <= '9';

        public bool IsValidName(string nameCandidate)
        {
            //Invalid if too short
            if (nameCandidate.Length < MIN_ACCEPTABLE_NAME_LENGTH)
                return false;

            //Invalid if first character is not an uppercase character
            if (!isUpperCase(nameCandidate[0]))
                return false;

            //Invalid if starts with a digit
            if (isNumeric(nameCandidate[0]))
                return false;

            //Invalid if has no consonant
            if (!HasConsonants(nameCandidate))
                return false;

            //Invalid if has no vowel
            if (!HasConsonants(nameCandidate))
                return false;

            //Invalid if has more contiguous consonants than is acceptable
            if (HasRepeatedConsonants(nameCandidate))
                return false;

            //Invalid if has more contiguous vowels than is acceptable
            if (HasRepeatedVowels(nameCandidate))
                return false;

            //Invalid if has more contiguous digits than is acceptable
            if (HasRepeatedDigits(nameCandidate))
                return false;

            //Otherwise valid
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
                if (consonantCount > MAX_ACCEPTABLE_REPEATED_CONSONANTS_OR_VOWELS)
                    return true;
            }

            return false;
        }

        private bool HasRepeatedDigits(string nameCandidate)
        {
            for (var i = 0; i < nameCandidate.Length; i++)
            {
                int digitCount = 0;
                for (var j = i; j < nameCandidate.Length; j++)
                {
                    if (isNumeric(nameCandidate[j]))
                        digitCount++;
                    else
                        break;
                }
                if (digitCount > MAX_ACCEPTABLE_REPEATED_DIGITS)
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
                if (vowelCount > MAX_ACCEPTABLE_REPEATED_CONSONANTS_OR_VOWELS)
                    return true;
            }

            return false;
        }

        private bool HasVowels(string nameCandidate)
        { 
            for (var i = 0; i < nameCandidate.Length; i++)
            {
                if (isVowel(nameCandidate[i]))
                    return true;
            }

            return false;
        }

        private bool HasConsonants(string nameCandidate)
        { 
            for (var i = 0; i < nameCandidate.Length; i++)
            {
                if (!isVowel(nameCandidate[i]))
                    return true;
            }

            return false;
        }

    }
}
