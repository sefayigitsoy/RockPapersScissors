using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. görev kullanıcıya seçmek istediği tercihi sorunuz ([r]ock-[p]aper-[s]cissors)
            //2.görev seçimi kontrol ediniz.
            //3.random oluşturunuz.
            //random=0=> bilgisayar seçeneği=taş
            //random=1=> bilgisayar seçeneği=kağıt
            //random=2=> bilgisayar seçeneği=makas.
            //4.görev kazananı yazdırınız.
            //5.görev tekrar oynamak istiyor musunuz diye sorunuz.
            //6.görev skor tutunuz.
            //7.görev oyun sürdükçe skoru güncelleyiniz.

            int playerScore = 0;
            int computerScore = 0;
            string exitKey = "";
            while (exitKey != "e")
            {
                Console.Clear();
                Console.WriteLine("Rock-Paper-Scissors");

                Console.WriteLine("Choose [r]ock,[p]aper,[s]cissors or [e]xit");
                string playerMove = "";
            GetInput:
                switch (Console.ReadLine().ToLower())
                {
                    case "r":
                        playerMove = "rock";
                        break;
                    case "p":
                        playerMove = "paper";
                        break;
                    case "s":
                        playerMove = "scissors";
                        break;
                    case "e":
                        exitKey = "e";
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input...Please try again.");
                        goto GetInput;
                        break;
                }
                Console.WriteLine($"Your choose {playerMove}");
                Random rnd = new Random();
                int random = rnd.Next(3);
                string computerMove = "";
                switch (random)
                {
                    case 0:
                        computerMove = "rock";
                        break;
                    case 1:
                        computerMove = "paper";
                        break;
                    case 2:
                        computerMove = "scissors";
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Computer's move {computerMove}");
                if ((playerMove=="rock"&&computerMove=="paper")||(playerMove=="paper"&&computerMove=="scissors")||(playerMove=="scissors"&&computerMove=="rock"))
                {
                    computerScore++;
                    Console.WriteLine("You lost. Computer won.");
                }
                else if ((playerMove=="rock"&&computerMove=="scissors")||(playerMove=="scissors"&&computerMove=="paper")||(playerMove=="paper"&&computerMove=="rock"))
                {
                    playerScore++;
                    Console.WriteLine("You won. Computer lost");
                }
                else
                {
                    Console.WriteLine("Game is tie.");
                }
                Console.WriteLine($"Your score {playerScore} and computer's score {computerScore}");
                Console.WriteLine("press enter to continue.");
                Console.WriteLine("asdasdasdsadsadsadsadasd");
                Console.WriteLine("asdasdasdsadsadsadsadasd");

                Console.ReadKey();
            }

        }
    }
}
