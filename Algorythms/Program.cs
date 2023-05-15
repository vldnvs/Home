using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace Algorythms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine('a' > 'b');

        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;

                a = b;
                b = remainder;

            }
            return a;
        }

        static int FindLargest(int[] numbers)
        {
            int largest = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < largest)
                {
                    largest = numbers[i];
                }

            }
            return largest;
        }

        static List<int> FindPrimes(int maxNumber)
        {
            //finding prime numbers in (2, maxNumber)

            bool[] isComposites = new bool[maxNumber];

            isComposites[0] = false;
            isComposites[1] = false;

            for (int i = 2; i < maxNumber; i += 2)
            {
                isComposites[i] = true;
            }

            int nextPrime = 3;
            int stopAt = Convert.ToInt32(Math.Sqrt(maxNumber));

            while (nextPrime <= stopAt)
            {
                for (int i = nextPrime * 2; i <= maxNumber; nextPrime += nextPrime)
                {
                    isComposites[i] = true;
                }

                nextPrime += 2;

                // чтобы пропускать числа, которые уже тру
                while (nextPrime <= maxNumber && isComposites[nextPrime])
                {
                    nextPrime += 2;
                }
            }

            List<int> primes = new List<int>();

            for (int i = 2; i < maxNumber; i++)
            {
                if (!isComposites[i])
                {
                    primes.Add(i);
                }
            }

            return primes;



        }

        static bool IsPrimeFerma(int p, int maxTests)
        {
            //can use it to check number if its prime (Theory of Ferma)

            for (int test = 1; test <= maxTests; test++)
            {
                Random random = new Random();
                int n = random.Next(1, p);

                if (Math.Pow(n, p - 1) % p != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

    class IntegerCell
    {
        //important to remember that we should use additional cell at the beginning of the structure 
        // second additional cell (usually have the biggest value of type)


        public int? cellValue;
        public IntegerCell? next;

        public void Iterate(IntegerCell top)
        {
            while (top != null)
            {
                Console.WriteLine(top.cellValue);
                top = top.next;
            }
        }

        public IntegerCell? FindCell(IntegerCell top, int targetValue)
        {
            while (top != null)
            {
                if (top.cellValue == targetValue)
                {
                    return top;
                }
                top = top.next;
            }
            return null;
        }

        public IntegerCell FindCellBefore(IntegerCell top, int targetValue)
        {
            while (top.next != null)
            {
                if (top.next.cellValue == targetValue)
                {
                    return top;
                }
                top = top.next;
            }
            return null;
        }

        public void AddAtBeggining(IntegerCell top, IntegerCell newCell)
        {
            newCell.next = top.next;
            top.next = newCell;
        }

        public void AddAtEnd(IntegerCell top, IntegerCell newCell)
        {
            while (top != null)
            {
                top = top.next;
            }

            newCell.next = top.next;
            top.next = newCell;
        }

        public void InsertCell(IntegerCell afterMe, IntegerCell newCell)
        {
            newCell.next = afterMe.next;
            afterMe.next = newCell;
        }

        public void DeleteAfter(IntegerCell afterMe)
        {
            afterMe.next = afterMe.next.next;
        }

        public void SortingInsertCell(IntegerCell top, IntegerCell newCell)
        {
            while (top.next != null && top.next.cellValue < newCell.cellValue)
            {
                top = top.next;
            }

            newCell.next = top.next;
            top.next = newCell;
        }

        public IntegerCell CopyList(IntegerCell oldSentinel)
        {
            IntegerCell newSentinel = new IntegerCell();
            IntegerCell lastAdded = newSentinel;
            IntegerCell oldCell = oldSentinel.next;

            while (oldCell != null)
            {
                lastAdded.next = new IntegerCell();

                lastAdded = lastAdded.next;

                lastAdded.cellValue = oldCell.cellValue;

                oldCell = oldCell.next;

            }

            lastAdded.next = null;

            return newSentinel;
        }

        public IntegerCell InsertionSort(IntegerCell input)
        {
            IntegerCell sentinel = new IntegerCell();

            sentinel.next = null;

            input = input.next;

            while (input != null)
            {
                IntegerCell nextCell = input;
                input = input.next;

                IntegerCell afterMe = sentinel;

                while (afterMe.next != null && afterMe.next.cellValue < nextCell.cellValue)
                {
                    afterMe = afterMe.next;
                }

                nextCell.next = afterMe.next;
                afterMe.next = nextCell;
            }
            return sentinel;
        }

        public IntegerCell SelectionSort(IntegerCell input)
        {
            IntegerCell sentinel = new IntegerCell();
            sentinel.next = null;

            while (input.next != null)
            {
                IntegerCell bestAfterMe = input;
                int? bestValue = bestAfterMe.next.cellValue;

                IntegerCell afterMe = input.next;
                while (afterMe.next != null)
                {
                    if (afterMe.next.cellValue > bestValue)
                    {
                        bestAfterMe = afterMe;
                        bestValue = afterMe.next.cellValue;
                    }

                    afterMe = afterMe.next;
                }
                IntegerCell bestCell = bestAfterMe.next;

                bestAfterMe.next = bestCell.next;

                bestCell.next = sentinel.next;
                sentinel.next = bestCell;

            }

            return sentinel;
            
        }
    }

    class TwoWaysIntegerCell
    {

        public TwoWaysIntegerCell? next;
        public TwoWaysIntegerCell? previous;
        public int? cellValue;

        public void InsertCell(TwoWaysIntegerCell afterMe, TwoWaysIntegerCell newCell)
        {
            newCell.next = afterMe.next;
            afterMe.next = newCell;

            newCell.next.previous = newCell;
            newCell.previous = afterMe;
        }
    }


  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }


    public class NumArray
    {

        List<int> _sums = new List<int>();

        public NumArray(int[] nums)
        {
            int summary = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                summary += nums[i];
                _sums.Add(summary);
            }

        }

        public int SumRange(int left, int right)
        {
            if (left == 0)
            {
                return _sums[right];
            }
            return _sums[right] - _sums[left - 1];
        }
    }

    /**
     * Your NumArray object will be instantiated and called as such:
     * NumArray obj = new NumArray(nums);
     * int param_1 = obj.SumRange(left,right);
     */





}























