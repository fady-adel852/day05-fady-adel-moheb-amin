//Question 1 Start:

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Operation complete");
        }
    }
}

/*The finally block executes regardless of whether an exception was thrown or not,
ensuring that "Operation complete" is always printed.
*/

//Question 1 End:






//Question 2 Start:
using System;

class Program
{
    static void Main()
    {
        int x, y;

        while (true)
        {
            Console.Write("Enter a positive integer for X: ");
            if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                break;
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        while (true)
        {
            Console.Write("Enter a positive integer for Y (greater than 1): ");
            if (int.TryParse(Console.ReadLine(), out y) && y > 1)
                break;
            Console.WriteLine("Invalid input. Please enter a positive integer greater than 1.");
        }

        Console.WriteLine($"X: {x}, Y: {y}");
    }
}

/*int.TryParse() improves program robustness by:

it preventing exceptions: int.TryParse() does not throw an exception
if the input is invalid. Instead, it returns false,
allowing the program to handle the invalid input gracefully.
In contrast, int.Parse() throws a FormatException
if the input is not a valid integer,
which can crash the program
if not properly handled.
*/


//Question 2 End:









//Question 3 Start:
using System;

class Program
{
    static void Main()
    {
        int? nullableInt = null;

        //Using the null-coalescing operator to assign a default value if the variable is null
        int value = nullableInt ?? -1;
        Console.WriteLine($"Value: {value}");

        // Demonstrating the difference between HasValue and Value properties
        if (nullableInt.HasValue)
        {
            Console.WriteLine($"Nullable integer has value: {nullableInt.Value}");
        }
        else
        {
            Console.WriteLine("Nullable integer does not have a value.");
        }

        //Assigning a value to the nullable integer
        nullableInt = 10;

        if (nullableInt.HasValue)
        {
            Console.WriteLine($"Nullable integer has value: {nullableInt.Value}");
        }
    }
}

/*What exception occurs when trying to access Value on a null Nullable<T>?

When trying to access the Value property on a null Nullable<T>,
an InvalidOperationException is thrown.
This exception indicates that the operation is not valid
because the nullable type does not have a value.
*/

//Question 3 End:



//Question 4 Start:
using System;

class Program
{
    static void Main()
    {
        int[] array = new int[5];

        try
        {
            // Trying to access an index out of bounds
            int value = array[10];
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Index out of bounds.");
        }
        finally
        {
            Console.WriteLine("Operation complete");
        }
    }
}

/*Why is it necessary to check array bounds before accessing elements?
Checking array bounds before accessing elements is necessary to
Prevent Exceptions, Accessing an array out of bounds throws an IndexOutOfRangeException,
which can crash the program if not handled properly.
*/


//Question 4 End:







//Question 5 Start:
using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[3, 3];

        //Getting user input for the 3x3 array
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter value for array[{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //Calculating and printing the sum of elements in each row
        for (int i = 0; i < 3; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < 3; j++)
            {
                rowSum += array[i, j];
            }
            Console.WriteLine($"Sum of elements in row {i}: {rowSum}");
        }

        //Calculating and printing the sum of elements in each column
        for (int j = 0; j < 3; j++)
        {
            int colSum = 0;
            for (int i = 0; i < 3; i++)
            {
                colSum += array[i, j];
            }
            Console.WriteLine($"Sum of elements in column {j}: {colSum}");
        }
    }
}

/*How is the GetLength(dimension) method used in multi-dimensional arrays?

The GetLength(dimension) method is used
to get the number of elements in a specified dimension
of a multi-dimensional array. For example, in a 2D array,
GetLength(0) returns the number of rows,
and GetLength(1) returns the number of columns.
This method is useful for iterating through
the elements of a multi-dimensional array without hardcoding the dimensions.
*/

//Question 5 End:











//Question 6 Start:
using System;

class Program
{
    static void Main()
    {
        //Creating a jagged array with three rows of varying sizes
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[2]; //First row with 2 elements
        jaggedArray[1] = new int[3]; //Second row with 3 elements
        jaggedArray[2] = new int[4]; //Third row with 4 elements

        //Populating each row with user input
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"Enter value for jaggedArray[{i}][{j}]: ");
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }

        //Printing all values row by row
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write($"Row {i}: ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}


/*How does the memory allocation differ
between jagged arrays and rectangular arrays?
Jagged Arrays: Each row in a jagged array is an independent array,
and the rows can have different lengths.
Memory is allocated separately for each row,
which means that the rows do not need to be contiguous in memory.
This can lead to more efficient memory usage
if the rows have significantly different lengths.
*/

//Question 6 End:








//Question 7 Start:
using System;

class Program
{
    static void Main()
    {
        // Declaring a nullable string
        string? nullableString = null;

        // Assigning it a value conditionally based on user input
        Console.Write("Enter a value for the string (or leave empty for null): ");
        string input = Console.ReadLine();
        nullableString = string.IsNullOrEmpty(input) ? null : input;

        // Using the null-forgiveness operator (!) to suppress warnings
        Console.WriteLine($"You entered: {nullableString!}");
    }
}

/*What is the purpose of nullable reference types in C#?
Nullable reference types in C# are used to indicate that a reference type variable can be null.
They help improve code safety and readability by making it explicit when a variable can be null,
and by providing compile-time warnings when nullability rules are violated.
This helps prevent NullReferenceException errors,
which are common in programs that do not properly handle null values.
*/

//Question 7 End:










//Question 8 Start:

using System;

class Program
{
    static void Main()
    {
        // Demonstrating boxing by assigning a value type to an object
        int valueType = 42;
        object boxedValue = valueType; // Boxing
        Console.WriteLine($"Boxed value: {boxedValue}");

        try
        {
            // Demonstrating unboxing
            int unboxedValue = (int)boxedValue; // Unboxing
            Console.WriteLine($"Unboxed value: {unboxedValue}");

            // Attempting invalid unboxing
            double invalidUnboxedValue = (double)boxedValue; // This will throw an InvalidCastException
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Error: Invalid cast during unboxing.");
        }
        finally
        {
            Console.WriteLine("Operation complete");
        }
    }
}

/*What is the performance impact of boxing and unboxing in C#?

Boxing and unboxing can have a significant performance impact because:

Boxing: When a value type is boxed, a new object is created on the heap,
and the value is copied into this object.
This involves memory allocation and copying,
which can be relatively expensive operations.

Unboxing: When a value type is unboxed,
the runtime checks the object type and then copies the value back to the stack.
This involves type checking and copying, which can also be costly.
*/

//Question 8 End:









//Question 9 Start:

using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 3;
        int sum, product;

        SumAndMultiply(a, b, out sum, out product);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
    }

    static void SumAndMultiply(int x, int y, out int sum, out int product)
    {
        sum = x + y;
        product = x * y;
    }
}
/*Why must out parameters be initialized inside the method?

Out parameters must be initialized inside the method
because they are intended to return values to the caller.
When a method is called with out parameters, the caller
expects these parameters to be assigned a value before the method returns.
If the method does not initialize the out parameters,
it would lead to undefined behavior and potential runtime errors.
Initializing out parameters ensures that the caller receives
valid and expected values.
*/

//Question 9 End:










//Question 10 Start:
using System;

class Program
{
    static void Main()
    {
        //Calling the method with both parameters
        PrintStringMultipleTimes("Hello", 3);

        //Calling the method with only the required parameter
        PrintStringMultipleTimes("World");

        //Demonstrating the use of named parameters
        PrintStringMultipleTimes(times: 2, str: "Named Parameters");
    }

    static void PrintStringMultipleTimes(string str, int times = 5)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(str);
        }
    }
}

/*Why must optional parameters always appear
at the end of a method's parameter list?

Optional parameters must appear at the end of a method's parameter list
to ensure that the compiler can correctly match arguments to parameters.
If optional parameters were allowed in the middle of the parameter list,
it would create ambiguity when calling the method,
as the compiler would not be able to determine
which arguments correspond to which parameters. By placing optional parameters at the end,
the compiler can easily identify and assign default values to any missing arguments.
*/

//Question 10 End:




//Question 11 Start:
using System;

class Program
{
    static void Main()
    {
        // Declaring a nullable integer array
        int?[] nullableArray = new int?[5];

        // Populating the array with some values
        nullableArray[0] = 10;
        nullableArray[2] = 20;

        // Using the null propagation operator to safely access properties
        for (int i = 0; i < nullableArray.Length; i++)
        {
            int value = nullableArray[i] ?? -1;
            Console.WriteLine($"Value at index {i}: {value}");
        }
    }
}

/*How does the null propagation operator prevent NullReferenceException?

The null propagation operator (?.) prevents NullReferenceException by
short-circuiting the evaluation of an expression if any part of it is null.
When you use ?., the expression evaluates to null
if the left-hand operand is null,
and the rest of the expression is not evaluated.
This ensures that you do not attempt
to access properties or methods on a null object,
which would otherwise result in a NullReferenceException.
*/

//Question 11 End:









//Question 12 Start:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a day of the week: ");
        string day = Console.ReadLine();

        int dayNumber = day switch
        {
            "Saturday" => 1,
            "Sunday" => 2,
            "Monday" => 3,
            "Tuesday" => 4,
            "Wednesday" => 5,
            "Thursday" => 6,
            "Friday" => 7,
            _ => 0 // Default case for invalid input
        };

        Console.WriteLine($"The corresponding number for {day} is {dayNumber}");
    }
}

/*When is a switch expression preferred over a traditional if statement?

A switch expression is preferred over a traditional if statement when
You have multiple conditions to check against a single variable.
Switch expressions provide a cleaner and more readable way
to handle multiple cases compared to a series of if-else statements.
*/

//Question 12 End:






//Question 13 Start:
using System;

class Program
{
    static void Main()
    {
        // Calling the method with individual values
        int sum1 = SumArray(1, 2, 3, 4, 5);
        Console.WriteLine($"Sum of individual values: {sum1}");

        // Calling the method with an array
        int[] numbers = { 6, 7, 8, 9, 10 };
        int sum2 = SumArray(numbers);
        Console.WriteLine($"Sum of array values: {sum2}");
    }

    static int SumArray(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}


/*What are the limitations of the params keyword in method definitions?

The limitations of the params keyword in method definitions include

Single Parameter: Only one params parameter is allowed in a method,
and it must be the last parameter in the parameter list.

Array Type: The params parameter must be an array type.
You cannot use params with other types.
*/

//Question 13 End: