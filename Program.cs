
using System.ComponentModel.DataAnnotations;

Page FirstPage = new Page (MyNotes.VariablesPageOne);

Page SecondPage = new Page (MyNotes.VariablesPageTwo);

Chapter kapitel1= new Chapter("variabler");

kapitel1.Pages.Add(FirstPage);
kapitel1.Pages.Add(SecondPage);

Chapter kapitel2= new Chapter("Artifical intelligence");

kapitel2.Pages.Add(FirstPage);
kapitel2.Pages.Add(SecondPage);

Book MyBook = new Book ("Haps");
MyBook.Chapters.Add(kapitel1);
MyBook.Chapters.Add(kapitel2);
MyBook.Start();



Console.ReadLine(); 