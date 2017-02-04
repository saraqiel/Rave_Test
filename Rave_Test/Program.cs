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
                                     "go here: https://www.infragistics.com/community/blogs/dhananjay_kumar/archive/2016/07/21/step-by-step-working-with-github-repository-and-visual-studio-2015.aspx" +
                                     "CREATING A REPOSITORY\n" +
                                     "1. Create a blank repository in Github ensuring that no README document is generated\n" +
                                     "2. Copy the repository URL\n" +
                                     "3. Download and Install Git from http://git-scm.com/download/win \n" +
                                     "4. Create or Open a solution in Visual Studio \n" +
                                     "5. Right-Click the solution and select \"Add Solution to Source Control\" \n" +
                                     "6. Open Team Explorer by either pressing CTRL+M or navigating to \"View->Team Explorer\" \n" +
                                     "7. Click Sync \n" +
                                     "8. Enter the URL you copied into the \"Publish to Remote Repository\" \n" +
                                     "9. Enter your Github credentials \n" +
                                     "6. Verify your projects been published by navigating to GitHub and viewing your projects \n" +
                                     "FINITO!";
               Console.WriteLine("Hello World!");
               Console.WriteLine(instructions);
               Console.ReadLine();
          }
     }
}
