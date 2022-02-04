
public class Calculator
{

    public int add(String numbers)
    {
        if (string.IsNullOrEmpty(numbers)) return 0;
        char delimiter = ',';
        if (DelimiterIsProvided(numbers))
        {
            delimiter = numbers.ElementAt(2);
            numbers = numbers.Substring(4);
        }
        string[] number = numbers.Split(delimiter, '\n'); 


        int result=number.Select(stringNumber => Int32.Parse(stringNumber))
                         .Where(number => number < 1000)
                         .Aggregate(0, (count, val) => count + val);

        return result;

    }


    private bool DelimiterIsProvided(string numbers)
    {
        if (numbers.StartsWith("//") ) return true ;
        return false;
    }
}
