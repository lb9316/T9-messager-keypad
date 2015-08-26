/**
 * ******************************************************************************************************************
 * FileName		:  NonPredMode.cs
 * 
 * Description	: This is the model end of the code where it returns string related to the number of times the button is
 *                pressed
 *                
 * @version		: NonPredMode.cs v 1.0	2015/15/03 5:15 PM
 *  
 * @author 		: lb9316 (Lakhan Bhojwani)
 * 
 * Revisions 	: Initial revision.
 * *******************************************************************************************************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_T9_Messager_
{
    class NonPredMode
    {
        // boolean value for each button. It turns true when 
        // that respective button is pressed.
        bool button1 = false;
        bool button2 = false;
        bool button3 = false;
        bool button4 = false;
        bool button5 = false;
        bool button6 = false;
        bool button7 = false;
        bool button8 = false;
        bool button9 = false;
        bool button0 = false;
        bool check = false;
        


        // counts the number of times respective button 
        // is pressed with in 2 seconds.
        static int counterOf1 = 1;
        static int counterOf2 = 1;
        static int counterOf3 = 1;
        static int counterOf4 = 1;
        static int counterOf5 = 1;
        static int counterOf6 = 1;
        static int counterOf7 = 1;
        static int counterOf8 = 1;
        static int counterOf9 = 1;
        static int counterOf0 = 1;

        
        // kepp track of time when respective button is pessed
        static int PreviousTimeOf1;
        static int PreviousTimeOf2;
        static int PreviousTimeOf3;
        static int PreviousTimeOf4;
        static int PreviousTimeOf5;
        static int PreviousTimeOf6;
        static int PreviousTimeOf7;
        static int PreviousTimeOf8;
        static int PreviousTimeOf9;
        static int PreviousTimeOf0;

        public String doWork(String name, string displayText)
        {
            // if button 1 is pressed it append ",",".","?","1" to the display text
            // depending on the number of time that button is pressed.
            if (name == "Button_1")
            {
                // makes all button false when this button is pressed
                button2 = false;
                button3 = false;
                button4 = false;
                button5 = false;
                button6 = false;
                button7 = false;
                button8 = false;
                button9 = false;

                button0 = false;

                // calculates the current time of the button pressed.
                int currentTime = Convert.ToInt32(DateTime.Now.ToString("hmmss"));

                // if pressed 1st time then "." is displayed
                if (PreviousTimeOf1 == 0 || button1 == false)
                {
                    PreviousTimeOf1 = currentTime;
                    displayText = displayText + ".";
                    button1 = true;
                }

                // depending on the number of times it is pressed, it appends other character.
                else if (currentTime - PreviousTimeOf1 < 2 && button1 == true)
                {
                    PreviousTimeOf1 = currentTime;
                    counterOf1 += 1;

                    if (counterOf1 % 4 == 1)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + ".";
                    }
                    if (counterOf1 % 4 == 2)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + ",";
                    }
                    if (counterOf1 % 4 == 3)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "?";
                    }
                    if (counterOf1 % 4 == 0)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "1";
                    }

                }
                int currentTime1 = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
                if (currentTime1 - PreviousTimeOf1 > 2)
                {
                    PreviousTimeOf1 = 0;
                    counterOf1 = 1;
                    button1 = false;
                }

                return displayText;
            }


            // if button 2 is pressed it append "a","b","c","2" to the display text
            // depending on the number of time that button is pressed.
            else if (name == "Button_2")
            {
                button1 = false;
                button3 = false;
                button4 = false;
                button5 = false;
                button6 = false;
                button7 = false;
                button8 = false;
                button9 = false;

                button0 = false;
                int currentTime = Convert.ToInt32(DateTime.Now.ToString("hmmss"));


                if (PreviousTimeOf2 == 0 || button2 == false)
                {

                    PreviousTimeOf2 = currentTime;
                    displayText = displayText + "a";
                    button2 = true;


                }

                else if (currentTime - PreviousTimeOf2 < 2 && button2 == true)
                {
                    PreviousTimeOf2 = currentTime;
                    counterOf2 += 1;

                    if (counterOf2 % 4 == 1)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "a";
                    }
                    if (counterOf2 % 4 == 2)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "b";
                    }
                    if (counterOf2 % 4 == 3)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "c";
                    }
                    if (counterOf2 % 4 == 0)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "2";
                    }

                }
                int currentTime1 = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
                if (currentTime1 - PreviousTimeOf2 > 2)
                {
                    PreviousTimeOf2 = 0;
                    counterOf2 = 1;
                    button2 = false;

                }
                return displayText;
            }

            // if button 3 is pressed it append "d","e",f","3" to the display text
            // depending on the number of time that button is pressed.
            else if (name == "Button_3")
            {

                button1 = false;
                button2 = false;
                button4 = false;
                button5 = false;
                button6 = false;
                button7 = false;
                button8 = false;
                button9 = false;

                button0 = false;
                int currentTime = Convert.ToInt32(DateTime.Now.ToString("hmmss"));


                if (PreviousTimeOf3 == 0 || button3 == false)
                {

                    PreviousTimeOf3 = currentTime;
                    displayText = displayText + "d";
                    button3 = true;


                }

                else if (currentTime - PreviousTimeOf3 < 2 && button3 == true)
                {
                    PreviousTimeOf3 = currentTime;
                    counterOf3 += 1;

                    if (counterOf3 % 4 == 1)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "d";
                    }
                    if (counterOf3 % 4 == 2)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "e";
                    }
                    if (counterOf3 % 4 == 3)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "f";
                    }
                    if (counterOf3 % 4 == 0)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "3";
                    }

                }
                int currentTime1 = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
                if (currentTime1 - PreviousTimeOf3 > 2)
                {
                    PreviousTimeOf3 = 0;
                    counterOf3 = 1;
                    button3 = false;

                }
                return displayText;
            }

            // if button 4 is pressed it append "g","h","i","4" to the display text
            // depending on the number of time that button is pressed.
            else if (name == "Button_4")
            {

                button1 = false;
                button2 = false;
                button3 = false;
                button5 = false;
                button6 = false;
                button7 = false;
                button8 = false;
                button9 = false;

                button0 = false;
                int currentTime = Convert.ToInt32(DateTime.Now.ToString("hmmss"));


                if (PreviousTimeOf4 == 0 || button4 == false)
                {

                    PreviousTimeOf4 = currentTime;
                    displayText = displayText + "g";
                    button4 = true;


                }

                else if (currentTime - PreviousTimeOf4 < 2 && button4 == true)
                {
                    PreviousTimeOf4 = currentTime;
                    counterOf4 += 1;

                    if (counterOf4 % 4 == 1)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "g";
                    }
                    if (counterOf4 % 4 == 2)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "h";
                    }
                    if (counterOf4 % 4 == 3)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "i";
                    }
                    if (counterOf4 % 4 == 0)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "4";
                    }

                }
                int currentTime1 = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
                if (currentTime1 - PreviousTimeOf4 > 2)
                {
                    PreviousTimeOf4 = 0;
                    counterOf4 = 1;
                    button4 = false;

                }
                return displayText;
            }

            // if button 5 is pressed it append "j","k","l","5" to the display text
            // depending on the number of time that button is pressed.
            else if (name == "Button_5")
            {

                button1 = false;
                button2 = false;
                button4 = false;
                button3 = false;
                button6 = false;
                button7 = false;
                button8 = false;
                button9 = false;
                button0 = false;
                int currentTime = Convert.ToInt32(DateTime.Now.ToString("hmmss"));


                if (PreviousTimeOf5 == 0 || button5 == false)
                {

                    PreviousTimeOf5 = currentTime;
                    displayText = displayText + "j";
                    button5 = true;


                }

                else if (currentTime - PreviousTimeOf5 < 2 && button5 == true)
                {
                    PreviousTimeOf5 = currentTime;
                    counterOf5 += 1;

                    if (counterOf5 % 4 == 1)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "j";
                    }
                    if (counterOf5 % 4 == 2)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "k";
                    }
                    if (counterOf5 % 4 == 3)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "l";
                    }
                    if (counterOf5 % 4 == 0)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "5";
                    }

                }
                int currentTime1 = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
                if (currentTime1 - PreviousTimeOf5 > 2)
                {
                    PreviousTimeOf5 = 0;
                    counterOf5 = 1;
                    button5 = false;

                }
                return displayText;
            }

            // if button 6 is pressed it append "m","n","o","6" to the display text
            // depending on the number of time that button is pressed.
            else if (name == "Button_6")
            {

                button1 = false;
                button2 = false;
                button4 = false;
                button5 = false;
                button3 = false;
                button7 = false;
                button8 = false;
                button9 = false;

                button0 = false;
                int currentTime = Convert.ToInt32(DateTime.Now.ToString("hmmss"));


                if (PreviousTimeOf6 == 0 || button6 == false)
                {

                    PreviousTimeOf6 = currentTime;
                    displayText = displayText + "m";
                    button6 = true;


                }

                else if (currentTime - PreviousTimeOf6 < 2 && button6 == true)
                {
                    PreviousTimeOf6 = currentTime;
                    counterOf6 += 1;

                    if (counterOf6 % 4 == 1)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "m";
                    }
                    if (counterOf6 % 4 == 2)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "n";
                    }
                    if (counterOf6 % 4 == 3)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "o";
                    }
                    if (counterOf6 % 4 == 0)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "6";
                    }

                }
                int currentTime1 = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
                if (currentTime1 - PreviousTimeOf6 > 2)
                {
                    PreviousTimeOf6 = 0;
                    counterOf6 = 1;
                    button6 = false;

                }
                return displayText;
            }

            // if button 7 is pressed it append "p","q","r","s","7" to the display text
            // depending on the number of time that button is pressed.
            else if (name == "Button_7")
            {

                button1 = false;
                button2 = false;
                button4 = false;
                button5 = false;
                button6 = false;
                button3 = false;
                button8 = false;
                button9 = false;

                button0 = false;
                int currentTime = Convert.ToInt32(DateTime.Now.ToString("hmmss"));


                if (PreviousTimeOf7 == 0 || button7 == false)
                {

                    PreviousTimeOf7 = currentTime;
                    displayText = displayText + "p";
                    button7 = true;


                }

                else if (currentTime - PreviousTimeOf7 < 2 && button7 == true)
                {
                    PreviousTimeOf7 = currentTime;
                    counterOf7 += 1;

                    if (counterOf7 % 5 == 1)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "p";
                    }
                    if (counterOf7 % 5 == 2)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "q";
                    }
                    if (counterOf7 % 5 == 3)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "r";
                    }
                    if (counterOf7 % 5 == 4)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "s";
                    }
                    if (counterOf7 % 5 == 0)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "7";
                    }


                }
                int currentTime1 = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
                if (currentTime1 - PreviousTimeOf7 > 2)
                {
                    PreviousTimeOf7 = 0;
                    counterOf7 = 1;
                    button7 = false;

                }
                return displayText;
            }

            // if button 8 is pressed it append "t","u","v","8" to the display text
            // depending on the number of time that button is pressed.
            else if (name == "Button_8")
            {

                button1 = false;
                button2 = false;
                button4 = false;
                button5 = false;
                button3 = false;
                button7 = false;
                button6 = false;
                button9 = false;

                button0 = false;
                int currentTime = Convert.ToInt32(DateTime.Now.ToString("hmmss"));


                if (PreviousTimeOf8 == 0 || button8 == false)
                {

                    PreviousTimeOf8 = currentTime;
                    displayText = displayText + "t";
                    button8 = true;


                }

                else if (currentTime - PreviousTimeOf8 < 2 && button8 == true)
                {
                    PreviousTimeOf8 = currentTime;
                    counterOf8 += 1;

                    if (counterOf8 % 4 == 1)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "t";
                    }
                    if (counterOf8 % 4 == 2)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "u";
                    }
                    if (counterOf8 % 4 == 3)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "v";
                    }
                    if (counterOf8 % 4 == 0)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "8";
                    }

                }
                int currentTime1 = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
                if (currentTime1 - PreviousTimeOf8 > 2)
                {
                    PreviousTimeOf8 = 0;
                    counterOf8 = 1;
                    button8 = false;

                }
                return displayText;
            }

            // if button 9 is pressed it append "w","x","y","z","9" to the display text
            // depending on the number of time that button is pressed.
            else if (name == "Button_9")
            {

                button1 = false;
                button2 = false;
                button4 = false;
                button5 = false;
                button3 = false;
                button7 = false;
                button6 = false;
                button8 = false;

                button0 = false;
                int currentTime = Convert.ToInt32(DateTime.Now.ToString("hmmss"));


                if (PreviousTimeOf9 == 0 || button9 == false)
                {

                    PreviousTimeOf9 = currentTime;
                    displayText = displayText + "w";
                    button9 = true;


                }

                else if (currentTime - PreviousTimeOf9 < 2 && button9 == true)
                {
                    PreviousTimeOf9 = currentTime;
                    counterOf9 += 1;

                    if (counterOf9 % 5 == 1)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "w";
                    }
                    if (counterOf9 % 5 == 2)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "x";
                    }
                    if (counterOf9 % 5 == 3)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "y";
                    }
                    if (counterOf9 % 5 == 4)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "z";
                    }
                    if (counterOf9 % 5 == 0)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "9";
                    }

                }
                int currentTime1 = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
                if (currentTime1 - PreviousTimeOf9 > 2)
                {
                    PreviousTimeOf9 = 0;
                    counterOf9 = 1;
                    button9 = false;

                }
                return displayText;
            }

            // when star button is clicked it deletes the last charachter of the Display Text        
            else if (name == "Button_Star")
            {
                button1 = false;
                button2 = false;
                button3 = false;
                button4 = false;
                button5 = false;
                button6 = false;
                button7 = false;
                button8 = false;
                button9 = false;
                button0 = false;

                if (displayText.Length > 0)
                {
                    displayText = displayText.Remove((displayText.Length) - 1);
                    return displayText;
                }
                return displayText;

            }
            // if button 0 is pressed it append "~","0" to the display text
            // depending on the number of time that button is pressed.
            else if (name == "Button_0")
            {
                button1 = false;
                button2 = false;
                button3 = false;
                button4 = false;
                button5 = false;
                button6 = false;
                button7 = false;
                button8 = false;
                button9 = false;
                int currentTime = Convert.ToInt32(DateTime.Now.ToString("hmmss"));


                if (PreviousTimeOf0 == 0 || button0 == false)
                {
                    PreviousTimeOf0 = currentTime;
                    displayText = displayText + "0";
                    button0 = true;
                }

                else if (currentTime - PreviousTimeOf0 < 2 && button0 == true)
                {
                    PreviousTimeOf0 = currentTime;
                    counterOf0 += 1;

                    if (counterOf0 % 2 == 1)
                    {

                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "0";
                    }
                    if (counterOf0 % 2 == 0)
                    {
                        displayText = displayText.Remove(displayText.Length - 1);
                        displayText = displayText + "~";

                    }
                }
                int currentTime1 = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
                if (currentTime1 - PreviousTimeOf0 > 2)
                {
                    PreviousTimeOf0 = 0;
                    counterOf0 = 1;
                    button0 = false;
                }
                return displayText;
            }
            else
            {
                if (check == false)
                {
                    button1 = false;
                    button2 = false;
                    button3 = false;
                    button4 = false;
                    button5 = false;
                    button6 = false;
                    button7 = false;
                    button8 = false;
                    button9 = false;

                    button0 = false;

                    displayText = displayText + " ";
                }
                return displayText;

            }

        }
    }
}
