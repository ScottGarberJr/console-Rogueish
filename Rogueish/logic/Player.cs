using System;
using System.Collections.Generic;
namespace Rogueish.logic
.logic
{
    public class Player : Object
    {
        // PROPERTIES
        public string name;
        public bool collissions = true;
        private char _asset = '0';
        public char asset
        {
            get { return _asset; }
        }
        public int posX, posY;

        private string _direction = "down";
        public string direction
        {
            get { return _direction; }
            set
            {
                List<string> directions = new List<string>{ "up", "down", "left", "right" };
                if (directions.Contains(direction))
                {
                    _direction = direction;
                }
            }
        }

        private int _score = 0;
        public int score
        {
            get { return _score; }
            set { _score = score; }
        }
        private int _health = 1;
        public int health
        {
            get { return _health; }
            set { _health = health; }
        }

        private int _attack = 1;
        public int attack
        {
            get { return _attack; }
            set { _attack = attack; }
        }

        // CONSTRUCTORS
        public Player(string user, int x, int y) : base(x, y)
        {
            this.name = user;
            this.posX = x;
            this.posY = y;
        }

        // METHODS

        public void whenAttacked()
        {

        }

        public void moveTo(int x, int y)
        {

        }

        public void Attack()
        {

        }


    }





}

