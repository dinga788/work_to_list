namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = 5;
            List<int> list = new List<int>(l);
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("Введите значения для a");
                int a = Convert.ToInt32(Console.ReadLine());
                list.Add(a);
            }
            Console.WriteLine("Вывод");
            foreach (var person in list)
            {
                Console.WriteLine(person + " ");
            }

            int temp = list[0];
            list[0] = list[l - 1];
            list[l - 1] = temp;

            Console.WriteLine("\nСписок после обмена первого и последнего элементов:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

        }
    }
}
