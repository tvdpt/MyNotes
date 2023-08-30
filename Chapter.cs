public class Chapter
{
    public string Title;
    public List<Page> Pages;
    public Chapter(string title)
    {
        Title = title;
        Pages = new List<Page>();
    }

    public Chapter(string title, List<Page> pages)
    {
        Title = title;
        Pages = pages;
    }

    public void Read()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Title);
        Console.ResetColor();
        Console.WriteLine("\nChapter contents:");
        foreach (Page page in Pages)
        {
            page.Read();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        Console.Clear();
    }
}