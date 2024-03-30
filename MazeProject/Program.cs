namespace MazeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Exercise 4-2
            //Room room1 = new Room("Room1");
            //Room room2 = new Room("Room2");

            //// Set room1's east to room2, room2's west to room1
            //room1.setConnectedRooms(null, room2, null, null);
            //room2.setConnectedRooms(null, null, null, room1);


            ////Prints 'This is room Room2'
            //room1.getConnectedRoom('E').print();

            ////Prints 'This is room Room1'
            //room2.getConnectedRoom('W').print();

            //// Exercise 4-3
            //Maze maz = new Maze();
            //if (maz.getStartRoom().getConnectedRoom('N').
            //getConnectedRoom('E').getConnectedRoom('E') == maz.getWinningRoom())
            //{
            //    Console.WriteLine("The maze seems to be set up correctly!");
            //}
            //else
            //{
            //    Console.WriteLine("There seems to be something wrong with the maze!");
            //}

            //// Exercise 4-4
            //Maze maz = new Maze();
            //Player pla = new Player(maz.getStartRoom());
            //pla.move('N');
            //pla.move('E');
            //pla.move('E');
            //Console.WriteLine("The player is now in {0}", pla.getCurrentRoom().getName());



        }
    }
}
