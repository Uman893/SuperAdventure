using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Workbench
    {
        public int classVariable1 = 3; 
        private int classVariable2 = 7;
        private int classVariable3;

        public void Function1()
        {
            int functionVariable1;
            if(classVariable1 < 5)
            {
                functionVariable1 = 1;
                int innerVariable1;
            }

            if(classVariable1 <= 5)
            {
                functionVariable1= 2;
                int innerVariable1;

            }
        }

        public void Function2()
        {
            int functionVariable1;

            if(classVariable2< 5)
            {
                functionVariable1 = 3;
                int innerVariable1;
            }

            if(classVariable2 >=5)
            {
                functionVariable1 = 4;

                int innerVariable1;
            }
        } 
    }
}
