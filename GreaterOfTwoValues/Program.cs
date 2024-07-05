class GreaterOfTwoValues
{
    static void Main()
    {
        
        string type = Console.ReadLine();

        
        string value1 = Console.ReadLine();

        
        string value2 = Console.ReadLine();

        switch (type)
        {
            case "int":
                int int1 = int.Parse(value1);
                int int2 = int.Parse(value2);
                Console.WriteLine($"{GetMax(int1, int2)}");
                break;
            case "char":
                char char1 = char.Parse(value1);
                char char2 = char.Parse(value2);
                Console.WriteLine($"{GetMax(char1, char2)}");
                break;
            case "string":
                Console.WriteLine($"{GetMax(value1, value2)}");
                break;
            
        }
    }

    static T GetMax<T>(T value1, T value2) where T : IComparable<T>
    {
        return value1.CompareTo(value2) > 0 ? value1 : value2;
    }
}