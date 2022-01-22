public class Calculator
{

    public int add(String numbers)
    {
        if (string.IsNullOrEmpty(numbers)) return 0;
        string[] number = numbers.Split(",");
        int result = 0;
        foreach(string numberItem in number)
        {
            result += Int32.Parse(numberItem);
        }
        return result;

    }
}
