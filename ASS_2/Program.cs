using System.Collections;

namespace ASS_2
{
    internal class Program
    {
        public static void reverse(ArrayList list)
        {
            Console.WriteLine("please enter num of element");
            int.TryParse(Console.ReadLine(), out int numOfElement);
            for (int i = 0; i < numOfElement; i++)
            {
                Console.WriteLine("enter number");
                int.TryParse(Console.ReadLine(), out int x);
                list.Add(x);
            }
         
                int n = list.Count;

                for (int i = 0; i < n / 2; i++)
                {
                    int temp = (int)list[i];
                    list[i] = list[n - 1 - i];
                    list[n - 1 - i] = temp;
                }
            
        }
        public static void even(List<int> list)
        {
            
        }
        static void Main(string[] args)
        {
            #region Part 1
            /*
     Collections contain from Non Generic Collections and Generic Collections
    first non Generic Collections
     *Implemented In C# 1.0 
     *Before Generics 
     *Based On Object 

     as example
    *Arraylist 
    * Sorted Array 
    * Stack 
    * Queue 
    * Hashtable

    non Generic Collections consist of
    * Lists
    * Hashtable
    ============================================
    second Generic Collections
    *Implemented In C# 2.0 
    *Based On Generic

    as example 
    * List 
    * LinkedList 
    * Stack 
    * Queue  
    * Dictionary

    Generic Collections consist of
    * Lists
    * Hashtable
     */
            #endregion

            #region Q1
            //ArrayList list = new ArrayList();
            //reverse(list);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q2
            //List<int> numbers1 = new List<int>();
            //Console.WriteLine("please enter number of element");
            //int.TryParse(Console.ReadLine(), out int numOfElement);
            //for (int i = 0; i < numOfElement; i++)
            //{
            //    Console.WriteLine("please enter number ");
            //    int.TryParse(Console.ReadLine(), out int x);
            //    numbers1.Add(x);
            //}
            //List<int> numbers2 = new List<int>();
            //foreach (var item in numbers1)
            //{
            //    if (item % 2 == 0)
            //        numbers2.Add(item);
            //}
            //foreach (var item in numbers2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q3
            //FixedSizeList<int> fixedSize = new FixedSizeList<int>(5);
            //fixedSize.Add(1);
            //fixedSize.Add(2);
            //fixedSize.Add(3);
            //fixedSize.Add(4);

            //Console.WriteLine(fixedSize.Retrieve(3)); 
            #endregion

        }
    }
}