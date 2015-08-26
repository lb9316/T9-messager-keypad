/**
 * ******************************************************************************************************************
 * FileName		: ControllerPred.cs
 * 
 * Description	: This is the controller end of the code where it decides whether to call the PredMode class or the 
 *                NonPredMode class depending on the action on checkbox.
 *                
 * 
 * @version		:  ControllerPred.cs v 1.0	2015/11/03 5:15 PM
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
    class ControllerPred
    {
        // check becomes true when checkbox is checked. 
        bool check = false;

        // creates object of NonPredMode class
        NonPredMode nonpred = new NonPredMode();

        // creates object of PredMode class
        PredMode predmode = new PredMode();
        
        // list stores all the predicted words
        static List<String> list = new List<string>();
      
        /// <summary>
        /// When the checkbox is checked this method is called
        /// </summary>
        public void IfChecked()
        {
            check = true;
        }

        /// <summary>
        /// Whent the checkbox is unchecked this method is called
        /// </summary>
        public void IfNotChecked()
        {
            check = false;
        }
        /// <summary>
        /// Get values for the textblock from the PredMode or NonPredMode class
        /// </summary>
        /// <param name="name"> name of the button</param>
        /// <param name="displayText"> Display Text</param>
        /// <returns> returns updated display string</returns>
        public String getValues(String name, String displayText)
        {
            // if checkbox is not checked then NonPredMode class is called 
            if (check == false)
            {
                String disp = nonpred.doWork(name, displayText);
                return disp;
            }
            // if checkbox is  checked then PredMode class is called 
            else
            {
                String disp = predmode.prediction(name, displayText);
                list = predmode.getList();
                return disp;

            }
        }
        /// <summary>
        /// returns list
        /// </summary>
        /// <returns> list of predicted words</returns>
        public List<String> getList()
        {
            return list;
        }

    }
}
