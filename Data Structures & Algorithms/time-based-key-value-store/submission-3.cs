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
        if(!map.ContainsKey(key)) {
            return string.Empty;
        }
        var stamps = map[key];
        int l = 0 , r = stamps.Count - 1;
        string res = string.Empty;
        while(l <= r) {
            int mid = l + (r - l)/2;
            if(stamps[mid].Timestamp == timestamp) {
                return stamps[mid].Value;
            }
            else if(stamps[mid].Timestamp > timestamp) {
                r = mid - 1;
            } else {
                res = stamps[mid].Value;
                l = mid + 1;
            }
        }
        return res;
    }
}
