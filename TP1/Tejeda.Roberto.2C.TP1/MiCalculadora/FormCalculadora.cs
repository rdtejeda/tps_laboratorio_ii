using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Inicia Objeto Form
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Limpia Campos
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "";
            lstOperaciones.Items.Clear();
        }
        /// <summary>
        /// Boton Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Evento Load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Evento Closing del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Boton Cerra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Boton Operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
                double aux;
                if(cmbOperator.Text != string.Empty && double.TryParse(txtNumero1.Text,out aux) && double.TryParse(txtNumero2.Text, out aux))
                {
                    double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperator.Text);
                    lblResultado.Text = resultado.ToString();
                    lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperator.Text} {txtNumero2.Text} = {resultado.ToString()}");
                }else
                {
                    MessageBox.Show("Debe selecciona Operandos y Operador validos","Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        /// <summary>
        /// Boton Convertir a Binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string binario;
            string auxiliaEntero = string.Empty;
            double resultado;
            int absoluto=0;
            if (double.TryParse(lblResultado.Text, out resultado))
            {
                absoluto = (int)Math.Abs(resultado);
                auxiliaEntero = absoluto.ToString();
                binario = Operando.DecimalBinario(auxiliaEntero);
                lblResultado.Text = binario;
                lstOperaciones.Items.Add($"Convertir a Binario {auxiliaEntero} = {binario}");
            }
            else
            {
                MessageBox.Show("No hay datos para realizar la conversión", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        /// <summary>
        /// Boton Convertir a Decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(lblResultado.Text))
            {
                string auxiliar = lblResultado.Text;
                string respuesta = Operando.BinarioDecimal(lblResultado.Text);
                lblResultado.Text= respuesta;
                lstOperaciones.Items.Add($"Converir a Decimal {auxiliar} = {respuesta}");
            }
            else
            {
                MessageBox.Show("No hay datos para realizar la conversión", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Opera los valores ingresadoa
        /// </summary>
        /// <param name="numero1">Numero 1</param>
        /// <param name="numero2">Numero 2</param>
        /// <param name="operador">Operador</param>
        /// <returns>Resultado</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            Operando operandoUno = new Operando();
            Operando operandoDos = new Operando();
            
            operandoUno.Numero = numero1;
            operandoDos.Numero = numero2;

            resultado = (Calculadora.Operar(operandoUno, operandoDos, Convert.ToChar(operador)));
                       
            return resultado;
        }
    } 
}
