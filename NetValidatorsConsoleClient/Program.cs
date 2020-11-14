using System;
using NetValidators;

namespace NetValidatorsConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            NamesValidatorImplementation nameValidator = new NamesValidatorImplementation();
            Console.WriteLine("Hello User. Welcome to Name Validator!");

            DoPromptAndValidationLoop(nameValidator);

            Console.WriteLine("Thanks Bye");
        }

        private static void DoPromptAndValidationLoop(NamesValidatorImplementation nameValidator)
        {
            string shouldContinue = "y";
            do
            {
                PromptAndValidateName(nameValidator);

                Console.WriteLine("Continue? y/N");
                shouldContinue = Console.ReadLine();
            } while (shouldContinue == "y" || shouldContinue == "Y");
        }

        private static void PromptAndValidateName(NamesValidatorImplementation nameValidator)
        {
            Console.WriteLine("Enter A Name to Validate:");
            string nameCandidate = Console.ReadLine();
            if (nameValidator.IsValidName(nameCandidate))
                Console.WriteLine($"{nameCandidate} is a valid name");
            else
                Console.WriteLine($"{nameCandidate} is NOT a valid name");
        }
    }
}
