using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
	public partial class NewTask : Form
	{
		string newValue = "";
		public NewTask()
		{
			InitializeComponent();
		}

		public string GetValue()
		{
			return newValue;
		}

		private void Form1_Load(object sender, EventArgs e)
		{}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void SaveButton(object sender, EventArgs e)
		{
			newValue = textBox1.Text;
			this.Close();
			if (newValue != "")
				MessageBox.Show("The new task '" + newValue + "' has been saved.");
		}

		private void CancelButton(object sender, EventArgs e)
		{
			newValue = ""; 
			this.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
// cancel = alt + c
// save = alt + s