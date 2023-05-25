int amountoflines = 0;
int amountoffiles = 0;
string tempstring = String.Empty;
string path = args[0];
string fileending = args[1];
string searchtext = args[2];


string[] dateien = Directory.GetFiles(path, fileending);

foreach (string datei in dateien)
{
    int linecount = 0;
    string[] lines = File.ReadAllLines(datei);

    //linecount++;

    if (Contains(lines, searchtext))
    {
        amountoffiles++;
        Console.WriteLine(datei);
    }

    for (int i = 0; i < lines.Length; i++)
    {
        linecount++;
        if (lines[i].Contains(searchtext))
        {
            amountoflines++;
            Console.WriteLine($"   {linecount}: {lines[i]}");
        }

    }

}



Console.WriteLine($"SUMMARY: \n     Number of found files: {amountoffiles}\n     Number of found lines: {amountoflines}\n     Number of occurences: N/A");

bool Contains(string[] lines, string searchtext)
{
    for (int i = 0; i < lines.Length; i++)
    {
        if (lines[i].Contains(searchtext)) { return true; }
    }

    return false;
}


int ProcessFile(string suchbegriff, string text, string tempstring)
{
foreach (var character in text)
{
    for (int i = 0; i < .Length; i++)
    {
        tempstring = 
    }
}
return 0;
}