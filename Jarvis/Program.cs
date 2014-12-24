using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Jarvis
{
     //NEW LINE ADDED WITH NEW COLLABORATOR METHOD
    //werwath !!!
    //jake
    class Program
    {
        static  ConsoleKeyInfo askQuestion(SpeechSynthesizer synth, String question) 
        {
            Console.WriteLine(question);
            synth.Speak(question);
            return Console.ReadKey(); 
        }

        static void Main(string[] args) 
        {
#region start up script
            //starting my program
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("wellcome to Jacob's personal reminder system");
            Random randomObject = new Random();
            int randnum = randomObject.Next(6) + 1;
            #endregion
#region array
            //Get a random array of ints including 1,2,3  (e.g. 2,1,3 or 1,3,2, etc.)
            //How do I create a random array of int in C#?
            System.Random rnd = new System.Random();
            var randomNumbers = Enumerable.Range(1, 3).OrderBy(r => rnd.Next()).ToArray();

            //Now loop through the random array of ints.
            //For example if randomNumbers is 2,1,3
            //randomNumbers[0] = 2
            //randomNumbers[1] = 1
            //randomNumbers[2] = 3
            //How do i loop through an array of int i
            for (int i = 0; i < randomNumbers.Count(); i++)
#endregion
#region did you get albuterol
            {
                switch(randomNumbers[i])
                {
                    case 1:
                        {
                            ConsoleKeyInfo KI = askQuestion(synth,"Did you get albuterol?");
                            ///finding out if you got albuteol or not this leads into two if else loops
#endregion
#region albuterol timer
                            if (KI.KeyChar == 'Y')//you got albuterol
                            {
                                synth.Speak("would you like to run a ten second timer?");
                                Console.WriteLine("would you like to run a ten second timer?");
                                ConsoleKeyInfo KI2 = Console.ReadKey();
                                if (KI2.KeyChar == 'Y')
                                {
                                    synth.Speak("starting count down for albuterol");
                                    Thread.Sleep(2000);///2hree seconds
                                    synth.Speak("three  ");
                                    Thread.Sleep(800);
                                    synth.Speak("Two    ");
                                    Thread.Sleep(800);
                                    synth.Speak("one    ");
                                    Thread.Sleep(800);
                                    synth.Speak("puff");
                                    Thread.Sleep(12000);///twelve seconds because it takes time ti do the puff and it wount kill you if you hold your breath to long
                                    synth.Speak(" your ten seconds are up");
                                    ///repeating the code so that it runns the counter tiwse because i have to du two puffs 
                                    Thread.Sleep(3000);
                                    synth.Speak("starting count down for albuterol");
                                    Thread.Sleep(2000);///three seconds
                                    synth.Speak("three  ");
                                    Thread.Sleep(800);
                                    synth.Speak("Two    ");
                                    Thread.Sleep(800);
                                    synth.Speak("one    ");
                                    Thread.Sleep(800);
                                    synth.Speak("puff");
                                    Thread.Sleep(12000);///ten seconds
                                    synth.Speak(" your ten seconds are up");
                                }
                                ///thats all fo this timer (its jsut for albuterol)
                                else
                                ///if you got albuterol but do not want a timer
                                {
                                    Thread.Sleep(600);
                                    synth.Speak("okay thats fine, you can do your two puffs of albuterol and when your done with that, I will walk you through everything else");
                                    Thread.Sleep(25000);
                                }
                            }
#endregion
#region albuterol timer (DID NOT GET)
                            else///you did not get albuterol
                            {
                                Console.WriteLine("Would you please go get your albuterol");
                                synth.Speak("Would you please go get albuterol");
                                Thread.Sleep(6000);
                                synth.Speak("starting count down for albuterol");
                                Thread.Sleep(2000);///2hree seconds
                                synth.Speak("three  ");
                                Thread.Sleep(800);
                                synth.Speak("Two    ");
                                Thread.Sleep(800);
                                synth.Speak("one    ");
                                Thread.Sleep(800);
                                synth.Speak("puff");
                                Thread.Sleep(12000);///twelve seconds because it takes time ti do the puff and it wount kill you if you hold your breath to long
                                synth.Speak(" your ten seconds are up");
                                ///repeating the code so that it runns the counter tiwse because i have to du two puffs 
                                Thread.Sleep(3000);
                                synth.Speak("starting count down for albuterol");
                                Thread.Sleep(2000);///three seconds
                                synth.Speak("three  ");
                                Thread.Sleep(800);
                                synth.Speak("Two    ");
                                Thread.Sleep(800);
                                synth.Speak("one    ");
                                Thread.Sleep(800);
                                synth.Speak("puff");
                                Thread.Sleep(12000);///ten seconds
                                synth.Speak(" your ten seconds are up");
                                   }
                            break;
                            }// case one ending
#endregion
#region saline
                    case 2:
                        {
                            Console.WriteLine("would you so kindly get saline");
                            synth.Speak("would you kindly get saline");
                            Console.WriteLine("did you put saline in your nebulizer?");
                            synth.Speak("please put saline in your nebulizer");
                            Thread.Sleep(4000);
                            break;
                        }
                    #endregion
#region pulmozyme
                    case 3:
                        {
                            Console.WriteLine(" please go get your pulmozyme");
                            synth.Speak("please go get your pulmozyme");
                            Thread.Sleep(4000);
                            Console.WriteLine("would you please put said pulmozyme in your pocket or such that it does not get lost");
                            synth.Speak("would you please put said pulmozyme in your pocket or such that it does not get lost");
                            Thread.Sleep(5000);
                            break;
                    #endregion
                        }
                }
            }

#region vest and pulymizin
                ///summery
                ///This is just runnign middle of my treatment reminders and cheacks
                ///this is just a small block and does not do much
            Console.WriteLine("starting a half hour timer for your vest.");                                          
                Thread.Sleep(1800000);
                synth.Speak("Is your vest done,");
                ConsoleKeyInfo KI3 = Console.ReadKey();
            if(KI3.KeyChar == 'Y')
            {
                Console.WriteLine("congratulations you have run your vest perfectly");
                synth.Speak("congratulations you have run your vest perfectly");
            }
            if(KI3.KeyChar == 'S')
            {
                Console.WriteLine("Okay so just finish it up, and you will be done in five, of ten minutes");
                synth.Speak("okay so just finish it up, and you will be done in five, of ten minutes");
            }
            if(KI3.KeyChar == 'N')
            {
                Console.WriteLine("Then you need to start it again, and activly work and restarting it at check points!");
                synth.Speak("Then you need to start it again, and activly work and restarting it at check points!");
            }
                Thread.Sleep(180000);
                synth.Speak("did you put pulmozyme in?");
                ConsoleKeyInfo KI4 = Console.ReadKey();
            if(KI4.KeyChar == 'Y')
            {
                Console.WriteLine("Good job remembring to put it in.");
                synth.Speak("Good job remembring to put it in.");
            }
            if(KI4.KeyChar == 'N')                                             
            {
                Console.WriteLine("well then can you please put your pulmozyme?");
                synth.Speak("well then can you please put your pulmozyme?");
            }
                Thread.Sleep(10000);
                #endregion
#region getting off
            Console.WriteLine("please turn of your computer.");
            synth.Speak("please turn of your computer.");
                #endregion
#region water
            switch (randnum)
                {
                    case 1:
                        {
                            ///this set of code is for when im do with tharpy 
                            ///it will reminde me to do kayston and to put my nebulizer in water to wash

                            synth.Speak("please put you nebulizer in water.");
                            Thread.Sleep(1500);
                            synth.Speak("please get your kayston and start it");
                            break;
                        }
                    case 2:
                        {
                            synth.Speak("pleease get you Kayston after you put your nebulizer in water");
                            break;
                        }
 #endregion
#region flowe vent and noise spray
                                    synth.Speak("starting count down for flowe vent");
                                    Thread.Sleep(3000);
                                    synth.Speak("three");
                                    Thread.Sleep(800);
                                    synth.Speak("Two");
                                    Thread.Sleep(800);
                                    synth.Speak("one");
                                    Thread.Sleep(800);
                                    synth.Speak("go");
                                    Thread.Sleep(12000);
                                    synth.Speak("ten seconds are done");
                                    Thread.Sleep(1500);
                                    synth.Speak("starting count down for flowe vent");
                                    Thread.Sleep(3000);
                                    synth.Speak("three");
                                    Thread.Sleep(800);
                                    synth.Speak("Two");
                                    Thread.Sleep(800);
                                    synth.Speak("one");
                                    Thread.Sleep(800);
                                    synth.Speak("go");
                                    Thread.Sleep(12000);
                                    synth.Speak("ten seconds are done");
                                    Thread.Sleep(2000);
                                    synth.Speak("please do your noise spray that you should have gotten");
                                    break;
                                }
#endregion
#region ending
                                synth.Speak("congragulations you have now run though a intire set of tharpy without missing anything");
                                Thread.Sleep(2000);
                                synth.Speak("Jarvis singing off");
#endregion                            
                        }

                }
            }

