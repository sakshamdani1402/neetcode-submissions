public class Solution {
    private int sum(int n) {
        int num = 0;
        while(n != 0) {
            num += (n%10) * (n%10);
            n/=10;
        }
        return num;
    }
    public bool IsHappy(int n) {
        int slow = n, fast = sum(n);
        while(slow != fast) {
            fast = sum(sum(fast));
            slow = sum(slow);
        }
        return fast == 1;
    }
}
