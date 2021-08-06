using System;
using System.Collections.Generic;

namespace EntidadFinanciera
{
    public class Tarjeta
    {
        private Titular _titular;

        private readonly Dictionary<Moneda, int> LimiteConsumo = new Dictionary<Moneda, int>()
        {
            { Moneda.ARS, 60000 },
            { Moneda.USD, 200 }
        };

        private readonly Dictionary<TipoTarjeta, decimal> ComisionesARS = new Dictionary<TipoTarjeta, decimal>()
        {
            { EntidadFinanciera.TipoTarjeta.Platinum, 0.1m },
            { EntidadFinanciera.TipoTarjeta.Gold, 0.2m },
            { EntidadFinanciera.TipoTarjeta.Plata, 0.3m }
        };

        private readonly Dictionary<TipoTarjeta, decimal> ComisionesUSD = new Dictionary<TipoTarjeta, decimal>()
        {
            { EntidadFinanciera.TipoTarjeta.Platinum, 0.01m },
            { EntidadFinanciera.TipoTarjeta.Gold, 0.02m },
            { EntidadFinanciera.TipoTarjeta.Plata, 0.03m }
        };

        private Dictionary<Moneda, decimal> Saldo;

        public event EventHandler<ExcesoDeConsumoEventArgs> ExcesoDeConsumo;

        public Tarjeta() { }
        public Tarjeta(long pNroTarjeta, string pTipoTarjeta, string pFechaOtorgamiento, string pFechaVencimiento)
        {
            NroTarjeta = pNroTarjeta;
            TipoTarjeta = pTipoTarjeta;
            FechaOtorgamiento = pFechaOtorgamiento;
            FechaVencimiento = pFechaVencimiento;
            _titular = null;
            
            Saldo = new Dictionary<Moneda, decimal>();
            Saldo[Moneda.ARS] = 0;
            Saldo[Moneda.USD] = 0;
        }

        public long NroTarjeta { get; set; }
        
        public string TipoTarjeta { get; set; }
        
        public string FechaOtorgamiento { get; set; }
        
        public string FechaVencimiento { get; set; }

        public decimal SaldoARS { get { return Saldo[Moneda.ARS]; } }

        public decimal SaldoUSD { get { return Saldo[Moneda.USD]; } }

        public void GenerarConsumo(decimal pMonto, Moneda pMoneda)
        {
            if (Saldo[pMoneda] + pMonto < LimiteConsumo[pMoneda])
            {
                Saldo[pMoneda] += pMonto;
            }
            else
            {
                decimal _exceso = Saldo[pMoneda] + pMonto - LimiteConsumo[pMoneda];
                ExcesoDeConsumo?.Invoke(this, new ExcesoDeConsumoEventArgs(pMoneda.ToString() + " " + _exceso.ToString()));
            }
        }

        public void RealizarPago(decimal pMonto, Moneda pMoneda)
        {
            decimal comision = 0;
            if (pMoneda == Moneda.ARS)
            {
                comision = ComisionesARS[(EntidadFinanciera.TipoTarjeta)Enum.Parse(typeof(EntidadFinanciera.TipoTarjeta), TipoTarjeta)];
            }
            
            else if (pMoneda == Moneda.USD)
            {
                comision = ComisionesUSD[(EntidadFinanciera.TipoTarjeta)Enum.Parse(typeof(EntidadFinanciera.TipoTarjeta), TipoTarjeta)];
            }

            Saldo[pMoneda] -= (pMonto * (1 - comision));
        }

        public void AsignarTitular(Titular pTitular) 
        { 
            _titular = pTitular;
        }
        
        public void QuitarAsignacionTitular() { _titular = null; }

        public Titular RetornaTitular() { return _titular; }
    }

    public class ExcesoDeConsumoEventArgs : EventArgs
    {
        string _importe;
        public ExcesoDeConsumoEventArgs(string pImporte) { _importe = pImporte; }
        public string ImporteExcedido { get { return _importe; } }
    }
}
