// -=-=-=-=-=-=-=-=-=- Operators -=-=-=-=-=-=-=-=-=-
// ---------- ariphmetic: + - * / %

int a = 5, b = 2;

Console.WriteLine($"A + B: {a + b}");
Console.WriteLine($"A - B: {a - b}");
Console.WriteLine($"A * B: {a * b}");
Console.WriteLine($"A / B: {a / b}");
Console.WriteLine($"A % B: {a % b}");

// return type = biggest operand type

Console.Write("Enter number: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine($"Last number digit: {a % 10}"); // 123 / 10 = 12.3

int result = (2 + 2) * 2; // 8

// midify the value: += -= *= %=
a += 10; // a = a + 10;
Console.WriteLine($"A = {a}");

// ------- increment / decrement: ++ --
++a; // prefix form
Console.WriteLine($"A = {a}");

a = 10;
// postfix form
//int c = a++ * 2; // 20
int c = ++a * 2;   // 22
