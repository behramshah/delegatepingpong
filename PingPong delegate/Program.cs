using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PingPong_delegate
{
    class Program
    {
        delegate void PPP();
        static void Main(string[] args)
        {
            string gamestarter=null;
            Console.WriteLine("Which player start the game? Type 1 or 2");            
                gamestarter = Console.ReadLine();                                    
                PPP play = null;
                while (gamestarter!=null)
                {
                    if (gamestarter == "1")
                    {
                        play = HitPing;
                    }

                    else if (gamestarter == "2")
                    {
                        play = HitPong;
                    }

                    else { Console.WriteLine("Incorrect player number. Choose 1 or 2"); gamestarter = Console.ReadLine(); }//validation
                    play();
                    Console.WriteLine("Try again?");
                    gamestarter = Console.ReadLine();                
                                   
                }

            
          

            Console.ReadKey();
        }
        private static void HitPing()
        {
            Console.WriteLine("Ping");
            Console.WriteLine("Pong");

        }
        private static void HitPong()
        {
            Console.WriteLine("Pong");
            Console.WriteLine("Ping");
        }
    }
                
 }



