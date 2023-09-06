
using System.ComponentModel.DataAnnotations;

Page Int = new Page ("An int variable in C# is a fundamental data type used to store whole numbers. It occupies 32 bits of memory, allowing it to represent a wide range of values, both positive and negative, with a default value of 0 if not initialized. You can perform arithmetic operations on int variables, but be cautious of potential overflow issues. int variables can be declared and initialized in a single step and can be used for tasks like counting, indexing, and basic mathematical calculations. When precision is not critical, int is more efficient than other numeric types like float or double.");

Page Second = new Page ("Min anden side");

Page third = new Page ("Min tredje0 side");

Chapter kapitel1= new Chapter("variabler");

kapitel1.Pages.Add(Int);
kapitel1.Pages.Add(Second);
kapitel1.Pages.Add(third);

kapitel1.Read();

Console.ReadLine(); 