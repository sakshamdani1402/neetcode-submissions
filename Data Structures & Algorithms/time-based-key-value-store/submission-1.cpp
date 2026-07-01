struct Val {
    string value;
    int time;
};

class TimeMap {
    unordered_map<string, vector<Val>> hash;

    string getVal(vector<Val>& list, int& timestamp) {
        int n = list.size();
        int l = 0, r = n - 1;
        while(l <= r) {
            int mid = l + (r - l)/2;
            Val res = list[mid];
            if(res.time == timestamp) {
                return res.value;
            }

            if(res.time < timestamp) {
                l = mid + 1;
            }
            else r = mid - 1;
        }
        return "";
    }

public:
    TimeMap() {
        
    }
    
    void set(string key, string value, int timestamp) {
        hash[key].push_back({value, timestamp});
    }
    
    string get(string key, int timestamp) {
        if(hash.find(key) == hash.end()) return "";

        string res = getVal(hash[key], timestamp);
        if(res == "") {
            for(int i = hash[key].size() - 1; i >=0;i--) {
                if(hash[key][i].time <= timestamp) return hash[key][i].value;
            }
        }

        return res;
    }
};
