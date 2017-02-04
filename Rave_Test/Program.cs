using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rave_Test
{
     class Program
     {
          static void Main(string[] args)
          {
               string instructions = @"For full tutorial on getting a Visual Studio solution/project setup with GitHub" +
                                     @" go here: https://www.infragistics.com/community/blogs/dhananjay_kumar/archive/2016/07/21/step-by-step-working-with-github-repository-and-visual-studio-2015.aspx" +
                                     "\n" +
                                     "1. Create a blank repository in Github ensuring that no README document is generated\n" +
                                     "2. Copy the repository URL\n" +
                                     @"3. Download and Install Git from http://git-scm.com/download/win \n";
               Console.WriteLine("Hello World");
               Console.WriteLine(instructions);
               Console.ReadLine();
          }
     }
}
