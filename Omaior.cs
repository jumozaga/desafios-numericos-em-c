using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
              int a = Convert.ToInt32(vet[0]);
              int b = Convert.ToInt32(vet[1]);
              int c = Convert.ToInt32(vet[2]);
              int maior = 0;
              
              if (b >= a && b >= c) {
                maior = b;
                
              } else if(c >= a && c >= b) {
                maior = c;
                
              } else {     
                maior = a;
                }
            
              
            Console.WriteLine($"{maior} eh o maior");
                        
        }
    }