﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    internal class Maze
    {
        Room kitchen;
        Room livingRoom;
        Room exit;
        Room bathroom;
        Room bedroom;
        Room tortureChamber;

        // Special rooms
        Room startRoom;
        Room winningRoom;
        Room losingRoom;
   
        public Maze() {
            this.kitchen = new Room("Kitchen");
            this.livingRoom = new Room("Living Room");
            this.exit = new Room("Exit");
            this.bathroom = new Room("Bathroom");
            this.bedroom = new Room("Bedroom");
            this.tortureChamber = new Room("Torture Chamber");

            this.setSpecialRooms();
            this.setRoomConnections();
        }

        private void setRoomConnections()
        {
            this.kitchen.setConnectedRooms(null, this.livingRoom, this.bathroom, null);
            this.livingRoom.setConnectedRooms(null, this.exit, this.bedroom, this.kitchen);
            this.exit.setConnectedRooms(null,null, null, this.livingRoom);
            this.bathroom.setConnectedRooms(this.kitchen, this.bedroom,null, null);
            this.bedroom.setConnectedRooms(this.livingRoom, null, this.tortureChamber, this.bathroom);
            this.tortureChamber.setConnectedRooms(this.bedroom, null, null, null);
        }

        private void setSpecialRooms()
        {
            this.winningRoom = this.exit;
            this.losingRoom = this.tortureChamber;
            this.startRoom = this.bathroom;
        }

        public Room getStartRoom()
        {
            return this.startRoom;
        }

        public Room getWinningRoom()
        {
            return this.winningRoom;
        }

        public Room getLosingRoom()
        {
            return this.losingRoom;
        }
    }
}
