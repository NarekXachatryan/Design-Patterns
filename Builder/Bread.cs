﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Bread
    {
        public Flour Flour { get; set; }
        public Salt Salt { get; set; }
      
        public Additives Additives { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Flour != null)
                sb.Append(Flour.Sort + "\n");
            if (Salt != null)
                sb.Append("Соль \n");
            if (Additives != null)
                sb.Append("Добавки: " + Additives.Name + " \n");
            return sb.ToString();
        }
    }


    class Flour
    {
        public string Sort { get; set; }
    }
    class Salt
    {

    }
    class Additives
    {
        public string Name { get; set; }
    }
   
}
