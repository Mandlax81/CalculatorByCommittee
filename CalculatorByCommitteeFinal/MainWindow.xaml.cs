using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using System.Windows.Forms;
using static SimpleClass;//need to import classes to use them here
using static Programmer;
using static Scientific;
using static VelocityConversion;
using static EnergyConversion;

namespace CalculatorByCommitteeFinal
{
    public partial class MainWindow : Window //SUPPOSED TO BE 'Form' HERE, BUT SIMPLY DOESN'T WORK? ANSWER: FORM IS NOT SUPPORTED IN A WPF PROJECT, WHICH IS WHY IS ISN'T AUTOMATICALLY IMPORTED
    {
        //Create the dictionary and allow it to be used by anyone.
        Dictionary<string, string> DisplayToFuncName = new Dictionary<string, string>();//creates dictonary with two strings, ones the term and the key to access i 
        //Dictionary to be used with the drop-down conversion forms?
        public MainWindow()
        {
            //Add conversions from the displayed name to make it match with the function name.
            //Also validates input, if it is not in the dictionary, it is not expected.
            DisplayToFuncName.Add("British Thermal Unit (BTU)", "BTU");//term, key
            DisplayToFuncName.Add("Calorie", "Calorie");
            DisplayToFuncName.Add("Inch-Pound", "InchPound");
            DisplayToFuncName.Add("Foot-Pound", "FootPound");
            DisplayToFuncName.Add("Newton Meters", "NewtonMeter");
            DisplayToFuncName.Add("Electron-Volt", "ElectronVolt");
            DisplayToFuncName.Add("Kilometers per hour", "KmPerHour");
            DisplayToFuncName.Add("Centimeters per second", "CentimetersPerSec");
            DisplayToFuncName.Add("Feet per second", "FeetPerSec");
            DisplayToFuncName.Add("MACH (at std. atm)", "MACH");
            DisplayToFuncName.Add("Miles per hour", "MPH");
            DisplayToFuncName.Add("Hexadecimal", "Hex");
            DisplayToFuncName.Add("Decimal", "Decimal");
            DisplayToFuncName.Add("Octal", "Octal");
            DisplayToFuncName.Add("Binary", "Binary");

            InitializeComponent();
        }

        /* Thank Steve Janusz for this elegant way to call the right method
from a dropdown! */
        private void conversionEnergyButton_Click(object sender, EventArgs e)
        {
            string from, to;
            try
            {
                //Get 'to' and 'from' from the dictionary.
                from = DisplayToFuncName[fromComboBoxConversionEnergy.Text];//grabbing text from the combo box, and seeing if in dictionary, and stores the key in the from
                to = DisplayToFuncName[toComboBoxConversionEnergy.Text];//same as above
            }
            catch (System.Collections.Generic.KeyNotFoundException)//if selected an object that didn't exist, put in third text box down
            {
                //Unit was not in the dictionary, so it is not valid.
                resultsTextBox.Text = "Invalid item in from or to unit.";
                return;
            }

            //Parse the input into a double.
            double numToConvert;
            bool successfulParse = Double.TryParse(firstNumberTextBox.Text, out numToConvert);

            //Input number is valid and from and to are not blank.
            if (from != "" && to != "" && successfulParse)//as long as the combobox value for both from and to is not empty and we can successfully convert to a double, do the following... 
            {
                //If to and from unit are the same, answer = input.
                if (from == to)
                {
                    resultsTextBox.Text = firstNumberTextBox.Text;
                }
                else
                {
                    //Create the method name for this conversion.
                    string methodName = $"convert{from}To{to}";

                    //Get the type and then the method for this conversion.
                    Type thisType = Type.GetType("EnergyConversion");//contextually selects the right type of conversion
                    MethodInfo theMethod = thisType.GetMethod(methodName);

                    //The method exists, so run it.
                    if (theMethod != null)
                    {
                        resultsTextBox.Text = theMethod.Invoke(this, new object[] { numToConvert }).ToString();
                    }
                    //The method did not exist.
                    else
                    {
                        resultsTextBox.Text = methodName + " Conversion not implemented.";
                    }
                }
            }
            //Not a valid double in the input.
            else if (successfulParse == false)
            {
                resultsTextBox.Text = "The number entered is invalid.";
            }
            //To or from were blank.
            else
            {
                resultsTextBox.Text = "Two units need to be selected.";
            }
        }

        /* Thank Steve Janusz for this elegant way to call the right method
        from a dropdown! */

        private void conversionVelocityButton_Click(object sender, EventArgs e)
        {
            string from, to;
            try
            {
                //Get 'to' and 'from' from the dictionary.
                from = DisplayToFuncName[fromComboBoxConversionVelocity.Text];
                to = DisplayToFuncName[toComboBoxConversionVelocity.Text];
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                //Unit was not in the dictionary, so it is not valid.
                resultsTextBox.Text = "Invalid item in from or to unit.";
                return;
            }

            //Parse the input into a double.
            double numToConvert;
            bool successfulParse = Double.TryParse(firstNumberTextBox.Text, out numToConvert);

            //Input number is valid and from and to are not blank.
            if (from != "" & to != "" & successfulParse)
            {
                //If to and from unit are the same, answer = input.
                if (from == to)
                {
                    resultsTextBox.Text = firstNumberTextBox.Text;
                }
                else
                {
                    //Create the method name for this conversion.
                    string methodName = $"convert{from}To{to}";

                    //Get the type and then the method for this conversion.
                    Type thisType = Type.GetType("VelocityConversion");
                    MethodInfo theMethod = thisType.GetMethod(methodName);

                    //The method exists, so run it.
                    if (theMethod != null)
                    {
                        resultsTextBox.Text = theMethod.Invoke(this, new object[] { numToConvert }).ToString();
                    }
                    //The method did not exist.
                    else
                    {
                        resultsTextBox.Text = methodName + " Conversion not implemented.";
                    }
                }
            }
            //Not a valid double in the input.
            else if (successfulParse == false)
            {
                resultsTextBox.Text = "The number entered is invalid.";
            }
            //To or from were blank.
            else
            {
                resultsTextBox.Text = "Two units need to be selected.";
            }
        }

        /* Thank Steve Janusz for this elegant way to call the right method
        from a dropdown! */

        private void programmerConversionButton_Click(object sender, EventArgs e)
        {
            string from, to;
            try
            {
                //Get 'to' and 'from' from the dictionary.
                from = DisplayToFuncName[fromProgrammerConversion.Text];
                to = DisplayToFuncName[toProgrammerConversion.Text];
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                //Unit was not in the dictionary, so it is not valid.
                resultsTextBox.Text = "Invalid item in from or to unit.";
                return;
            }

            //Parse the input into a string.
            String stringToConvert = firstNumberTextBox.Text;

            //Input number is valid and from and to are not blank.
            if (from != "" & to != "" & stringToConvert != "")
            {
                //If to and from unit are the same, answer = input.
                if (from == to)
                {
                    resultsTextBox.Text = firstNumberTextBox.Text;
                }
                else
                {
                    //Create the method name for this conversion.
                    string methodName = $"convert{from}To{to}";

                    //Get the type and then the method for this conversion.
                    Type thisType = Type.GetType("Programmer");
                    MethodInfo theMethod = thisType.GetMethod(methodName);

                    //The method exists, so run it.
                    if (theMethod != null)
                    {
                        resultsTextBox.Text = theMethod.Invoke(this, new object[] { stringToConvert }).ToString();

                    }
                    //The method did not exist.
                    else
                    {
                        resultsTextBox.Text = methodName + " Conversion not implemented.";
                    }
                }
            }
            //To or from were blank.
            else
            {
                resultsTextBox.Text = "Two units need to be selected.";
            }
        }

        //Event handlers used for all pages
        private void clearButton_Click(object sender, RoutedEventArgs e)//clears the button within all pages
        {
            firstNumberTextBox.Text = "";
            secondNumbertextBox.Text = "";
            resultsTextBox.Text = "";
        }
        private void resultsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        //All event handlers for Add page
        private void plusButton_Click(object sender, RoutedEventArgs e)//takes from the object sender (the button that was clicked), routes the information appropriately?
        {
            double dblFirstNumber, dblSecondNumber, dblResults = 0.0;//creates variables to store the two numbers and their results, sets them initially equal to 0.0
            Double.TryParse(firstNumberTextBox.Text, out dblFirstNumber);//takes the first number and parses/converts it out as a double
            Double.TryParse(secondNumbertextBox.Text, out dblSecondNumber);//takes the second number and parses/converts it out as a double
            dblResults = addNumbers(dblFirstNumber, dblSecondNumber);//calls the addNumbs method from SimpleCLass class, passing the users first and second numbers, stores it in dblResults
            resultsTextBox.Text = dblResults.ToString();//takes the stored results, converts it to a string, and represents the result in the resultsTextBox as text
        }
        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            double dblFirstNumber, dblSecondNumber, dblResults = 0.0;
            Double.TryParse(firstNumberTextBox.Text, out dblFirstNumber);
            Double.TryParse(secondNumbertextBox.Text, out dblSecondNumber);
            dblResults = subtractNumbers(dblFirstNumber, dblSecondNumber);
            resultsTextBox.Text = subtractNumbers(dblFirstNumber, dblSecondNumber).ToString();
        }
        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            double dblFirstNumber, dblSecondNumber, dblResults = 0.0;
            Double.TryParse(firstNumberTextBox.Text, out dblFirstNumber);
            Double.TryParse(secondNumbertextBox.Text, out dblSecondNumber);
            dblResults = multiplyNumbers(dblFirstNumber, dblSecondNumber);
            resultsTextBox.Text = multiplyNumbers(dblFirstNumber, dblSecondNumber).ToString();
        }
        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            double dblFirstNumber, dblSecondNumber, dblResults = 0.0;
            Double.TryParse(firstNumberTextBox.Text, out dblFirstNumber);
            Double.TryParse(secondNumbertextBox.Text, out dblSecondNumber);
            dblResults = divideNumbers(dblFirstNumber, dblSecondNumber);
            resultsTextBox.Text = divideNumbers(dblFirstNumber, dblSecondNumber).ToString();
        }


        //All event handlers for Programmer page:

        private void plusHexadecimal_Click(object sender, RoutedEventArgs e)
        {
            // Author: Alexander Ihle
            // Date: 11/02/2016

            string number1 = firstNumberTextBox.Text;
            string number2 = secondNumbertextBox.Text;
            string number3 = AddHexa(number1, number2);

            if (number3 == "Error: Hexadecimals Only")
            {

                System.Windows.MessageBox.Show("Please only enter hexadecimal values!", "Error");

            }
            else if (number3 == "Error: Those values are too large.")
            {

                System.Windows.MessageBox.Show("Please use smaller values.", "Error");

            }
            else
            {

                resultsTextBox.Text = number3;

            }

        }

        private void minusHexadecimal_Click(object sender, RoutedEventArgs e)
        {
            // Author: Alexander Ihle
            // Date: 11/02/2016

            string number1 = firstNumberTextBox.Text;
            string number2 = secondNumbertextBox.Text;
            string number3 = SubtractHexa(number1, number2);

            if (number3 == "Error: Hexadecimals Only")
            {

                System.Windows.MessageBox.Show("Please only enter hexadecimal values!", "Error");

            }
            else if (number3 == "Error: Those values are too large.")
            {

                System.Windows.MessageBox.Show("Please use smaller values.", "Error");

            }
            else
            {

                resultsTextBox.Text = number3;

            }

        }

        private void multiplyHexadecimal_Click(object sender, RoutedEventArgs e)
        {
            // Author: Alexander Ihle
            // Date: 11/02/2016

            string number1 = firstNumberTextBox.Text;
            string number2 = secondNumbertextBox.Text;
            string number3 = MultiplyHexa(number1, number2);

            if (number3 == "Error: Hexadecimals Only")
            {

                System.Windows.MessageBox.Show("Please only enter hexadecimal values!", "Error");

            }
            else if (number3 == "Error: Those values are too large.")
            {

                System.Windows.MessageBox.Show("Please use smaller values.", "Error");

            }
            else
            {

                resultsTextBox.Text = number3;

            }

        }

        private void divideHexadecimal_Click(object sender, RoutedEventArgs e)
        {
            //NOT COMPLETED!

        }

        private void plusOctal_Click(object sender, RoutedEventArgs e)
        {
            //NOT COMPLETED!
        }

        private void minusOctal_Click(object sender, RoutedEventArgs e)
        {
            resultsTextBox.Text = subtractOctals(firstNumberTextBox.Text, secondNumbertextBox.Text);

        }

        private void multiplyOctal_Click(object sender, RoutedEventArgs e)
        {
            resultsTextBox.Text = multiplyOctals(firstNumberTextBox.Text, secondNumbertextBox.Text);
        }

        private void divideOctal_Click(object sender, RoutedEventArgs e)
        {
            resultsTextBox.Text = divideOctals(firstNumberTextBox.ToString(), secondNumbertextBox.ToString());
        }


        //Enumerated list 1(title and index mapping): Exception name 0, Exception name 1, Exception name 2
        public enum exceptionTitles
        {
            tooLarge42 = 0,//keeps the index-value at a standard definition
            nullValue42 = 1,
            defaultError42 = 2
        }
        private void plusBinary_Click(object sender, RoutedEventArgs e)
        {
            string n = firstNumberTextBox.Text;//stores the first number received from text box
            string m = secondNumbertextBox.Text; //stores the second number received from text box
            string o = addBinary(n, m);//calls the addBinary method, passing n and m. Stores the result in o

            bool validInput = true;

            //This checks to see if the first number is either a 0 or a 1
            if (validInput)
            {
                foreach (char character in n)
                {
                    if (character != '0' && character != '1')
                    {
                        System.Windows.MessageBox.Show("Only enter binary values!", "Error: First Number");
                        validInput = false;
                        break;
                    }
                }
            }

            //This checks to see if the second number is either a 0 or a 1
            if (validInput)
            {
                foreach (char character in m)
                {
                    if (character != '0' && character != '1')
                    {
                        System.Windows.MessageBox.Show("Only enter binary values!", "Error: Second Number");
                        break;
                    }
                }
            }            

            if (o == "Error. Those values are too large.")
            {
                //Array 1(exception unique identifier): 00 for exception 0, 11 for exception 1, 22 for exception 2
                string[] identifierException = new string[1];
                identifierException[0] = "Too Large";

                //Array 2 (description): description of exception 0, description of exception 1, description of exception 2 
                //Value must be 0, Value must be 1, Value must not be less than 0
                string[] descriptionException = new string[1];
                descriptionException[0] = "Error. Value must be smaller.";
                string[] Names = Enum.GetNames(typeof(exceptionTitles));//this gets the string type of the enum, which is in array format (i.e. Che, Castro, Spartacus)

                for (int i = 0; i < identifierException.Length; i++)//loop through arrays, need to make sure number of indexes match
                {//prints out a concatenated identifier name and related description
                    System.Windows.MessageBox.Show((i + 1) + ". " + "Title: " + Names[0] + "." + "\nIdentifier: " + identifierException[i] + "\nDescription: " + descriptionException[i]);
                }
            }
            else if (o == "Error. Default.")
            {
                //Array 1(exception unique identifier): 00 for exception 0, 11 for exception 1, 22 for exception 2
                string[] identifierException = new string[1];
                identifierException[0] = "Error. Default.";

                //Array 2 (description): description of exception 0, description of exception 1, description of exception 2 
                //Value must be 0, Value must be 1, Value must not be less than 0
                string[] descriptionException = new string[1];
                descriptionException[0] = "Error. This is a general error statement. Please research the issue further";
                string[] Names = Enum.GetNames(typeof(exceptionTitles));//this gets the string type of the enum, which is in array format (i.e. Che, Castro, Spartacus)

                for (int i = 0; i < identifierException.Length; i++)//loop through arrays, need to make sure number of indexes match
                {//prints out a concatenated identifier name and related description
                    System.Windows.MessageBox.Show((i + 1) + ". " + "Title: " + Names[2] + "." + "\nIdentifier: " + identifierException[i] + "\nDescription: " + descriptionException[i]);
                }
            }
            else
            {
                resultsTextBox.Text = o;
            }
        }






        private void minusBinary_Click(object sender, RoutedEventArgs e)
        {

            string n = firstNumberTextBox.Text;//stores the first number received from text box
            string m = secondNumbertextBox.Text; //stores the second number received from text box
            string o = subtractBinary(n, m);//calls the addBinary method, passing n and m. Stores the result in o
            
            //This checks the initial input of the two values
            foreach (char character in n)
            {
                if (character != '0' && character != '1')
                {
                    System.Windows.MessageBox.Show("Only enter binary values!", "Error: First Number");
                    break;
                }
            }           
            //This checks the initial input of the two values
            foreach (char character in m)
            {
                if (character != '0' && character != '1')
                {
                    System.Windows.MessageBox.Show("Only enter binary values!", "Error: Second Number");
                    break;
                }
            }

            //this if/else statement collects the returned strings from the Programmer class, and creates a pop-up box as well
            if (o == "Error: Those values are too large.")
            {
                System.Windows.MessageBox.Show("Please enter smaller values!", "Error");                
            }
            else
            {
                resultsTextBox.Text = o;
            }

        }
        private void multiplyBinary_Click(object sender, RoutedEventArgs e)
        {
            string n = firstNumberTextBox.Text;//stores the first number received from text box
            string m = secondNumbertextBox.Text; //stores the second number received from text box
            string o = multiplyBinary(n, m);//calls the addBinary method, passing n and m. Stores the result in o
            

            //This checks the initial input of the two values
            foreach (char character in n)
            {
                if (character != '0' && character != '1')
                {
                    System.Windows.MessageBox.Show("Only enter binary values!", "Error: First Number");
                    break;
                }
            }  
            //This checks the initial input of the two values
            foreach (char character in m)
            {
                if (character != '0' && character != '1')
                {
                    System.Windows.MessageBox.Show("Only enter binary values!", "Error: Second Number");
                    break;
                }
            }
            //this if/else statement collects the returned strings from the Programmer class, and creates a pop-up box as well
            if (o == "Error: Those values are too large.")
            {

                System.Windows.MessageBox.Show("Please enter smaller values!", "Error");
            }
            else
            {
                resultsTextBox.Text = o;
            }
        }


        //All event handlers used with Scientific Class
        private void squareRootButton_Click(object sender, RoutedEventArgs e)
        {
            // Call the SquareRoot Function
            double dblFirstNumber, dblResults = 0.0;
            Double.TryParse(firstNumberTextBox.Text, out dblFirstNumber);
            dblResults = squareRoot(dblFirstNumber);
            resultsTextBox.Text = squareRoot(dblFirstNumber).ToString();

        }
        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            // NOT COMPLETED! call the log function
        }
        private void cubeRootButton_Click(object sender, RoutedEventArgs e)
        {
            // call the Cube Root function
            double dblFirstNumber, dblResults = 0.0;
            Double.TryParse(firstNumberTextBox.Text, out dblFirstNumber);
            dblResults = cubeRoot(dblFirstNumber);
            resultsTextBox.Text = cubeRoot(dblFirstNumber).ToString();
        }
        private void inverseButton_Click(object sender, RoutedEventArgs e)
        {
            // call the Inversion function
            double dblFirstNumber, dblResults = 0.0;
            Double.TryParse(firstNumberTextBox.Text, out dblFirstNumber);
            dblResults = inverseOfN(dblFirstNumber);
            resultsTextBox.Text = inverseOfN(dblFirstNumber).ToString();
        }
        private void ToThePowerOfYButton1_Click(object sender, RoutedEventArgs e)
        {
            //NOT COMPLETED!
        }

        private void convertButtonConversionVelocity1_Click(object sender, RoutedEventArgs e)
        {
            string from, to;
            try
            {
                //Get 'to' and 'from' from the dictionary.
                from = DisplayToFuncName[fromComboBoxConversionVelocity.Text];
                to = DisplayToFuncName[toComboBoxConversionVelocity.Text];
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                //Unit was not in the dictionary, so it is not valid.
                resultsTextBox.Text = "Invalid item in from or to unit.";
                return;
            }

            //Parse the input into a double.
            double numToConvert;
            bool successfulParse = Double.TryParse(firstNumberTextBox.Text, out numToConvert);

            //Input number is valid and from and to are not blank.
            if (from != "" & to != "" & successfulParse)
            {
                //If to and from unit are the same, answer = input.
                if (from == to)
                {
                    resultsTextBox.Text = firstNumberTextBox.Text;
                }
                else
                {
                    //Create the method name for this conversion.
                    string methodName = $"convert{from}To{to}";

                    //Get the type and then the method for this conversion.
                    Type thisType = Type.GetType("VelocityConversion");
                    MethodInfo theMethod = thisType.GetMethod(methodName);

                    //The method exists, so run it.
                    if (theMethod != null)
                    {
                        resultsTextBox.Text = theMethod.Invoke(this, new object[] { numToConvert }).ToString();
                    }
                    //The method did not exist.
                    else
                    {
                        resultsTextBox.Text = methodName + " Conversion not implemented.";
                    }
                }
            }
            //Not a valid double in the input.
            else if (successfulParse == false)
            {
                resultsTextBox.Text = "The number entered is invalid.";
            }
            //To or from were blank.
            else
            {
                resultsTextBox.Text = "Two units need to be selected.";
            }

        }
    }
}
