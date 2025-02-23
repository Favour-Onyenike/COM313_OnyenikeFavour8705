﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for parsing dates from strings

// Collection of various date string formats to attempt parsing
string[] sampleDateTimes = {
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15",
};

foreach (string datestr in sampleDateTimes) {
    DateTime result;
    if(DateTimes.TryParse(datestr, out result)){
        console.WriteLine($"{datestr, -25} get parse as: {result}");
    }
    else{
        console.WriteLine($"could not parse '{datestr}'");
    }
}

   
    
