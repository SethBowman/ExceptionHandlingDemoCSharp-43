
var numbers = new int[] { 1, 2, 3, 4 };

//try-catch block


try
{
    //try to do something
    numbers[10] = 30;

    Console.WriteLine(numbers[10]);
}
catch (IndexOutOfRangeException e)
{

    //if we are thrown an exception, we catch it
    Console.WriteLine($"That was not an index that exists. {e.Message}");
}
catch (Exception e)
{
    //umbrella catch, catches all errors we may have missed
    Console.WriteLine(e.Message);
}


Console.WriteLine("Continue on..");

try
{

    Console.WriteLine("Please give me a number:");

    var userInput = int.Parse(Console.ReadLine());

    Console.WriteLine($"I like the number {userInput} too!");
}
catch(FormatException e)
{
    Console.WriteLine($"Failed to parse.\n{e.Message}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    //optional
    //the finally happens no matter what
    Console.WriteLine("Hello");
}


Console.WriteLine("Continue on..");

var strNumbers = new string[] { "12", "2", "ten", "twelve", "88", "1000", "64", "twenty", "140" };
var realNumbers = new List<int>();

foreach (var number in strNumbers)
{
    try
    {
        var num = int.Parse(number);
        realNumbers.Add(num);
    }
    catch(FormatException e)
    {
        Console.WriteLine($"Could not parse {number}. {e.Message}");
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("Parsed numbers:");

foreach (var number in realNumbers)
{
    Console.WriteLine(number);
}
