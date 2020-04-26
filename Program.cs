
using System.Linq;
using System.Collections.Concurrent;
using System.Reflection.Emit;
using System.Data;

using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            string levelChoose = "";
         int first = 0;
         int second = 0;
         int third = 0;
         int fourth = 0;
         int fifth = 0;
         int sixth = 0;
            

            Console.WriteLine( "Welcome to Orbit guessing game ");
            Console.WriteLine("Please choose your prefer level to play");
            Console.WriteLine( "Enter E for Easy,  ");
            Console.WriteLine( "Enter M for Meduim,  ");
            Console.WriteLine( "Enter H for Hard,  ");
            levelChoose = Console.ReadLine();

               if (levelChoose == "E") {
                  for (int i = 0; i < 6; i++)
                    {

                     if (i == 0)
                     {
                            Console.Write(" Game started! Enter your guess number ");
                            first = int.Parse(Console.ReadLine()); 
                         if    (first == 5){
                              Console.Write("Good one!!! You guess right");
                          }
                          else{ 

                           Console.WriteLine("AUSH!!!!   you guess wrong");
                           Console.WriteLine("You have five attempt left");
                        }  
                     }
                     else if (i == 1 && first != 5 )
                     {
                         Console.Write(" Enter your guess number ");
                            second = int.Parse(Console.ReadLine()); 
                         if    (second == 2){
                              Console.Write("Good one!!! You guess right ");
                          }
                          else{ 

                           Console.WriteLine("you guess wrong");
                           Console.WriteLine("You have four attempt left");
                        }  
                     }
                     else if (i== 2 && second != 2 && first != 5 )
                     {
                         Console.Write(" Enter your guess number ");
                            third = int.Parse(Console.ReadLine()); 
                         if    (third == 8){
                              Console.Write("Awe Some !!! You guess right  you are a super human you have finish the levels");
                          }
                          else{ 

                           Console.WriteLine("you guess wrong");
                           Console.WriteLine("You have three attempt left ");
                        }  
                     }
                     else if (i== 3 && third != 8 && first != 5 && second != 2)
                     {
                         Console.Write(" Enter your guess number ");
                            fourth = int.Parse(Console.ReadLine()); 
                         if    (fourth == 1){
                              Console.Write("Awe Some !!! You guess right  you are a super human you have finish the levels");
                          }
                          else{ 

                           Console.WriteLine("you guess wrong");
                           Console.WriteLine("You have two attempt left ");
                        }  
                     }
                     else if (i== 4 && fourth != 1 && third != 8 && first != 5 && second != 2)
                     {
                         Console.Write(" Enter your guess number ");
                            fifth = int.Parse(Console.ReadLine()); 
                         if    (fifth == 5){
                              Console.Write("Awe Some !!! You guess right ");
                          }
                          else{ 

                           Console.WriteLine("you guess wrong");
                           Console.WriteLine("You have one attempt left");
                        }  
                     }
                     else if (i== 5 && fifth != 5  && fourth != 1 && third != 8 && first != 5 && second != 2)
                     {
                         Console.Write(" Enter your guess number ");
                            sixth = int.Parse(Console.ReadLine()); 
                         if    (sixth == 9){
                              Console.Write("Awe Some !!! You guess right  you are a super human you have finish the levels");
                          }
                          else{ 

                           Console.WriteLine("you guess wrong");
                           Console.WriteLine("You have exsust your life  GAME OVER!!");
                        }  
                     }
                     
                     
                  }
                    
               };

     












                    

                    
               
               




             






            






        }
    }
}
