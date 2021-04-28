using System;
using System.Collections.Generic;
using System.Text;

namespace DataStrFinalProject
{

    class Item 
    {
        
        private static HashSet<string> pack = new HashSet<string>(); //could be item objects


        public HashSet<string> getPack()
        {
            return pack;
        }

        public void AddItem(string item)
        {
            this.getPack().Add(item);
        }

        public void UseItem(string item)
        {
            this.getPack().Remove(item);
        }

        public void OpenItemBox()
        {
            foreach (string item in this.getPack())
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }

    }
}
