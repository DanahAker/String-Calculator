
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



        var integerNumbers = number.Select(stringNumber => Int32.Parse(stringNumber));
        var negatives = integerNumbers.Where(x => x < 0);
        if (negatives.Count() != 0) throw new Exception($"negatives not allowed: {negatives}");
        int result = integerNumbers.Where(number => number < 1000)   
                                   .Sum(x=>x);


        return result;
       

    }

   

    private bool DelimiterIsProvided(string numbers)
    {
        if (numbers.StartsWith("//") ) return true ;
        return false;
    }
}
