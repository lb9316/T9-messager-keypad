/**
 * ******************************************************************************************************************
 * FileName		: dictMode.cs
 * 
 * Description	: This is the model end of the code where it reads each word from the EnglishWords.txt file
 *                and convert it to its numerical value related to the T9 Keypad and store it to SortedDictionary data structure
 *                
 * 
 * @version		:  dictMode.cs v 1.0	2015/11/03 5:15 PM
 *  
 * @author 		: lb9316 (Lakhan Bhojwani)
 * 
 * Revisions 	: Initial revision.
 * *******************************************************************************************************************
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WPF_T9_Messager_
{

    class dictModel
    {
        // dictionary stores data in the key value pair where key will be words and value will be its numeric conversion.
        static SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();

        // take stores the predicted words
        static List<String> take = new List<String>();
       
        public void ConnectDataBase()
        {
            // reads text file
            StreamReader myReader = new StreamReader("EnglishWords.txt");
            string line = "";

            // reads line by line of text file
            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                {

                    // converts string to lower case
                    string result = line.ToLower();

                    // all numbers are replace by empty character
                    result = Regex.Replace(result, "[2-9]", string.Empty);

                    // character a, b, c are replaced by 2 
                    result = Regex.Replace(result, "[abc]", "2");

                    // character d,e,f are replaced by 3
                    result = Regex.Replace(result, "[def]", "3");

                    // character g,h,i are replaced by 4
                    result = Regex.Replace(result, "[ghi]", "4");

                    // character j,k,l are replaced by 5
                    result = Regex.Replace(result, "[jkl]", "5");

                    // character m,n,o are replaced by 6
                    result = Regex.Replace(result, "[mno]", "6");

                    // character p,q,r,s are replaced by 7
                    result = Regex.Replace(result, "[pqrs]", "7");

                    // character t,u,v are replaced by 8
                    result = Regex.Replace(result, "[tuv]", "8");

                    // character w,x,y,z are replaced by 9
                    result = Regex.Replace(result, "[wxyz]", "9");

                    
                    result = Regex.Replace(result, "[^2-9]", " ");

                    
                    dictionary[line] = result;
                }


            }
            myReader.Close();

        }
        /// <summary>
        /// This method reads the text which is inserted by user and returs list of words which are related to
        /// that word.
        /// </summary>
        /// <param name="display"> Display text</param>
        /// <returns> returns list of predicted words</returns>
        public List<String> getTableValue(string display)
        {
            take.Clear();
            foreach (KeyValuePair<string, string> entry in dictionary)
            {

                string t = Convert.ToString(entry.Value);

                if (t.Length == display.Length)
                {
                    bool test1 = t.Equals(display);
                    if (test1 == true)
                    {
                        take.Add(Convert.ToString(entry.Key));
                    }
                }


                else if (t.Length > display.Length)
                {
                    bool test1 = t.Substring(0, display.Length).Equals(display);
                    if (test1 == true)
                    {
                        take.Add(Convert.ToString(entry.Key));
                    }
                }
            }
            return take;
        }
    }

}