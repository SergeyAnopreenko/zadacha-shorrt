using System.Globalization;
using System.Numerics;

string text = "bcvfgdh345aaaaaaafr;";
Dictionary<char, int> map = new();
foreach (char c in text)
{
    if (map.ContainsKey(c))
        map[c]++;
    else
        map[c] = 1;
}

foreach (var pair in map)
{
    if (Char.IsAsciiLetter(pair.Key))
        Console.WriteLine($"{pair.Key} : {pair.Value}");
}

