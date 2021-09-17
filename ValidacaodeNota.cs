using System; 

class minhaClasse {

    static void Main(string[] args) { 
      double somaDasNotas = 0;
      int i = 0;
      
      do {
        double notaEntradaConsole = double.Parse(Console.ReadLine());

        if(notaEntradaConsole < 0 || notaEntradaConsole > 10) {
          Console.WriteLine("nota invalida");
        } else {
          i++;
          somaDasNotas += notaEntradaConsole; 
        }
      } while (i < 2);
    
    Console.WriteLine("media = " + (somaDasNotas / 2).ToString("N2"));

    

    }

}
