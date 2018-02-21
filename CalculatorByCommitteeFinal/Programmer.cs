using System;
using System.Linq;
using System.Windows;
using static System.Console;
internal class Programmer
{
    /*********************
*  addBinary  method
*  Author: Benjamin Andrews 10.31.16
*  Purpose: add two numbers together and return the results
*  Input: two numbers, overloaded for double, int, and long 
*  Output: the sum, overloaded for double, int, and long
*  Invariant/Error Check: the sum is beyond the capacity of the return variable 
************************/
    //ADD BINARY MODULE:
    
    public static string addBinary(string n, string m)//gets two strings from interface
    {
        /*Outline
         * wrap string in try catch
         * Try
         * convert both strings into binary String addBinary(String n, String m)
         * compute strings together, and store in variable
         * convert combined binary into string again, store in variable
         * Catch
         * Final
        */
    
        //Variables
        int baseNum = 2;//base number in binary
        string numValSum = "";//stores computed and converted numbers in variable 
        
        try //This checks the conversion and computation of the two values
        {
            //Conversions to ints
            int numValN = Convert.ToInt32(n, baseNum);//Converts first user input from string to int
            int numValM = Convert.ToInt32(m, baseNum);//Converts second user input from string to int

            //Computes sum of two values, storing as integer
            numValSum = "0" + (Convert.ToString(numValN + numValM, baseNum)); //Store the addition and conversion in a string variable
            //Note: needed to concatenate a '0' to the beginnning to make the math output properly
        }
        catch (OverflowException)//catches values that are too large, when computed together
        {
            return ("Error. Those values are too large.");
        }
        catch
        {
            return ("Error. Default.");
        }
        //returns computed and converted numbers
        return (numValSum);
        //Note, return must always be after the try catch block, but still inside the module
    }   

    public static string addBinary(double n, double m)//gets two strings from interface
    {
        /*Outline
         * wrap string in try catch
         * Try
         * convert both strings into binary String addBinary(String n, String m)
         * compute strings together, and store in variable
         * convert combined binary into string again, store in variable
         * Catch
         * Final
        */

        //Variables
        string numValSum = "";//stores computed and converted numbers in variable 
        try //This checks the conversion and computation of the two values
        {
            //Conversions to ints
            double numValN = BitConverter.DoubleToInt64Bits(n);//Converts first user input from double to binary
            double numValM = BitConverter.DoubleToInt64Bits(m);//Converts second user input from double to binary
            //Computes sum of two values, storing as integer
            numValSum = "0" + (Convert.ToString(numValN + numValM)); //Store the addition and conversion in a string variable
            //Note: needed to concatenate a '0' to the beginnning to make the math output properly
        }
        catch (OverflowException)//catches values that are too large, when computed together
        {
            return ("Error: Those values are too large.");
        }
        catch (FormatException)
        {
            return ("Error. Binary Only.");
        }
        catch
        {
            return ("Error. Default.");
        }
        //returns computed and converted numbers
        return (numValSum);
        //Note, return must always be after the try catch block, but still inside the module
    }

    //SUBTRACT BINARY MODULE:
    public static string subtractBinary(string n, string m)//gets two strings from interface
    {
        /*Outline
         * wrap string in try catch
         * Try
         * convert both strings into binary String addBinary(String n, String m)
         * compute strings together, and store in variable
         * convert combined binary into string again, store in variable
         * Catch
         * Final
        */

        //https://msdn.microsoft.com/en-us/library/cc165449.aspx
        //Compares n to m. If n is less than m (i.e. -1) the return statement issues
        if (System.String.Compare(n, m) == -1)//System.String.Compare compares the customer's first name like Benjamin to the saved customers first name. If equal to one, it provides the maximum. Not sure why?
        {
            return ("First Number must be greater than Second Number");
        }

        //Variables
        int baseNum = 2;//base number in binary
        string numValSum = "";//stores computed and converted numbers in variable 
        try //This checks the conversion and computation of the two values
        {
            //Conversions to ints
            int numValN = Convert.ToInt32(n, baseNum);//Converts first user input from string to int
            int numValM = Convert.ToInt32(m, baseNum);//Converts second user input from string to int


            //Computes sum of two values, storing as integer
            numValSum = "0" + (Convert.ToString(numValN - numValM, baseNum)); //Store the addition and conversion in a string variable
            //Note: needed to concatenate a '0' to the beginnning to make the math output properly
        }
        catch (OverflowException)//catches values that are too large, when computed together
        {
            return ("Error: Those values are too large.");
        }
        catch (FormatException)
        {
            return ("Error. Binary Only.");
        }
        catch
        {
            return ("Error. Default.");
        }
        //returns computed and converted numbers
        return (numValSum);
        //Note, return must always be after the try catch block, but still inside the module
    }

    //Multiply BINARY MODULE:
    public static string multiplyBinary(string n, string m)//gets two strings from interface
    {
        /*Outline
         * wrap string in try catch
         * Try
         * convert both strings into binary String addBinary(String n, String m)
         * compute strings together, and store in variable
         * convert combined binary into string again, store in variable
         * Catch
         * Final
        */

        //Variables
        int baseNum = 2;//base number in binary
        string numValSum = "";//stores computed and converted numbers in variable 
        try //This checks the conversion and computation of the two values
        {
            //Conversions to ints
            int numValN = Convert.ToInt32(n, baseNum);//Converts first user input from string to int
            int numValM = Convert.ToInt32(m, baseNum);//Converts second user input from string to int


            //Computes sum of two values, storing as integer
            numValSum = "0" + (Convert.ToString(numValN * numValM, baseNum)); //Store the addition and conversion in a string variable
            //Note: needed to concatenate a '0' to the beginnning to make the math output properly
        }
        catch (OverflowException)//catches values that are too large, when computed together
        {
            return ("Error: Those values are too large.");
        }
        catch (FormatException)
        {
            return ("Error. Binary Only.");
        }
        catch
        {
            return ("Error. Default.");
        }
        //returns computed and converted numbers
        return (numValSum);
        //Note, return must always be after the try catch block, but still inside the module

    }

    /*********************
*  convertHexToDecimal method 
*  Author: Matt Danielson 11/2/2016
*  Purpose: convert Hex number to decimal
*  Input: one hex number in string form
*  Output: one decimal number in string form
************************/

    public static string convertHexToDecimal(string number1)
    {
        string decValue = "";
        try
        {
            // check if number is in hex form
            bool isHex = number1.ToCharArray().Any(c => "0123456789abcdefABCDEF".Contains(c));

            if (isHex == true)
                decValue = Convert.ToString(Convert.ToInt32(number1, 16), 10); // convert hex to decimal
            else
                decValue = "Error";        // returns error if not in hex form  
        }
        catch (InvalidOperationException e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        catch (IndexOutOfRangeException e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        catch (OverflowException e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        catch (Exception e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        return decValue;
    }

    /*********************
    *  convertHexToOctal method 
    *  Author: Matt Danielson 11/2/2016
    *  Purpose: convert Hex number to octal
    *  Input: one hex number in string form
    *  Output: one octal number in string form
    ************************/

    public static string convertHexToOctal(string number1)
    {
        string octValue = "";
        try
        {
            // check if number is in hex form
            bool isHex = number1.ToCharArray().Any(c => "0123456789abcdefABCDEF".Contains(c));

            if (isHex == true)
                octValue = Convert.ToString(Convert.ToInt32(number1, 16), 8); // convert hex to octal
            else
                octValue = "Error";        // returns Error if not in hex form
        }
        catch (InvalidOperationException e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        catch (IndexOutOfRangeException e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        catch (OverflowException e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        catch (Exception e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        return octValue;
    }

    /*********************
    *  convertHexToBinary method 
    *  Author: Matt Danielson 11/2/2016
    *  Purpose: convert Hex number to binary
    *  Input: one hex number in string form
    *  Output: one binary number in string form
    ************************/

    public static string convertHexToBinary(string number1)
    {
        string binaryValue = "";
        try
        {
            // check if number is in hex form
            bool isHex = number1.ToCharArray().Any(c => "0123456789abcdefABCDEF".Contains(c));

            if (isHex == true)
                binaryValue = Convert.ToString(Convert.ToInt32(number1, 16), 2); // convert hex to binary
            else
                binaryValue = "Error";          // returns Error if not in hex form
        }
        catch (InvalidOperationException e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        catch (IndexOutOfRangeException e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        catch (OverflowException e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        catch (Exception e)
        {
            WriteLine("You've encounted the following error:");
            WriteLine(e.Message);
        }
        return binaryValue;
    }

    public static string AddHexa(string a, string b)
    {

        // Author: Alexander Ihle
        // Date: 11/02/2016

        long number1, number2;

        try
        {

            number1 = System.Convert.ToInt64(a, 16);
            number2 = System.Convert.ToInt64(b, 16);

        }
        catch (System.OverflowException)
        {

            return "Error: Those values are too large.";

        }
        catch
        {

            return "Error: Hexadecimals Only";

        }

        long number3 = number1 + number2;

        string c = System.Convert.ToString(number3, 16).ToUpper();
        return c;

    }

    public static string SubtractHexa(string a, string b)
    {

        // Author: Alexander Ihle
        // Date: 11/02/2016

        long number1, number2;

        try
        {

            number1 = System.Convert.ToInt64(a, 16);
            number2 = System.Convert.ToInt64(b, 16);

        }
        catch (System.OverflowException)
        {

            return "Error: Those values are too large.";

        }
        catch
        {

            return "Error: Hexadecimals Only";

        }

        long number3 = number1 - number2;

        string c = System.Convert.ToString(number3, 16).ToUpper();

        return c;

    }

    public static string MultiplyHexa(string a, string b)
    {

        // Author: Alexander Ihle
        // Date: 11/02/2016

        long number1, number2;

        try
        {

            number1 = System.Convert.ToInt64(a, 16);
            number2 = System.Convert.ToInt64(b, 16);

        }
        catch (System.OverflowException)
        {

            return "Error: Those values are too large.";

        }
        catch
        {

            return "Error: Hexadecimals Only";

        }

        long number3 = number1 * number2;

        string c = System.Convert.ToString(number3, 16).ToUpper();

        return c;

    }

    /*************************
*  subtractOctals method 
*  Author: Jon Geerlings 11/04/2016
*  Purpose: subtract octal1 from octal2 and return the results
**************************/

    public static string subtractOctals(string number1, string number2)
    {
        double octal1, octal2;
        Double.TryParse(number1, out octal1);
        Double.TryParse(number2, out octal2);
        return (octal1 - octal2).ToString();
    }


    /*  end of subtractOctals ***************************/

    /*********************
    *  multiplyOctals method 
    *  Author: Jon Geerlings 11/04/2016
    *  Purpose: mulitply two octals together and return the results
    **********************/

    public static string multiplyOctals(string number1, string number2)
    {
        double octal1, octal2;
        Double.TryParse(number1, out octal1);
        Double.TryParse(number2, out octal2);
        return (octal1 * octal2).ToString();
    }

    /*  end of multiplyOctals ***************************/

    /*********************
    *  divideOctals method 
    *  Author: Jon Geerlings 11/04/2016
    *  Purpose: divide octal1 by octal2 and return the results
    *********************/

    public static string divideOctals(string number1, string number2)
    {
        double octal1, octal2;
        Double.TryParse(number1, out octal1);
        Double.TryParse(number2, out octal2);

        return (octal1 / octal2).ToString();
    }

    /*****************************************************************************/

    //MakeDecimal builds an 'unsigned long' whole number ulDec
    //from given string sEnter making sure no overflow error.
    //Returns 'true' for valid ulDec.
    //This avoids wrong number type input exception.
    //Not overloading this function; this one 'largest size fits all'
    //interprets the largest possible positive integer- 18446744073709551615.
    //By Bruce Bedford

    // wrapper classes to conform to the way the rest of the methods are called  //
    public static string convertDecimalToHex(string firstNumber)
    {
        string results = "Err";
        ulong wholeNumber;
        bool isOk = MakeDecimal(firstNumber, out wholeNumber);
        if (isOk)
        { results = TenToBase(16, wholeNumber); }
        else
        { results = "Use only digits 0-9, Enter whole number."; }
        return results;
    }

    public static string convertDecimalToOctal(string firstNumber)
    {
        string results = "Err";
        ulong wholeNumber;
        bool isOk = MakeDecimal(firstNumber, out wholeNumber);
        if (isOk)
        { results = TenToBase(8, wholeNumber); }
        else
        { results = "Use only digits 0-9, Enter whole number."; }
        return results;
    }

    public static string convertDecimalToBinary(string firstNumber)
    {
        string results = "Err";
        ulong wholeNumber;
        bool isOk = MakeDecimal(firstNumber, out wholeNumber);
        if (isOk)
        { results = TenToBase(2, wholeNumber); }
        else
        { results = "Use only digits 0-9, Enter whole number."; }
        return results;
    }

    public static bool MakeDecimal(string sEnter, out ulong ulDec)
    {
        try
        {
            if (sEnter == null)
            { sEnter = ""; }
            string sUse = sEnter.Trim();
            int iL = sUse.Length;
            char[] cArray = sUse.ToCharArray();
            int iDigitsFound = 0;
            ulDec = 0;
            ulong ulSum = 0;
            ulong ulPwr = 1;
            bool bGrows = true;
            for (int i = iL - 1; i >= 0; i--)
            {
                try
                {
                    // i = 100; //test error                        
                    switch (cArray[i])  //for index out of range
                    {
                        case '0':
                            iDigitsFound++;
                            ulSum = ulSum + ulPwr * 0;
                            break;
                        case '1':
                            iDigitsFound++;
                            ulSum = ulSum + ulPwr * 1;
                            break;
                        case '2':
                            iDigitsFound++;
                            ulSum = ulSum + ulPwr * 2;
                            break;
                        case '3':
                            iDigitsFound++;
                            ulSum = ulSum + ulPwr * 3;
                            break;
                        case '4':
                            iDigitsFound++;
                            ulSum = ulSum + ulPwr * 4;
                            break;
                        case '5':
                            iDigitsFound++;
                            ulSum = ulSum + ulPwr * 5;
                            break;
                        case '6':
                            iDigitsFound++;
                            ulSum = ulSum + ulPwr * 6;
                            break;
                        case '7':
                            iDigitsFound++;
                            ulSum = ulSum + ulPwr * 7;
                            break;
                        case '8':
                            iDigitsFound++;
                            ulSum = ulSum + ulPwr * 8;
                            break;
                        case '9':
                            iDigitsFound++;
                            ulSum = ulSum + ulPwr * 9;
                            break;
                        default:
                            return false;
                    }
                } //end try
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                    return false;
                } //end catch


                //WriteLine($"{ulDec}  {ulSum}");
                ulPwr = ulPwr * 10;
                if (ulDec > ulSum)
                { bGrows = false; }
                ulDec = ulSum;
            }
            if ((iDigitsFound == iL) && (bGrows))
            { return true; }
            else
            { return false; }
        }//end try
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "MakeDecimal Error");
            ulDec = 0;
            return false;
        }//end catch
    } //end truly MakeDecimal given numeric string        
      //++++++++++++++++++++++++++++++++++++

    //Convert base ten integer to other base.
    //Given unsigned long integer ulTen is converted to base 1<iBase<36
    //Outputs string using 0-9 & A-Z as needed.
    //Output max string length is 64 characters.
    //Use iBase=2 for binary; =8 for Octal; & =16 for Hex.
    //By Bruce Bedford
    public static string TenToBase(int iBase, ulong ulTen)
    {
        try
        {
            int iX = 0;
            const int iMax = 64;    //max digits in output string
            ulong[] ulDigit = new ulong[iMax];
            string sNum = "";   //could allow for + or - sign prefix
            if (iBase > 36)
            { return "Base too large."; }
            if (iBase < 2)
            { return "Base too small."; }
            // ulTen can only be positive                                
            do
            {
                try
                {   // for division error
                    //iBase = 0;  //error
                    ulDigit[iX] = ulTen % (ulong)iBase;
                    ulTen = ulTen / (ulong)iBase;
                } //end try
                catch (Exception g)
                {
                    MessageBox.Show(g.Message);
                    return "*";
                } //end catch

                iX++;
            } while (ulTen > 0);
            string sDigit;
            for (int i = iX - 1; i >= 0; i--)
            {
                try
                {
                    //i = 100; //test error
                    switch (ulDigit[i]) //for index out of range
                    {
                        case 0: sDigit = "0"; break;
                        case 1: sDigit = "1"; break;
                        case 2: sDigit = "2"; break;
                        case 3: sDigit = "3"; break;
                        case 4: sDigit = "4"; break;
                        case 5: sDigit = "5"; break;
                        case 6: sDigit = "6"; break;
                        case 7: sDigit = "7"; break;
                        case 8: sDigit = "8"; break;
                        case 9: sDigit = "9"; break;
                        case 10: sDigit = "A"; break;
                        case 11: sDigit = "B"; break;
                        case 12: sDigit = "C"; break;
                        case 13: sDigit = "D"; break;
                        case 14: sDigit = "E"; break;
                        case 15: sDigit = "F"; break;
                        case 16: sDigit = "G"; break;
                        case 17: sDigit = "H"; break;
                        case 18: sDigit = "I"; break;
                        case 19: sDigit = "J"; break;
                        case 20: sDigit = "K"; break;
                        case 21: sDigit = "L"; break;
                        case 22: sDigit = "M"; break;
                        case 23: sDigit = "N"; break;
                        case 24: sDigit = "O"; break;
                        case 25: sDigit = "P"; break;
                        case 26: sDigit = "Q"; break;
                        case 27: sDigit = "R"; break;
                        case 28: sDigit = "S"; break;
                        case 29: sDigit = "T"; break;
                        case 30: sDigit = "U"; break;
                        case 31: sDigit = "V"; break;
                        case 32: sDigit = "W"; break;
                        case 33: sDigit = "X"; break;
                        case 34: sDigit = "Y"; break;
                        case 35: sDigit = "Z"; break;
                        default: sDigit = "*"; break;
                    }
                } //end try
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                    return "*";
                } //end catch

                sNum = sNum + sDigit;
            }
            return sNum;
        } //end try
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "TenToBase Error");
            return "";
        } //end catch           
    } //end TenToBase 'n' given ulong
      //++++++++++++++++++++++++++++++++++++

    //Convert base ten integer to other base.
    //Given long integer lTen is converted to base 1<iBase<36
    //Outputs string using 0-9 & A-Z as needed.
    //Output max string length is 64 characters.
    //Use iBase=2 for binary; =8 for Octal; & =16 for Hex.
    //By Bruce Bedford
    public static string TenToBase(int iBase, long lTen)
    {
        try
        {
            int iX = 0;
            const int iMax = 64;    //max digits in output string
            long[] lDigit = new long[iMax];
            string sNum = "";   //could allow for + or - sign prefix
            if (iBase > 36)
            { return "Base too large."; }
            if (iBase < 2)
            { return "Base too small."; }
            if (lTen < 0)
            {
                if (lTen > -9223372036854775808)
                { lTen = -lTen; }   //could allow for + or - sign prefix
            }
            do
            {
                try
                {   // for division error
                    //iBase = 0;  //error
                    lDigit[iX] = lTen % iBase;
                    lTen = lTen / iBase;
                } //end try
                catch (Exception g)
                {
                    MessageBox.Show(g.Message);
                    return "*";
                } //end catch  
                iX++;
            } while (lTen > 0);
            string sDigit;
            for (int i = iX - 1; i >= 0; i--)
            {
                try
                {
                    //i = 100; //test error
                    switch (lDigit[i]) //for index out of range
                    {
                        case 0: sDigit = "0"; break;
                        case 1: sDigit = "1"; break;
                        case 2: sDigit = "2"; break;
                        case 3: sDigit = "3"; break;
                        case 4: sDigit = "4"; break;
                        case 5: sDigit = "5"; break;
                        case 6: sDigit = "6"; break;
                        case 7: sDigit = "7"; break;
                        case 8: sDigit = "8"; break;
                        case 9: sDigit = "9"; break;
                        case 10: sDigit = "A"; break;
                        case 11: sDigit = "B"; break;
                        case 12: sDigit = "C"; break;
                        case 13: sDigit = "D"; break;
                        case 14: sDigit = "E"; break;
                        case 15: sDigit = "F"; break;
                        case 16: sDigit = "G"; break;
                        case 17: sDigit = "H"; break;
                        case 18: sDigit = "I"; break;
                        case 19: sDigit = "J"; break;
                        case 20: sDigit = "K"; break;
                        case 21: sDigit = "L"; break;
                        case 22: sDigit = "M"; break;
                        case 23: sDigit = "N"; break;
                        case 24: sDigit = "O"; break;
                        case 25: sDigit = "P"; break;
                        case 26: sDigit = "Q"; break;
                        case 27: sDigit = "R"; break;
                        case 28: sDigit = "S"; break;
                        case 29: sDigit = "T"; break;
                        case 30: sDigit = "U"; break;
                        case 31: sDigit = "V"; break;
                        case 32: sDigit = "W"; break;
                        case 33: sDigit = "X"; break;
                        case 34: sDigit = "Y"; break;
                        case 35: sDigit = "Z"; break;
                        default: sDigit = "*"; break;
                    }
                } //end try
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                    return "*";
                } //end catch

                sNum = sNum + sDigit;
            }
            return sNum;
        } //end try
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "TenToBase Error");
            return "";
        } //end catch
    } //end TenToBase 'n' given long
      //+++++++++++++++++++++++++++++++++++++++++

    //Convert base ten integer to other base.
    //Given integer iTen is converted to base 1<iBase<36
    //Outputs string using 0-9 & A-Z as needed.
    //Output max string length is 64 characters.
    //Use iBase=2 for binary; =8 for Octal; & =16 for Hex.
    //By Bruce Bedford
    public static string TenToBase(int iBase, int iTen)
    {
        try
        {
            int iX = 0;
            const int iMax = 64;    //max digits in output string
            int[] iDigit = new int[iMax];
            string sNum = "";   //could allow for + or - sign prefix
            if (iBase > 36)
            { return "Base too large."; }
            if (iBase < 2)
            { return "Base too small."; }
            if (iTen < 0)
            {
                iTen = -iTen;   //could allow for + or - sign prefix
            }
            do
            {
                try
                {   // for division error
                    //iBase = 0;  //error
                    iDigit[iX] = iTen % iBase;
                    iTen = iTen / iBase;
                } //end try
                catch (Exception g)
                {
                    MessageBox.Show(g.Message);
                    return "*";
                } //end catch                       
                iX++;
            } while (iTen > 0);
            string sDigit;
            for (int i = iX - 1; i >= 0; i--)
            {
                try
                {
                    //i = 100; //test error
                    switch (iDigit[i]) //for index out of range
                    {
                        case 0: sDigit = "0"; break;
                        case 1: sDigit = "1"; break;
                        case 2: sDigit = "2"; break;
                        case 3: sDigit = "3"; break;
                        case 4: sDigit = "4"; break;
                        case 5: sDigit = "5"; break;
                        case 6: sDigit = "6"; break;
                        case 7: sDigit = "7"; break;
                        case 8: sDigit = "8"; break;
                        case 9: sDigit = "9"; break;
                        case 10: sDigit = "A"; break;
                        case 11: sDigit = "B"; break;
                        case 12: sDigit = "C"; break;
                        case 13: sDigit = "D"; break;
                        case 14: sDigit = "E"; break;
                        case 15: sDigit = "F"; break;
                        case 16: sDigit = "G"; break;
                        case 17: sDigit = "H"; break;
                        case 18: sDigit = "I"; break;
                        case 19: sDigit = "J"; break;
                        case 20: sDigit = "K"; break;
                        case 21: sDigit = "L"; break;
                        case 22: sDigit = "M"; break;
                        case 23: sDigit = "N"; break;
                        case 24: sDigit = "O"; break;
                        case 25: sDigit = "P"; break;
                        case 26: sDigit = "Q"; break;
                        case 27: sDigit = "R"; break;
                        case 28: sDigit = "S"; break;
                        case 29: sDigit = "T"; break;
                        case 30: sDigit = "U"; break;
                        case 31: sDigit = "V"; break;
                        case 32: sDigit = "W"; break;
                        case 33: sDigit = "X"; break;
                        case 34: sDigit = "Y"; break;
                        case 35: sDigit = "Z"; break;
                        default: sDigit = "*"; break;
                    }
                } //end try
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                    return "*";
                } //end catch

                sNum = sNum + sDigit;
            }
            return sNum;
        } //end try
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "TenToBase Error");
            return "";
        } //end catch
    } //end TenToBase 'n' given int
      //++++++++++++++++++++++++++++++
}
