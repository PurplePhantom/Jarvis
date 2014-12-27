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
        static void speakAndWait(SpeechSynthesizer synth, String statement, int millisecondsToWait)
        {
            Console.WriteLine(statement);
            synth.Speak(statement);
            Thread.Sleep(millisecondsToWait);
            return;

        }
        static void speakAbuterolCountdown(SpeechSynthesizer synth) 
        {
                speakAndWait(synth,"starting count down for albuterol",2000);///2hree seconds
                speakAndWait(synth,"three",800);     
                speakAndWait(synth,"two",800);  
                speakAndWait(synth,"one",800); 
                speakAndWait(synth,"puff",12000);///twelve seconds because it takes time ti do the puff and it wount kill you if you hold your breath to long
                return;                    

        }
        static void newFunction(SpeechSynthesizer synth, String GB)
        {
            ///i would like to make a function that is like askQuestion but insted takes a string and both says and reads it
        }

#region askquestion
        static ConsoleKeyInfo askQuestion(SpeechSynthesizer synth, String question) 
        {
            Console.WriteLine(question);
            synth.Speak(question);
            ConsoleKeyInfo key =  Console.ReadKey();
            return key;
        }
        
        #endregion

        static void Main(string[] args) 
        {
#region start up script
            //starting my program
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("wellcome to Jacob's personal reminder system");
            Random randomObject = new Random();
            int randnum = randomObject.Next(6) + 1;
            #endregion

            ConsoleKeyInfo k = askQuestion(synth, "Can you enter a letter?");
            Console.WriteLine(k.KeyChar);
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
                                ConsoleKeyInfo KI2 = askQuestion(synth, "Would you like to start a 10 second timer for albuterol");
                                if (KI2.KeyChar == 'Y')
                                {
                                    speakAbuterolCountdown(synth);
                                    ///repeating the code so that it runns the counter tiwse because i have to du two puffs 
                                    speakAndWait(synth," your ten seconds are up",3000);

                                    speakAbuterolCountdown(synth);
                                    ///repeating the code so that it runns the counter tiwse because i have to du two puffs 
                                    speakAndWait(synth," your ten seconds are up",0);

                                }
                                ///thats all fo this timer (its jsut for albuterol)
                                else
                                ///if you got albuterol but do not want a timer
                                {
                                    Thread.Sleep(600);
                                    speakAndWait(synth,"okay thats fine, you can do your two puffs of albuterol and when your done with that, I will walk you through everything else",25000);
                                }
                            }
#endregion
#region albuterol timer (DID NOT GET)
                            else///you did not get albuterol
                            {
                                speakAndWait(synth,"Would you please go get your albuterol",6000);
                                speakAbuterolCountdown(synth);
                                speakAndWait(synth,"your ten seconds are up",3000);
                                ///repeating the code so that it runns the counter tiwse because i have to du two puffs 
                                Thread.Sleep(3000);
                                speakAbuterolCountdown(synth);
                                speakAndWait(synth," your ten seconds are up",0);
                            }
                            break;
                            }// case one ending
#endregion
#region saline
                    case 2:
                        {
                            speakAndWait(synth, "would you so kindly get saline",0);
                            speakAndWait(synth, "did you put saline in your nebulizer?",4000);
                            break;
                        }
                    #endregion
#region pulmozyme
                    case 3:
                        {
                            speakAndWait(synth, "please go get your pulmozyme",4000);
                            speakAndWait(synth,"would you please put said pulmozyme in your pocket or such that it does not get lost",5000);
                            break;
                    #endregion
                        }
                }
            }

#region vest and pulymizin
                ///summery
                ///This is just runnign middle of my treatment reminders and cheacks
                ///this is just a small block and does not do much
                speakAndWait(synth, "starting a half hour timer for your vest.", 1800000);                                          
                ConsoleKeyInfo KI3 = askQuestion(synth, "Is your vest done?");
            if(KI3.KeyChar == 'Y')
            {
                speakAndWait(synth,"congratulations you have run your vest perfectly",0);
            }
            if(KI3.KeyChar == 'S')
            {
                speakAndWait(synth, "Okay so just finish it up, and you will be done in five, of ten minutes",0);
            }
            if(KI3.KeyChar == 'N')
            {
                speakAndWait(synth, "Then you need to start it again, and activly work and restarting it at check points!",0);
            }
                Thread.Sleep(180000);

                ConsoleKeyInfo KI4 = askQuestion(synth,"did you put pulmozyme in?");
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
            //FIXME (dj80hd) What if the user enters a different letter like F ?
                Thread.Sleep(10000);
                #endregion
#region getting off
            speakAndWait(synth,"please turn of your computer.",0);
                #endregion
#region water
            switch (randnum)
                {
                    case 1:
                        {
                            ///this set of code is for when im do with tharpy 
                            ///it will reminde me to do kayston and to put my nebulizer in water to wash

                            speakAndWait(synth,"please put you nebulizer in water.",1500);
                            speakAndWait(synth,"please get your kayston and start it",0);
                            break;
                        }
                    case 2:
                        {
                            speakAndWait(synth,"pleease get you Kayston after you put your nebulizer in water",0);
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
                                speakAndWait(synth,"congragulations you have now run though a intire set of tharpy without missing anything",2000);
                                speakAndWait(synth, "Jarvis singing off",0);
#endregion                            
                        }

                }
            }

