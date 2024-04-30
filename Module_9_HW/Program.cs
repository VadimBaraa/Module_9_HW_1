using System;

public class CustomException : Exception
{
    public CustomException(string message) : base($"Слово \"{message}\" содержит букву 'А'.")
    {
    }
}

class Program
{
    static void Main(string[] args)
    {


        try
        {
            string str = "автобус";
            CheckForLetterA(str);
            Console.WriteLine(str);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка деления на ноль.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Ошибка выхода за границы массива.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Ошибка нулевого указателя (null).");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Ошибка недопустимой операции.");
        }
        catch (CustomException)
        {
            Console.WriteLine($"В слове имеется буква заглавная А");
        }
        finally
        {
                Console.WriteLine("Блок finally выполнен.");
        }
    }

    static void CheckForLetterA(string word)
    {
        if (word.Contains("А"))
        {
            throw new CustomException("Слово содержит букву 'А'.");
        }
    }
}
