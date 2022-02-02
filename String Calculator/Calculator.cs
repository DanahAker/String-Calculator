
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
        bool thereIsNegativeNumber = false;
        foreach (string numberItem in number)
        {
            int num = Int32.Parse(numberItem);
            if(num< 0)
            {
                Store(num);
                thereIsNegativeNumber = true;
            }
            if (num > 1000) continue;
            else result += num;
        }

        if (thereIsNegativeNumber) throw new Exception($"negatives not allowed: {negatives.ElementAt(0)}");
            

        return result;

    }

    List<int> negatives = new List<int>();
    private void Store(int num)
    {
            negatives.Add(num);
    }

    private bool DelimiterIsProvided(string numbers)
    {
        if (numbers.ElementAt(0) == '/' && numbers.ElementAt(1) == '/') return true ;
        return false;
    }
}
