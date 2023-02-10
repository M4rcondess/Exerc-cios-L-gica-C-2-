using System;

class Program {
  
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

  string nome, entrada;
  Double n1, n2, n3, media;
  //escreval ("texto")
  Console.WriteLine ("Digite o nome do aluno");

  //leia (variavel)
    nome = Console.ReadLine ();

  //solicite que o usuario digite a n1
    Console.WriteLine ("Digite a primeira nota");

  //receber a n1 na variavel de texto 
  entrada = Console.ReadLine();

  //converter a entrada em um double
  n1 = Double.Parse(entrada);

  //repete para n2
    Console.WriteLine("Digite a segunda nota");
    entrada = Console.ReadLine();
    n2 = Double.Parse(entrada);

    Console.WriteLine("Digite a terceira nota");
    entrada = Console.ReadLine();
    n3 = Double.Parse(entrada);

    
    //calculo media
    media = (n1 + n2 + n3 *5)/10;
    Console.WriteLine ("A média do(a) aluno(a) " + nome + " é " +media);
    
    
    
    
  
  }
}