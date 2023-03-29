using StackAndQueue_day14;

namespace StackAndQueueDay14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queue Program!");
            Console.WriteLine("#####################");
            UC1_CreateStack obj = new UC1_CreateStack();
            obj.push(70);
            obj.push(30);
            obj.push(56);
            obj.Display();

        }

    }
}
