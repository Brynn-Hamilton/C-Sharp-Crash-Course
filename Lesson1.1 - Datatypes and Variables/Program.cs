
// type // variable name // data/value given to variable of type x

int i = 10; // integer, whole numbers, -2,147,483,648 to 2,147,483,648
double d = 50.0; // double, decimal format, -1.79769313486232e308 to 1.79769313486232e308
float f = 32.7f; // float, decimal format, 	-3.402823e38 to 3.402823e38
decimal dm = 23.50m; // decimal, decimal format, primarily used for money, (+ or -)1.0 x 10e-28 to 7.9 x 10e28
string s = "I am a string"; // string, sequence of characters 
char c = 'c'; // character, single character
bool isAdult = true; // boolean, true or false

// Printing a string to the console "Please enter three numbers"
//Console.WriteLine("Please enter two numbers");
//int input1 = Convert.ToInt32(Console.ReadLine());


//string input1 = Console.ReadLine();
//int intInput = Convert.ToInt32(input1);

//string input1 = Console.ReadLine();
//string input2 = Console.ReadLine();
//string sum = input1 + " " + input2;
//Console.WriteLine(sum);


Console.WriteLine("Please enter 3 letters");
string letter1 = Console.ReadLine();
string letter2 = Console.ReadLine();
string letter3 = Console.ReadLine();
string displayReverse = letter3 + letter2 + letter1;

Console.WriteLine($"The letters in reverse are {letter3}, {letter2}, {letter1}");
Console.WriteLine();
Console.WriteLine(displayReverse);
