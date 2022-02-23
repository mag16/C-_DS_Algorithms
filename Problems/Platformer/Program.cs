using System;

namespace Platformer {

    public class Platformer {
        public Platformer (int numberOfTiles, int position) {
            throw new InvalidOperationException ("Waiting to be implemented.");
        }

        public void JumpLeft () {
            throw new InvalidOperationException ("Waiting to be implemented.");
        }

        public void JumpRight () {
            throw new InvalidOperationException ("Waiting to be implemented.");
        }

        public int Position () {
            throw new InvalidOperationException ("Waiting to be implemented.");
        }

        public static void Main (string[] args) {
            Platformer platformer = new Platformer (6, 3);
            Console.WriteLine (platformer.Position ()); // should print 3

            platformer.JumpLeft ();
            Console.WriteLine (platformer.Position ()); // should print 1

            platformer.JumpRight ();
            Console.WriteLine (platformer.Position ()); // should print 4
        }
    }
}