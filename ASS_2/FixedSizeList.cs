namespace ASS_2
{
    public class FixedSizeList<T>
    {
        int capacity;
        List<int> list;
        int size;

        public FixedSizeList(int c)
        {
            capacity = c;
            size = 0;
            list = new List<int>(); // تهيئة القائمة
        }

        public void Add(int item)
        {
            if (size >= capacity)
                Console.WriteLine("Cannot enter number, the list is full");
            else
            {
                list.Add(item);
                size++;
            }
        }

        public int Retrieve(int item)
        {
            return list.IndexOf(item);
        }

        public void Display()
        {
            Console.WriteLine("List items:");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}