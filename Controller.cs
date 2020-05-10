using System;

namespace Assignment5
{
    class Controller
    {
        public void run(){
            int answer = -1;

            do{

                Console.WriteLine(  "Welcome to my app\n" +
                                    "1.Finding the factorial of a number\n" +
                                    "2.Print a decimal number as binary, octal, and hexadecimal\n" +
                                    "3.Find the Greatest Common Divisor of two numbers\n" +
                                    "4.The Fibonacci series\n" +
                                    "5.Tower of Hanoi\n" + 
                                    "6.Quit\n"

                                    );
                int.TryParse(Console.ReadLine(), out answer);

                if(answer == 1){
                    getFactorialNum();
                } else if(answer == 2){
                    convertNum();
                } else if(answer == 3){
                    getGCDNum();
                } else if(answer == 4){
                    getFibNum();
                } else if(answer == 5){
                    getTowerNum();
                }

            }while(answer != 6);  
        }

        private void getFactorialNum()  
        {  
            int answer = -1;
            do{

                Console.WriteLine( "Please enter a number\n");
                                    
                int.TryParse(Console.ReadLine(), out answer);

            }while(answer >=0);  

            factorial(answer);
        }

        private long factorial(long n) 
        {
            if (n <= 1)
                return 1;
            else
                return n * factorial(n - 1);
        }

        private void convertNum(){
            int answer = -1;
            do{

                Console.WriteLine( "Please enter a number\n");
                                    
                int.TryParse(Console.ReadLine(), out answer);
                Console.WriteLine(answer);
            }while(answer == -1); 

            // binary
            string binary = "";
            int binAnswer = answer;

            while(binAnswer > 0){
                binary = Convert.ToString(binAnswer%2) + binary;
                binAnswer = binAnswer/2;
            }
            
            Console.WriteLine("Binary:" + binary);
            


            // Hex

             // For storing remainder
            int rem;
                
            // For storing result
            string str=""; 
        
            // Digits in hexadecimal number system
            char[] hex={'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
            int hexAnswer = answer;

            while(hexAnswer > 0)
            {
                rem = hexAnswer%16; 
                str = hex[rem]+str; 
                hexAnswer = hexAnswer/16;
            }

            Console.WriteLine("Hexadecimal: " + str);

            // Octal
            string octal = "";
            
            rem = answer; 
            
            while(rem != 0)
            {
                octal = Convert.ToString(rem%8) + octal;
                
                rem = rem/8;
                
                
            }

            Console.WriteLine("Octal: " + octal);
      
            
        }

        private void getFibNum()  
        {  
            int answer = -1;
            do{

                Console.WriteLine( "Please enter a number(greater than 0)\n");
                                    
                int.TryParse(Console.ReadLine(), out answer);

            }while(answer <=0);  

            
            Console.WriteLine("\nThe Fibonacci of {0} term  is {1} \n", answer, Fib(answer));
        }

        private int Fib(int n)  
        {  
            if (n <=2){
                return 1;
            }else{
                return Fib( n - 1 ) + Fib( n - 2 ); 
            }
            
        }    

        private void getGCDNum()  
        {  
            ulong answer1 = 0;
            do{

                Console.WriteLine( "Please enter a number(greater than 0)\n");
                                    
                ulong.TryParse(Console.ReadLine(), out answer1);

            }while(answer1 <=0);  

            ulong answer2 = 0;
            do{

                Console.WriteLine( "Please enter a number(greater than 0)\n");
                                    
                ulong.TryParse(Console.ReadLine(), out answer2);

            }while(answer2 <=0); 

            
            
            Console.WriteLine("\nThe Greatest Common Divisor is {0} \n", GCD(answer1,answer2));
        }

        public static ulong GCD(ulong n1, ulong n2)
        {
            if (n2 != 0)
                return GCD(n2, n1 % n2);
            else
                return n1;
        }

        static void towerOfHanoi(int n, string from_rod, string to_rod, string aux_rod) 
    { 
        if (n == 1) 
        { 
            Console.WriteLine("Move disk 1 from rod " +  from_rod + " to rod " + to_rod); 
            return; 
        } 
        towerOfHanoi(n-1, from_rod, aux_rod, to_rod); 

        Console.WriteLine("Move disk " + n + " from rod " +  from_rod + " to rod " + to_rod); 

        towerOfHanoi(n-1, aux_rod, to_rod, from_rod); 
    } 
      
    
    public static void getTowerNum() 
    { 
        int answer = -1;
            do{

                Console.WriteLine( "Please enter a number(greater than 0)\n");
                                    
                int.TryParse(Console.ReadLine(), out answer);

            }while(answer <=0); 
        towerOfHanoi(answer, "A", "C", "B");  
    } 
    }
}
