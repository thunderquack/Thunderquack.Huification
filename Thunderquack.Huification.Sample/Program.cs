using Thunderquack.Huification;

Console.WriteLine("Please write a sentence, use Ctrl-C to exit:");
ConsoleColor textColor = Console.ForegroundColor;
while (true)
{
    string st = Console.ReadLine();
    try
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(st.Huificate());
        Console.ForegroundColor = textColor;
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(e.ToString());
    }
    finally
    {
        Console.ForegroundColor = textColor;
    }
}