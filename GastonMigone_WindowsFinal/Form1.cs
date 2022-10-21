using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastonMigone_WindowsFinal
{
    public partial class Form1 : Form
    {
        string nombre = "";
        string apellido = "";
        string puesto = "";
        decimal sueldo = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            nombre = ValidarNombre(txtNom.Text);
            apellido = ValidarApellido(txtApe.Text);
            
            if(txtSue.Text != "")
            {
                sueldo = ValidarSueldo(Convert.ToDecimal(txtSue.Text));

            }
            else
            {
                sueldo = Convert.ToDecimal(Interaction.InputBox("Error!! El sueldo no puede ser menor o igual a cero, intente nuevamente : ", "Sueldo"));
            }
            
            puesto = ValidarPuesto(txtPue.Text);
        }


        private void btnMos_Click(object sender, EventArgs e)
        {

            if (nombre.Length < 2 || nombre.Length > 50)
            {
                nombre = ValidarNombre(txtNom.Text);
            }
            if (apellido.Length < 2 || apellido.Length > 50)
            {
                apellido = ValidarApellido(txtApe.Text);
            }
            if ((puesto == "DESARROLLADOR") || (puesto == "DBA") || (puesto == "SOPORTE TÉCNICO"))
            {
                Imprimir(nombre, apellido, puesto);
            }
            else
            {
                puesto = ValidarPuesto(txtPue.Text.ToUpper());
                Imprimir(nombre, apellido, puesto);
            }
        }

        private void btnHor_Click(object sender, EventArgs e)
        {
            double horas = 0;
            double horasLun = 0;
            double horasMar = 0;
            double horasMie = 0;
            double horasJue = 0;
            double horasVie = 0;

            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        horasLun = Convert.ToDouble(Interaction.InputBox("Ingrese horas trabajadas el lunes:"));
                        horas = horas + horasLun;
                        break;
                    case 1:
                        horasMar = Convert.ToDouble(Interaction.InputBox("Ingrese horas trabajadas el martes:"));
                        horas = horas + horasMar;
                        break;
                    case 2:
                        horasMie = Convert.ToDouble(Interaction.InputBox("Ingrese horas trabajadas el miércoles:"));
                        horas = horas + horasMie;
                        break;
                    case 3:
                        horasJue = Convert.ToDouble(Interaction.InputBox("Ingrese horas trabajadas el jueves:"));
                        horas = horas + horasJue;
                        break;
                    case 4:
                        horasVie = Convert.ToDouble(Interaction.InputBox("Ingrese horas trabajadas el viernes:"));
                        horas = horas + horasVie;
                        break;

                }
            }
            Imprimir("Trabajó un total de: " + Convert.ToString(horas) + " hs en la semana");
            Imprimir("El promedio de las horas trabajadas es: " + (horas / 5));
            if (horasLun < 4) { Imprimir("El lunes trabajó menos de 4hs"); }
            if (horasMar < 4) { Imprimir("El martes trabajó menos de 4hs"); }
            if (horasMie < 4) { Imprimir("El miércoles trabajó menos de 4hs"); }
            if (horasJue < 4) { Imprimir("El jueves trabajó menos de 4hs"); }
            if (horasVie < 4) { Imprimir("El viernes trabajó menos de 4hs"); }


        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtApe.Clear();
            txtNom.Clear();
            txtPue.Clear();
            txtSue.Clear();

            Imprimir("Se limpiaron los campos!!");
        }

        #region validadores

        private string ValidarNombre(string nomVal)
        {
            string validador = "no";
            while (validador != "validado")
            {
                if (nomVal.Length > 2 && nomVal.Length < 50)
                {
                    validador = "validado";
                }
                else
                {
                    nomVal = Interaction.InputBox("Error!! El nombre debe contener entre 3 y 49 caracteres, intente nuevamente : ", "Nombre");
                }

            }
            return nomVal;

        }


        private string ValidarApellido(string apeVal)
        {
            string validador = "no";
            while (validador != "validado")
            {
                if (apeVal.Length > 2 && apeVal.Length < 50)
                {
                    validador = "validado";
                }
                else
                {
                    apeVal = Interaction.InputBox("Error!! El apellido debe contener entre 3 y 49 caracteres, intente nuevamente : ", "Apellido");
                }

            }
            return apeVal;

        }

        private string ValidarPuesto(string puestoVal)
        {
            puestoVal = puestoVal.ToUpper();
            string validador = "no";
            while (validador != "validado")
            {
                switch (puestoVal)
                {

                    case "SOPORTE TÉCNICO":
                        validador = "validado";
                        break;
                    case "DBA":
                        validador = "validado";
                        break;
                    case "DESARROLLADOR":
                        validador = "validado";
                        break;

                }
                if (validador != "validado")
                {
                    puestoVal = Interaction.InputBox("Error!! Ingresar un puesto válido! : ", "Puesto").ToUpper();
                }

            }
            return puestoVal;

        }


        private decimal ValidarSueldo(decimal sueldoVal)
        {

            string validador = "no";
            while (validador != "validado")
            {
                if (sueldoVal > 0)
                {
                    validador = "validado";
                }
                else
                {
                    sueldoVal = Convert.ToDecimal(Interaction.InputBox("Error!! El sueldo no puede ser menor o igual a cero, intente nuevamente : ", "Sueldo"));
                }
               
            }
            return sueldoVal;

        }

        #endregion

        #region imprimir

        private void Imprimir(string texto)
        {
            MessageBox.Show(texto);
        }
        
        
        private void Imprimir(string nom,string ape,string pue)
        {
            MessageBox.Show("Nombre completo:" + nom.ToUpper() + " " + ape.ToUpper() +" con puesto en: " + pue);
        }

        #endregion

    }
}
