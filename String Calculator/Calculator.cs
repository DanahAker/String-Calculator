public class Calculator
{

    public int add(String numbers)
    {
        if (string.IsNullOrEmpty(numbers)) return 0;
        string[] number = numbers.Split(",");
        int FirstNumber = Int32.Parse(number[0]);
        if (number.Length == 1) return FirstNumber;
        int SecondNumber = Int32.Parse(number[1]);
        return FirstNumber + SecondNumber;

    }
}
