using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo_de_for
{
    class Camion
    {
        string matricula;
        int capacidad;
        double consumo;
        int cargaActual;


        Camion()
        {

        }

        public Camion(string matricula,int capacidad,double consumo)
        {
            this.matricula = matricula;
            this.capacidad = capacidad;
            this.consumo = consumo;
            this.cargaActual = 0;
        }

        
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        } 
        
        public int Capacidad
        {
            get { return capacidad; }
            set {capacidad = value; }
        }
        public double Consumo
        {
            get { return consumo; }
            set {consumo = value; }
        }

        public int CargaActual
        {
            get { return cargaActual; }
            set { cargaActual = value; }
        }

        public bool cargar(int carga)
        {
            if (this.capacidad >= carga) { 
                cargaActual = carga;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void descargar()
        {
            cargaActual = 0;
        }
    }
}
