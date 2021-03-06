﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Inmuebles
    {
        public string IdI { get; set; }
        public string Ciudad { get; set; }
        public string DireccionI { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }
        public double Comision { get; set; }
        public int Medida { get; set; }
        public int Banos { get; set; }
        public int Dormitorios { get; set; }
        public string Foto { get; set; }

        public Inmuebles() { }

        public Inmuebles(string pId, string pCiudad, string pDireccion, string pDescripcion, string pTipo, double pPrecio,double pComision, int pMedida, int pBanos,int pDormitorios,string pFoto)
        {
            this.IdI = pId;
            this.Ciudad = pCiudad;
            this.DireccionI = pDireccion;
            this.Descripcion = pDescripcion;
            this.Tipo = pTipo;
            this.Precio = pPrecio;
            this.Comision = pComision;
            this.Medida = pMedida;
            this.Banos = pBanos;
            this.Dormitorios = pDormitorios;
            this.Foto = pFoto;
        }
    }
}
