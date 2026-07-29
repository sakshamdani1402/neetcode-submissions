public struct Pair
{
    public string Value {get; set; }
    public int Timestamp {get; set; }

    public Pair(string val, int time) {
        Value = val;
        Timestamp = time;
    }
}

public class TimeMap {
    Dictionary<string, List<Pair>> dict;
    public TimeMap() {
        dict = new();
    }

    public string Find(List<Pair> list, int time) {
        int l = 0, r = list.Count - 1;
        int index = -1;
        while(l <= r) {
            int mid = l + (r - l)/2;
            if(list[mid].Timestamp == time) {
                return list[mid].Value;
            }else if(list[mid].Timestamp > time) {
                r = mid - 1;
            } else {
                index = mid;
                l = mid + 1;
            }
        }
        return index == -1 ? "": list[index].Value;
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!dict.ContainsKey(key)) {
            dict[key] = new();
        }
        dict[key].Add(new Pair(value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if(!dict.ContainsKey(key)) {
            return string.Empty;
        }
        return Find(dict.GetValueOrDefault(key), timestamp); 
    }
}
