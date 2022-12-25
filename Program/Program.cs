
int arrayCapacity = 10;
string[] originalArray = new string[arrayCapacity];
string[] matchedArray = new string[originalArray.Length];
int matches = 0;
int lessOrEquial = 3;
string userInput = string.Empty;

for (int i = 0; i < originalArray.Length; i++)
{
    userInput = string.Empty;
    while (userInput == string.Empty)
    {
        System.Console.WriteLine($"Input string number {i}:");
        userInput = Console.ReadLine()!;
    }

    originalArray[i] = userInput;

    if (originalArray[i].Length <= lessOrEquial)
    {
        matchedArray[matches] = originalArray[i];
        matches++;
    }
}

Array.Resize(ref matchedArray, matches);

for (int i = 0; i < matchedArray.Length; i++)
{
    System.Console.WriteLine($"Matched element {i} is {matchedArray[i]}");
}