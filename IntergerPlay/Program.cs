using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergerPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop for running/continue

            bool LoopRunProgram = true;
            while (LoopRunProgram == true)
            {
                //name of person to use throughout program

                Console.WriteLine("Hi, how're you doing... actually let's be more informal, what is your name?");
                var UserNameInput = Console.ReadLine();

               
                int myNum;
                {
                    Console.WriteLine("Cool name, " + UserNameInput + ". Could you please put in an interger between 1 and 100?");
                    var NumbNumber = Console.ReadLine();


                    if (int.TryParse(NumbNumber, out myNum) == false)
                    {

                        continue;
                    }
                    else
                    {


                        int Input = int.Parse(NumbNumber);

                        //validate that it is between 1 and 100
                        if (Input > 1 && Input < 100)
                        {   
                            //Even or odd
                            Console.WriteLine("Gotta do some logic checks, one sec");
                            bool EvenOdd = (Input % 2 != 0);
                            string OddEven;
                            
                            if (EvenOdd == true)
                            {                            
                                OddEven = "odd";
                            }
                            else
                            {
                                OddEven = "even";
                            }
                            //Comparison time!
                            Console.WriteLine("This number is " +OddEven+ " isn't that neat " +UserNameInput+ "?");

                            if (Input > 1 && Input < 25)
                            {
                                Console.WriteLine("This is also less than 25, it's " +Input+ " afterall. Were you able to infer that " + UserNameInput + "? Don't worrry if you couldn't, that's what machines are for!");
                            }
                            if (Input > 26 && Input < 60)
                            {
                                Console.WriteLine("This Number is more than 25, it's " +Input+ " so it's less than 60 too " +UserNameInput+ ".This is a neat number comparison, right " +UserNameInput+ "?");
                            }
                            if (Input > 60)
                            {
                                Console.WriteLine("Of the numbers you picked, is was a big one " +UserNameInput+ " yup, proud of you for picking " +Input+ ".");
                            }

                            }
                        else
                            {
                                Console.WriteLine("that's not a number I wanna deal with right now " + UserNameInput + "");

                            }
                                                       

                        }
                    }

                    string Response = ("Wanna start again " + UserNameInput + "? (y/n)");
                    bool end = true;
                    while (end)
                    {
                        Console.WriteLine(Response);
                        string UserRestart = Console.ReadLine();

                        if (UserRestart == "y")
                        {
                            LoopRunProgram = true;
                            end = false;
                        }
                        if (UserRestart == "n")
                        {
                            LoopRunProgram = false;
                            end = false;
                        }
                        else
                        {
                            Response = "I don't know what you're trying to say, " + UserNameInput + " can you type something else out? Possibly a Y or an N?";

                        }
                    }






                
            }
        }
    }
}