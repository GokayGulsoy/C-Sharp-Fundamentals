namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------
            //   uncomment the parts of the code according  |                                              
            //   to parts that you want to practice.        |                               
            //-----------------------------------------------

            /*
            // creating variables to store repetative information
            string characterName = "John";
            int characterAge;
            characterAge = 35;

            // Using method "WriteLine(String anyString)" provided
            // by the Console class located in System namespace
            Console.WriteLine("      /|");
            Console.WriteLine("     / |");
            Console.WriteLine("    /  |");
            Console.WriteLine("   /   |");
            Console.WriteLine("  /    |");
            Console.WriteLine(" /     |");
            Console.WriteLine("/______|");


            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            // data types
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = true;

            // Working with strings
            phrase = "Giraffe Academy";
            Console.WriteLine(phrase);
            // some methods of strings
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.Contains("Academy"));
            // strings are array of characters (indexes start from 0)
            Console.WriteLine(phrase[0]); // G
            Console.WriteLine(phrase[1]); // i
            Console.WriteLine(phrase[2]); // r

            Console.WriteLine(phrase.IndexOf('f')); // ==> 4
            Console.WriteLine(phrase.Substring(8)); // ==> "Academy"

            // working with numbers
            // basic arithmetic operators
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 - 8);
            Console.WriteLine(5 * 8);
            Console.WriteLine(5 / 8);
            Console.WriteLine(5 % 2);

            // working with floating-point numbers
            Console.WriteLine(5 / 2.0);
            int num = 6;
            num++;

            Console.WriteLine(num);
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Round(56.6));

            // Taking an input from user
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.Write("Enter your age: ");
            string ageStr = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + ageStr);


            Console.WriteLine("43" + "56");
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Basic Mad Libs game
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            // Arrays
            int[] luckyNumbers = { 4, 8, 16, 32, 64 };
            Console.WriteLine("Sum of first two entries in the array is: ");
            Console.WriteLine(luckyNumbers[0] + luckyNumbers[1]);
            // creating arrays with "new" keyword
            string[] friends = new string[10];

            
            // methods

            // calling the "SayHi" method with different parameters
            SayHi("Mike", 33);
            SayHi("John", 23);
            SayHi("Sedwick", 55);

            // return statement
            Console.WriteLine("Cube of 5 is: " + Cube(5));

            // conditions
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are male and tall");
            }

            else if (isMale && !isTall)
            {
                Console.WriteLine("You are short male");
            }

            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not male but you are tall");
            }

            else
            {
                Console.WriteLine("You are not male and tall");
            }

            // "Calling GetMax method"
            Console.WriteLine("Max of 56, 66, and 87 is: " + GetMax(56,66,87));

            // Building a better calculator
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the op: ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }

            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }

            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }

            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            else
            {
                Console.WriteLine("Invalid operator !");
            }

            // switch statement 
            Console.WriteLine(GetDay(0)); // ==> Sunday
            Console.WriteLine(GetDay(4)); // ==> Thursday
            Console.WriteLine(GetDay(80)); // ==> Invalid case !!

            // while loop
            int index = 1; 

            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            // very basic guessing game 
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;


            do
            {

                if (guessCount < guessLimit)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }

                else
                {
                    Console.WriteLine("You have reached the guess limit");
                    break;
                }
            }
            while (guess != secretWord);


            if (guess == secretWord)
            {
                Console.WriteLine("You have correctly guessed the secret word " + secretWord);
            }
           
            // for loop
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] luckyNumbers = { 4, 8, 15, 16, 17, 18 };

            // traversing entries of array sequentially with for loop
            Console.WriteLine("Array entries are as follows");
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            // bulidng an exponent method
            Console.WriteLine("4 to the power of 3 is: " + GetPow(4, 3));

            // two-dimensional arrays
            int[,] numberGrid = {
                {1,2 },
                {3,4},
                {4,5}
            };

            */

            // exeption handling

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter other number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;
            }

            catch (FormatException e)
            {

                Console.WriteLine(e.Message);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            // Creating an instance of class Book 
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);

            Console.WriteLine("Title of book1 is: " + book1.title);
            Console.WriteLine("Author of book1 is: " + book1.author);
            Console.WriteLine("Number of pages in book1 is: " + book1.pages);

            Console.WriteLine("Title of book2 is: " + book2.title);
            Console.WriteLine("Author of book2 is: " + book2.author);
            Console.WriteLine("Number of pages in book2 is: " + book2.pages);

            Student student1 = new Student("Jim", "Computer Science", 2.8);
            Student student2 = new Student("Adam", "Electriacal Engineering", 3.8);

            Console.WriteLine("Student 1 name is: " + student1.name);
            Console.WriteLine("Student 1 major is: " + student1.major);
            Console.WriteLine("Student 1 grade is: " + student1.gpa);

            Console.WriteLine("Student 2 name is: " + student2.name);
            Console.WriteLine("Student 2 major is: " + student2.major);
            Console.WriteLine("Student 2 grade is: " + student2.gpa);

            if (student1.HasHonors())
            {
                Console.WriteLine(student1.name + " is honors student");
            }


            if (student2.HasHonors())
            {
                Console.WriteLine(student2.name + " is honors student");
            }

            // getters and setters
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            shrek.Rating = "R";
            Console.WriteLine(shrek.Rating);

            // accessing static member directly with class name "Song"
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(holiday.GetSongCount());
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.GetSongCount());

            // static methods and classes
            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("john");

            // Inheritence
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakeSpecialDish();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }

            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }

            else
            {
                result = num3;
            }

            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;

                default:
                    dayName = "Invalid day Number";
                    break;
            }

            return dayName;
        }

        static int GetPow(int baseNum, int powNum)
        {

            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }
}