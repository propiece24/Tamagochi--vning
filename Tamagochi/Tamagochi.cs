using System;
using System.Collections.Generic;

namespace Tamagochi
{
    public class Tamagochi
    {
        
        private int hunger = 0;
        private int boredom = 0;
        private List<string> words = new List<string>();
        private bool isAlive = true;
        private Random generator = new Random();
        public string name = ("");


        public void Feed()
        {
           hunger --;
        }
        public void Hi()
        {
          ReduceBoredom();
          
        
      

        }
        public void Teach(string word)
        {

          
 

        }
        public void Tick()
        {



        }
        public void PrintStats()
        {



        }
        public bool GetAlive()
        {
           if( isAlive == true)
           {
               return true;
           }
           else
           {
              return false;
           }
        }
        private void ReduceBoredom()
        {
          boredom --;
        }





    }



}



