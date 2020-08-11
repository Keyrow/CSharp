using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet BestBuffetInTheWorld = new Buffet();
            Ninja Song = new Ninja(2000);
            while (!Song.IsFull)
            {
                Song.Eat(BestBuffetInTheWorld.Serve());
            }
            Song.Eat(BestBuffetInTheWorld.Serve());
        }
    }
}
