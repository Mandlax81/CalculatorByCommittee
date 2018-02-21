using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;


    internal class Scientific
    {
    /*************************************************
    Square Root(number1) 	double squareRoot(double n)	Frank
    Cube Root(number1)	double cubeRoot(double n)	Frank
    Raise x to the power of y	double xToThePowerOfy(double x, double y)	Greg
    log(number1)	double logOfn(double n)	Greg
    1/number1	double inverseOfn(double n)	Frank
    modulo (mod) n/p	double moduloOfnDividedByp(double n, double p)	OPEN

   *************************************************/
    

    /*
     * Author:   Frank Borges
     * Date:     11/02/16
     * Purpose:  >/ Calculator built by community
     *           >/ I was in charge of creating functions
     *              for:
     *              1) square roots
     *              2) cube roots 
     *              3) inverse functions
     * In:      number
     * Out:     sqNumber, cubenum, invNumber
     * General Notes: 
     *           All functions are self explainatory
     *           After several hours of testing, I 
     *               couldn't find any problems
     *               or any way to break my functions
     */

    // square root function
    /*
     * Notes:
     * No need to reinvent the wheel
     * and make things less efficient
     */

    public static double squareRoot(double number)
    {
        double sqNumber = 0.0;
        try
        {
            sqNumber = (double)(Sqrt(number));
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }

        return (double)(sqNumber);
    }

    public static double cubeRoot(double number)
    {
        double cubenum = 0.0;
        try
        {
            cubenum = (double)Pow(number, (double)1 / 3);
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }

        return (double)(cubenum);
    }

    public static double inverseOfN(double number)
    {
        double invNumber = 0.0;

        try
        {
            invNumber = 1 / number;
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }

        return (double)(invNumber);
    }

}
