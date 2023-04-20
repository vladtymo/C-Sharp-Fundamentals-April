﻿// Top-Level Statements - hide the base code (class Program with Main method)

// ... write your code here ...

// inline comment
/*
    block comment
    block comment
*/

// Ctrl + F5                         - build and run application
// Alt + Arrow Up/Dowm               - move line up/dowm
// Select Code Block -> Ctrl + K + F - formate selected code

// ------------------ console output ------------------
// invoke method syntax: className.MethodName(parameter1, parameter2...);

Console.WriteLine("Hello C#! I am going to deal with you:)");
// snippet: cw: Console.WriteLine();

Console.Write("How are you?");
Console.Write(" - I am fine!");
Console.WriteLine(); // end of line
Console.WriteLine("New line...");

/* Escape sequences: 
 *  \n - new line
 *  \t - tabulation
 *  \' - single quote '
 *  \" - double quote "
 *  \\ - backslash \
 */

Console.WriteLine("Dear, \"Vlad\"!\n\tWelcome!\n\t\tSee you!");
// @ - string literal (ignore all escape sequences)
Console.WriteLine(@"Escape sequences: \n \t \\ \'. File path: C:\Users\Vlad\new");

// ------------------ console input ------------------
// ------- read string value
Console.Write("Enter your name: ");
string name = Console.ReadLine();

// string concatination: "text" + "text" = "texttext"
Console.WriteLine("Hello, dear " + name + "!");
// string interpolation: $"text {expression} text" (introduced in C# 6)
Console.WriteLine($"Hello, dear {name}! {{}}");

// ------- read numeric value
Console.Write("Enter your birthdate year: ");

// type.Parse(string): convert string to specific type
int year = int.Parse(Console.ReadLine());

Console.WriteLine($"You are {DateTime.Now.Year - year} years old...");
