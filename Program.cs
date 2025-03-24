using System.Collections;

public class IPAddress:DictionaryBase{
    public void Add(string key, object value){
        base.InnerHashtable.Add(key, value);
    }
    public void Remove(string key){
        base.InnerHashtable.Remove(key);
    }
    public object Item(string key){
        return base.InnerHashtable[key];
    }
}
public class MyDictionary{
    public string[] keys;
    public string[] values;
    public static int count = 0;
    public void Add(string key, string value){
        if(count<keys.Length){
            keys[count] = key;
            values[count] = value;
            count++;
        }
    }
    public string Item(string key){
        int index = -1;
        for(int i=0; i<keys.Length; i++){
            if(keys[i] == key){
                index = i;
                break;
            }
        }
        if(index != -1)
            return values[index];
        else
            return null;
    }
    public void Remove(string key){
        
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        IPAddress ip = new IPAddress();
        ip.Add("Micheal", "192.168.0.1");
        ip.Add("John", "192.168.1.1");
        /* Console.WriteLine("Mike's IP: " 
                        + ip.Item("Micheal")); */
        IDictionaryEnumerator en = 
                        ip.GetEnumerator();
        while(en.MoveNext())
            Console.WriteLine(en.Key + " : " + en.Value);

        Dictionary<string, string> ip2 = 
                        new Dictionary<string, string>();
        ip2.Add("Micheal", "192.168.0.1");
        ip2.Add("John", "192.168.0.2");
        foreach(KeyValuePair<string, string> kvp in ip2)
            Console.WriteLine(kvp.Key + " : " + kvp.Value);

    }
}