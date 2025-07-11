namespace Lab1.Files.StringAndCollections;

public class DictionaryGeneric
{
    public Dictionary<string, string?> _userDictionary = [];

    public bool AddToMap(string key, string? val)
    {
        if (_userDictionary.ContainsKey(key))
        {
            Console.WriteLine($"Key '{key}' already exists.");
            return false;
        }
        _userDictionary.Add(key,val);
        return true;
    }

    public void Display(string key)
    {
        Console.WriteLine(_userDictionary.TryGetValue(key, out var value)//using out reference
            ? $"Id: {key}, Name: {value}"
            : $"Key '{key}' not found.");
    }
    public void DisplayEntireList()
    {
        foreach (var key in _userDictionary)
        {
            Display(key.Key);
        }
    }
}
//Program.cs
// var generic = new DictionaryGeneric();
// generic.AddToMap("John", "Doe");
// generic.AddToMap("Jane", "Smith");
// generic.AddToMap("Josh", "Henry");
// generic.AddToMap("mail", "goat");
//
// generic.Display("mail");
// generic.DisplayEntireList();