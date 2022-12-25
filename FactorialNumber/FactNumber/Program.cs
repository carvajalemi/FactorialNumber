using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Por favor ingrese el numero:");
    string numeroComoString = Console.ReadLine(); 
    // string a int
    int numero = Int32.Parse(numeroComoString);
    // variable para ir incrementando el contador
    int i=1;
    // valor inicial del factorial
    int factorial =1;
    // mientras el contador sea menor al numero hacer
    while (i<numero)
    {
      i=i+1;
      factorial= factorial*i;
          
    }       
    Console.WriteLine ("EL factorial es:" +factorial);
  }      
}