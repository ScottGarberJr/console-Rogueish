using System;
namespace Rogueish.logic
{
    public abstract class Object
    {

        // PROPERTIES
        string name;
        
        public int posX, posY;

        bool collissions = false;
        bool killable = false;

        private char _asset;
        public char asset
        {
            get { return _asset; }
        }
        private int _health = 1;
        public int health
        {
            get { return _health; }
            set { _health = health; }
        }

        // CONSTRUCTORS
        public Object(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }

        // METHODS
        public void whenAttacked()
        {
            
        }
        public void whenTouched()
        {

        }
    }
    // ----------------------------------------------  OBJECTS  ------------------------------------------ //
    public class Wall : Object
    {
        // PROPERTIES
        string name = "wall";

        bool collissions = true;
        bool killable = false;

        private char _asset = '#';
        public char asset
        {
            get { return _asset; }
        }
        private int _health = 1;
        public int health
        {
            get { return _health; }
            set { _health = health; }
        }

        // CONSTRUCTORS
        public Wall(int x, int y): base(x, y)
        {
            this.posX = x;
            this.posY = y;
        }

        // METHODS
        public void whenAttacked() { }
        public void whenTouched() { }
    }

    public class Boulder : Object
    {
        // PROPERTIES
        string name = "boulder";
        
        bool collissions = true;
        bool killable = true;

        private char _asset = '@';
        public char asset
        {
            get { return _asset; }
        }
        private int _health = 4;
        public int health
        {
            get { return _health; }
            set { _health = health; }
        }

        // CONSTRUCTORS
        public Boulder(int x, int y) : base(x, y)
        {
            this.posX = x;
            this.posY = y;
        }

        // METHODS
        public void whenAttacked() { }
        public void whenTouched() { }
    }

    //public class Empty : Object
    //{
    //    // PROPERTIES
    //    string name = "empty";
    //    char asset = ' ';
    //    int posX, posY;

    //    bool collissions = false;
    //    bool killable = false;
    //    private int _health = 1;
    //    public int health
    //    {
    //        get { return _health; }
    //        set { _health = health; }
    //    }

    //    // CONSTRUCTORS
    //    public Empty(int x, int y) : base(x, y)
    //    {
    //        this.posX = x;
    //        this.posY = y;
    //    }

    //    // METHODS
    //    public void whenAttacked() { }
    //    public void whenTouched() { }
    //}

    public class Spikes : Object
    {
        // PROPERTIES
        string name = "spikes";
        
        int posX, posY;

        bool collissions = true;
        bool killable = false;

        private char _asset = '%';
        public char asset
        {
            get { return _asset; }
        }
        private int _health = 1;
        public int health
        {
            get { return _health; }
            set { _health = health; }
        }

        // CONSTRUCTORS
        public Spikes(int x, int y) : base(x, y)
        {
            this.posX = x;
            this.posY = y;
        }

        // METHODS
        public void whenAttacked() { }
        public void whenTouched() { }
    }

    public class Coin : Object
    {
        // PROPERTIES
        string name = "coin";
        
        int posX, posY;

        bool collissions = false;
        bool killable = false;

        private char _asset = '$';
        public char asset
        {
            get { return _asset; }
        }
        private int _health = 1;
        public int health
        {
            get { return _health; }
            set { _health = health; }
        }

        // CONSTRUCTORS
        public Coin(int x, int y) : base(x, y)
        {
            this.posX = x;
            this.posY = y;
        }

        // METHODS
        public void whenAttacked() { }
        public void whenTouched()
        {

        }
    }


}

