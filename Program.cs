
using System.ComponentModel.DataAnnotations;

Page FirstPage = new Page (MyNotes.VariablesPageOne);

Page SecondPage = new Page (MyNotes.VariablesPageTwo);

Chapter kapitel1= new Chapter("Variabler");

kapitel1.Pages.Add(FirstPage);
kapitel1.Pages.Add(SecondPage);

Page FirstPageAI = new Page (MyNotes.AIPageOne);
Page SecondPageAI = new Page (MyNotes.AIPageTwo);

Chapter kapitel2= new Chapter("AI");

kapitel2.Pages.Add(FirstPageAI);
kapitel2.Pages.Add(SecondPageAI);

Book MyBook = new Book ("DIn mors noter");
MyBook.Chapters.Add(kapitel1);
MyBook.Chapters.Add(kapitel2);
MyBook.Start();



Console.ReadLine(); 