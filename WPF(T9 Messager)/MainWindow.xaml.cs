/**
 * ******************************************************************************************************************
 * FileName		: MainWindow.xaml.cs
 * 
 * Description	: This is the view end of the code where it calls the controller on any button click.
 *                This class is responsible for displaying the text and handling the lables for predictive mode.               
 * 
 * @version		:  MainWindow.xaml.cs v 1.0	2015/10/03 10:15 PM
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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_T9_Messager_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        /// <summary>
        /// check if the predictive mode is ON or OFF
        /// </summary>
        bool check = false;

        /// <summary>
        /// Creats the oblect of dictModel class
        /// </summary>
        dictModel dict = new dictModel();

        /// <summary>
        /// resultArray stores all the predictive words 
        /// </summary>
        static List<String> resultArray = new List<String>();


        /// <summary>
        /// creats object of ControllerPred class
        /// </summary>
        ControllerPred conpred = new ControllerPred();


        /// <summary>
        /// Constructor calls method InitializeComponents to initialize 
        /// all the components of the window. It all calls the ConnectDataBase method
        /// of dictModel class where the dictionary is initialized
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            dict.ConnectDataBase();

        }

        /// <summary>
        /// This method is called whenever any button is pressd on the window.
        /// </summary>
        /// <param name="sender"> this decides which button is pressed </param>
        /// <param name="e">Initializes a new instance of the RoutedEventArgs class.</param>
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            // displayText is the text which is in the Main Display
            String displaytext = Display.Text;
            
            // buttonSelect is a button which is been pressed 
            Button buttonSelect = (Button)sender;

            // name of the button
            String name = buttonSelect.Name;

            // calls the getValues() method which returns updated Main Display
            Display.Text = conpred.getValues(name, displaytext);

            // if predictive mode is ON
            if (check == true)
            {
                // calls getList() method which returns updated List
                resultArray = conpred.getList();

                
                if (resultArray.Count > 0)
                {
                    // display
                    if (resultArray.Count >= 6)
                    {

                        Pred4.Content = Convert.ToString(resultArray[3]);
                        Pred1.Content = Convert.ToString(resultArray[0]);
                        Pred2.Content = Convert.ToString(resultArray[1]);
                        Pred3.Content = Convert.ToString(resultArray[2]);
                        Pred5.Content = Convert.ToString(resultArray[4]);
                        Pred6.Content = Convert.ToString(resultArray[5]);


                    }

                    else if (resultArray.Count == 5)
                    {
                        Pred4.Content = Convert.ToString(resultArray[3]);
                        Pred1.Content = Convert.ToString(resultArray[0]);
                        Pred2.Content = Convert.ToString(resultArray[1]);
                        Pred3.Content = Convert.ToString(resultArray[2]);
                        Pred5.Content = Convert.ToString(resultArray[4]);
                        Pred6.Content = "-";
                    }

                    else if (resultArray.Count == 4)
                    {
                        Pred4.Content = Convert.ToString(resultArray[3]);
                        Pred1.Content = Convert.ToString(resultArray[0]);
                        Pred2.Content = Convert.ToString(resultArray[1]);
                        Pred3.Content = Convert.ToString(resultArray[2]);
                        Pred5.Content = "-";
                        Pred6.Content = "-";
                    }

                    else if (resultArray.Count == 3)
                    {
                        Pred1.Content = Convert.ToString(resultArray[0]);
                        Pred2.Content = Convert.ToString(resultArray[1]);
                        Pred3.Content = Convert.ToString(resultArray[2]);
                        Pred4.Content = "-";
                        Pred5.Content = "-";
                        Pred5.Content = "-";
                    }

                    else if (resultArray.Count == 2)
                    {
                        Pred1.Content = Convert.ToString(resultArray[0]);
                        Pred2.Content = Convert.ToString(resultArray[1]);
                        Pred3.Content = "-";
                        Pred4.Content = "-";
                        Pred5.Content = "-";
                        Pred6.Content = "-";
                    }


                    if (resultArray.Count == 1)
                    {
                        Pred1.Content = Convert.ToString(resultArray[0]);
                        Pred2.Content = "-";
                        Pred3.Content = "-";
                        Pred4.Content = "-";
                        Pred5.Content = "-";
                        Pred6.Content = "-";
                    }

                }
                else
                {
                    Pred1.Content = "-";
                    Pred2.Content = "-";
                    Pred3.Content = "-";
                    Pred4.Content = "-";
                    Pred5.Content = "-";
                    Pred6.Content = "-";
                }

            }

        }
        private void PredMode_Checked_1(object sender, RoutedEventArgs e)
        {
            check = true;
            conpred.IfChecked();

        }
        private void PredMode_UnChecked_1(object sender, RoutedEventArgs e)
        {
            check = false;
            Pred1.Content = "";
            Pred2.Content = "";
            Pred3.Content = "";
            Pred4.Content = "";
            Pred5.Content = "";
            Pred6.Content = "";
            conpred.IfNotChecked();

        }

    }
}