using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inve_inve.Models.Enum;

namespace inve_inve.Models
{
    public class Cambio
    {
        public string SolicitanteCed{get;set;}
        public Equipo Equipo{get;set;}
        public Tipo tipo;
        public string Justificacion{get;set;}
        public Estado estado;
        public Fecha FechaCreacion=Fecha.Now();

        public Cambio(string solicitanteCed, Equipo equipo, Tipo tipo, string justificacion)
        {
            SolicitanteCed = solicitanteCed;
            Equipo = equipo;
            this.tipo = tipo;
            Justificacion = justificacion;
            estado= Estado.PENDIENTE;
        }
        public Cambio(string solicitanteCed, Equipo equipo, string justificacion)
        {
            SolicitanteCed = solicitanteCed;
            Equipo = equipo;
            tipo = Tipo.ELIMINACION;
            Justificacion = justificacion;
            estado= Estado.PENDIENTE;
        }
        public Cambio(string solicitanteCed, Equipo equipo)
        {
            SolicitanteCed = solicitanteCed;
            Equipo = equipo;
            tipo = Tipo.AGREGACION;
            Justificacion = "NA";
            estado= Estado.PENDIENTE;
        }
        public Cambio(string format){
            string[] obj=  format.Split(":");
            SolicitanteCed = obj[0];
            Equipo = new Equipo(obj[1]);
            tipo = TipeTraslator(obj[2]);
            estado= EstadoTraslator(obj[3]);
            Justificacion = (obj[4]!= "NA")?obj[4]:"NA";
            
        }
        public Tipo TipeTraslator(string format){
            switch (format)
            {
                case "ELIMINACION":
                return Tipo.ELIMINACION;

                case "AGREGACION":
                return Tipo.AGREGACION;

                default:
                return Tipo.ELIMINACION;
            }

        }
        public Estado EstadoTraslator(string format){
            switch (format)
            {
                case "ACEPTADA":
                return Estado.ACEPTADA;

                case "PENDIENTE":
                return Estado.PENDIENTE;
                case "RECHAZADA":
                return Estado.RECHAZADA;

                default:
                return Estado.PENDIENTE;
            }

        }
        
        public override string ToString()
        {
            return $@"{SolicitanteCed}:{Equipo.ToString()}:{tipo}:{estado}:{Justificacion}";
        }
        
    }
}