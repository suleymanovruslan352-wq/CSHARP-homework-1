//1
//string str;
//Console.WriteLine("Input Number: ");
//str = Console.ReadLine();
//int number = int.Parse(str);

//if (number % 3 == 0 && number % 5 == 0)
//{
//    Console.WriteLine("Fizz Buzz");
//}
//else if(number % 5 == 0)
//{
//    Console.WriteLine("Buzz");
//}
//else if(number % 3 == 0)
//{
//    Console.WriteLine("Fizz");
//}
//else
//{
//    Console.WriteLine(number);
//}

//2

//string num1;
//Console.WriteLine("Input Number:");
//num1 = Console.ReadLine();

//string percent;
//Console.WriteLine("Input Percent:");
//percent = Console.ReadLine();

//int number = int.Parse(num1);
//int percentValue = Convert.ToInt32(percent);
//int result = (number *  percentValue) / 100;
//Console.WriteLine("Result: ");
//Console.WriteLine($"{result} %");

//3

//string num1;
//Console.WriteLine("Input Number1:");
//num1 = Console.ReadLine();

//string num2;
//Console.WriteLine("Input Number2:");
//num2 = Console.ReadLine();

//string num3;
//Console.WriteLine("Input Number3:");
//num3 = Console.ReadLine();

//string num4;
//Console.WriteLine("Input Number4:");
//num4 = Console.ReadLine();

//int number1 = int.Parse(num1);
//int number2 = int.Parse(num2);
//int number3 = int.Parse(num3);
//int number4 = int.Parse(num4);

//int result = number1 * 1000 + number2 * 100 + number3 * 10 + number4;
//Console.WriteLine($"RESULT: {result}");

//4



//Console.WriteLine("Input Number (6 digits):");
//int number = int.Parse(Console.ReadLine());

//Console.WriteLine("Input [position1] (1-6):");
//int position1 = int.Parse(Console.ReadLine()) - 1; 

//Console.WriteLine("Input [position2] (1-6):");
//int position2 = int.Parse(Console.ReadLine()) - 1; 

//int digit1 = 0;
//int digit2 = 0;
//int total = 0;

//for (int i = 0; i < 6; i++)
//{
//    int currentDigit = (number / Pow10(6 - i - 1)) % 10;

//    if (i == position1)
//    {
//        digit1 = currentDigit;
//    }
//    if (i == position2)
//    {
//        digit2 = currentDigit;
//    }
//}

//for (int i = 0; i < 6; i++)
//{
//    int currentPositionFromLeft = 6 - i - 1;
//    int digitToPlace;

//    if (currentPositionFromLeft == position1)
//    {
//        digitToPlace = digit2;
//    }
//    else if (currentPositionFromLeft == position2)
//    {
//        digitToPlace = digit1;
//    }
//    else
//    {
//        digitToPlace = (number / Pow10(i)) % 10;
//    }

//    total += digitToPlace * Pow10(i);
//}

//Console.WriteLine($"Result: {total}");

//static int Pow10(int power)
//{
//    int result = 1;
//    for (int i = 0; i < power; i++)
//    {
//        result *= 10;
//    }
//    return result;
//}





//5
//string choice;
//Console.WriteLine("Input choice:\n" +
//    "1. (Celsium)\n" +
//    "2. (Farengeyt) ");
//choice = Console.ReadLine();
//if (choice == "1")
//{
//    string temp;
//    Console.WriteLine("Input temperature (Celsium): ");
//    temp = Console.ReadLine();
//    double temperature = Convert.ToDouble(temp);
//    Console.WriteLine("Temperature of Farengeyt: ");
//    double result = (temperature * 1.8) + 32;
//    Console.WriteLine(result);
//}
//else if (choice == "2")
//{
//    string temp2;
//    Console.WriteLine("Input temperature (Farengeyt): ");
//    temp2 = Console.ReadLine();
//    double temperature2 = Convert.ToDouble(temp2);
//    Console.WriteLine("Temperature to Celsium: ");
//    double result2 = (temperature2 - 32) / 1.8;
//    Console.WriteLine(result2);
//}
//else
//{
//    Console.WriteLine("Invalid choice!");
//}

//6
//Console.WriteLine("Input Start: ");
//string start;
//start = Console.ReadLine();
//Console.WriteLine("Input End: ");
//string end;
//end = Console.ReadLine();
//int startc = int.Parse(start);
//int endc = int.Parse(end);
//if (startc > endc)
//{
//    int temp;
//    temp = startc;
//    startc = endc;
//    endc = temp;
//}
//for (int i = startc; i < endc + 1; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
