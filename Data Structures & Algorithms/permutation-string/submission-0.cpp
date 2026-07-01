class Solution {
    // private isAnagram(unordered_map<char, int>& hash) {

    // }
    // void moveI(int& i, int& j, string& s2) {
    //     while(i<j) {
    //         chars2[s2[i]-'a']--;
    //         i++;
    //     }
    // } 
public:
    bool checkInclusion(string s1, string s2) {
        vector<int> count(26, 0);
    int len1 = s1.length(), len2 = s2.length();
    
    if (len1 > len2) return false;

    for (int i = 0; i < len1; ++i) {
        count[s1[i] - 'a']++;
        count[s2[i] - 'a']--;
    }

    int matches = 0;
    for (int i = 0; i < 26; ++i) {
        if (count[i] == 0) matches++;
    }

    for (int i = len1; i < len2; ++i) {
        if (matches == 26) return true;

        int right = s2[i] - 'a';
        int left = s2[i - len1] - 'a';

        count[right]--;
        if (count[right] == 0) {
            matches++;
        } else if (count[right] == -1) {
            matches--;
        }

        count[left]++;
        if (count[left] == 0) {
            matches++;
        } else if (count[left] == 1) {
            matches--;
        }
    }

    return matches == 26;
    }
};
