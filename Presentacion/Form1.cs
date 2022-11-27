using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa.BC;
using Capa.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable getall()
        {

            JugadoresBC oClaseBC = new JugadoresBC();

            dt = oClaseBC.GetAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;


            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            JugadoresBC oClaseBC = new JugadoresBC();


            oClaseBC.Insert(dt);

            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getall();
        }
    }
}
