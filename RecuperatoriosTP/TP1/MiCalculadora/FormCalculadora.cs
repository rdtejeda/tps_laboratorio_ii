using Entidades;
using System;
using System.Windows.Forms;


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
            cmbOperator.Text = "";
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
            //double aux;
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperator.Text);
            lblResultado.Text = resultado.ToString();
            string txtNumeroUno = txtNumero1.Text;
            string txtNumeroDos = txtNumero2.Text;
            if (String.IsNullOrEmpty(txtNumero1.Text))
            {
                txtNumeroUno = "0";
            }
            else
            {
                for (int i = 0; i < txtNumero1.Text.Length; i++)
                {
                    if (txtNumero1.Text[i] == ',' || Char.IsDigit(txtNumero1.Text[i]))
                    {
                    }
                    else
                    {
                        txtNumeroUno = "0";
                        break;
                    }
                }
            }
            if (String.IsNullOrEmpty(txtNumero2.Text))
            {
                txtNumeroDos = "0";
            }
            else
            {
                for (int i = 0; i < txtNumero2.Text.Length; i++)
                {
                    if (txtNumero2.Text[i] == ',' || Char.IsDigit(txtNumero2.Text[i]))
                    {
                    }
                    else
                    {
                        txtNumeroDos = "0";
                        break;
                    }
                }
            }
            if (String.IsNullOrEmpty(cmbOperator.Text))
            {
                cmbOperator.Text = "+";
            }
            lstOperaciones.Items.Add($"{txtNumeroUno} {cmbOperator.Text} {txtNumeroDos} = {resultado.ToString()}");
        }
        /// <summary>
        /// Boton Convertir a Binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(lblResultado.Text))
            {
                string auxiliar = lblResultado.Text;
                string respuesta = Operando.DecimalBinario(auxiliar);
                if (respuesta != "Valor Inválido")
                {
                    int absoluto;
                    absoluto = (int)Math.Abs(double.Parse(lblResultado.Text));
                    lblResultado.Text = respuesta;
                    lstOperaciones.Items.Add($"Converir a Binario {absoluto} = {respuesta}");
                }
                else
                {
                    lstOperaciones.Items.Add($"Converir a Binario {auxiliar} = {respuesta}");
                }
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
                lblResultado.Text = respuesta;
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
        private double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            Operando operandoUno = new Operando(numero1);
            Operando operandoDos = new Operando(numero2);
            if (String.IsNullOrEmpty(operador))
            {
                operador = "?";
            }
            resultado = (Calculadora.Operar(operandoUno, operandoDos, Convert.ToChar(operador)));

            return resultado;
        }
    }
}
