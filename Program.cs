class Program
{
    static void Main()
    {
        int intValue = 42;
        double doubleValue = 3.14159;
        bool boolValue = true;
        DateTime dateTimeValue = DateTime.Now;

        string intString = intValue.ToString();
        string doubleString = doubleValue.ToString();
        string boolString = boolValue.ToString();
        string dateTimeString = dateTimeValue.ToString();

        string intConvertString = Convert.ToString(intValue);
        string doubleConvertString = Convert.ToString(doubleValue);
        string boolConvertString = Convert.ToString(boolValue);
        string dateTimeConvertString = Convert.ToString(dateTimeValue);

        Console.WriteLine("Using ToString():");
        Console.WriteLine("int: " + intString);
        Console.WriteLine("double: " + doubleString);
        Console.WriteLine("bool: " + boolString);
        Console.WriteLine("DateTime: " + dateTimeString);

        Console.WriteLine("\nUsing Convert.ToString():");
        Console.WriteLine("int: " + intConvertString);
        Console.WriteLine("double: " + doubleConvertString);
        Console.WriteLine("bool: " + boolConvertString);
        Console.WriteLine("DateTime: " + dateTimeConvertString);
    }
}
