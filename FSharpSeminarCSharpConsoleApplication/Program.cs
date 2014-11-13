using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FS = FSharpSeminarLibrary;

namespace FSharpSeminarCSharpConsoleApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      var numbers = FS.Utils.GetNumbers(1, 20);
      var squares = FS.Utils.SumSquares(numbers);
      
      Console.ReadLine();
    }
  }
}
