using System.IO;

string writeText = "This is a File";
File.WriteAllText("csharpfile.txt", writeText);

string readText = File.ReadAllText("csharpfile.txt");
Console.WriteLine(readText);
