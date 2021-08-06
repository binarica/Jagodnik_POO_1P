using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EntidadFinanciera
{
    public enum TipoDoc { DNI, Pasaporte, CI, LE, LC }

    public enum TipoTarjeta { Platinum, Gold, Plata }

    public enum Moneda { ARS, USD }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Titular> Titulares;
        List<Tarjeta> Tarjetas;
        VistaTarjetasTitular VistaTarjetasTitular;

        public static readonly Dictionary<TipoTarjeta, string> TipoTarjetaPrimerosNumeros = new Dictionary<TipoTarjeta, string>()
        {
            { TipoTarjeta.Platinum, "9999" },
            { TipoTarjeta.Gold, "8888" },
            { TipoTarjeta.Plata, "7777" }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            Titulares = new List<Titular>();
            Tarjetas = new List<Tarjeta>();
            VistaTarjetasTitular = new VistaTarjetasTitular();

            grillaTitulares.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaTitulares.MultiSelect = false;
            grillaTarjetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaTarjetas.MultiSelect = false;
            grillaTarjetasTitular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaTarjetasTitular.MultiSelect = false;

            comboBoxTipoDoc.DataSource = Enum.GetValues(typeof(TipoDoc));
            comboBoxTipoDoc.SelectedIndex = 0;

            comboBoxTipoTarjeta.DataSource = Enum.GetValues(typeof(TipoTarjeta));
            comboBoxTipoTarjeta.SelectedIndex = 0;
        }

        private void ActualizarVista(DataGridView DG, object PO)
        {
            DG.DataSource = null;
            DG.DataSource = PO;
        }

        #region ABM Titulares
        private void btnAltaTitular_Click(object sender, EventArgs e)
        {
            try
            {
                string _td = comboBoxTipoDoc.Text;
                if (!Enum.IsDefined(typeof(TipoDoc), _td))
                {
                    throw new Exception("Tipo de documento no válido. Seleccione uno de la lista.");
                }

                string _nd = textBoxNroDoc.Text;
                if (_nd.Length != 8)
                {
                    throw new Exception("Número de documento no válido.\r\nDebe contener 8 caracteres.");
                }

                if (Titulares.Exists(t => t.TipoDoc.Equals(_td) && t.NroDoc.Equals(_nd)))
                {
                    throw new Exception("Ya existe una persona con ese tipo y número de documento.");
                }

                string _n = textBoxNombre.Text;
                string _a = textBoxApellido.Text;

                if (string.IsNullOrEmpty(_n) || string.IsNullOrEmpty(_a))
                {
                    throw new Exception("Nombre y/o apellido no pueden estar vaciós.");
                }

                if (_n.Any(c => char.IsDigit(c)) || _a.Any(c => char.IsDigit(c)))
                {
                    throw new Exception("Nombre y/o apellido no válidos.\r\nNo pueden contener números.");
                }

                Titular titular = new Titular(_td, _nd, _n, _a);
                Titulares.Add(titular);

                ActualizarVista(grillaTitulares, Titulares);

                LimpiarFormTitular();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBajaTitular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Titulares.Count == 0)
                {
                    throw new Exception("No existen titulares.");
                }

                Titular t = (Titular)(grillaTitulares.SelectedRows[0].DataBoundItem);
                Titulares.Remove(t);

                ActualizarVista(grillaTitulares, Titulares);

                LimpiarFormTitular();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModTitular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Titulares.Count == 0)
                {
                    throw new Exception("Debe agregar un titular primero.");
                }

                Titular t = (Titular)(grillaTitulares.SelectedRows[0].DataBoundItem);
                t.Nombre = textBoxNombre.Text;
                t.Apellido = textBoxApellido.Text;

                ActualizarVista(grillaTitulares, Titulares);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarFormTitular()
        {
            comboBoxTipoDoc.Enabled = true;
            textBoxNroDoc.Text = "";
            textBoxNroDoc.Enabled = true;
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
        }
        #endregion

        #region ABM Tarjetas
        private void btnAltaTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                bool esNumero = long.TryParse(textBoxNroTarjeta.Text, out _);
                if (!(esNumero && textBoxNroTarjeta.Text.Length == 16))
                {
                    throw new Exception("Número de tarjeta no válido.\r\nDebe contener 16 dígitos.");
                }

                string _tt = comboBoxTipoTarjeta.Text;
                if (!Enum.IsDefined(typeof(TipoTarjeta), _tt))
                {
                    throw new Exception("Tipo de tarjeta no válido. Seleccione uno de la lista.");
                }

                string primerosNumeros = textBoxNroTarjeta.Text.Substring(0, 4);
                if (TipoTarjetaPrimerosNumeros[(TipoTarjeta)Enum.Parse(typeof(TipoTarjeta), _tt)] != primerosNumeros)
                {
                    throw new Exception("El número de tarjeta no corresponde al tipo seleccionado.");
                }

                long _nt = long.Parse(textBoxNroTarjeta.Text);
                if (Tarjetas.Exists(a => a.NroTarjeta.Equals(_nt)))
                {
                    throw new Exception("Ya existe una tarjeta con ese número.");
                }

                string _fo = textBoxFechaOtorgamiento.Text;
                string _fv = textBoxFechaVencimiento.Text;

                if (!DateTime.TryParse(_fo, out _) || !DateTime.TryParse(_fv, out _))
                {
                    throw new Exception("Fecha de otorgamiento/vencimiento no válida. Use el formato MM-DD-AAAA.");
                }

                Tarjeta t = new Tarjeta(_nt, _tt, _fo, _fv);
                t.ExcesoDeConsumo += AlertaExcesoDeConsumo;

                Tarjetas.Add(t);
                ActualizarVista(grillaTarjetas, Tarjetas);
                
                LimpiarFormTarjeta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnBajaTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tarjetas.Count == 0)
                {
                    throw new Exception("No existen tarjetas.");
                }

                Tarjeta tarjeta = (Tarjeta)(grillaTarjetas.SelectedRows[0].DataBoundItem);

                if (tarjeta.SaldoARS > 0 || tarjeta.SaldoUSD > 0)
                {
                    throw new Exception("La tarjeta posee consumos. No se puede eliminar.");
                }

                Titular titular = tarjeta.RetornaTitular();

                if (titular != null)
                {
                    titular.EliminarTarjeta(tarjeta);
                    ActualizarVista(grillaTarjetasTitular, VistaTarjetasTitular.RetornaListaVistaTarjetasTitular(titular));
                }

                tarjeta.ExcesoDeConsumo -= AlertaExcesoDeConsumo;
                Tarjetas.Remove(tarjeta);
                ActualizarVista(grillaTarjetas, Tarjetas);

                LimpiarFormTarjeta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tarjetas.Count == 0)
                {
                    throw new Exception("Debe agregar una tarjeta primero.");
                }

                Tarjeta t = (Tarjeta)(grillaTarjetas.SelectedRows[0].DataBoundItem);
                t.FechaOtorgamiento = textBoxFechaOtorgamiento.Text;
                t.FechaVencimiento = textBoxFechaVencimiento.Text;

                ActualizarVista(grillaTitulares, Titulares);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarFormTarjeta()
        {
            comboBoxTipoTarjeta.Enabled = true;
            textBoxNroTarjeta.Text = "";
            textBoxNroTarjeta.Enabled = true;
            textBoxFechaOtorgamiento.Text = "";
            textBoxFechaVencimiento.Text = "";
        }
        #endregion

        #region Asignaciones de tarjetas
        private void btnAsignarTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Titulares.Count == 0)
                {
                    throw new Exception("Debe agregar un titular primero.");
                }

                if (Tarjetas.Count == 0)
                {
                    throw new Exception("Debe agregar una tarjeta primero.");
                }

                Titular titular = (Titular)(grillaTitulares.SelectedRows[0].DataBoundItem);
                Tarjeta tarjeta = (Tarjeta)(grillaTarjetas.SelectedRows[0].DataBoundItem);
                titular.AñadirTarjeta(tarjeta);
                
                ActualizarVista(grillaTarjetasTitular, VistaTarjetasTitular.RetornaListaVistaTarjetasTitular(titular));
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnQuitarAsignacionTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tarjetas.Count == 0)
                {
                    throw new Exception("No existen tarjetas.");
                }

                Tarjeta tarjeta = (Tarjeta)(grillaTarjetas.SelectedRows[0].DataBoundItem);
                if (tarjeta.SaldoARS > 0 || tarjeta.SaldoUSD > 0)
                {
                    throw new Exception("La tarjeta posee consumos. No se puede quitar la asignación.");
                }

                Titular titular = tarjeta.RetornaTitular();
                if (titular == null)
                {
                    throw new Exception("La tarjeta no tiene titular.");
                }

                titular.EliminarTarjeta(tarjeta);
                tarjeta.QuitarAsignacionTitular();
                ActualizarVista(grillaTarjetasTitular, VistaTarjetasTitular.RetornaListaVistaTarjetasTitular(titular));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void grillaTitulares_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Titular t = (Titular)(grillaTitulares.SelectedRows[0].DataBoundItem);
                comboBoxTipoDoc.Text = t.TipoDoc;
                comboBoxTipoDoc.Enabled = false;
                textBoxNroDoc.Text = t.NroDoc.ToString();
                textBoxNroDoc.Enabled = false;
                textBoxNombre.Text = t.Nombre;
                textBoxApellido.Text = t.Apellido;

                ActualizarVista(grillaTarjetasTitular, VistaTarjetasTitular.RetornaListaVistaTarjetasTitular(t));
            }
            catch (Exception) { }
        }

        private void grillaTarjetas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Tarjeta t = (Tarjeta)(grillaTarjetas.SelectedRows[0].DataBoundItem);
                textBoxNroTarjeta.Text = t.NroTarjeta.ToString();
                textBoxNroTarjeta.Enabled = false;
                comboBoxTipoTarjeta.Text = t.TipoTarjeta;
                comboBoxTipoTarjeta.Enabled = false;
                textBoxFechaOtorgamiento.Text = t.FechaOtorgamiento;
                textBoxFechaVencimiento.Text = t.FechaVencimiento;
            }
            catch (Exception) { }
        }

        private void btnLimpiarFormTitular_Click(object sender, EventArgs e)
        {
            LimpiarFormTitular();
        }

        private void btnLimpiarFormTarjeta_Click(object sender, EventArgs e)
        {
            LimpiarFormTarjeta();
        }

        #region Consumos
        private void btnGenerarConsumoARS_Click(object sender, EventArgs e)
        {
            GenerarConsumo(Moneda.ARS);
        }

        private void btnGenerarConsumoUSD_Click(object sender, EventArgs e)
        {
            GenerarConsumo(Moneda.USD);
        }

        private void GenerarConsumo(Moneda pMoneda)
        {
            try
            {
                if (Tarjetas.Count == 0)
                {
                    throw new Exception("Debe agregar una tarjeta.");
                }

                Tarjeta tarjeta = (Tarjeta)(grillaTarjetas.SelectedRows[0].DataBoundItem);
                if (tarjeta.RetornaTitular() == null)
                {
                    throw new Exception("La tarjeta debe ser asignada a un titular primero.");
                }

                string input = Interaction.InputBox("Ingrese el monto del consumo en " + pMoneda.ToString());
                if (!decimal.TryParse(input, out _))
                {
                    throw new Exception("El monto no es válido.");
                }

                tarjeta.GenerarConsumo(decimal.Parse(input), pMoneda);
                ActualizarVista(grillaTarjetas, Tarjetas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Pagos
        private void btnRealizarPagoARS_Click(object sender, EventArgs e)
        {
            RealizarPago(Moneda.ARS);
        }

        private void btnRealizarPagoUSD_Click(object sender, EventArgs e)
        {
            RealizarPago(Moneda.USD);
        }

        private void RealizarPago(Moneda pMoneda)
        {
            try
            {
                if (Tarjetas.Count == 0)
                {
                    throw new Exception("Debe agregar una tarjeta.");
                }

                Tarjeta tarjeta = (Tarjeta)(grillaTarjetas.SelectedRows[0].DataBoundItem);
                if (tarjeta.RetornaTitular() == null)
                {
                    throw new Exception("La tarjeta debe ser asignada a un titular primero.");
                }

                string input = Interaction.InputBox("Ingrese el monto a pagar en " + pMoneda.ToString());
                if (!decimal.TryParse(input, out _))
                {
                    throw new Exception("El monto no es válido.");
                }

                tarjeta.RealizarPago(decimal.Parse(input), pMoneda);
                ActualizarVista(grillaTarjetas, Tarjetas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Eventos
        private void AlertaExcesoDeConsumo(object sender, ExcesoDeConsumoEventArgs e)
        {
            MessageBox.Show($"El consumo supero el límite por {e.ImporteExcedido}");
        }
        #endregion
    }
}
