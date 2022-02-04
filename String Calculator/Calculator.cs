
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

        int result = 0;

        foreach (string numberItem in number)
        {
            int num = Int32.Parse(numberItem);
            if(num< 0) Store(num);
            if (num > 1000) continue;
            result += num;
        }

        if (negatives.Count()!=0) throw new Exception($"negatives not allowed: {negatives}");
        return result;

    }

    List<int> negatives = new List<int>();
    private void Store(int num)
    {
        negatives.Add(num);
    }

    private bool DelimiterIsProvided(string numbers)
    {
        if (numbers.StartsWith("//") ) return true ;
        return false;
    }
}
