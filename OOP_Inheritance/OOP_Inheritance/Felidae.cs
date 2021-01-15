using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    /// <summary>Felidae is latin for "cats"</summary>
    public class Felidae
    {
        private bool male;

        // This constructor calls another constructor
        public Felidae() : this(true)
        {

        }

        // This is the constructor that is inherited
        public Felidae(bool male)
        {
            this.male = male;
        }

        public bool Male
        {
            get { return male; }
            set { this.male = value; }
        }

        public virtual void Walk()
        {
            // ... 
        }
    }
}
