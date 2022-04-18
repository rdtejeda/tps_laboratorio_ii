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
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = " ";
            lstOperaciones.Items.Clear();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

            string auxiliar = lblResultado.Text;
            string respuesta = Operando.BinarioDecimal(lblResultado.Text);
            lblResultado.Text= respuesta;
            lstOperaciones.Items.Add($"Converir a Decimal {auxiliar} = {respuesta}");
            
           
        }

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
