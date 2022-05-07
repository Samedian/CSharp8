using System;

namespace Stackalloc
{
    class Program
    {
        /*
         -> allocates a block of memory on the stack

         -> memory block created during the method execution is automatically 
            discarded when that method returns

         -> cannot explicitly free the memory allocated
         */

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter Length of Array :");
            int length = Convert.ToInt32(Console.ReadLine());

            //C# 7.2 can use with span don't have to use unsafe when assign it to Span
            Span<int> numbers = stackalloc int[length];

            Console.WriteLine("Enter Numbers :");
            for (var i = 0; i < length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array :");
            for (var i = 0; i < length; i++)
            {
                Console.Write(numbers[i]+"  ");
            }

            */

            //C# 8.0, can use a stackalloc expression inside other expressions 
            //whenever a Span<T> or ReadOnlySpan<T> variable is allowed

            /*
            Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            var index = numbers.IndexOfAny(stackalloc[] { 2, 4, 6, 8 });
            Console.WriteLine(index);
            */

            //pointer 

            /*
            Console.WriteLine("Enter Length of Array :");
            int length = Convert.ToInt32(Console.ReadLine());
            unsafe
            {
                int* array = stackalloc int[length];
                Console.WriteLine("Enter Numbers :");
                for (var i = 0; i < length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Array :");
                for (var i = 0; i < length; i++)
                {
                    Console.Write(array[i] + "  ");
                }
            }
            */
            //amount of memory available on the stack is limited.If you allocate too much memory on the stack, a StackOverflowException is thrown.

            /*
            Console.WriteLine("Enter Length of Array :");
            int inputLength = Convert.ToInt32(Console.ReadLine());
            const int MaxStackLimit = 1024;
            Span<byte> buffer = inputLength <= MaxStackLimit ? stackalloc byte[inputLength] : new byte[inputLength];
            */


        }
        }
    }
