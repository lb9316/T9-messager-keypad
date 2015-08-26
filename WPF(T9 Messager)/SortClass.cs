/**
 * ******************************************************************************************************************
 * FileName		: SortClass.cs
 * 
 * Description	: This is the model end of the code where it  sorts the List by the length of the elements
 *                in it.
 *                
 * @version		: SortClass.cs v 1.0	2015/11/03 5:15 PM
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
    class SortClass : IComparer<string>
    {
        /// <summary>
        /// Sort with respect to length of string.
        /// </summary>
        /// <param name="x"> 1st string</param>
        /// <param name="y"> 2nd string</param>
        /// <returns></returns>
        public int Compare(string x, string y)
        {
            if (x.Length > y.Length) return 1;
            else if (x.Length < y.Length) return -1;
            else return 0;
        }

    }
}
