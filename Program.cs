
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
         string first = "";
         string second = "";
         string third = "";
         string fourth = "";
         string fifth = "";
         string sixth = "";
            

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
                            first = (Console.ReadLine()); 
                         if    (first == "5"){
                              Console.Write("Good one!!! You guess right");
                          }
                          else{ 

                           Console.WriteLine("AUSH!!!!   you guess wrong");
                           Console.WriteLine("You have five attempt left");
                        }  
                     }
                     else if (i == 1 && first =! 5 )
                     {
                         Console.Write(" Enter your guess number ");
                            second = (Console.ReadLine()); 
                         if    (second == "2"){
                              Console.Write("Good one!!! You guess right ");
                          }
                          else{ 

                           Console.WriteLine("you guess wrong");
                           Console.WriteLine("You have four attempt left");
                        }  
                     }
                     else if (i== 2 && second =! 2 )
                     {
                         Console.Write(" Enter your guess number ");
                            third = (Console.ReadLine()); 
                         if    (third == "8"){
                              Console.Write("Awe Some !!! You guess right  you are a super human you have finish the levels");
                          }
                          else{ 

                           Console.WriteLine("you guess wrong");
                           Console.WriteLine("You have three attempt left ");
                        }  
                     }
                     else if (i== 3 && third ==! 8)
                     {
                         Console.Write(" Enter your guess number ");
                            fourth = (Console.ReadLine()); 
                         if    (fourth == "1"){
                              Console.Write("Awe Some !!! You guess right  you are a super human you have finish the levels");
                          }
                          else{ 

                           Console.WriteLine("you guess wrong");
                           Console.WriteLine("You have two attemp left ");
                        }  
                     }
                     else if (i== 4 && fourth =! 1 )
                     {
                         Console.Write(" Enter your guess number ");
                            fifth = (Console.ReadLine()); 
                         if    (fifth == "5"){
                              Console.Write("Awe Some !!! You guess right ");
                          }
                          else{ 

                           Console.WriteLine("you guess wrong");
                           Console.WriteLine("You have one attempt left");
                        }  
                     }
                     else if (i== 5 && fifth =! 5 )
                     {
                         Console.Write(" Enter your guess number ");
                            sixth = (Console.ReadLine()); 
                         if    (sixth == "9"){
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
