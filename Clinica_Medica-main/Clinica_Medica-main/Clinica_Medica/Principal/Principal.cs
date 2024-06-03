using General.GUI;
using General.GUI.GUIGestiones;
using Principal.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Principal
{
    public partial class Principal : Form
    {
        private Form activeForm;
        public Principal()
        {
            InitializeComponent();
        }
        private void OpenFroms(Form from)
        { 
            if(activeForm != null) {
                activeForm.Close();
            }
            activeForm = from;
            from.TopLevel = false;
            from.FormBorderStyle = FormBorderStyle.None;
            from.Dock = DockStyle.Fill;
            this.PanelEscritorio.Controls.Add(from);
            this.PanelEscritorio.Tag = from;
            from.BringToFront();
            from.Show();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          Close();
        }

       

        private void Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
           /* home.MdiParent = this;
            home.Show();*/
            OpenFroms(home);

        }
      
        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctoresGestion doc = new DoctoresGestion();
            OpenFroms(doc);
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            EmpleadosGestion Empleado = new EmpleadosGestion();
            OpenFroms(Empleado);

        }

        private void Pacientes_Click(object sender, EventArgs e)
        {
            PacientesGestion pacientes= new PacientesGestion();
            OpenFroms(pacientes);

        }

        private void Citas_Click(object sender, EventArgs e)
        {
            CitasGestion citasGestion = new CitasGestion();
            OpenFroms(citasGestion);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            UsuariosGestion usuario = new UsuariosGestion();
            OpenFroms(usuario);
        }

        private void Medicamento_Click(object sender, EventArgs e)
        {
            MedicamentoGestion medicamento = new MedicamentoGestion();
            OpenFroms(medicamento);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //creacion de objeto para llamarlo nuevoMenuItem.Click += (s, ev) => OpenFroms(f);
          
          //Reportes.GUI.VisorInventario f = new VisorInventario();  ESTA COMENTADO POR QUE EL REPORTE NO EXITE AQUI 
          //SE TIENE QUE CREAR 
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            //parte para crear el submenu que se tocara mostrar cuando seleccione el boton
            ToolStripMenuItem nuevoMenuItem = new ToolStripMenuItem("Reporte 1"); //asigna un nombre para el reporte que creaste
            ToolStripMenuItem abrirMenuItem = new ToolStripMenuItem("Reporte 2"); //asigna un nombre para el reporte que creaste
            ToolStripMenuItem salirMenuItem = new ToolStripMenuItem("Reporte 3"); //asigna un nombre para el reporte que creaste

            // Asinga los valores a boton que se creo anteriormente
            nuevoMenuItem.Click += (s, ev) => OpenFroms(f); // mostrara el primer reporte  solo ponele el objeto que crearte 
            abrirMenuItem.Click += (s, ev) => OpenFroms(f); // cambia la f por la variable del objeto que se creo para mostrar el reporte
            salirMenuItem.Click += (s, ev) => OpenFroms(f);  // cambia la f por la variable del objeto que se creo para mostrar el reporte

            // No tocar nada ya que aui manda a llarmlo para mostrar y ejecuta todo si se mueve valio
            contextMenu.Items.Add(nuevoMenuItem);
            contextMenu.Items.Add(abrirMenuItem);
            contextMenu.Items.Add(new ToolStripSeparator()); // Separador
            contextMenu.Items.Add(salirMenuItem);

            // Mostrar el ContextMenuStrip en la posición del cursor
            contextMenu.Show(Cursor.Position);
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Login login = new Login();

        }
    }
}
