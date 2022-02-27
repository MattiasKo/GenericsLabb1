//SUT21 Mattias Kokkonen

using System;

namespace GenericsLabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            LådaCollection LåList = new LådaCollection();

            LåList.Add(new Låda(1, 2, 3));
            LåList.Add(new Låda(2, 5, 1));
            LåList.Add(new Låda(5, 2, 1));
            LåList.Add(new Låda(16, 5, 10));
            LåList.Add(new Låda(30, 30, 30));
            


            Visa(LåList);

            LåList.Add(new Låda(30, 30, 30));
            LåList.Add(new Låda(1, 5, 2));
           

            LåList.Remove(new Låda(16, 5, 10));
            Console.WriteLine();
            Visa(LåList);

            //testa contain
            Låda kollaLåda = new Låda(1, 2, 3);
            Console.WriteLine("Contains= \tHöjd:{0}\tLängd:{1}\tBredd:{2} : {3}",
                kollaLåda.höjd.ToString(),kollaLåda.längd.ToString(), kollaLåda.bredd.ToString(), 
                LåList.Contains(kollaLåda).ToString());

            //testa contain same value
            Låda kollaLåda2 = new Låda(1, 2, 3);
            Console.WriteLine("Contains= \tHöjd:{0}\tLängd:{1}\tBredd:{2} : {3}",
                kollaLåda2.höjd.ToString(), kollaLåda2.längd.ToString(), kollaLåda2.bredd.ToString(),
                LåList.Contains(kollaLåda2,new LådaSameValues()).ToString());

            Låda kollaLåda3 = new Låda(2, 1, 5);
            Console.WriteLine("Contains= \tHöjd:{0}\tLängd:{1}\tBredd:{2} : {3}",
                kollaLåda3.höjd.ToString(), kollaLåda3.längd.ToString(), kollaLåda3.bredd.ToString(),
                LåList.Contains(kollaLåda3,new LådaSameVol()).ToString());

            Console.ReadKey();

        }

        public static void Visa(LådaCollection LådaList)
        {
            Console.WriteLine("\nHöjd\tLängd\tBredd\tHashcode");

            foreach (Låda l in LådaList)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                     l.höjd.ToString(), l.längd.ToString(), l.bredd.ToString(), l.GetHashCode().ToString());
            }
        }
    }

}
