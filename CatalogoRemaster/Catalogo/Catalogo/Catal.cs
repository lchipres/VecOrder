using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Catal 
    {
        Producto[] p = new Producto[15];
        int cuantosBan = 0;

        public void agregarP(Producto p)
        {
            this.p[cuantosBan] = p;
            cuantosBan++;
        }

        public int getCuantos()
        {
            return cuantosBan;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Producto element in p)
            {
                s += element+Environment.NewLine;
            }
            return s;
        }

        public string buscarP(int codigo)
        {
            string s = "";
            foreach(Producto element in p)
            {
                if (element.getCodigo() == codigo)
                {
                    s += element + Environment.NewLine;
                }
            }
            return s;
        }

        public void eliminarP(int codigo)
        {
            int tmp = 0;
            bool bandera = false;
            for(int i=0;i<15;i++)
            {
                if (p[i] != null)
                {
                    if (p[i].getCodigo() == codigo)
                    {
                        tmp = p[i+1].getID();
                        p[i+1] = null;
                        for (i=tmp; i < p.Length; i++)
                        {
                            if (p[i+1] != null)
                            {
                                p[i] = p[i + 1];
                            }
                            else if (p[i+1] == null)
                            {
                                cuantosBan = p[i].getID() + 1;
                                break;
                            }
                        }
                        bandera = true;
                    }
                    else if (bandera == true)
                    {
                        break;
                    }
                }         
            }
            
        }

    }
}
