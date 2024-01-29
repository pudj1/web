
class Hello
{
    static string selected = "";
    static void Main(string[] args)
    {
        Console.WriteLine("Select Function by writing the number:");
        Console.WriteLine("1 - Lorem Ipsum");
        Console.WriteLine("2 - Calculator");
        selected = Console.ReadLine();
        if (selected == "1")
        {
            LoremIpsum();
        } else if (selected == "2")
        {
            Calculator();
        } else
        {
            Console.WriteLine("You writed the wrong number.");
        }
    }

    private static void LoremIpsum()
    {
        Console.WriteLine("Write number of words to give:");
        int numberOfWordsToReturn = int.Parse(Console.ReadLine());

        string result = "";
        try
        {
            string content = File.ReadAllText("TextFile1.txt");
            string[] words = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int actualNumberOfWords = Math.Min(numberOfWordsToReturn, words.Length);
            result = string.Join(" ", words, 0, actualNumberOfWords);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            result = "";
        }
        Console.WriteLine($"First {numberOfWordsToReturn} words from the Lorem Ipsum: {result}");
    }

    static void Calculator()
    {
        Console.WriteLine("Write operation(+,-,*,/):");
        string operation = Console.ReadLine();
        Console.WriteLine("Write first number:");
        float numOne = float.Parse(Console.ReadLine());
        Console.WriteLine("Write second number:");
        float numTwo = float.Parse(Console.ReadLine());
        if (operation == "+")
        {
            Console.WriteLine("result is " + (numOne + numTwo));
        } else if (operation == "-")
        {
            Console.WriteLine("result is " + (numOne - numTwo));
        } else if (operation == "*")
        {
            Console.WriteLine("result is " + (numOne * numTwo));
        } else if (operation == "/")
        {
            Console.WriteLine("result is " + (numOne / numTwo));
        } else
        {
            Console.WriteLine("You writed the wrong operation.");
        }
    }
}