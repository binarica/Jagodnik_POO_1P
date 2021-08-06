using System.Collections.Generic;

namespace EntidadFinanciera
{
    public class VistaTarjetasTitular
    {
        private List<VistaTarjetasTitular> ListaVistaTarjetasTitular;

        public long NroTarjeta { get; set; }
        public string FechaOtorgamiento { get; set; }
        public string FechaVencimiento { get; set; }

        public VistaTarjetasTitular()
        {
            ListaVistaTarjetasTitular = new List<VistaTarjetasTitular>();
        }

        public VistaTarjetasTitular(long pNroTarjeta, string pFechaOtorgamiento, string pFechaVencimiento)
        {
            NroTarjeta = pNroTarjeta;
            FechaOtorgamiento = pFechaOtorgamiento;
            FechaVencimiento = pFechaVencimiento;
        }

        public List<VistaTarjetasTitular> RetornaListaVistaTarjetasTitular(Titular pTitular)
        {
            ListaVistaTarjetasTitular.Clear();
            List<Tarjeta> tarjetas = pTitular.RetornaListaTarjetas();
            tarjetas.ForEach(t => ListaVistaTarjetasTitular.Add(new VistaTarjetasTitular(t.NroTarjeta, t.FechaOtorgamiento, t.FechaVencimiento)));

            return ListaVistaTarjetasTitular;
        }

    }
}
