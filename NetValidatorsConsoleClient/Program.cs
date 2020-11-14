using System;
using System.Collections.Generic;
using NetValidators;

namespace NetValidatorsConsoleClient
{
    class Program
    {
        private static List<Option> options;
        static void Main(string[] args)
        {
            NamesValidatorImplementation nameValidator = new NamesValidatorImplementation();
            EmailValidatorImplementation emailValidator = new EmailValidatorImplementation();

            Console.WriteLine("Hello User. Welcome to Validator!");

            options = new List<Option>
            {
                new Option("Name Validator", ()=>{ DoPromptAndValidationLoop(nameValidator) ;}),
                new Option("Email Validator", ()=>{ DoEmailValidationLoop(emailValidator); })
            };

            int index = 0;

            WriteMenu(options, options[index]);

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                switch (keyinfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index + 1 < options.Count)
                        {
                            index++;
                            WriteMenu(options, options[index]);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (index - 1 >= 0)
                        {
                            index--;
                            WriteMenu(options, options[index]);
                        }
                        break;
                    case ConsoleKey.Enter:
                        options[index].Selected.Invoke();
                        index = 0;
                        break;
                }
            }

            while (keyinfo.Key != ConsoleKey.X);
            Console.ReadKey();


            Console.WriteLine("Thanks Bye");
        }

        static void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();

            foreach (Option option in options)
            {
                if (option == selectedOption)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.WriteLine(option.Name);
            }
        }

        private static void DoEmailValidationLoop(EmailValidatorImplementation emailValidator)
        {
            string shouldContinue = "y";
            do
            {
                PromptAndValidateEmail(emailValidator);

                Console.WriteLine("Continue? y/N");
                shouldContinue = Console.ReadLine();
            } while (shouldContinue == "y" || shouldContinue == "Y");
        }

        private static void PromptAndValidateEmail(EmailValidatorImplementation emailValidator)
        {
            Console.WriteLine("Enter an email to Validate:");
            string emailCandidate = Console.ReadLine();
            if (emailValidator.IsValidEmail(emailCandidate))
                Console.WriteLine($"{emailCandidate} is a valid email");
            else
                Console.WriteLine($"{emailCandidate} is NOT a valid email");
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

    public class Option
    {
        public string Name { get; }
        public Action Selected { get; }

        public Option(string name, Action selected)
        {
            Name = name;
            Selected = selected;
        }
    }
}
