/**
 * ******************************************************************************************************************
 * FileName		: PredMode.cs
 * 
 * Description	: This is the model end of the code where words are predicted.
 *              
 * @version		:  PredMode.cs v 1.0	2015/11/03 8:00 PM
 *  
 * @author 		: lb9316 (Lakhan Bhojwani)
 * 
 * Revisions 	: Initial revision.
 * *******************************************************************************************************************
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_T9_Messager_
{
    class PredMode
    {
        // which word from the list is to be displayed on the TextBlock
        static int wordCounter = 0;
        // stores the button number when pressed.
        static String letters = "";
        // list to store the predicted words
        static List<String> resultArray = new List<String>();
        static bool star = false;
        bool space = false;
        static ArrayList PreviousPred = new ArrayList();

        dictModel dict = new dictModel();

        /// <summary>
        /// predicts the word related to the button pressed.
        /// </summary>
        /// <param name="name"> name of the button</param>
        /// <param name="displayText"> display text </param>
        /// <returns></returns>
        public String prediction(String name, String displayText)
        {
            // when hash button is pressed it adds space to the text
            if (name == "Button_hash")
            {

                displayText = displayText + " ";
                letters = "";
                space = true;
                resultArray.Clear();
                return displayText;

            }
            else
            {


                if (name == "Button_1")
                {

                }
                //if button 2 is pressed words related to it are predicted 
                else if (name == "Button_2")
                {
                    space = false;
                    wordCounter = 0;
                    resultArray.Clear();
                    letters = letters + "2";
                    resultArray = dict.getTableValue(letters);


                }
                //if button 3 is pressed words related to it are predicted
                else if (name == "Button_3")
                {
                    space = false;
                    wordCounter = 0;
                    resultArray.Clear();
                    letters = letters + "3";
                    resultArray = dict.getTableValue(letters);

                }
                //if button 4 is pressed words related to it are predicted
                else if (name == "Button_4")
                {
                    space = false;
                    wordCounter = 0;
                    resultArray.Clear();
                    letters = letters + "4";
                    resultArray = dict.getTableValue(letters);

                }
                //if button 5 is pressed words related to it are predicted
                else if (name == "Button_5")
                {
                    space = false;
                    wordCounter = 0;
                    resultArray.Clear();
                    letters = letters + "5";
                    resultArray = dict.getTableValue(letters);


                }
                //if button 6 is pressed words related to it are predicted
                else if (name == "Button_6")
                {
                    space = false;
                    wordCounter = 0;
                    resultArray.Clear();
                    letters = letters + "6";
                    resultArray = dict.getTableValue(letters);

                }
                //if button 7 is pressed words related to it are predicted
                else if (name == "Button_7")
                {
                    space = false;
                    wordCounter = 0;
                    resultArray.Clear();
                    letters = letters + "7";
                    resultArray = dict.getTableValue(letters);


                }
                //if button 8 is pressed words related to it are predicted
                else if (name == "Button_8")
                {
                    space = false;
                    wordCounter = 0;
                    resultArray.Clear();
                    letters = letters + "8";
                    resultArray = dict.getTableValue(letters);

                }
                //if button 9 is pressed words related to it are predicted
                else if (name == "Button_9")
                {
                    space = false;
                    wordCounter = 0;
                    resultArray.Clear();
                    letters = letters + "9";
                    resultArray = dict.getTableValue(letters);

                }
                //if button star is pressed it removes the last character from the 
               // string and then predict from the remaining words.
              // if the last character is space then the last word is deleted if this 
             // button is pressed. 


                else if (name == "Button_Star")
                {
                    char[] charr = displayText.ToCharArray();
                    int result = Array.LastIndexOf(charr, ' ');
                    string newDisplay = "";
                    wordCounter = 0;
                    resultArray.Clear();

                    if (result == charr.Length - 1 && space == true)
                    {
                        string[] arr = displayText.Split(' ');
                        int n = arr[arr.Length - 2].Length;
                        newDisplay = "";
                        for (int i = 0; i < ((arr.Length) - 2); i++)
                            newDisplay = newDisplay + arr[i] + " ";
                        resultArray.Clear();
                        displayText = newDisplay;
                        letters = "";
                        space = false;
                        return displayText;



                    }

                    else if (displayText.Length > 0)
                    {
                        if (letters.Length > 0)
                        {
                            letters = letters.Remove(letters.Length - 1);
                        }

                        displayText = displayText.Remove(displayText.Length - 1);

                        if (letters.Length == 0)
                        {
                            return displayText;
                        }
                        else
                        {


                            resultArray = dict.getTableValue(letters);
                            resultArray.Sort(new SortClass());


                            if (displayText.Length == 0)
                            {
                                if (wordCounter < resultArray.Count)
                                {
                                    displayText = displayText + Convert.ToString(resultArray[wordCounter]);
                                    return displayText;
                                }
                                else
                                {
                                    displayText = "";
                                    for (int i = 0; i < letters.Length; i++)
                                    {
                                        displayText = displayText + "-";
                                    }
                                    return displayText;
                                }

                            }
                            else
                            {
                                string[] arr = displayText.Split(' ');
                                int n = arr[arr.Length - 1].Length;

                                for (int i = 0; i < n; i++)
                                    displayText = displayText.Remove((displayText.Length) - 1);



                                if (resultArray.Count > 0)
                                {
                                    if (wordCounter < resultArray.Count)
                                    {
                                        displayText = displayText + Convert.ToString(resultArray[wordCounter]);
                                        return displayText;

                                    }
                                    else
                                    {
                                        for (int i = 0; i < letters.Length; i++)
                                        {
                                            displayText = displayText + "-";
                                        }
                                        return displayText;

                                    }

                                }
                                else
                                {
                                    for (int i = 0; i < letters.Length; i++)
                                    {
                                        displayText = displayText + "-";
                                    }
                                    return displayText;
                                }

                            }
                        }
                    }
                }
                // if button 0 is pressed then the 1st element of the list is removed
                else if (name == "Button_0")
                {
                    if (resultArray.Count > 0)
                        resultArray.RemoveAt(0);
                    
                }

                if (star == true)
                {
                    star = false;

                    return displayText;
                }
                else
                {
                    // sorts according to the length of the string inside the list
                    resultArray.Sort(new SortClass());




                    if (displayText.Length == 0)
                    {
                        if (wordCounter < resultArray.Count)
                        {
                            displayText = displayText + Convert.ToString(resultArray[wordCounter]);
                            return displayText;
                        }
                        else
                        {
                            displayText = "";
                            for (int i = 0; i < letters.Length; i++)
                            {
                                displayText = displayText + "-";
                            }
                            return displayText;
                        }

                    }
                    else
                    {
                        string[] arr = displayText.Split(' ');
                        int n = arr[arr.Length - 1].Length;

                        for (int i = 0; i < n; i++)
                            displayText = displayText.Remove((displayText.Length) - 1);



                        if (resultArray.Count > 0)
                        {
                            if (wordCounter < resultArray.Count)
                            {
                                displayText = displayText + Convert.ToString(resultArray[wordCounter]);
                                return displayText;

                            }
                            else
                            {
                                for (int i = 0; i < letters.Length; i++)
                                {
                                    displayText = displayText + "-";
                                }
                                return displayText;

                            }

                        }
                        else
                        {
                            for (int i = 0; i < letters.Length; i++)
                            {
                                displayText = displayText + "-";
                            }
                            return displayText;
                        }

                    }

                }


            }

        }
        /// <summary>
        /// returns the list of predicted words.
        /// </summary>
        /// <returns></returns>
        public List<String> getList()
        {
            return resultArray;
        }

    }
}