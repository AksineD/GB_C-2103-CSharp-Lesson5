// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   Program.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

var fileName = "startup.txt";

SaveToFile(DateTime.Now.ToLongTimeString(), fileName);

void SaveToFile(string text, string filename)
{
    var fullPath = Path.Combine(Environment.CurrentDirectory, filename);
    if (File.Exists(fullPath)) File.AppendAllText(fileName, text + Environment.NewLine);
    else File.WriteAllText(fileName, text + Environment.NewLine);
}