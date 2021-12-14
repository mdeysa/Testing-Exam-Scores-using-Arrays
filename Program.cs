using System;
using System.IO;

namespace assignment5SyedAhmedISM240
{
    class Program
    {

        // declare variables

        int total;
        int average;
        int max;
        int min;
        int median;











        static void Main(string[] args)
        {

            int score;
            int index = 0;
            int elements = 0;
            int[] array = new int[45];


            // testing to see if exam scores are valid

            try
            {

                //reading data from text file
                StreamReader inputfile;
                inputfile = File.OpenText("Exam_scores.txt");

                // while loop that runs until the end of data
                while (index < array.Length && !inputfile.EndOfStream)
                {
                    //reading data and store into array
                    array[index] = int.Parse(inputfile.ReadLine());
                    index++;
                    elements++;

                }



                Program program = new Program();



                //display the methods 
                Console.WriteLine("");
                Console.WriteLine("");
                program.Total(array);
                Console.WriteLine("");
                program.Average(array, elements);
                Console.WriteLine("");
                program.Max(array);
                Console.WriteLine("");
                program.Min(array);
                Console.WriteLine("");
                program.Sort(array);
                Console.WriteLine("");
                program.Median(array, elements);





            }
            catch
            {
                Console.WriteLine("File not found");
            }

        }

        //total

        private void Total (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                total = total + array[i];
            }

            Console.WriteLine("The total of arrays value is: " + total);

        }
        
        // average

        private void Average(int[] array, int elements)
        {
            average = total / elements;

            Console.WriteLine("The average of the array is: " + average);

        }

        // largest value

        private void Max(int[] array)
        {
            int max = 60;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            Console.WriteLine("Max value is: " + max);


        }
         
        // min value
        
        private void Min(int [] array)
        {
            int min = 60;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            Console.WriteLine("Min value is: " + min);

        }


        private int [] Sort(int [] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1 +i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;


                     }



                 }



            }

            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i] + " ");
            }
            return array;


        }

        //median

        private void Median(int[] array, int elements)
        {
            int middle = 0;
            int middle2;

            // checks if array odd or even

            if (array.Length % 2 == 0)
            {
                middle2 = (array[(elements / 2) - 1] +( array[elements / 2])) / 2;
                middle = array[middle2];
                Console.WriteLine("Median is: " + middle);
            }
            else
            {
                middle2 = elements / 2;
                middle = array[middle2];
                Console.WriteLine("Median is: " + middle);

            }
            
                         









        }




        
    }
}
