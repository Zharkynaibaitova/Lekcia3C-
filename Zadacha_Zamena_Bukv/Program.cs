// Дан текст. В тексте нужно ысе пробелы заменить черточками, маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- В тексте нужно ысе пробелы заменить - черточками"
            + "маленькие буквы к заменить большими К"
            + "а большие С заменить маленькими с"
            + "вот и все как бы";

// srting s = "qwerty"
//             012345

// s [3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);