using System;

class Program
{
    static void Main(string[] args)
    {
        string Aset = "", Bset = "", Cset = "";
        int Ahp = 0, Bhp = 0, Chp = 0;
        string Astat = "", Bstat = "", Cstat = "";
        double Ascore = 0, Bscore = 0, Cscore = 0;
        int Adist = 0, Bdist = 0, Cdist = 0;
        int mAdist = 0, mBdist = 0, mCdist = 0;
        int Ax = 0, Ay = 0;

        Console.WriteLine("Enter the coordinates of A");
        Console.Write("Ax: ");
        try
        {

            Ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ay: ");
            Ay = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();

            if (Ax > 10 || Ax < -10 || Ay > 10 || Ay < -10)
            {
                Console.WriteLine("Invalid Coordinates.");
                Console.ReadKey();
            }
            else
            {
                int Bx = rand.Next(-10, 11);
                int By = rand.Next(-10, 11);
                int Cx = rand.Next(-10, 11);
                int Cy = rand.Next(-10, 11);


                //Distributing sets
                int sets = rand.Next(1, 7);

                if (sets == 1)
                {
                    Aset = "FA";
                    Bset = "PA";
                    Cset = "IA";
                }
                else if (sets == 2)
                {
                    Aset = "FA";
                    Bset = "IA";
                    Cset = "PA";
                }
                else if (sets == 3)
                {
                    Aset = "PA";
                    Bset = "FA";
                    Cset = "IA";
                }
                else if (sets == 4)
                {
                    Aset = "PA";
                    Bset = "IA";
                    Cset = "FA";
                }
                else if (sets == 5)
                {
                    Aset = "IA";
                    Bset = "PA";
                    Cset = "FA";
                }
                else
                {
                    Aset = "IA";
                    Bset = "FA";
                    Cset = "PA";
                }

                //distributing healths
                int healths = rand.Next(1, 7);

                if (healths == 1)
                {
                    Ahp = 80;
                    Bhp = 100;
                    Chp = 60;
                }
                else if (healths == 2)
                {
                    Ahp = 80;
                    Bhp = 60;
                    Chp = 100;
                }
                else if (healths == 3)
                {
                    Ahp = 100;
                    Bhp = 80;
                    Chp = 60;
                }

                else if (healths == 4)
                {
                    Ahp = 100;
                    Bhp = 60;
                    Chp = 80;
                }
                else if (healths == 5)
                {
                    Ahp = 60;
                    Bhp = 100;
                    Chp = 80;
                }
                else
                {
                    Ahp = 60;
                    Bhp = 80;
                    Chp = 100;
                }

                //first scoreboard
                Console.Write("\nA: (" + Ax + "," + Ay + ") ");
                Console.SetCursorPosition(12, 4);
                Console.Write("Set " + Aset);
                Console.WriteLine("   Health:" + Ahp);
                Console.Write("B: (" + Bx + "," + By + ") ");
                Console.SetCursorPosition(12, 5);
                Console.Write("Set " + Bset);
                Console.WriteLine("   Health:" + Bhp);
                Console.Write("C: (" + Cx + "," + Cy + ") ");
                Console.SetCursorPosition(12, 6);
                Console.Write("Set " + Cset);
                Console.WriteLine("   Health:" + Chp);

                Console.WriteLine();

                Console.WriteLine("   + - - - - - - - - - - ^ - - - - - - - - - - +");
                Console.WriteLine(" 10| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  9| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  8| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  7| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  6| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  5| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  4| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  3| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  2| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  1| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  0| - - - - - - - - - - + - - - - - - - - - - >");
                Console.WriteLine(" -1| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -2| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -3| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -4| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -5| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -6| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -7| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -8| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -9| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("-10| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  0| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("   + - - - - - - - - - - - - - - - - - - - - - +");
                Console.WriteLine("     0 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 0  \n\n");
                Console.SetCursorPosition(25 + (2 * Ax), 19 - Ay);
                Console.WriteLine("A");
                Console.SetCursorPosition(25 + (2 * Bx), 19 - By);
                Console.WriteLine("B");
                Console.SetCursorPosition(25 + (2 * Cx), 19 - Cy);
                Console.WriteLine("C");
                Console.SetCursorPosition(0, 34);

                Console.WriteLine();

                //manhattan distance
                int mAB = (Math.Abs(Bx - Ax) + Math.Abs(By - Ay));
                int mAC = (Math.Abs(Cx - Ax) + Math.Abs(Cy - Ay));
                int mBC = (Math.Abs(Bx - Cx) + Math.Abs(By - Cy));

                int AB = (int)Math.Sqrt(((Bx - Ax) * (Bx - Ax)) + ((By - Ay) * (By - Ay)));
                int AC = (int)Math.Sqrt(((Cx - Ax) * (Cx - Ax)) + ((Cy - Ay) * (Cy - Ay)));
                int BC = (int)Math.Sqrt(((Bx - Cx) * (Bx - Cx)) + ((By - Cy) * (By - Cy)));

                if ((AB > 15) & (BC > 15) & (AC > 15))
                {
                    Console.WriteLine("Players are too distant");
                    Console.WriteLine("GAME OVER");
                    Console.ReadLine();

                }
                else
                {
                    if ((AB <= AC) && (AB <= BC))
                    {
                        Adist = AB;
                        Bdist = AB;

                        if ((Aset == "FA" && Bset == "PA") || (Aset == "PA" && Bset == "IA") || (Aset == "IA" && Bset == "FA"))
                        {
                            Console.WriteLine("Round 1 : A-B");

                            Ahp -= 25;
                            Bhp = 0;
                            Ascore = 10 * mAB + (100 - Ahp);
                            Astat = "Survivor     ";
                            Bstat = "Defeated     ";
                            Cstat = "Non-fighter  ";

                        }
                        else
                        {
                            Console.WriteLine("Round 1 : A-B");

                            Bhp -= 25;
                            Ahp = 0;
                            Bscore = 10 * mAB + (100 - Bhp);
                            Astat = "Defeated     ";
                            Bstat = "Survivor     ";
                            Cstat = "Non-fighter  ";

                        }
                    }
                    else if (BC <= AC)
                    {
                        if ((Bset == "FA" && Cset == "PA") || (Bset == "PA" && Cset == "IA") || (Bset == "IA" && Cset == "FA"))
                        {
                            Console.WriteLine("Round 1 : B-C");

                            Bhp -= 25;
                            Chp = 0;
                            Bscore = 10 * mBC + (100 - Bhp);
                            Astat = "Non-fighter  ";
                            Bstat = "Survivor     ";
                            Cstat = "Defeated     ";

                        }
                        else
                        {
                            Console.WriteLine("Round 1 : B-C");

                            Chp -= 25;
                            Bhp = 0;
                            Cscore = 10 * mBC + (100 - Chp);
                            Astat = "Non-fighter  ";
                            Bstat = "Defeated     ";
                            Cstat = "Survivor     ";

                        }

                    }
                    else
                    {
                        if ((Aset == "FA" && Cset == "PA") || (Aset == "PA" && Cset == "IA") || (Aset == "IA" && Cset == "FA"))
                        {
                            Console.WriteLine("Round 1 : A-C");

                            Ahp -= 25;
                            Chp = 0;
                            Ascore = 10 * mAC + (100 - Ahp);
                            Astat = "Survivor     ";
                            Bstat = "Non-fighter  ";
                            Cstat = "Defeated     ";

                        }
                        else
                        {
                            Console.WriteLine("Round 1 : A-C");

                            Chp -= 25;
                            Ahp = 0;
                            Cscore = 10 * mAC + (100 - Chp);
                            Astat = "Defeated     ";
                            Bstat = "Non-fighter  ";
                            Cstat = "Survivor     ";

                        }

                    }

                    //first round scoreBoard
                    Console.WriteLine();
                    Console.Write("\nA: " + Astat + " ");
                    Console.Write("Health:" + Ahp);
                    Console.SetCursorPosition(30, 38);
                    Console.WriteLine(" Score:" + Ascore);
                    Console.Write("B: " + Bstat + " ");
                    Console.Write("Health:" + Bhp);
                    Console.SetCursorPosition(30, 39);
                    Console.WriteLine(" Score:" + Bscore);
                    Console.Write("C: " + Cstat + " ");
                    Console.Write("Health:" + Chp);
                    Console.SetCursorPosition(30, 40);
                    Console.WriteLine(" Score:" + Cscore + "\n\n\n");
                    Console.Read();





                    if (Chp == 0)
                    {
                        Console.WriteLine("Round 2 : A-B");
                        if (AB > 15)
                        {
                            Console.WriteLine("\n\nToo distant, no attack");

                        }
                        else
                        {
                            if ((Aset == "FA" && Bset == "PA") || (Aset == "PA" && Bset == "IA") || (Aset == "IA" && Bset == "FA"))
                            {


                                Ahp -= 25;
                                Bhp = 0;
                                Ascore = 10 * mAB + (100 - Ahp);
                                Bstat = "Defeated     ";
                                Astat = "Survivor     ";

                            }
                            else
                            {


                                Bhp -= 25;
                                Ahp = 0;
                                Bscore = 10 * mAB + (100 - Bhp);
                                Astat = "Defeated     ";
                                Bstat = "Survivor     ";

                            }

                            //round 2 scoreboard
                            Console.WriteLine();
                            Console.Write("\nA: " + Astat + " ");
                            Console.Write("Health:" + Ahp);
                            Console.SetCursorPosition(30, 48);
                            Console.WriteLine(" Score:" + Ascore);
                            Console.Write("B: " + Bstat + " ");
                            Console.Write("Health:" + Bhp);
                            Console.SetCursorPosition(30, 49);
                            Console.WriteLine(" Score:" + Bscore);
                            Console.Write("C: " + Cstat + " ");
                            Console.Write("Health:" + Chp);
                            Console.SetCursorPosition(30, 50);
                            Console.WriteLine(" Score:" + Cscore);
                            Console.WriteLine();
                        }
                    }

                    else if (Bhp == 0)
                    {
                        Console.WriteLine("Round 2 : A-C");
                        if (AC > 15)
                        {
                            Console.WriteLine("\n\nToo distant, no attack");

                        }
                        else
                        {
                            if ((Aset == "FA" && Cset == "PA") || (Aset == "PA" && Cset == "IA") || (Aset == "IA" && Cset == "FA"))
                            {


                                Ahp -= 25;
                                Chp = 0;
                                Ascore = 10 * mAC + (100 - Ahp);
                                Cstat = "Defeated     ";
                                Astat = "Survivor     ";

                            }
                            else
                            {

                                Chp -= 25;
                                Ahp = 0;
                                Cscore = 10 * mAC + (100 - Chp);
                                Astat = "Defeated     ";
                                Cstat = "Survivor     ";
                            }

                            //round 2 scoreboard
                            Console.WriteLine();
                            Console.Write("\nA: " + Astat + " ");
                            Console.Write("Health:" + Ahp);
                            Console.SetCursorPosition(30, 48);
                            Console.WriteLine(" Score:" + Ascore);
                            Console.Write("B: " + Bstat + " ");
                            Console.Write("Health:" + Bhp);
                            Console.SetCursorPosition(30, 49);
                            Console.WriteLine(" Score:" + Bscore);
                            Console.Write("C: " + Cstat + " ");
                            Console.Write("Health:" + Chp);
                            Console.SetCursorPosition(30, 50);
                            Console.WriteLine(" Score:" + Cscore);
                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Round 2 : B-C");
                        if (BC > 15)
                        {
                            Console.WriteLine("\nToo distant, no attack");

                        }
                        else
                        {
                            if ((Bset == "FA" && Cset == "PA") || (Bset == "PA" && Cset == "IA") || (Bset == "IA" && Cset == "FA"))
                            {


                                Bhp -= 25;
                                Chp = 0;
                                Bscore = 10 * mBC + (100 - Bhp);
                                Cstat = "Defeated     ";
                                Bstat = "Survivor     ";

                            }
                            else
                            {

                                Chp -= 25;
                                Bhp = 0;
                                Cscore = 10 * mBC + (100 - Chp);
                                Bstat = "Defeated     ";
                                Cstat = "Survivor     ";
                            }
                            //round 2 scoreboard
                            Console.Write("\n\nA: " + Astat + " ");
                            Console.Write("Health:" + Ahp);
                            Console.SetCursorPosition(30, 48);
                            Console.WriteLine(" Score:" + Ascore);
                            Console.Write("B: " + Bstat + " ");
                            Console.Write("Health:" + Bhp);
                            Console.SetCursorPosition(30, 49);
                            Console.WriteLine(" Score:" + Bscore);
                            Console.Write("C: " + Cstat + " ");
                            Console.Write("Health:" + Chp);
                            Console.SetCursorPosition(30, 50);
                            Console.WriteLine(" Score:" + Cscore);
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine();
                    if ((Ascore > Bscore) && (Ascore > Cscore))
                    {
                        Console.WriteLine("\nA has the maximum score (" + Ascore + ")");
                    }
                    else if ((Bscore > Ascore) && (Bscore > Cscore))
                    {
                        Console.WriteLine("\nB has the maximum score (" + Bscore + ")");
                    }
                    else
                    {
                        Console.WriteLine("\nC has the maximum score (" + Cscore + ")");
                    }

                    Console.ReadKey();
                }
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Please enter a number");
            Console.ReadKey();
        }
    }
}
