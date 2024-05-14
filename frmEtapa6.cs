using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalvetEtapa6
{
    public partial class frmEtapa6 : Form
    {
        public frmEtapa6()
        {
            InitializeComponent();
        }

        int Contador; //Para las colisiones
        List<clsVehiculo> listaVehiculos = new List<clsVehiculo>(); //Lista de vehiculos activos

        private void frmMainEtapa6_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int Cantidad = Convert.ToInt16(txtCantidad.Text); //Cantidad q pone el usuario, trae x vehiculos
            for (int i = 0; i < Cantidad; i++)
            {
                clsVehiculo nuevoVehiculo = new clsVehiculo();
                int Aleatorio = random.Next(1, 4); //Esto aleatoriza los vehiculos
                nuevoVehiculo.CrearVehiculo(Aleatorio); //Dentro de lo la clase esta el switch. Aleatorio traera distintos vehiculos

                int posicionX, posicionY;
                bool superpuesto;

                do
                {
                    // random de x, a que lado esta
                    posicionX = random.Next(0, this.ClientSize.Width - nuevoVehiculo.pctVehiculo.Width);

                    //random de y, que tan alto esta
                    posicionY = random.Next(0, this.ClientSize.Height - nuevoVehiculo.pctVehiculo.Height);

                    superpuesto = false;//No esta superpuesto con nadie

                    // vemos si la posicion decidida ya esta ocupada
                    foreach (clsVehiculo vehiculoExistente in listaVehiculos)
                    {
                        if (Math.Abs(posicionX - vehiculoExistente.pctVehiculo.Location.X) < nuevoVehiculo.pctVehiculo.Width &&
                            Math.Abs(posicionY - vehiculoExistente.pctVehiculo.Location.Y) < nuevoVehiculo.pctVehiculo.Height)
                        {
                            superpuesto = true; //En caso de estar superpuesto cambiamos el booleano
                            break;
                        }
                    }
                }
                while (superpuesto);

                //Agregamos a la lista y ponemos el picturebox del vehiculo en el frm
                nuevoVehiculo.pctVehiculo.Location = new Point(posicionX, posicionY); 
                listaVehiculos.Add(nuevoVehiculo);
                Controls.Add(nuevoVehiculo.pctVehiculo);
            }
            txtCantidad.Clear();
            btnCrear.Enabled = false;
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            if(tmrMovimiento.Enabled == false)
            {
                tmrMovimiento.Enabled = true;
            }                                   //Se activa o desactiva dependiendo de su estado
            else
            {
                tmrMovimiento.Enabled = false;
            }
        }

        private void tmrMovimiento_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            foreach (clsVehiculo vehiculo in listaVehiculos.ToList()) //Para cada vehiculo en la lista 
            {                
                int desplazamientoX = random.Next(-30, 30);
                int desplazamientoY = random.Next(-30, 30);     //Movimiento aleatorio del vehiculo
                int nuevaPosX = vehiculo.pctVehiculo.Location.X + desplazamientoX;
                int nuevaPosY = vehiculo.pctVehiculo.Location.Y + desplazamientoY;

                if (nuevaPosX < 0)
                    nuevaPosX = 0;
                else if (nuevaPosX > this.ClientSize.Width - vehiculo.  .Width)
                    nuevaPosX = this.ClientSize.Width - vehiculo.pctVehiculo.Width;
                                               //En caso de chocar con los limites, da la vuelta
                if (nuevaPosY < 0)
                    nuevaPosY = 0;
                else if (nuevaPosY > this.ClientSize.Height - vehiculo.pctVehiculo.Height)
                    nuevaPosY = this.ClientSize.Height - vehiculo.pctVehiculo.Height;
                vehiculo.pctVehiculo.Location = new Point(nuevaPosX, nuevaPosY);
                                    //En caso de chocar
                foreach (clsVehiculo otroVehiculo in listaVehiculos.ToList())
                {
                    if (otroVehiculo != vehiculo && vehiculo.pctVehiculo.Bounds.IntersectsWith(otroVehiculo.pctVehiculo.Bounds))
                    {
                        
                        listaVehiculos.Remove(vehiculo);
                        listaVehiculos.Remove(otroVehiculo);
                        Controls.Remove(vehiculo.pctVehiculo); //"Mata" el vehiculo y el chocado, suma al contador y actualiza el label
                        Controls.Remove(otroVehiculo.pctVehiculo);
                        Contador++;
                        lblContador.Text ="Choques: " + Convert.ToString(Contador);
                        break; 
                    }
                }
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            btnCrear.Enabled = true; //Cuando escribimos se activa el boton
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true; //admitimos solo numeros en el textbox
            }
        }
    }
}
