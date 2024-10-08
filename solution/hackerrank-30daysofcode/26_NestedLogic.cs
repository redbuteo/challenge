//https://www.hackerrank.com/challenges/30-nested-logic
class NestedLogic {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
                var actually = Console.ReadLine().Split(' ');
        var day_a = int.Parse(actually[0]);
        var month_a = int.Parse(actually[1]);
        var year_a = int.Parse(actually[2]);

        var expected = Console.ReadLine().Split(' ');
        var day_e = int.Parse(expected[0]);
        var month_e = int.Parse(expected[1]);
        var year_e = int.Parse(expected[2]);

        var fine = 0;

        if (year_a > year_e) {
            fine = 10000;
        }
        else if (year_a == year_e) {
            if (month_a > month_e) {
                fine = (month_a - month_e) * 500;
            }
            else if (month_a == month_e && day_a > day_e) {
                fine = (day_a - day_e) * 15;
            }
        }

        Console.WriteLine(fine);
    }
}
