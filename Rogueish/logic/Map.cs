using System;
using System.Collections.Generic;
using Rogueish.logic;

namespace Rogueish.logic
{
        public class Map
    {
        /*
         *  - Start of a game, new Map() is created, which loads the overridden LoadMap() for different maps, a LoadBorder(), and LoadPlayer()
         *  - Changes to positions are updated on the Object in a list. All map objects are on the list. after each turn, UpdateMap() reloads the map
         *  then updates the cells based on list objects' positions
         */



        string name;
        List<Object> objects = new List<Object>();
        char[,] grid = new char[30, 30];


        public Map(string name)
        {
            this.name = name;
            LoadThisMap();
            //Console.WriteLine("Map loaded."); // testing
        }

        public void LoadThisMap()
        {

            for (int row = 0; row < 30; row++)
            {
                for (int col = 0; col < 30; col++)
                {
                    if (row == 0 || row == 29 || col == 0 || col == 29)
                    {
                        grid[row, col] = ' ';
                    }
                }
            }

            LoadBorder();
            Update();

        }

        public void Update()
        {
            foreach (Object obj in objects)
            {
                grid[obj.posX, obj.posY] = obj.asset;
            }
            for (int row = 0; row < 30; row++)
            {
                for (int col = 0; col < 30; col++)
                {
                    Console.Write(grid[row, col]);
                }
                Console.Write("\n");
            }

        }

        public void LoadBorder()
        {
            for(int row=0; row < 30; row++)
            {
                for (int col = 0; col < 30; col++)
                {
                    if(row==0 || row==29 || col==0 || col == 29)
                    {
                        objects.Add(new Wall(row, col));
                    }
                }
            }
        }

        public void LoadPlayer()
        {
            
        }
    }
}

