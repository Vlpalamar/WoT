using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public   class Tank
    {
        public string Name { get; set; }
        protected int Ammo_lvl { get; set; }
        protected int Armor_lvl { get; set; }
        protected int Maneuv_lvl { get; set; } 

        public Tank(string name="T34")
        {  
            Name = name;
            var rand = new Random();
            Ammo_lvl = rand.Next(1, 100);
            Armor_lvl = rand.Next(1, 100);
            Maneuv_lvl = rand.Next(1, 100);
        }

        public static int operator *(Tank t1, Tank t2)
        {
            int victory_count1=0;
            int victory_count2=0;

            if     (t1.Ammo_lvl > t2.Ammo_lvl)
                victory_count1++;
            else if(t1.Ammo_lvl<t2.Ammo_lvl)
                victory_count2++;

            if      (t1.Armor_lvl > t2.Armor_lvl)
                victory_count1++;
            else if (t1.Armor_lvl < t2.Armor_lvl)
                victory_count2++;

            if      (t1.Maneuv_lvl > t2.Maneuv_lvl)
                victory_count1++;
            else if (t1.Maneuv_lvl < t2.Maneuv_lvl)
                victory_count2++;


            if      (victory_count1 == victory_count2)
                return 0;
            else if (victory_count1 > victory_count2)             
                return -1;           
            else
                return 1;
            
           



        }



    }
}
