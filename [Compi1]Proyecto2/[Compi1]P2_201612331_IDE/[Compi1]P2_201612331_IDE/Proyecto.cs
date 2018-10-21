using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Compi1_P2_201612331_IDE
{
    public class Proyecto
    {
        String path;
        Boolean enlinea;
        public Proyecto()
        {
            path = "";
            enlinea = false;
        }
        public void setPath(String path)
        {
            this.path = path;
            enlinea = true;
        }
        public String getPath()
        {
            if(enlinea)
            {
                return this.path;
            }
            else
            {
                return "";
            }
        }
    }
}
