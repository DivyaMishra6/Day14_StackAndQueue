using StackAndQueue_day14;

namespace StackAndQueueDay14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queue Program!");
            Console.WriteLine("#####################");

            PeekAndPopUC2 obj = new PeekAndPopUC2();
            obj.push(70);
            obj.push(30);
            obj.push(56);
            obj.Display();
            //obj.Peek();
            Console.WriteLine("After pop operation:");
            //obj.Pop();
            obj.IsEmpty();
            obj.Display();
        }

    }
}
