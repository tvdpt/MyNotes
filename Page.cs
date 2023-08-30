public class Page
{
    public string Content;
    public Page(string content)
    {
        Content = content;
    }

    public virtual void Read()
    {
        Console.Clear();
        Console.WriteLine("\nPage contents:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Book.WriteLine(Content);
        Console.ResetColor();
    }
}