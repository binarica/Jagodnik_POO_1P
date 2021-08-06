using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EntidadFinanciera
{
    public class Titular
    {
        List<Tarjeta> _listaTarjetas;
        public Titular() { }
        public Titular(string pTipoDoc, string pNroDoc, string pNombre, string pApellido)
        {
            TipoDoc = pTipoDoc;
            NroDoc = pNroDoc;
            Nombre = pNombre;
            Apellido = pApellido;
            _listaTarjetas = new List<Tarjeta>();
        }

        public string TipoDoc { get; set; }
        public string NroDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public void AñadirTarjeta(Tarjeta pTarjeta)
        {
            try
            {
                if (pTarjeta.RetornaTitular() == null)
                {
                    _listaTarjetas.Add(pTarjeta);
                    _listaTarjetas.Last().AsignarTitular(this);
                    pTarjeta.AsignarTitular(this); 
                }
                else
                {
                    throw new Exception("Esta tarjeta ya está asignada."); 
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }
        }

        public void EliminarTarjeta(Tarjeta pTarjeta)
        {
            if (_listaTarjetas.Contains(pTarjeta))
            {
                _listaTarjetas.Remove(pTarjeta);
            }
        }

        public List<Tarjeta> RetornaListaTarjetas()
        {
            List<Tarjeta> aux = new List<Tarjeta>();
            foreach (Tarjeta a in _listaTarjetas) { 
                aux.Add(a); 
            }
            return aux;
        }
    }
}
