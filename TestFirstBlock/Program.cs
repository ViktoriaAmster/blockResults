string[] userSFillingOfFirstArray()
{
    Console.Write("Enter some random words space separated. Press Enter in the end: ");
    string? userSText = Console.ReadLine();
    while (userSText is null)
    {
        Console.WriteLine("Empty string! Enter some new words: ");
        userSText = Console.ReadLine();
    }

    string[] firstArray = userSText.Split(' ');
    return firstArray;
}

Console.Clear();
string[] wordsFirstArray = userSFillingOfFirstArray();

int countWordsLessThreeSymbol = 0;
foreach (var word in wordsFirstArray)
{
    if (word.Length <= 3) countWordsLessThreeSymbol++;
}

string[] resultArray = new string[countWordsLessThreeSymbol];
int arrayCount = 0;

foreach (var word in wordsFirstArray)
{
    if (word.Length <= 3)
    {
        resultArray[arrayCount] = word;
        arrayCount++;
    }
}

foreach (var newWord in resultArray)
{
    Console.WriteLine(newWord);
}