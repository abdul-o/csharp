
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
            
                   /* welcome message and instruction */

            Console.WriteLine( "Welcome to Orbit guessing game ");
            Console.WriteLine("Please choose your prefer level to play");
            Console.WriteLine( "Enter E for Easy,  ");
            Console.WriteLine( "Enter M for Meduim,  ");
            Console.WriteLine( "Enter H for Hard,  ");
            levelChoose = Console.ReadLine();

               /* Code for Easy level selection */

               if (levelChoose == "E") {
                  for (int i = 0; i < 6; i++)
                    {

                     if (i == 0)
                     {
                            Console.WriteLine(" Game started! At this level you are to guess a number between 1 - 10 ");
                            Console.Write( " Enter your guess number ");
                            first = int.Parse(Console.ReadLine()); 
                         if    (first == 5){
                              Console.Write("You got it right!");
                          }
                          else{ 

                           Console.WriteLine("That was wrong ");
                           Console.WriteLine("You have five attempts left ");
                        }  
                     }
                     else if (i == 1 && first != 5 )
                     {
                         Console.Write(" Enter your guess number ");
                            second = int.Parse(Console.ReadLine()); 
                         if    (second == 2){
                              Console.Write("You got it right! ");
                          }
                          else{ 

                           Console.WriteLine("That was wrong");
                           Console.WriteLine("You have four attempst left ");
                        }  
                     }
                     else if (i== 2 && second != 2 && first != 5 )
                     {
                         Console.Write(" Enter your guess number ");
                            third = int.Parse(Console.ReadLine()); 
                         if    (third == 8){
                              Console.Write("You got it right! ");
                          }
                          else{ 

                           Console.WriteLine("That was wrong ");
                           Console.WriteLine("You have three attempts left ");
                        }  
                     }
                     else if (i== 3 && third != 8 && first != 5 && second != 2)
                     {
                         Console.Write(" Enter your guess number ");
                            fourth = int.Parse(Console.ReadLine()); 
                         if    (fourth == 1){
                              Console.Write("You got it right!s");
                          }
                          else{ 

                           Console.WriteLine("That was wrong ");
                           Console.WriteLine("You have two attempts left ");
                        }  
                     }
                     else if (i== 4 && fourth != 1 && third != 8 && first != 5 && second != 2)
                     {
                         Console.Write(" Enter your guess number ");
                            fifth = int.Parse(Console.ReadLine()); 
                         if    (fifth == 5){
                              Console.Write("You got it right! ");
                          }
                          else{ 

                           Console.WriteLine("That was wrong ");
                           Console.WriteLine("You have one attempt left ");
                        }  
                     }
                     else if (i== 5 && fifth != 5  && fourth != 1 && third != 8 && first != 5 && second != 2)
                     {
                         Console.Write(" Enter your guess number ");
                            sixth = int.Parse(Console.ReadLine()); 
                         if    (sixth == 9){
                              Console.Write("You got it right!");
                          }
                          else{ 

                           Console.WriteLine("That was wrong ");
                           Console.WriteLine("You have exsust your life  GAME OVER!! ");
                        }  
                     }
                     
                     
                  }
                    
               }


               /* code for medium level selection*/

               else if ( levelChoose == "M")
               {
                   for (int i = 0; i < 4; i++)
                   {
                      if (i == 0)
                     {
                            Console.WriteLine(" Game started! At this level you are to guess a number between 1 - 20 ");
                            Console.Write( " Enter your guess number ");
                            first = int.Parse(Console.ReadLine()); 
                         if    (first == 12){
                              Console.Write("You got it right!");
                          }
                          else{ 

                           Console.WriteLine("That was wrong ");
                           Console.WriteLine("You have three attempts left ");
                        }
                     }   
                        else if (i == 1 && first != 12 )
                     {
                         Console.Write(" Enter your guess number ");
                            second = int.Parse(Console.ReadLine()); 
                         if    (second == 6){
                              Console.Write("You got it right! ");
                          }
                          else{ 

                           Console.WriteLine("That was wrong");
                           Console.WriteLine("You have two attempts left ");
                        }  
                     } 

                     else if (i== 2 && second != 6 && first != 12 )
                     {
                         Console.Write(" Enter your guess number ");
                            third = int.Parse(Console.ReadLine()); 
                         if    (third == 16){
                              Console.Write("You got it right");
                          }
                          else{ 

                           Console.WriteLine("That was wrong ");
                           Console.WriteLine("You have one attempt left ");
                        }  
                     }
                     else if (i == 3 && first != 12 && second != 6 && third != 16 )
                     {
                         Console.Write(" Enter your guess number ");
                            second = int.Parse(Console.ReadLine()); 
                         if    (second == 20){
                              Console.Write("You got it right! ");
                          }
                          else{ 

                           Console.WriteLine("That was wrong");
                           Console.WriteLine("You have exsust your life  GAME OVER!! ");
                        }  
                     } 
                       
                   } 
               }


                   /* code for hard level selection*/

               else if ( levelChoose == "H")
               {
                   for (int i = 0; i < 3; i++)
                   {
                      if (i == 0)
                     {
                            Console.WriteLine(" Game started! At this level you are to guess a number between 1 - 50 ");
                            Console.Write( " Enter your guess number ");
                            first = int.Parse(Console.ReadLine()); 
                         if    (first == 23){
                              Console.Write("You got it right");
                          }
                          else{ 

                           Console.WriteLine("That was wrong ");
                           Console.WriteLine("You have two attempts left ");
                        }
                     }   
                        else if (i == 1 && first != 23 )
                     {
                         Console.Write(" Enter your guess number ");
                            second = int.Parse(Console.ReadLine()); 
                         if    (second == 17){
                              Console.Write("You got it right! ");
                          }
                          else{ 

                           Console.WriteLine("That was wrong");
                           Console.WriteLine("You have one attempts left ");
                        }  
                     } 
                     else if (i == 2 && first != 23 && second != 17 )
                     {
                         Console.Write(" Enter your guess number ");
                            second = int.Parse(Console.ReadLine()); 
                         if    (second == 46){
                              Console.Write("You got it right! ");
                          }
                          else{ 

                           Console.WriteLine("That was wrong");
                           Console.Write("You have exsust your life  GAME OVER!! ");
                        }  
                     }
                   }   
               } 
               
                   
               

     












                    

                    
               
               




             






            






        }
    }
}
