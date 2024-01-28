using System;

namespace hello_world
{
    public class Username
    {
        private int idNumber;

        public int setId(int idNumber)
        {
            return this.idNumber = idNumber;
        }

        public int getId()
        {
            return this.idNumber;
        }
    }
}
