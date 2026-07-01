struct Car {
    int pos;
    double time;
};

class Solution {
public:
    int carFleet(int target, vector<int>& position, vector<int>& speed) {
        vector<Car> ds;
        int ans=0;
        for(int i=0;i<speed.size();i++) {
            ds.push_back({position[i], (double)(target - position[i])/speed[i] });
        }
        sort(ds.begin(), ds.end(), [](Car &a, Car &b) {
            return a.pos > b.pos;
        });

        double maxTime = 0;
  
        for(Car &car : ds) {
            if(car.time > maxTime)  {
                maxTime = car.time;
                ans++;
            }
        }
        return ans;
    }
};

// 4 1 0 7
// 2 2 1 1