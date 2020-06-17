using System;

namespace Casino
{
    class Program
    {
        static void LevelUp() //Level Up Banner
        {
            string ASCII_Title = @"
 ▄▀▀▀▀▄     ▄▀▀█▄▄▄▄  ▄▀▀▄ ▄▀▀▄  ▄▀▀█▄▄▄▄  ▄▀▀▀▀▄          ▄▀▀▄ ▄▀▀▄  ▄▀▀▄▀▀▀▄ 
█    █     ▐  ▄▀   ▐ █   █    █ ▐  ▄▀   ▐ █    █          █   █    █ █   █   █ 
▐    █       █▄▄▄▄▄  ▐  █    █    █▄▄▄▄▄  ▐    █          ▐  █    █  ▐  █▀▀▀▀  
    █        █    ▌     █   ▄▀    █    ▌      █             █    █      █      
  ▄▀▄▄▄▄▄▄▀ ▄▀▄▄▄▄       ▀▄▀     ▄▀▄▄▄▄     ▄▀▄▄▄▄▄▄▀        ▀▄▄▄▄▀   ▄▀       
  █         █    ▐               █    ▐     █                        █         
  ▐         ▐                    ▐          ▐                        ▐         

                                                        
                                                        ";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(ASCII_Title);
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(ASCII_Title);
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Winner() //Winner Banner
        {
            string ASCII_Title = @"
 __       __  __                                         
|  \  _  |  \|  \                                        
| $$ / \ | $$ \$$ _______   _______    ______    ______  
| $$/  $\| $$|  \|       \ |       \  /      \  /      \ 
| $$  $$$\ $$| $$| $$$$$$$\| $$$$$$$\|  $$$$$$\|  $$$$$$\
| $$ $$\$$\$$| $$| $$  | $$| $$  | $$| $$    $$| $$   \$$
| $$$$  \$$$$| $$| $$  | $$| $$  | $$| $$$$$$$$| $$      
| $$$    \$$$| $$| $$  | $$| $$  | $$ \$$     \| $$      
 \$$      \$$ \$$ \$$   \$$ \$$   \$$  \$$$$$$$ \$$      
                                                        
                                                        ";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(ASCII_Title);
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(ASCII_Title);
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            string ASCII_Title = @"
:'######::'##::::::::'#######::'########:
'##... ##: ##:::::::'##.... ##:... ##..::
 ##:::..:: ##::::::: ##:::: ##:::: ##::::
. ######:: ##::::::: ##:::: ##:::: ##::::
:..... ##: ##::::::: ##:::: ##:::: ##::::
'##::: ##: ##::::::: ##:::: ##:::: ##::::
. ######:: ########:. #######::::: ##::::
:......:::........:::.......::::::..:::::
'##::::'##::::'###:::::'######::'##::::'##:'####:'##::: ##:'########:
 ###::'###:::'## ##:::'##... ##: ##:::: ##:. ##:: ###:: ##: ##.....::
 ####'####::'##:. ##:: ##:::..:: ##:::: ##:: ##:: ####: ##: ##:::::::
 ## ### ##:'##:::. ##: ##::::::: #########:: ##:: ## ## ##: ######:::
 ##. #: ##: #########: ##::::::: ##.... ##:: ##:: ##. ####: ##...::::
 ##:.:: ##: ##.... ##: ##::: ##: ##:::: ##:: ##:: ##:. ###: ##:::::::
 ##:::: ##: ##:::: ##:. ######:: ##:::: ##:'####: ##::. ##: ########:
..:::::..::..:::::..:::......:::..:::::..::....::..::::..::........::
                                                        
                                                        ";
            Console.WriteLine(ASCII_Title);
            System.Threading.Thread.Sleep(2000);
            Random rnd = new Random();
            int num1, num2, num3, balance, equal, turns = 1, level = 0, profitNUM = 0;
            bool Jackpot; //If there is jackpot on turn
            string profit;
            balance = 1000; //Starting balance
            var line = ""; //For continue the game
            while (0 < 1) //Infinity Loop
            {
                if (turns != 1)
                {
                    System.Console.WriteLine("Press ENTER to start, other to exit");
                    line = Console.ReadLine();
                }
                else if (turns == 1)
                {
                    line = "";
                    System.Console.WriteLine("Starting!");
                }
                if ((string.IsNullOrEmpty(line)) || (turns == 1)) // Enter
                {
                    Jackpot = false;
                    profit = "";
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(ASCII_Title);
                    Console.WriteLine("");
                    num1 = rnd.Next(1, 10); //Number 1
                    num2 = rnd.Next(1, 10); //Number 2
                    num3 = rnd.Next(1, 10); //Number 3
                    if ((num1 == num2) && (num1 == num3)) //All numbers are equal, changing one
                    {
                        if (level <= 4) //Played no more then 40 turns
                        {
                            equal = rnd.Next(1, 10);
                            if (equal < 8) //Do nothinng
                            { }
                            else //Change num1 randumly
                            {
                                equal = rnd.Next(1, 10);
                            }
                        }
                        else if (turns <= 8) //Played no more then 80 turns
                        {
                            equal = rnd.Next(1, 20);
                            if (equal < 15) //Do nothinng
                            { }
                            else //Change num1 randumly
                            {
                                num1 = rnd.Next(1, 10); //Number 1
                            }
                        }
                        else if (turns <= 11) //Played no more then 110 turns
                        {
                            equal = rnd.Next(1, 40);
                            if (equal < 30) //Do nothinng
                            { }
                            else //Change num1 randumly
                            {
                                num1 = rnd.Next(1, 10); //Number 1
                            }
                        }
                        else
                        {
                            equal = rnd.Next(1, 100);
                            if (equal < 50) //Do nothinng
                            { }
                            else //Change num1 randumly
                            {
                                num1 = rnd.Next(1, 10); //Number 1
                            }
                        }
                    }
                    else if ((num1 != num2) && (num1 != num3) && (num2 != num3)) //All numbers are not equal, changing num1 to match num2 and num3 to match num 2
                    {
                        if (turns <= 4) //Played no more then 40 turns
                        {
                            equal = rnd.Next(1, 30);
                            if (equal < 15) //Do nothinng
                            { }
                            else //Change num1
                            {
                                equal = rnd.Next(1, 4);
                                if (equal == 1)
                                {
                                    num1 = num2; //Num1 equal to num2
                                }
                                else if (equal == 2)
                                {
                                    num1 = num3; //Num1 equal to num3
                                }
                                else
                                {
                                    num2 = num3; //Num2 equal to num3
                                }
                            }
                        }
                        else if (turns <= 8) //Played no more then 80 turns
                        {
                            equal = rnd.Next(1, 4);
                            if (equal == 1)
                            {
                                num1 = num2; //Num1 equal to num2
                            }
                            else if (equal == 2)
                            {
                                num1 = num3; //Num1 equal to num3
                            }
                            else
                            {
                                num2 = num3; //Num2 equal to num3
                            }
                        }
                        else if (turns <= 11) //Played no more then 110 turns
                        {
                            equal = rnd.Next(1, 200);
                            if (equal < 175) //Do nothinng
                            { }
                            else //Change num1
                            {
                                equal = rnd.Next(1, 3);
                                if (equal == 1)
                                {
                                    num1 = num2; //Num1 equal to num2
                                }
                                else
                                {
                                    num1 = num3; //Num1 equal to num3
                                }
                            }
                        }
                        else
                        {
                            equal = rnd.Next(1, 300);
                            if (equal < 280) //Do nothinng
                            { }
                            else //Change num1
                            {
                                equal = rnd.Next(1, 3);
                                if (equal == 1)
                                {
                                    num1 = num2; //Num1 equal to num2
                                }
                                else
                                {
                                    num1 = num3; //Num1 equal to num3
                                }
                            }
                        }

                    }
                    balance -= 100; //Updadte balance
                    System.Threading.Thread.Sleep(200);
                    System.Console.WriteLine("Balance: $" + balance + "   Level: " + level + "   Turn: " + turns);
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Press ENTER to stop the number");
                    Console.WriteLine("");
                    System.Console.WriteLine("-------------------");
                    System.Console.WriteLine("|     |" + "     |" + "     |");
                    System.Console.WriteLine("-------------------");

                    //Print number 1
                    line = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(ASCII_Title);
                    Console.WriteLine("");
                    System.Console.WriteLine("Balance: $" + balance + "   Level: " + level + "   Turn: " + turns);
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Press ENTER to stop the number");
                    System.Console.WriteLine("");
                    System.Console.WriteLine("-------------------");
                    System.Console.WriteLine("|  " + num1 + "  |" + "     |" + "     |");
                    System.Console.WriteLine("-------------------");

                    //Print number 2
                    line = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(ASCII_Title);
                    Console.WriteLine("");
                    System.Console.WriteLine("Balance: $" + balance + "   Level: " + level + "   Turn: " + turns);
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Press ENTER to stop the number");
                    System.Console.WriteLine("");
                    System.Console.WriteLine("-------------------");
                    System.Console.WriteLine("|  " + num1 + "  |" + "  " + num2 + "  |" + "     |");
                    System.Console.WriteLine("-------------------");

                    //Print number 3
                    line = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(ASCII_Title);
                    Console.WriteLine("");
                    System.Console.WriteLine("Balance: $" + balance + "   Turn: " + turns);
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Press ENTER to stop the number");
                    System.Console.WriteLine("");
                    System.Console.WriteLine("-------------------");
                    System.Console.WriteLine("|  " + num1 + "  |" + "  " + num2 + "  |" + "  " + num3 + "  |");
                    System.Console.WriteLine("-------------------");

                    if ((num1 == num2) && (num1 == num3)) //All numbers are equal (jackpot)
                    {
                        balance += 300;
                        profit = "+$300";
                        profitNUM = 300;
                        System.Console.WriteLine("");
                        System.Console.WriteLine("----------");
                        System.Console.WriteLine("Jackpot!!!");
                        System.Console.WriteLine("----------");
                        Jackpot = true; //There was a jackpot
                    }
                    else if ((num1 == num2) || (num1 == num3) || (num2 == num3)) //num1 = num2 or num1 = num2 or num2 = num3
                    {
                        balance += 200;
                        profit = "+$200";
                        profitNUM = 200;
                    }
                    else if ((num1 != num2) && (num1 != num3) && (num2 != num3)) //Numbers are not equal
                    {
                        profit = "$0";
                    }
                    Console.Clear();
                    Console.WriteLine(ASCII_Title);
                    Console.WriteLine("");
                    System.Console.Write("Balance: $" + balance + "   Level: " + level + "   Turn: " + turns + "   Profit: ");
                    if (profitNUM > 0) //If you got profit
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(profit);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    System.Console.WriteLine("-------------------");
                    System.Console.Write("|  " + num1 + "  |");
                    System.Threading.Thread.Sleep(20);
                    System.Console.Write("  " + num2 + "  |");
                    System.Threading.Thread.Sleep(20);
                    System.Console.WriteLine("  " + num3 + "  |");
                    System.Console.WriteLine("-------------------");
                    System.Console.WriteLine("");
                    System.Console.WriteLine("");
                    System.Threading.Thread.Sleep(1000);
                    if (Jackpot == false) //No jackpot was
                    {
                        if (profitNUM > 0) //If you got profit
                        {
                            Winner(); Winner(); Winner(); Winner(); Winner(); //Winner Banner
                        }
                    }
                    if (turns % 10 == 0) //If you passed 10 turns
                    {
                        level++;
                        LevelUp(); LevelUp(); LevelUp(); LevelUp(); LevelUp(); LevelUp(); LevelUp(); LevelUp(); //Level Up Banner

                    }
                    Console.WriteLine(ASCII_Title);
                    Console.WriteLine("");
                    System.Console.Write("Balance: $" + balance + "   Level: " + level + "   Turn: " + turns + "   Profit: ");
                    if (profitNUM > 0) //If you got profit
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(profit);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    System.Console.WriteLine("-------------------");
                    System.Console.Write("|  " + num1 + "  |");
                    System.Threading.Thread.Sleep(20);
                    System.Console.Write("  " + num2 + "  |");
                    System.Threading.Thread.Sleep(20);
                    System.Console.WriteLine("  " + num3 + "  |");
                    System.Console.WriteLine("-------------------");
                    System.Console.WriteLine("");
                    System.Console.WriteLine("");
                    turns++;
                    if (balance == 0) //No balance
                    {
                        //Console.Clear();
                        System.Threading.Thread.Sleep(200);
                        System.Console.WriteLine("Sorry, no balance left");
                        System.Console.WriteLine("You played: " + turns.ToString() + " turns");
                        System.Console.WriteLine("Game Over");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                }
                else //Exit the games
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
