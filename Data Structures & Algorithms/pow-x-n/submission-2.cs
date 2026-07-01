public class Solution {
    public double MyPow(double x, int n) {
        if(n == 0) {
            return 1.0;
        }
        if(n < 0) {
            x = 1/x;
            n = -n;
        }
        double product = x, res = 1.0;
        while(n > 0) {
            if(n % 2 != 0) {
                res *= product;
            }
            product *= product;
            n/=2;
        }
        return res;
    }
}
