using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Class1
{


  public class Exercise1
  {

    public void run()
    {
    Directory.CreateDirectory("../../output");
    string[]  nomesarq = Directory.GetFiles("./output/arq");
      /* F
        Leia os nomes dos arquivos no diretório `ex1data`,
        e escreva um por linha no arquivo `output/ex1output.txt`.
      */

      var directory_filepath = "./ex1data";
      var output_filepath = "output/ex1output.txt";

      using (TextWriter writer = File.CreateText("test.txt"))
      {
      }

      using (TextReader reader = File.OpenText("test.txt")) {
        Console.WriteLine(nomesarq);
      }

      
    }
  }
}
