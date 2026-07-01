
public class KVP
{
    public string Value {get; set;}
    public int Timestamp {get; set;}
    public KVP(string value, int time)
    {
        Value = value;
        Timestamp = time;
    }
}
public class TimeMap {
    private Dictionary<string, List<KVP>> map;
    public TimeMap() {
        map = new Dictionary<string, List<KVP>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(map.ContainsKey(key))
        {
            map[key].Add(new KVP(value, timestamp));
        }
        else
        {
            map.Add(key, new List<KVP>(){new KVP(value, timestamp)});
        }
    }
    
    public string Get(string key, int timestamp) {
        if(!map.ContainsKey(key))
        {
            return string.Empty;
        }
        var stores = map[key];
        int l = 0, r = stores.Count - 1;
        string res = "";
        while(l <= r) {
            int mid = l + (r - l)/2;
            var kvp = stores[mid];
           if(kvp.Timestamp <= timestamp)
           {
                res = kvp.Value;
                l = mid + 1;
           }
           else
           {
                r = mid - 1;
           }
        }
        return res;
    }
}
// 1