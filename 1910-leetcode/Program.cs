// 1910. Remove All Occurrences of a Substring
//linq 
//no func cases
string s = "mountains, mountains, mountains, mountains";
Console.WriteLine(s);
s = s.Replace("mountains", "peaks"); // this replace all by one step
Console.WriteLine(s);                // but it's case-sensitive thing.
s = s.Replace("mountains", "peaks");
Console.WriteLine(s);
//func cases lol
string zxc = "zzxclordzxclordxc";
Console.WriteLine($"Removed Occurences of: ''zxc'' in string ''zxzxcclordzxclordxc'' => {RemoveOccurrences(zxc, "zxc")}");
//case sensitive piece of crap which passed only 78/80 cases
string RemoveOccurrences(string s, string part) {
    if (part.Length > s.Length) return s;
    while (AreThereOccurences(s, part))
    {
        s = s.Remove(s.IndexOf(part), part.Length);
        s = s.Replace(part, "");
        AreThereOccurences(s, part);
    }
    return s;
}

bool AreThereOccurences(string s, string part) => s.Contains(part);
