public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        ///
        /// Plan : 
        /// Create an array named multiples 
        /// Make a for loop with parameters of i=1; i == lenght; i++
        /// Multiply the "number" * i 
        /// append the result to the multiples array
        ///

        ///int[] multiples = new int[length];
        List<double> multiples = new();
        for (int i = 1; i <= length; i++)
        {
            double value = i * number;
            multiples.Add(value);
        }

        return multiples.ToArray(); ; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        ///
        /// tienes que contar el tamano de la lista y tener el numero, despues restarle donde quieren comenzar, 9 - 3 = 6 
        /// y luego en otra lista ir por el valor 6 de la lista original y sumarle 1 hasta llegar al 9
        /// en otra lista ir de la posicion 1 hasta la 6 con los valores de la lista original y depues pegar las dos listas. 
        /// 
        /// 
        
        
    }
}
