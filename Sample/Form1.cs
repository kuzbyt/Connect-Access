using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sample.Controller;

namespace Sample
{
	public partial class Form1 : Form
	{
		Query controler;
		public Form1()
		{
			InitializeComponent();
			controler = new Query(ConnectionString.ConnStr);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = controler.updatePerson();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			controler.Add(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
		}

		private void button3_Click(object sender, EventArgs e)
		{
			controler.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));
		}
	}
}
