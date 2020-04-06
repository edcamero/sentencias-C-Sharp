using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_de_trasporte
{
    class EmpresaTrasporte
    {
        Camion[] camiones;
        
        public EmpresaTrasporte()
        {
            
            camiones = new Camion[4];
            camiones[0] = new Camion("BAC213", 150, 85);
            camiones[1] = new Camion("CAP384", 190, 70);
            camiones[2] = new Camion("GER273", 280, 100);
            camiones[3] = new Camion("JKV232", 215, 110);
        }

        public Camion darCamion1()
        {
            return camiones[0];
        }
        public Camion darCamion2()
        {
            return camiones[1];
        }
        public Camion darCamion3()
        {
            return camiones[2];
        }
        public Camion darCamion4()
        {
            return camiones[3];
        }

        public bool cargarCamion(String pMatricula, int pPesoCarga)
        {   foreach(Camion camion in camiones)
            {
                if (camion.Matricula == pMatricula)
                {   
                    return camion.cargar(pPesoCarga);
                }
            }
            return false;
        } 
        
        public void descargarCamion(String pMatricula)
        {   foreach(Camion camion in camiones)
            {
                if (camion.Matricula == pMatricula)
                {
                     camion.descargar();
                }
            }
        }

        public int darCapacidadTotal()
        {
            int capacidadTotal = 0;
            foreach(Camion camion in camiones)
            {
                capacidadTotal = capacidadTotal + camion.Capacidad;
            }
            return capacidadTotal;
        } 
        
        public int darCargaActualTotal()
        {
            int cargaActual = 0;
            foreach(Camion camion in camiones)
            {
                cargaActual = cargaActual + camion.CargaActual;
            }
            return cargaActual;
        }

        public double calcularCargaPromedio()
        {
            int cargaTotal = 0;
            double cargaPromedio=0;
            foreach(Camion camion in camiones)
            {
                cargaTotal = cargaTotal + camion.CargaActual;
            }
            cargaPromedio = cargaTotal / 4;
            return cargaPromedio;
        }

        public Camion darMejorCamion(int pPesoCarga)
        {
            Camion aux = null;
            
            foreach (Camion camion in camiones)
            {
                if (aux == null)
                {
                    if (camion.Capacidad >= pPesoCarga)
                    {
                        aux = camion;
                    }
                }
                else
                {
                    if(camion.Capacidad >= pPesoCarga&& camion.Consumo < aux.Consumo)
                    {
                        aux = camion;
                    }
                }
            }

            return aux;
            
        }

    }
}
