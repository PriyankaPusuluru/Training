Console.WriteLine("Hello, World!");
int a = 5;
int b = 10;
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a > b);
Console.WriteLine(a < b);
Console.WriteLine(a == b);
var firstName = "Priya";
var LastName = "Pusuluru";
Console.WriteLine(firstName + " " + LastName);

Console.WriteLine("Enter a number:");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter another number:");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of {c} and {d} is {c + d}");

//1.Write a C# code to accept two integers and check whether they are equal or not.
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x == y)
{
    Console.WriteLine("The two integers are equal.");
}
else
{
    Console.WriteLine("The two integers are not equal.");
}
//2.Write a C# Sharp program to check whether a given number is positive or negative.
int s = Convert.ToInt32(Console.ReadLine());
if (s > 0)
{
    Console.WriteLine("The number is positive.");
}
else if (s < 0)
{
    Console.WriteLine("The number is negative.");
}
else
{
    Console.WriteLine("The number is zero.");
}
// 3.Write a C# Sharp program to accept a person's height in centimeters and
//  categorize them according to their height.
Console.WriteLine("Enter the height:");
var height = Convert.ToInt32(Console.ReadLine());
if (height < 150)
{
    Console.WriteLine("Under short group");
}
else if (height >=150 && height <=170)
{
    Console.WriteLine("Under medium group");
}
else
{
    Console.WriteLine("Under tall group");
}
// Write a C# Sharp program to find the largest of three numbers.
int p = Convert.ToInt32(Console.ReadLine());
int q = Convert.ToInt32(Console.ReadLine());
int r = Convert.ToInt32(Console.ReadLine());
if (p > q && p > r)
{
    Console.WriteLine($"{p} is the largest number.");
}
else if (q > p && q > r)
{
    Console.WriteLine($"{q} is the largest number.");
}
else
{
    Console.WriteLine($"{r} is the largest number.");
}

//5.Write a C# Sharp program to read roll no, name and marks of three subjects 
// and calculate the total, percentage and division.
Console.WriteLine("Enter roll number:");
var rollNumber = Console.ReadLine();
Console.WriteLine("Enter name:");
var name = Console.ReadLine();
Console.WriteLine("Enter marks for subject 1:");
var marks1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter marks for subject 2:");
var marks2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter marks for subject 3:");
var marks3 = Convert.ToInt32(Console.ReadLine());

var total = marks1 + marks2 + marks3;
var percentage = (double)total / 3;
var division = percentage >= 60 ? "First" : percentage >= 50 ? "Second" : "Third";

Console.WriteLine($"Roll Number: {rollNumber}");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Total: {total}");
Console.WriteLine($"Percentage: {percentage:F2}");
Console.WriteLine($"Division: {division}");

//Write a program that checks a customer's eligibility for a discount based
//  on their membership level and purchase amount
//membership levels (Gold 5%, Silver 10%, Platinum 20%) discount
// (if purchase amount < 100 no discount , more than 100 apply discount)
Console.WriteLine("Enter membership level (Gold/Silver/Platinum):");
var membershipLevel = Console.ReadLine();
Console.WriteLine("Enter purchase amount:");
var purchaseAmount = Convert.ToInt32(Console.ReadLine());
if (purchaseAmount < 100)
{
    Console.WriteLine("No discount applicable.");
}
else
{
    double discount = 0;
    switch (membershipLevel.ToLower())
    {
        case "gold":
            discount = 0.05;
            break;
        case "silver":
            discount = 0.10;
            break;
        case "platinum":
            discount = 0.20;
            break;
        default:
            Console.WriteLine("Invalid membership level.");
            return;
    }
    var discountedAmount = purchaseAmount - (purchaseAmount * discount);
    Console.WriteLine($"Discounted amount: {discountedAmount:F2}");
}
//Write a switch statement that takes an integer variable representing aday of 
// the week (1 for Monday, 2 for Tuesday, etc.) and prints the corresponding day name.
Console.WriteLine("Enter a number (1-7) representing a day of the week:");
var dayNumber = Convert.ToInt32(Console.ReadLine());

switch (dayNumber)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day number.");
        break;
}

//Write a program in C# Sharp to display the first 10 natural numbers using for loop.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//Write a C# Sharp program to find the sum of the first
//  10 natural numbers using for loop.
int sum = 0;
for (int i = 1; i <= 10; i++)
{
    sum += i;
}
Console.WriteLine($"Sum of the first 10 natural numbers: {sum}");

//Write a program that takes a positive integer input from the user 
// and calculates the sum of its digits using a loop.
Console.WriteLine("Enter a positive integer:");
var number = Convert.ToInt32(Console.ReadLine());
int sumOfDigits = 0;
while (number > 0)
{
    sumOfDigits += number % 10;
    number /= 10;
}
Console.WriteLine($"Sum of digits: {sumOfDigits}");

//Write a program that takes a string input from the 
// user and uses a loop to reverse the string.
Console.WriteLine("Enter a string:");
var input = Console.ReadLine();
var reversed = "";
for (int i = input.Length - 1; i >= 0; i--)
{
    reversed += input[i];
}
Console.WriteLine($"Reversed string: {reversed}");

//Write a program that uses a while loop to calculate the 
// sum of all integers from 1 to 100.
int total = 0;
int counter = 1;
while (counter <= 100)
{
    total += counter;
    counter++;
}
Console.WriteLine($"Sum of integers from 1 to 100: {total}");

//using do while loop, Create a game where the user has to guess
//  a randomly generated number between 1 and 100. The program should tell the user
//  if their guess is too high or too low and continue until they guess correctly.
Random random = new Random();

int randomNumber = random.Next(1, 101);
int guess;

do
{
    Console.WriteLine("Guess a number between 1 and 100:");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess > randomNumber)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else if (guess < randomNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else
    {
        Console.WriteLine("Correct! You guessed the number.");
    }

} while (guess != randomNumber);

//using while loop, Write a program that counts down from a user 
// specified number to zero.
Console.WriteLine("Enter a number to count down from:");
int countDownNumber = Convert.ToInt32(Console.ReadLine());
while (countDownNumber >= 0)
{
    Console.WriteLine(countDownNumber);
    countDownNumber--;
}

//Write a program that prints the multiplication table from 1 to 10 using
//  nested for loops.
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}