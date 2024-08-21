//https://www.hackerrank.com/challenges/simple-array-sum

class SimpleArraySum {

    static int simpleArraySum(int n, int[] ar) {
        // Complete this function
        int sum = 0;
        foreach(int i in ar)
        {
            sum = sum+ i;
        }
        return sum;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = simpleArraySum(n, ar);
        Console.WriteLine(result);
    }
}
