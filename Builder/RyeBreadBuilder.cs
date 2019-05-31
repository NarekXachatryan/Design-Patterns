using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class RyeBreadBuilder:BreadBuilder
    {
        public override void SetAdditives()
        {
            
        }

        public override void SetFlour()
        {
            this.Bread.Flour = new Flour
            {
                Sort = "Ржаная мука 1 сорт"
            };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }
    }
}
