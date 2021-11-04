using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoPost post1 = new VideoPost("Video", "Ivan", true, "www.youtube.com", 12.34);
            Console.WriteLine(post1.ToString());
        }
    }
}
