// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   Program.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

var fileName = "bin1.dat";

Console.WriteLine("Enter an arbitrary set of numbers (0...255). Separate each number with space.");
var data = Console.ReadLine();

var tokens = data.Split(' ');

var dataToSave = Array.ConvertAll(tokens, byte.Parse);

using (var binWriter = new BinaryWriter(File.Open(fileName, FileMode.Create)))
{
    foreach (var item in dataToSave) binWriter.Write(item);
}