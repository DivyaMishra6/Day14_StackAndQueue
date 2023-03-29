using StackAndQueue_day14;

namespace StackAndQueueDay14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queue Program!");
            Console.WriteLine("#####################");
            CreateDeqeue obj = new CreateDeqeue();
            obj.Enqueue(56);
            obj.Enqueue(30);
            obj.Enqueue(70);
            //obj.Display();

            Console.WriteLine("Element stored in queue is:-");
            obj.Display();
            Console.WriteLine("After Dequeue operation:");
            obj.Dequeue();
            Console.WriteLine("Element stored in queue is:-");
            obj.Display();

        }

    }
}
