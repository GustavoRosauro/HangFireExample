using System;

namespace HangFireCore
{
    public interface IDemoJob
    {
        void RunDemoTask();
    }
    public class DemoJob:IDemoJob
    {
        public void RunDemoTask()
        {
            Console.WriteLine("simple task example ");
        }
    }
}
