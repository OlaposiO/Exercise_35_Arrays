using System;

namespace Exercise_35
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "cow", "elephat", "jaguar", "horse", "crow" }; //new string[5]; <- another way of making an array.
            bool valid = true;
            do
            {
                do
                {


                    Console.Write("Enter two indices: ");
                    string userInput = Console.ReadLine();
                    string[] splitInputs = userInput.Split(" ");
                    string input1 = new string(splitInputs[0]);
                    string input2 = new string(splitInputs[1]);
                    char[] firstLetter;

                    int animalIndex = GetIndex(input1);
                    int letterIndex = GetIndex(input2);

                    if (animalIndex < animals.Length)
                    {
                        firstLetter = animals[animalIndex].ToCharArray();
                        if (letterIndex < firstLetter.Length)
                        {
                            Console.WriteLine($" The animal at index: {input1} is {animals[animalIndex]}");

                            

                            Console.WriteLine($"The letter at index {input2} is {firstLetter[letterIndex]}");
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid index.");
                            valid = false;
                        }


                    }
                    else
                    {
                        Console.WriteLine("That is not a valid index.");
                        valid = false;
                    }





                } while (valid == false);


            } while (Continue_Program());

        }

        static bool Continue_Program()
        {
            char c;
            do
            {
                Console.Write("Would you like to continue? (y/n)? << ");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    Console.WriteLine("\nGoodBye");
                    return false;
                }
                Console.WriteLine();
            } while (c != 'y' && c != 'Y');
            return true;
        }

        static int GetIndex(string s)
        {
            int userAnimal = int.Parse(s);

            return userAnimal;
        }
    }
}
