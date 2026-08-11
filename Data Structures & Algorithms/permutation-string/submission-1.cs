public class Solution {
    private int GetIdx(char c) => c - 'a';

    private bool Check(int[] a1, int[] a2) {
        for(int i =0; i<26; i++) {
            if(a1[i] != a2[i]) return false;
        }
        return true;
    }

    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;

        int[] arr1 = new int[26];
        int[] arr2 = new int[26];
        Array.Fill(arr1, 0);
        Array.Fill(arr2, 0);

        for(int i = 0; i < s1.Length; i++) {
            int idx1 = GetIdx(s1[i]);
            arr1[idx1]++;
            int idx2 = GetIdx(s2[i]);
            arr2[idx2]++;
        }

        for(int i = s1.Length; i < s2.Length; i++) {
            if(Check(arr1, arr2)) return true;

            arr2[GetIdx(s2[i])] ++;
            arr2[GetIdx(s2[i - s1.Length])]--;
        }

        return Check(arr1, arr2);
    }
}
