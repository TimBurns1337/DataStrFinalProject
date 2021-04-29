using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStrFinalProject
{

    class Item 
    {
        private static ArrayList pack = new ArrayList();

        public ArrayList getPack()
        {
            return pack;
        }

        public void AddItem(string item)
        {
            pack.Add(item);
        }
        
        public void UseItem(int item)
        {
           pack.RemoveAt(item);            
        }

        public void OpenItemBox()
        {            
            int i = 0;
            foreach (var item in pack)
            {
                Console.WriteLine(i + " / " + item + " ");
                i++;
            }
            Console.WriteLine();
        }

    }
}
