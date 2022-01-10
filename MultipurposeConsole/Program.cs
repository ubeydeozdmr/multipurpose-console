// Definitions

var yellow = ConsoleColor.Yellow;
var blue = ConsoleColor.Blue;
var red = ConsoleColor.Red;
var green = ConsoleColor.Green;
byte selector;

try
{
    // Program starts from here
    Main();

    void Main()
    {
        // The menu that appears when the console is first opened
        Console.ForegroundColor = yellow;
        Console.WriteLine("Welcome to MultipurposeConsole! Created by Ubeyde Emir Özdemir. Github: https://github.com/ubeydeozdmr");
        Console.WriteLine("Which of the following operations you want to do, please type the number related to it and press enter.");
        Console.WriteLine("\t0\tExit from application.");
        Console.WriteLine("\t1\tPrint your name.");
        Console.WriteLine("\t2\tPerform four operations with two numbers.");
        Console.WriteLine("\t3\tFind the discounted price of the product you want to buy.");
        Console.WriteLine("\t4\tFind the grade points average of the three exams.");
        Console.WriteLine("\t5\tFind the perimeter and area of the rectangle.");
        Console.WriteLine("\t6\tFind the area of the circle.");
        Console.WriteLine("\t7\tFind the equivalent resistance of the three resistors.");
        Console.WriteLine("\t8\tFind out if the number you wrote is odd or even.");
        Console.WriteLine("\t9\tDivide one number by another and find the remainder.");
        Console.WriteLine("\t10\tSelect a word, phrase, etc. that you want to print. Print as many times as you want.");
        Console.WriteLine("\t11\tCalculate your body mass index.");
        Console.WriteLine("\t12\tAdd up the quantities of the number in the number you have chosen, by choosing again.");
        Console.WriteLine("\t13\tFind out if the number you entered is a prime number.");
        Console.WriteLine("\t14\tEvaluate your exam grade.");
        Console.WriteLine("\t15\tFind what any power of any number is equal to.");
        Selection();
    }

    void Selection()
    {
        // What happens if you select a number and press enter
        try
        {
            Console.ForegroundColor = yellow;
            selector = Convert.ToByte(Console.ReadLine());
            Console.ForegroundColor = blue;
            SelectionAction();
        }
        catch (Exception ex)
        {
            // What happens if you do not enter the valid number
            Console.ForegroundColor = red;
            if (ex.GetType().ToString() == "System.FormatException")
            {
                Console.WriteLine("Make sure the value you enter is a number.");
            }
            else if (ex.GetType().ToString() == "System.OverflowException")
            {
                Console.WriteLine("Please make sure you enter a number in valid ranges.");
            }
            else
            {
                Console.WriteLine(ex.Message);
            }
            Console.ForegroundColor = yellow;
            Selection();
        }
    }

    void SelectionAction()
    {
        try
        {
            switch (selector)
            {
                case 0:
                    Console.ForegroundColor = yellow;
                    Environment.Exit(0);
                    break;
                case 1:
                    PrintYourName();
                    break;
                case 2:
                    SimpleCalculator();
                    break;
                case 3:
                    DiscountCalculator();
                    break;
                case 4:
                    AverageMarkCalculator();
                    break;
                case 5:
                    AreaOfRectangle();
                    break;
                case 6:
                    AreaOfCircle();
                    break;
                case 7:
                    EquivalentResistanceCalculator();
                    break;
                case 8:
                    OddOrEven();
                    break;
                case 9:
                    RemainderFinder();
                    break;
                case 10:
                    TextRepeater();
                    break;
                case 11:
                    BmiFinder();
                    break;
                case 12:
                    MultipleAddition();
                    break;
                case 13:
                    PrimeNumberFinder();
                    break;
                case 14:
                    MarkEvaluation();
                    break;
                case 15:
                    ExponentOfNumberFinder();
                    break;
                default:
                    Console.ForegroundColor = red;
                    Console.WriteLine("Please make sure you enter a number in valid ranges.");
                    Console.ForegroundColor = yellow;
                    Selection();
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
        }
    }

    void AskAgain()
    {
        try
        {
            Console.ForegroundColor = blue;
            Console.WriteLine("Would you like to try again? (y/n)");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string selectedOption = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            if (selectedOption == "y")
            {
                SelectionAction();
            }
            else if (selectedOption == "n")
            {
                Main();
            }
            else
            {
                Console.ForegroundColor = red;
                Console.WriteLine("You have pressed a wrong key.");
                Console.ReadLine();
                AskAgain();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            AskAgain();
        }
    }

    void PrintYourName()
    {
        try
        {
            string nameInput, surnameInput;
            Console.WriteLine("Please enter your name");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            nameInput = Console.ReadLine();
            Console.WriteLine("Please enter your surname");
            surnameInput = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.ForegroundColor = green;
            Console.WriteLine("Your full name is {0} {1}", nameInput, surnameInput);
            AskAgain();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            PrintYourName();
        }
    }

    void SimpleCalculator()
    {
        try
        {
            decimal firstNumber, secondNumber;
            Console.WriteLine("Please enter the first number");
            firstNumber = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            secondNumber = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please select an operation. Type the symbol of the relevant operation and press enter.");
            Console.WriteLine("\t+\tFor addition");
            Console.WriteLine("\t-\tFor subtraction");
            Console.WriteLine("\t*\tFor multiplication");
            Console.WriteLine("\t/\tFor division");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string selectedOperation = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            decimal result = 0;
            if (selectedOperation == "+" || selectedOperation == "-" || selectedOperation == "*" || selectedOperation == "/")
            {
                Result(firstNumber, secondNumber);
                Console.ForegroundColor = green;
                Console.WriteLine("Result: " + result);
                Console.ForegroundColor = blue;
                AskAgain();
            }
            else
            {
                SimpleCalculator();
            }

            decimal Result(decimal firstNumber, decimal secondNumber)
            {
                switch (selectedOperation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        break;
                }
                return result;
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            SimpleCalculator();
        }
    }

    void DiscountCalculator()
    {
        try
        {
            double tagPrice, discount;
            Console.WriteLine("Please enter the tag price of the product you want to buy.");
            tagPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please write how many percent discount you want to buy.");
            discount = Convert.ToDouble(Console.ReadLine());

            if (discount > 0 && discount < 100 && tagPrice >= 0)
            {
                Console.ForegroundColor = green;
                Console.WriteLine("Discounted product price: " + tagPrice * (100 - discount) / 100);
                if (discount == 0)
                {
                    Console.WriteLine("If the discount rate is 0%, it means that there is no discount on that product.");
                }
                if (discount == 100)
                {
                    Console.WriteLine("A 100% discount rate actually means that the product is made for free.");
                }
                AskAgain();
            }
            else
            {
                Console.ForegroundColor = red;
                Console.WriteLine("Discount cannot be more than 100% or less than 0%. Please enter a valid discount rate.");
                Console.ForegroundColor = blue;
                Console.ReadLine();
                DiscountCalculator();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            DiscountCalculator();
        }
    }

    void AverageMarkCalculator()
    {
        try
        {
            byte mark1, mark2, mark3;
            Console.WriteLine("Please enter your first exam grade.");
            mark1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Please enter your second exam grade.");
            mark2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Please enter your third exam grade.");
            mark3 = Convert.ToByte(Console.ReadLine());

            if (mark1 > 0 && mark2 > 0 && mark3 > 0 && mark1 < 100 && mark2 < 100 && mark3 < 100)
            {
                Console.ForegroundColor = green;
                Console.WriteLine("Your average mark: " + (mark1 + mark2 + mark3) / 3);
                Console.ForegroundColor = blue;
                AskAgain();
            }
            else
            {
                Console.ForegroundColor = red;
                Console.WriteLine("The grade values you enter cannot be less than zero or greater than a hundred.");
                Console.ForegroundColor = blue;
                AverageMarkCalculator();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            AverageMarkCalculator();
        }
    }

    void AreaOfRectangle()
    {
        try
        {
            int edge1, edge2;
            Console.WriteLine("Please enter one side of the rectangle.");
            edge1 = Convert.ToInt32(Console.ReadLine());
            if (edge1 < 0) { ValidLength(); }
            Console.WriteLine("Please enter other side of the rectangle.");
            edge2 = Convert.ToInt32(Console.ReadLine());
            if (edge2 < 0) { ValidLength(); }
            Console.ForegroundColor = green;
            Console.WriteLine("The perimeter of the rectangle is " + 2 * (edge1 + edge2) + " and the area is " + edge1 * edge2);
            Console.ForegroundColor = blue;
            void ValidLength()
            {
                Console.ForegroundColor = red;
                Console.WriteLine("The side length you enter must be greater than zero.");
                Console.ForegroundColor = blue;
                AreaOfRectangle();
            }
            AskAgain();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            AreaOfRectangle();
        }
    }

    void AreaOfCircle()
    {
        try
        {
            double radius, angleOfCircleSegment;
            Console.WriteLine("Please enter the radius.");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the angle of the circle segment. If your circle is full circle, type 360 and press enter.");
            angleOfCircleSegment = Convert.ToDouble(Console.ReadLine());

            if (angleOfCircleSegment >= 0 && angleOfCircleSegment <= 360 && radius > 0)
            {
                SelectPI();
                void SelectPI()
                {
                    Console.WriteLine("Press 3 if you want the Pi to get 3, press 4 if you want to get 3.14 and press enter.");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string selectedOperation = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    if (selectedOperation == "3" || selectedOperation == "4")
                    {
                        double pi = 3;
                        switch (selectedOperation)
                        {
                            case "3":
                                pi = 3;
                                break;
                            case "4":
                                pi = 3.14;
                                break;
                        }
                        Console.ForegroundColor = green;
                        Console.WriteLine("Area of the circle: " + (pi * radius * radius * angleOfCircleSegment / 360));
                        Console.ForegroundColor = blue;
                        AskAgain();
                    }
                    else
                    {
                        Console.ForegroundColor = red;
                        Console.WriteLine("You have entered a wrong input.");
                        Console.ForegroundColor = blue;
                        SelectPI();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = blue;
            AreaOfCircle();
        }
    }

    void EquivalentResistanceCalculator()
    {
        try
        {
            double resistance1, resistance2, resistance3, equivalentResistance;
            Console.WriteLine("Enter the first resistance value in ohms.");
            resistance1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second resistance value in ohms.");
            resistance2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third resistance value in ohms.");
            SerialOrParallel();
            void SerialOrParallel()
            {
                resistance3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type a for serial connection, b for parallel connection and press enter.");
#pragma warning disable CS8604 // Possible null reference argument.
                char selectedOperation = Convert.ToChar(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
                switch (selectedOperation)
                {
                    case 'a':
                        equivalentResistance = resistance1 + resistance2 + resistance3;
                        GetEquivalentResistance();
                        break;
                    case 'b':
                        equivalentResistance = (resistance1 * resistance2 * resistance3) / (resistance1 * resistance2 + resistance2 * resistance3 + resistance1 * resistance3);
                        GetEquivalentResistance();
                        break;
                    default:
                        Console.ForegroundColor = red;
                        Console.WriteLine("You have entered a wrong input.");
                        Console.ForegroundColor = blue;
                        SerialOrParallel();
                        break;
                }
                void GetEquivalentResistance()
                {
                    Console.ForegroundColor = green;
                    Console.WriteLine("Equivalent resistance: " + equivalentResistance);
                    Console.ForegroundColor = blue;
                    AskAgain();
                }
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = blue;
            EquivalentResistanceCalculator();
        }
    }

    void OddOrEven()
    {
        try
        {
            Console.WriteLine("Please type a number and press enter.");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.ForegroundColor = green;
                Console.WriteLine("The number you entered is even");
                AskAgain();
            }
            else if (input % 2 == 1)
            {
                Console.ForegroundColor = green;
                Console.WriteLine("The number you entered is odd");
                AskAgain();
            }
            else
            {
                Console.ForegroundColor = red;
                Console.WriteLine("Please make sure you enter a positive number. The number value you enter cannot be less than 0.");
                Console.ForegroundColor = blue;
                Console.ReadLine();
                OddOrEven();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            OddOrEven();
        }
    }

    void RemainderFinder()
    {
        try
        {
            int dividend, divisor;
            Console.WriteLine("Please enter the number you want to divide and press enter.");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What number do you want to divide " + dividend + " by?");
            divisor = Convert.ToInt32(Console.ReadLine());

            if (dividend >= 0 && divisor > 0)
            {
                Console.ForegroundColor = green;
                Console.WriteLine("Remainder of {0} divided by {1}: " + (dividend % divisor), dividend, divisor);
                AskAgain();
            }
            else
            {
                Console.ForegroundColor = red;
                Console.WriteLine("The divisor cannot be less than 0. Also, the divisor must be greater than 0.");
                RemainderFinder();
                Console.ForegroundColor = blue;
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            RemainderFinder();
        }
    }

    void TextRepeater()
    {
        try
        {
            Console.WriteLine("Please enter the word, phrase, etc. you want to enter. enter and press enter.");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string inputtedText = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("The word, sentence, etc. you entered. How many times do you repeat?");
            int counter = Convert.ToInt32(Console.ReadLine());

            //for döngüsü ile 0'dan başlanıp sayacın bir eksiği kadar kullanıcının girdiği metin alt alta tekrarlanır.
            Console.ForegroundColor = green;
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(inputtedText);
            }
            AskAgain();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            TextRepeater();
        }
    }

    void BmiFinder()
    {
        try
        {
            double weight, height, yourBMI;
            Console.WriteLine("Please enter your weight in kg.");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height in cm.");
            height = Convert.ToDouble(Console.ReadLine());
            yourBMI = weight / ((height / 100) * (height / 100));
            Console.WriteLine("Your body-mass index: {0}", yourBMI);
            Console.ForegroundColor = green;
            if (yourBMI < 18)
            {
                Console.WriteLine("Underweight");
            }
            else if (yourBMI < 25)
            {
                Console.WriteLine("Healthy");
            }
            else if (yourBMI < 30)
            {
                Console.WriteLine("Overweight");
            }
            else if (yourBMI < 35)
            {
                Console.WriteLine("Obese");
            }
            else if (yourBMI < 100)
            {
                Console.WriteLine("Extremely Obese");
            }
            else
            {
                Console.ForegroundColor = red;
                Console.WriteLine("Please make sure you enter the correct data.");
                Console.ForegroundColor = blue;
                BmiFinder();
            }
            if (yourBMI > 0)
            {
                AskAgain();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            BmiFinder();
        }
    }

    void MultipleAddition()
    {
        try
        {
            int number, counter, total = 0;
            Console.WriteLine("How many numbers will you collect?");
            counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= counter; i++)
            {
                string t = i switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th",
                };
                Console.WriteLine("Enter the {0}{1} number: ", i, t);
                number = Convert.ToInt32(Console.ReadLine());
                total += number;
            }
            Console.ForegroundColor = green;
            Console.WriteLine("The sum of {0} numbers you entered: {1}", counter, total);
            AskAgain();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            MultipleAddition();
        }
    }

    void PrimeNumberFinder()
    {
        try
        {
            int controller = 0, inputtedNumber;
            Console.WriteLine("Enter the number you want to know if it is prime.");
            inputtedNumber = Convert.ToInt32(Console.ReadLine());

            if (inputtedNumber <= 0)
            {
                Console.WriteLine("The number you enter must be a positive integer. Please enter an integer greater than zero.");
                PrimeNumberFinder();
            }

            for (int i = 2; i < inputtedNumber; i++)
            {
                if (inputtedNumber % i == 0)
                {
                    controller++;
                    break;
                }
            }
            Console.ForegroundColor = green;
            string str = (controller != 0 || inputtedNumber == 1) ? "not " : "";
            Console.WriteLine("The number {0} you entered is {1}a prime number.", inputtedNumber, str);
            AskAgain();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            PrimeNumberFinder();
        }
    }

    void MarkEvaluation()
    {
        try
        {
            Console.WriteLine("Enter your exam grade.");
            int mark;
            mark = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = green;
            if (mark < 50)
            {
                Console.WriteLine("You failed the exam.");
            }
            else if (mark < 60)
            {
                Console.WriteLine("Your score is poor.");
            }
            else if (mark < 70)
            {
                Console.WriteLine("Your score is medium.");
            }
            else if (mark < 85)
            {
                Console.WriteLine("Your score is high.");
            }
            else if (mark <= 100)
            {
                Console.WriteLine("Your score is too high.");
                if (mark == 100)
                {
                    Console.WriteLine("Excellent!");
                }
            }
            else
            {
                Console.ForegroundColor = red;
                Console.WriteLine("Please enter a valid exam grade.");
                Console.ForegroundColor = blue;
                MarkEvaluation();
            }
            if (mark >= 0 && mark <= 100)
            {
                AskAgain();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            MarkEvaluation();
        }
    }

    void ExponentOfNumberFinder()
    {
        try
        {
            int baseNumber, exponent, result = 1;
            Console.WriteLine("Lütfen taban sayıyı girin.");
            baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen taban sayının \"üssünü\" giriniz.");
            exponent = Convert.ToInt32(Console.ReadLine());

            //for döngüsü burada aynı sayıyı kullanıcının girdiği üs değeri kadar çarpar.

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            string t = exponent switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th",
            };
            Console.ForegroundColor = green;
            Console.WriteLine("The {0}{1} power of {2} is equal to {3}.", exponent, t, baseNumber, result);
            AskAgain();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = yellow;
            ExponentOfNumberFinder();
        }
    }

}
catch (Exception ex)
{
    Console.ForegroundColor = red;
    Console.WriteLine(ex.Message);
    Console.ForegroundColor = yellow;
}

// Created by Ubeyde Emir Özdemir
// GitHub: https://github.com/ubeydeozdmr