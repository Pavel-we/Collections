using System;
using System.Linq;
using static System.Console;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static (int, int) minMax1(int[] array) => (array.Min(), array.Max());
        static int minMax2(int number, int[,] array)
        {
            int minS = array[0, 0] * array[1, 0];
            for(int i = 1; i < number; i++)
            {
                int newS = array[0, i] * array[1, i];
                    
                if (newS < minS)
                    minS = newS;
            }
            return minS; ;
        }
        static int minMax3(int number, int[,] array)
        {
            int maxP = 2 * (array[0, 0] * array[1, 0]);
            for (int i = 1; i < number; i++)
            {
                int newP = 2 * (array[0, i] * array[1, i]);

                if (newP < maxP)
                    maxP = newP;
            }
            return maxP;
        }
        static int minMax4(int[] array)
        {
            int indexMinimumNumber = 0;
            int minimumNumber = int.MaxValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < minimumNumber)
                {
                    indexMinimumNumber = i;
                    minimumNumber = array[i];
                } 
            }
            return indexMinimumNumber;
        }
        static double minMax5(double[,] array)
        {
            double maximumDensity = 0;

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    double density = array[0, i] / array[1, j];

                    if(density > maximumDensity)
                        maximumDensity = density;
                }
            }
            return maximumDensity;
        }
        static int? minMax6(int[] array)
        {
            int indexMinimumNumber = 0;
            int indexMaximumNumber = 0;

            int minimumNumber = int.MaxValue;
            int maximumNumber = int.MinValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < minimumNumber)
                {
                    indexMinimumNumber = i;
                    minimumNumber = array[i];
                }
                if(array[i] > maximumNumber)
                {
                    indexMaximumNumber = i;
                    maximumNumber = array[i];
                }
            }
            return null;

            Write(indexMinimumNumber < indexMaximumNumber ? indexMinimumNumber : indexMaximumNumber);
            Write(indexMaximumNumber > indexMinimumNumber ? indexMaximumNumber : indexMinimumNumber);
        }
        static int? minMax7(int[] array)
        {
            int indexMinimumNumber = 0;
            int indexMaximumNumber = 0;

            int minimumNumber = int.MaxValue;
            int maximumNumber = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maximumNumber)
                {
                    indexMaximumNumber = i;
                    maximumNumber = array[i];
                }
                if (array[i] < minimumNumber)
                {
                    indexMinimumNumber = i;
                    minimumNumber = array[i];
                }
            }
            return null;

            Write(indexMinimumNumber < indexMaximumNumber ? indexMinimumNumber : indexMaximumNumber);
            Write(indexMaximumNumber > indexMinimumNumber ? indexMaximumNumber : indexMinimumNumber);
        }
        static int? minMax8(int[] array)
        {
            int indexMinimumNumberA = 0;
            int indexMinimumNumberB= 0;

            int minimumNumberA = int.MaxValue;
            int minimumNumberB = int.MaxValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < minimumNumberA)
                {
                    indexMinimumNumberA = i;
                    minimumNumberA = array[i];
                }
                if(array[i] <= minimumNumberB)
                {
                    indexMinimumNumberB = i;
                    minimumNumberB = array[i];
                }
            }
            return null;

            Write(indexMinimumNumberA < indexMinimumNumberB ? minimumNumberA : minimumNumberB);
            Write(indexMinimumNumberB > indexMinimumNumberA ? minimumNumberB : minimumNumberA);
        }
        static int? minMax9(int[] array)
        {
            int indexMaximumNumberA = 0;
            int indexMaximumNumberB = 0;

            int maximumNumberA = int.MaxValue;
            int maximumNumberB = int.MaxValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > maximumNumberA)
                {
                    indexMaximumNumberA = i;
                    maximumNumberA = array[i];
                }
                if(array[i] >= maximumNumberB)
                {
                    indexMaximumNumberB = i;
                    maximumNumberB = array[i];
                }
            }
            return null;

            Write(indexMaximumNumberA < indexMaximumNumberB ? indexMaximumNumberA : indexMaximumNumberB);
            Write(indexMaximumNumberB > indexMaximumNumberA ? indexMaximumNumberB : indexMaximumNumberA);
        }
        static int minMax10(int[] array)
        {
            int minimumNumber = int.MaxValue;
            int maximumNumber = int.MinValue;
            int minimumNumberIndex = 0;
            int maximumNumberIndex = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < minimumNumber)
                {
                    minimumNumber = array[i];
                    minimumNumberIndex = i;
                }
                if(array[i] > maximumNumber)
                {
                    maximumNumber = array[i];
                    maximumNumberIndex = i;
                }
            }
            int indexExtremalNumber = Math.Min(maximumNumberIndex, minimumNumberIndex);
            return indexExtremalNumber;
        }
        static int minMax11(int[] array)
        {
            int minimumNumber = int.MaxValue;
            int maximumNumber = int.MinValue;
            int minimumNumberIndex = 0;
            int maximumNumberIndex = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] <= minimumNumber)
                {
                    minimumNumber = array[i];
                    minimumNumberIndex = i;
                   
                }
                if( array[i] >= maximumNumber)
                {
                    maximumNumber = array[i];
                    maximumNumber = i;
                }
            }
            int indexExtremalNumber = Math.Min(maximumNumberIndex, minimumNumberIndex);
            return indexExtremalNumber;
        }
        static int? minMax12(int[] array)
        {
            int minimumNumber = int.MaxValue;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < minimumNumber && array[i] >= 0)
                {
                    minimumNumber = array[i];
                }
            }
            return null;

            WriteLine(minimumNumber == int.MaxValue ? 0 : minimumNumber);
        }
        static int? minMax13(int[] array)
        {
            int maximumNumberIndex = 0;
            int maximumNumber = int.MinValue;

            for(int i = 0; i < array.Length; i++)
            {

                if(array[i] > maximumNumber && array[i] % 2 != 0)
                {
                    maximumNumberIndex = i;
                    maximumNumber = array[i];
                }
            }
            return null;

            if (maximumNumber != int.MinValue)
                Write(maximumNumberIndex);
        }
        static int? minMax14(int[] array, int numberB)
        {
            int minimumNumberIndex = 0;
            int minimumNumber = int.MaxValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < minimumNumber && array[i] > numberB)
                {
                    minimumNumberIndex = i;
                    minimumNumber = array[i];
                }
            }
            return null;
            if (minimumNumber != 0)
                Write($"{minimumNumberIndex}, {minimumNumber}");
            else
            {
                Write(0);
                Write(0);
            }
        }
        static int? minMax15(int[] array, int numberB, int numberC)
        {
            int minimumNumberIndex = 0;
            int minimumNumber = int.MaxValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < minimumNumber && array[i] > numberB && array[i] < numberC)
                {
                    minimumNumberIndex = i;
                    minimumNumber = array[i];
                }
            }
            return null;
            if(minimumNumberIndex != 0)
                Write($"{minimumNumberIndex}, {minimumNumber}");
            else
            {
                Write(0);
                Write(0);
            }
        }
        static int? minMax16(int[] array)
        {
            int minimumNumberIndex = 0;
            int minimumNumber = int.MaxValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < minimumNumber)
                {
                    minimumNumberIndex = i;
                    minimumNumber = array[i];
                }
            }
            return null;
            Write(minimumNumberIndex);
        }
        static int? minMax17(int[] array)
        {
            int maximumNumberIndex = 0;
            int maximumNumber = int.MinValue;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > maximumNumber)
                {
                    maximumNumberIndex = i;
                    maximumNumber = array[i];
                }
            }
            return null;
            Write(array.Length - maximumNumberIndex);
        }
        static int? minMax18(int[] array)
        {
            int maximumNumberIndexA = 0;
            int maximumNumberIndexB = 0;
            int maximumNumberA = int.MinValue;
            int maximumNumberB = int.MinValue;

            for(int i = 0;i < array.Length; i++)
            {
                if(array[i] > maximumNumberA)
                {
                    maximumNumberIndexA = i;
                    maximumNumberA = array[i];
                }
                if(array[i] >= maximumNumberB)
                {
                    maximumNumberIndexB = i;
                    maximumNumberB = array[i];
                }
            }
            return null;
            int ammount = maximumNumberIndexA - maximumNumberIndexB;
            Write(ammount == 0 ? 0 : ammount);
        }
        static int? minMax19(int[] array, int number)
        {
            int minNumberA = int.MinValue;
            int minNumberB = int.MinValue;

            for(int i = 1; i <= array.Length; i++)
            {
                if((number < minNumberA) || (i == 1))
                {
                    minNumberA = number;
                    minNumberB = 0;
                }
                if (number == minNumberA)
                    minNumberB++;
            }
            return null;
            Write(minNumberB);
        }
        static int minMax20(int[] array)
        {
            int numberOfElements = 0;
            int min = array.Min();
            int max = array.Max();

            foreach (int number in array)
            {
                if (number == min || number == max) numberOfElements++;
            }
            return numberOfElements;
        }
        static double? minMax21(int[] array)
        {
            double sum = 0;
            double mean = 0;
            int min = array.Min();
            int max = array.Max();

            foreach (double number in array)
            {
                if(number != min && number != max)
                {
                    sum += number;
                    mean++;
                }
                if (mean == 0) return null;
            }
            return (sum / mean);
        }
        static (int, int) minMax22(int[] array)
        {
            var(firstMinimumNumber, secondMinimumNumber) = array[0] > array[1] ?
                (array[1], array[0]) :
                (array[0], array[1]);

            for(int i = 2; i < array.Length; i++)
            {
                if(array[i] < secondMinimumNumber)
                {
                    if (array[i] < firstMinimumNumber)
                    {
                        secondMinimumNumber = firstMinimumNumber;
                        firstMinimumNumber = array[i];
                    }
                    else secondMinimumNumber = array[i];
                }
            }
            return (firstMinimumNumber, secondMinimumNumber);
        }
        static (int, int, int) minMax23(int[] array)
        {
            var (firstMaximumNumber, secondMaximumNumber, thirdMaximumNumber) = array[0] < array[1] && array[1] < array[2]?
                (array[0],array[1], array[2]) :
                (array[2], array[1], array[0]);

            for( int i = 3; i < array.Length; i++)
            {
                if(array[i] > firstMaximumNumber)
                {
                    if(array[i] > secondMaximumNumber)
                    {
                        if (array[i] > firstMaximumNumber)
                        {
                            firstMaximumNumber = secondMaximumNumber;
                            secondMaximumNumber = thirdMaximumNumber;
                            thirdMaximumNumber = array[i];
                        }
                        else firstMaximumNumber = array[i];
                    } 
                }
            }
            return (thirdMaximumNumber, secondMaximumNumber, firstMaximumNumber);
        }
        static int minMax24(int[] array)
        {
            int maxSumma = array[0] + array[1];
            for(int i = 1; i < array.Length - 1; i++)
            {
                int sum = array[i] + array[i + 1];

                if (maxSumma < sum)
                    maxSumma = array[i] + array[i + 1];
            }
            return maxSumma;
        }
        static (int, int) minMax25(int[] array)
        {
            int minDobootAdjacentNumber = array[0] * array[1];
            int firstAdjacentNumber = 0;
            int secondAdjacentNumber = 1;

            for(int i = 0; i < array.Length - 1; i++)
            {
                int dobootAdjacentNumber = array[i] * array[i + 1];
                if (minDobootAdjacentNumber > dobootAdjacentNumber)
                {
                    minDobootAdjacentNumber = array[i] * array[i + 1];
                    firstAdjacentNumber = 1;
                    secondAdjacentNumber = i + 1;
                   
                }
            }
            return (secondAdjacentNumber, firstAdjacentNumber);
        }
        static int minMax26(int[] array)
        {
            int numberOfEven = 0;
            int maxNumberOfEven = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) numberOfEven++;

                if (maxNumberOfEven < numberOfEven)
                    maxNumberOfEven = numberOfEven;

                if (array[i] % 2 == 1) numberOfEven = 0;
            }
            return maxNumberOfEven;
        }
        static int minMax27(int[] array)
        {
            int identicalNumbers = 1;
            int sequenceOfIdenticalNumbers = 1;

            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                    identicalNumbers++;

                else
                    identicalNumbers = 0;

                if (sequenceOfIdenticalNumbers < identicalNumbers)
                    sequenceOfIdenticalNumbers = identicalNumbers;
            }
            return sequenceOfIdenticalNumbers;
        }
        static int minMax28(int[] array)
        {
            int number = 1;
            int sequenceNumbers = 1;

            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i + 1])
                    number++;
                else
                {
                    Write(0);
                    Write(0);
                }
                if (sequenceNumbers < number)
                    sequenceNumbers = number;
            }
            return sequenceNumbers;
        }
        static int? minMax29(int [] array)
        {
            int max = 0;
            int minimalNumber = array.Min();
            int maxNumberOfConsecutiveElements = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == minimalNumber) 
                    max++;

                if (maxNumberOfConsecutiveElements < max)
                    maxNumberOfConsecutiveElements = max;

                else return null;
            }
            return maxNumberOfConsecutiveElements;
        }
        static int? minMax30(int[] array)
        {
            int min = 0;
            int maximalNumber = array.Max();
            int maxNumberOfConsecutiveElements = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == maximalNumber)
                    min++;
                if (maxNumberOfConsecutiveElements < min)
                    min = maxNumberOfConsecutiveElements;
                else return null;
            }
            return maxNumberOfConsecutiveElements;
        }

    }
}

