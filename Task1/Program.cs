// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   Program.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

var fileName = "TestTextFile.txt";

var userText = GetUserInput();

SaveToFile(userText, fileName);

string GetUserInput()
{
    Console.WriteLine("Enter a custom string");
    var result = Console.ReadLine();

    return result;
}

void SaveToFile(string text, string filename)
{
    var fullPath = Path.Combine(Environment.CurrentDirectory, filename);

    if (File.Exists(fullPath)) File.AppendAllText(fileName, text + Environment.NewLine);
    else File.WriteAllText(fileName, text + Environment.NewLine);
}