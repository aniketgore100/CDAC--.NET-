using System.Collections;
namespace collectionExample

{
    internal class Program
    {
        static void Main1()
        {
            ArrayList o = new ArrayList();
            o.Add(1);
            o.Add("ANIKET");
            o.Add(2.34);
            o.Add(false);

            Console.WriteLine(o.Count);
           // o.RemoveAt(2);
            //foreach(object i in o)
            //{
            //    Console.WriteLine(i);
            //}
            ArrayList o2 = new ArrayList();
            o2.Add(10);
            o.AddRange(o2);
            o.Insert(0, "gore");
            o.InsertRange(0, o2);
            o.Remove(1);
            o.RemoveAt(0);
            o.RemoveRange(0, 2);
            foreach (object i in o)
            {
                Console.WriteLine(i);
            }
            o2 = o.GetRange(0, 3);
            Console.WriteLine(o[0]);
        }
        static void Main2()
        {
            ArrayList obj = new ArrayList();
            Console.WriteLine($"count is {obj.Count}, capacity is {obj.Capacity}");
            obj.Add(2);
            obj.TrimToSize();
            Console.WriteLine($"count is {obj.Count}, capacity is {obj.Capacity}");
        }
        static void Main()
        {
            SortedList obj = new SortedList();
            obj.Add(10, "aniket");
            Console.WriteLine(obj.Count);
            obj[2] = "gore";
            foreach (DictionaryEntry item in obj)
            {
                Console.WriteLine($"key is {item.Key}, value is {item.Value}");
            }
        }
        
}
}