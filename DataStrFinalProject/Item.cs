using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStrFinalProject
{

    class Item 
    {

        //private static HashSet<string> pack = new HashSet<string>(); //could be item objects
        //private static string[] pack = new string[100];
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
            /*
            foreach (string item in this.getPack())
            {
                Console.Write(item+" ");
            }
            */
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
