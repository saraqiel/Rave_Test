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
               string create_instructions = "For full tutorial on getting a Visual Studio solution/project setup with GitHub \n" +
                                     "go here: https://www.infragistics.com/community/blogs/dhananjay_kumar/archive/2016/07/21/step-by-step-working-with-github-repository-and-visual-studio-2015.aspx \n\n" +
                                     "CREATING A REPOSITORY \n" +
                                     "1. Create a blank repository in Github ensuring that no README document is generated \n" +
                                     "2. Copy the repository URL \n" +
                                     "3. Download and Install Git from http://git-scm.com/download/win \n" +
                                     "4. Create or Open a solution in Visual Studio \n" +
                                     "5. Right-Click the solution and select \"Add Solution to Source Control\" \n" +
                                     "6. Open Team Explorer by either pressing CTRL+M or navigating to \"View->Team Explorer\" \n" +
                                     "7. Click Sync \n" +
                                     "8. Enter the URL you copied into the \"Publish to Remote Repository\" \n" +
                                     "9. Enter your Github credentials \n" +
                                     "6. Verify your projects been published by navigating to GitHub and viewing your projects \n" +
                                     "FINITO!";
               string committing_instructions = "COMMITTING CHANGES \n" + 
                                                "1. After changing the code, right click on the solution and select \"Commit...\" \n" +
                                                "2. Enter a comment describing the changes made \n" + 
                                                "3. A notice will be generated with a commit identifier, click Sync to push changes to the repo \n" +
                                                "4. You should get a notification letting you know if the push was successful or not \n"
                                                ;

               Console.WriteLine("Hello World!");
               Console.WriteLine(create_instructions);
               Console.WriteLine(committing_instructions);
               Console.ReadLine();
          }
     }
}
