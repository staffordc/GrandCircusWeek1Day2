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
            //loop for running/continueing

            bool LoopRunProgram = true;
            while (LoopRunProgram == true)
            {
                //name of person to use throughout program

                Console.WriteLine("Hi, how're you doing... actually let's be more formal, what is your name?");
                var UserNameInput = Console.ReadLine();

                //Enter integer between 1 and 100

                

                int myNum;
                bool NumLoopCheckIsNumb = true;
                while (NumLoopCheckIsNumb == true)
                {
                    Console.WriteLine("Cool name," + UserNameInput + " Could you please put in an interger between 1 and 100?");
                    var NumbNumber = Console.ReadLine();


                    if (int.TryParse(NumbNumber, out myNum) == false)
                    {
                        
                        continue;
                    }
                    else
                    {
                        

                        int Input = int.Parse(NumbNumber);

                        //validate that it is between 1 and 100
                        if (Input>1 && Input < 100)
                        {
                            Console.WriteLine("Gotta do some logic checks, one sec");
                            if (Input % 2 != 0)
                            {
                                Console.WriteLine("This is an Odd Number");
                                NumLoopCheckIsNumb = false;
                            }
                            
                            //2<#<25 and Even
                            if (2 < Input && Input < 25 && Input % 2 == 0)
                            {
                                Console.WriteLine("Even");
                                NumLoopCheckIsNumb = false;
                            }

                            //26 to 60, just Even (if not odd)
                            if (26 < Input && Input < 60 && Input % 2 == 0)
                            {
                                Console.WriteLine("Even");
                                NumLoopCheckIsNumb = false;
                            }

                            //Even < 60 print number and Even
                            if (Input > 60 && Input % 2 == 0)
                            {
                                Console.WriteLine(+Input + " Even");
                                NumLoopCheckIsNumb = false;
                            }
                            //odd and greater than 60 print number and odd
                            if (Input > 60 && Input % 2 != 0)
                            {
                                Console.WriteLine(+Input + " Odd");
                                NumLoopCheckIsNumb = false;
                            }

                        }
                        else
                        {
                            Console.WriteLine("that's not a number I wanna deal with right now " + UserNameInput + "");
                            
                        }
                        //Odd print number and Odd

                        
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
                        Response = "I don't know what you're trying to say," + UserNameInput + " can you type something else out? Possibly a Y or an N?";
                        
                    }
                }
               





            }
        }
    }
}