public class Solution {
    public double MyPow(double x, int n) {
        if(n == 0) {
            return 1;
        }
        if(n < 0) {
            x = 1/x;
            n = -n;
        }
        double result = 1.0;
        double currentProduct = x;
        while(n > 0) {
            if(n%2 == 1) {
                result *= currentProduct;
            }
            currentProduct *= currentProduct;
            n/=2;
        }
        return result;
    }
}
