
public class Calculator
{

    public int add(String numbers)
    {
        if (string.IsNullOrEmpty(numbers)) return 0;
        char delimiter = ',';
        if (DelimiterIsProvided(numbers))
        {
            delimiter = numbers.ElementAt(2);
            numbers = numbers.Remove(0, 4);
        }
        string[] number = numbers.Split(delimiter, '\n'); 
        int result = 0;
        foreach(string numberItem in number)
        {
            result += Int32.Parse(numberItem);
        }
        return result;
    }

    private bool DelimiterIsProvided(string numbers)
    {
        if (numbers.ElementAt(0) == '/' && numbers.ElementAt(1) == '/') return true ;
        return false;
    }
}
