using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class VelocityConversion
    {
        /*******************************************************************
        double centimetersPerSecToFeetPerSec(double n)	Cm/s to Ft/sec	Joseph - missing
        double feetPerSecToCentimetersPerSec(double n)	Ft/sec to Cm/s	Joseph - missing
        double machToCentimetersPerSec(double n)	MACH to Cm/s	    Joseph - missing
        double mphToCentimetersPerSec(double n)	MPH to Cm/s	            Lindsay - missing
        double convertKmPerHourToCentimetersPerSec(double n)	Km/hr to Cm/s	Blake <-

        double convertCentimetersPerSecToMACH(double n)	Cm/s to MACH	    Gus <-
        double convertFeetPerSecToMACH(double n)	Ft/sec to MACH	        Gus <-
        double convertMACHToFeetPerSec(double n)	MACH to Ft/sec          John T <-
        double mphToFeetPerSec(double n)	MPH to Ft/sec 	            Lindsay - missing
        double convertKmPerHourToFeetPerSec(double n)	Km/hr to Ft/sec	        Blake <-

        double convertCentimetersPerSecToMPH(double n)	Cm/s to MPH	Gus <-
        double convertFeetPerSecToMPH(double n)	Ft/sec to MPH	Kerry <-
        double machToMPH(double n)	MACH to MPH	            John T <-
        double convertMPHToMACH(double n)	MPH to MACH	            Jorge <-
        double convertKmPerHourToMPH(double n)	Km/hr to MPH	    Jorge <-

        double centimetersPerSecToKmPerHour(double n)	Cm/s to Km/hr	Kerry <-
        double feetPerSecToKmPerHour(double n)	Ft/sec to Km/hr	        Kerry <-
        double convertMACHToKmPerHour(double n)	MACH to Km/hr           John T <-
        double mphTokmPerHour(double n)	MPH to Km/hr	                Lindsay - missing
        double convertKmPerHourToKmPerHour(double n)	Km/hr to MACH	Jorge <-

        *******************************************************************/


        public static double convertKmPerHourToCentimetersPerSec(double number)
        {
            number = (number * 1000) / 36;

            return number;
        }


        public static double convertKmPerHourToFeetPerSec(double number)
        {
            double dblNumber = (number * 1000) / 1097.28;

            return dblNumber;
        }

    public static double convertCentimetersPerSecToMACH(double n) // method for centimetersPerSecToMACH
    {
        return (n * 0.00002938669958);
    }

    public static double convertFeetPerSecToMACH(double n) // method for feetPerSecToMACH
    {
        return (n * 0.0009181);
    }

    public static double convertCentimetersPerSecToMPH(double n) // method for centimetersPerSecToMPH
    {
        return (n * 0.022369362920544);
    }

    public static double convertMACHToFeetPerSec(double number1)
    {
        double machFeet = 1125.33;
        double result = number1 * machFeet;
        return (number1 * machFeet);
    }
    /*
     Mach to Miles
     John Truong 11/5/2016
     Convert mach to miles
     */
    public static double convertMACHToMPH(double number1)
    {
        double machMiles = 767.269;
        double result = number1 * machMiles;
        return (number1 * machMiles);
    }
    /*
     Mach to kilometer
     John Truong 11/5/2016
     Convert mach to kilometer
     */
    public static double convertMACHToKmPerHour(double number1)
    {
        double machKilo = 1234.8;
        double result = number1 * machKilo;
        return (number1 * machKilo);
    }

    /*feetPerSecToMPH method
 * Author: Kerry Swanson 11/06/2016
 * Purpose: convert feet per second to miles per hour and return result
 * Input: one number, double
 * Output: the converted number, double
 * Invariant: the result is beyond the capacity of the return variable
 */
    public static double convertFeetPerSecToMPH(double n)
    {
        return (n * 0.681818);
    }

    /*centimetersPerSecTokmPerHour method
     * Author: Kerry Swanson 11/06/2016
     * Purpose: convert centimeters per second to kilometers per hour and return result
     * Input: one number, double
     * Output: the converted number, double
     * Invariant: the result is beyond the capacity of the return variable
     */
    public static double convertCentimetersPerSecToKmPerHour(double n)
    {
        return (n * 0.036);
    }

    /*feetPerSecTokmPerHour method
     * Author: Kerry Swanson 11/06/2016
     * Purpose: convert centimeters per second to kilometers per hour and return result
     * Input: one number, double
     * Output: the converted number, double
     * Invariant: the result is beyond the capacity of the return variable
     */
    public static double convertFeetPerSecToKmPerHour(double n)
    {
        return (n * 1.09728);
    }

    /*mphToMach method */

    /*********************************
     *        Jorge Sagastume        *
     *          11/02/2016           *
     *       COP2360 Fall 2016       *
     *       MidTerm Assignment     *
     * ******************************/


    /******************* mphToMach method ************************************/
    public static double convertMPHToMACH(double number1)
    {
        return (number1 * 0.0013);
    }
    /*                throw new Exception("A negative numbered was entered!\nVelocity cannot go backwards!\nPlease press Continue and enter a positive number."); */

    /*************************** end mphToMach method ******************************/


    /************************* kmperHour to MPH method ****************************/
    public static double convertKmPerHourToMPH(double number1)
    {
        return (number1 * 0.621371);
    }

    /************************* End of kmtoMPH *************************************/

    /************************ kmperHour to MACH method *****************************/

    public static double convertKmPerHourToMACH(double number1)
    {
        return (number1 * 0.0008162972);
    }
    /* End of kmtoMPH */


}

