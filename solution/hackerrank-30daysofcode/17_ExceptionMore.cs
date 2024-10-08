//https://www.hackerrank.com/challenges/30-more-exceptions
namespace exception_more;
class Calculator{
    public int power(int n, int p)
    {
        if(n<0||p<0)
                throw new Exception("n and p should be non-negative");
        try{
            
            return Convert.ToInt32(Math.Pow(n, p));
        }
        catch(Exception e){
            
        }
        return 0;
    }
}

class ExceptionMore{
    static void Main(String[] args){
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try{
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
               Console.WriteLine(e.Message);

            }
        }
        
        
        
    }
}