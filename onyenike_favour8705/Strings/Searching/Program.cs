﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for searching string content

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
Console.WriteLine($"{teststr.Contains("fox")}");
Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");

// TODO: StartsWith and EndsWith determine if a string starts 
// or ends with a given test string
Console.WriteLine($"{teststr.StartsWith("the")}");
Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{teststr.StartsWith("dog")}");
Console.WriteLine($"{teststr.StartsWith("dog", StringComparison.CurrentCultureIgnoreCase)}");




// TODO: IndexOf, LastIndexOf finds the index of a substring
Console.WriteLine($"{teststr.IndexOf("the")}");
Console.WriteLine($"{teststr.IndexOf("the", StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{teststr.LastIndexOf("the")}");


// TODO: Determining empty, null, or whitespace
string str1 = null;
string str2 = "   ";
string str3 = String.Empty;

Console.WriteLine($"{string.IsNullOrEmpty(str1)}");
Console.WriteLine($"{string.IsNullOrWhiteSpace(str2)}");
Console.WriteLine($"{string.IsNullOrEmpty(str3)}");
