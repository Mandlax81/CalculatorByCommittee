internal class SimpleClass
{
    /*********************
    *  addNumbers method 
    *  Author: Jim Barrell 10/19/2016
    *  Purpose: add two numbers together and return the results
    *  Input: two numbers, overloaded for double, int, and long
    *  Output: the sum, overloaded for double, int, and long
    *  Invariant: the sum is beyond the capacity of the return variable 
    ************************/
    public static double addNumbers(double number1, double number2)
    {
        return (number1 + number2);//this returns the added numbers back to the event handler, whis is in MainWindow.xaml.cs
    }
    public static long addNumbers(long number1, long number2)
    {
        return (number1 + number2);
    }
    public static int addNumbers(int number1, int number2)
    {
        return (number1 + number2);
    }

    /*  end of addNumbers ***************************/
    
    /*********************
    *  subtractNumbers method 
    *  Author: Jim Barrell 10/19/2016
    *  Purpose: subtract number1 from number2 and return the results
    *  Input: two numbers, overloaded for double, int, and long
    *  Output: the sum, overloaded for double, int, and long
    *  Invariant: the difference is beyond the capacity of the return variable 
    ************************/
    public static double subtractNumbers(double number1, double number2)
    {
        return (number1 - number2);
    }
    public static long subtractNumbers(long number1, long number2)
    {
        return (number1 - number2);
    }
    public static int subtractNumbers(int number1, int number2)
    {
        return (number1 - number2);
    }
    /*  end of subtractNumbers ***************************/

    /*********************
    *  multiplyNumbers method 
    *  Author: Jim Barrell 10/19/2016
    *  Purpose: mulitply two numbers together and return the results
    *  Input: two numbers, overloaded for double, int, and long
    *  Output: the product, overloaded for double, int, and long
    *  Invariant: the product is beyond the capacity of the return variable   
    ************************/
    public static double multiplyNumbers(double number1, double number2)
    {
        return (number1 * number2);
    }
    public static long multiplyNumbers(long number1, long number2)
    {
        return (number1 * number2);
    }
    public static int multiplyNumbers(int number1, int number2)
    {
        return (number1 * number2);
    }
    /*  end of multiplyNumbers ***************************/

    /*********************
    *  divideNumbers method 
    *  Author: Jim Barrell 10/19/2016
    *  Purpose: divide number1 by number2 and return the results as a real number
    *  Input: two numbers, overloaded for double, int, and long
    *  Output: the quotient as a double no matter the input type
    *  Invariant: the quotient is beyond the capacity of the return variable 
    ************************/

    public static double divideNumbers(double number1, double number2)
    {
        return (number1 / number2);
    }
    public static double divideNumbers(long number1, long number2)
    {
        return ((double)number1 / (double)number2);
    }
    public static double divideNumbers(int number1, int number2)
    {
        return ((double)number1 / (double)number2);
    }

}