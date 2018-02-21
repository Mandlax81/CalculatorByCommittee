using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class EnergyConversion
{
    /*******************************************************************
    double convertBTUTtoCalorie(double n)	    Edward <-
    double convertBTUtoInchPound(double n)	    Edward <-
    double convertBTUtoFootPound(double n)	    Edward <-
    double convertBTUtoNewtonMeter(double n)	Frankie <-
    double convertBTUtoElectronVolt(double n)	Frankie <-

    double convertElectronVoltToBTU(double n)	                Frankie <-
    double convertElectronVoltToCalorie(double n)	            OPEN
    double convertElectronVoltToInchPoundInchPound(double n)	OPEN
    double convertElectronVoltToFootPound(double n)	            OPEN
    double convertElectronVoltToNewtonMeter(double n)   	    OPEN

    double convertCalorieToBTU(double n)	        OPEN
    double convertCalorieToInchPound(double n)	    Steve <-
    double convertCalorieToFootPound(double n)	    Steve <-
    double convertCalorieToNewtonMeter(double n)	Steve <-
    double convertCalorieToElectronVolt(double n)	OPEN

    double convertInchPoundToCalorie(double n)	    OPEN
    double convertInchPoundToInchPound(double n)	OPEN
    double convertInchPoundToFootPound(double n)	OPEN
    double convertInchPoundToNewtonMeter(double n)	OPEN
    double convertInchPoundToElectronVolt(double n)	OPEN

    double convertFootPoundToCalorie(double n)	    OPEN
    double convertFootPoundToInchPound(double n)	OPEN
    double convertFootPoundtoBTU(double n)	        OPEN
    double convertFootPoundToNewtonMeter(double n)	OPEN
    double convertFootPoundToElectronVolt(double n)	OPEN

    *******************************************************************/


    public static double convertCalorieToInchPound(double calorie)
    {
        //The ratio from Calories to Inch-Pounds
        double CALORIES_TO_INCHPOUND = 37.047453054;

        //ratio * given calories = inch pounds
        return CALORIES_TO_INCHPOUND * calorie;
    }

    public static double convertCalorieToFootPound(double calorie)
    {
        //The ratio from Calories to Foot-Pounds
        double CALORIES_TO_FOOTPOUND = 3.08728764444;

        //ratio * given calories = foot pounds
        return CALORIES_TO_FOOTPOUND * calorie;
    }

    public static double convertCalorieToNewtonMeter(double calorie)
    {
        //The ratio from Calories to Newton Meters
        double CALORIES_TO_NEWTONMETER = 4.1858;

        //ratio * given calories = newton meters
        return CALORIES_TO_NEWTONMETER * calorie;
    }


    /********* BTU to Calorie *********/
  
    public static double convertBTUToCalorie(double n)
    {
            return n * (251.995761);
    }
  
     public static double convertBTUToInchPound(double n)
    {
            return n * (9331.783825147);
    }
    /********* BTU to FootPound *********/
    public static double convertBTUToFootPound(double n)
    {
            return n * (778.169262);
    }

    public static double convertBTUToNewtonMeter(double number1)
    {
        return (number1 * 1055.0559);
    }

    public static double convertBTUToElectronVolt(double number2)
    {
        return (number2 * 6.585e+21);
    }

    public static double convertElectronVoltToBTU(double number3)
    {
        return (number3 * 1.51857e-22);
    }

    /*******************************************************************
double convertInchPoundToCalorie(double n)	    Joshua
--double convertInchPoundToInchPound(double n)	Joshua
double convertInchPoundToFootPound(double n)	Joshua
double convertInchPoundToNewtonMeter(double n)	Joshua
double convertInchPoundToElectronVolt(double n)	Joshua
*******************************************************************/

    public static double convertInchPoundToBTU(double dblNumber)
    {
        /*
         * Convert Inch Pound to BTU
         * Inch_Pound / 9338.03189942 = BTU
        */
        try
        {
            if (Double.IsNaN(dblNumber) == true)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
            else if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }

            dblNumber /= 9338.03189942;

        }
        catch (System.ArgumentException Exception)
        {
            throw new System.ArgumentException($"The number entered must be a positive number that is greater than zero.\n\n\nArgument: {Exception}");
        }
        finally
        {
            if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
        }

        return dblNumber;
    }

    public static double convertInchPoundToInchPound(double dblNumber)
    {
        /*
         * Convert Inch Pound to InchPound
         * Inch_Pound equals Inch_Pound
        */
        try
        {
            if (Double.IsNaN(dblNumber) == true)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
            else if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }

            return dblNumber;

        }
        catch (System.ArgumentException Exception)
        {
            throw new System.ArgumentException($"The number entered must be a positive number that is greater than zero.\n\n\nArgument: {Exception}");
        }
        finally
        {
            if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
        }

    }

    public static double convertInchPoundToCalorie(double dblNumber)
    {
        /*
         * Convert Inch Pound to Calorie
         * Inch_Pound / 37.047453054 = Calorie
        */
        try
        {
            if (Double.IsNaN(dblNumber) == true)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
            else if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }

            dblNumber /= 37.047453054;

        }
        catch (System.ArgumentException Exception)
        {
            throw new System.ArgumentException($"The number entered must be a positive number that is greater than zero.\n\n\nArgument: { Exception }");
        }
        finally
        {
            if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
        }

        return dblNumber;

    }

    public static double convertInchPoundToFootPound(double dblNumber)
    {
        /*
         * Convert Inch Pound to Foot Pound
         * Inch_Pound / 12 = Foot_Pound
        */
        try
        {
            if (Double.IsNaN(dblNumber) == true)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
            else if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }

            dblNumber /= 12;

        }
        catch (System.ArgumentException Exception)
        {
            throw new System.ArgumentException($"The number entered must be a positive number that is greater than zero.\n\n\nArgument: {Exception}");
        }
        finally
        {
            if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
        }

        return dblNumber;

    }

    public static double convertInchPoundToNewtonMeter(double dblNumber)
    {
        /*
         * Convert Inch Pound to Calorie
         * Inch_Pound / 8.85074576738 = Newton_Meter
        */
        try
        {
            if (Double.IsNaN(dblNumber) == true)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
            else if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }

            dblNumber /= 8.85074576738;

        }
        catch (System.ArgumentException Exception)
        {
            throw new System.ArgumentException($"The number entered must be a positive number that is greater than zero.\n\n\nArgument: {Exception}");
        }
        finally
        {
            if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
        }

        return dblNumber;

    }

    public static double convertInchPoundToElectronVolt(double dblNumber)
    {

        /*
         * Convert Inch Pound to Calorie
         * Inch_Pound / 1.41804645004E-18 = Electron Volt
        */
        try
        {
            if (Double.IsNaN(dblNumber) == true)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
            else if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }

            dblNumber /= 1.41804645004E-18;

        }
        catch (System.ArgumentException Exception)
        {
            throw new System.ArgumentException($"The number entered must be a positive number that is greater than zero.\n\n\nArgument: {Exception}");
        }
        finally
        {
            if (dblNumber <= 0)
            {
                throw new System.ArgumentException("The number entered must be a positive number that is greater than zero.");
            }
        }

        return dblNumber;

    }
}
