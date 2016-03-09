using System;

/// <summary>
/// Description of form/class/etc.
/// </summary>
public class catalog
{
    item[] itemDatabase;
    string[] stringItemPaths;
    
    //Contains an array all items.
    public catalog()
    {
        stringItemPaths = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + (char)92 + "data" + (char)92 + "items" + (char)92 + "store", "*.ini", System.IO.SearchOption.AllDirectories);
        itemDatabase = new item[stringItemPaths.GetUpperBound(0) + 1];

        //Load all individual's
        for (int i = 0; stringItemPaths.GetUpperBound(0) > i; i++) {
            string[] s = stringItemPaths[i].Split((char)92);
            string f = s[s.Length];
            s[s.Length] = "";
            string p = "";
            foreach (string line in s) {
                p += line;
            }
            itemDatabase[i] = new item(p, f);
        }
    }
}