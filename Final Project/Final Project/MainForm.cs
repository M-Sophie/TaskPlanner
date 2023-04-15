using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
	// Save as SVG
	// read user input
	// Transfer user input to first form

	public partial class TaskPlanner : Form
	{
		List<CheckBox> CheckBoxes = new List<CheckBox>();
		bool[] CurrentlyUsed = {false, false, false, false, false, false, false, false, false, false};
		int i = 0;
		string newVal;

		private void NewTaskForm()
		{
			this.Hide();
			bool done = false;
			for (; !done; i++)
			{
				if (!(CurrentlyUsed[i]))
				{
					using (NewTask newForm = new NewTask())
					{
						newForm.ShowDialog();
						newVal = newForm.GetValue();
						if (newVal != "")
						{
							CheckBoxes[i].Text = newVal;
							checkBox1.Visible = true;
							CurrentlyUsed[i] = true;
						}
						done = true;
					}
				}
				else if (i == 9)
				{
					MessageBox.Show("Your list is full. You will need to complete the current tasks before you can add more");
					done = true;
				}
			}
			Show();
		}

		private void NewWindow(bool newTask)
		{
			this.Hide();
			using (TaskPlanner newForm = new TaskPlanner())
			{
				if (newTask)
				{
					NewTaskForm();
				}
			}
			Show();
		}

		public TaskPlanner()
		{
			InitializeComponent();
			CheckBoxes.Add(checkBox1);
			CheckBoxes.Add(checkBox2);
			CheckBoxes.Add(checkBox3);
			CheckBoxes.Add(checkBox4);
			CheckBoxes.Add(checkBox5);
			CheckBoxes.Add(checkBox6);
			CheckBoxes.Add(checkBox7);
			CheckBoxes.Add(checkBox8);
			CheckBoxes.Add(checkBox9);
			CheckBoxes.Add(checkBox10);
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewWindow(false);
		}

		private void exportAsSVGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Add saving request
			this.Close();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
		
		private void check(CheckBox checkBox)
		{
			checkBox.Checked = true;
		}

		private void uncheck(CheckBox checkBox)
		{
			checkBox.Checked = false;
		}

		private void checkChange (CheckBox checkBox)	
		{
			if (checkBox.Checked)
			{
				uncheck(checkBox);
			}
			else
			{
				check(checkBox);
			}
		}
	
		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			checkChange(checkBox1); 
		}

		private void AddButton(object sender, EventArgs e)
		{
			NewWindow(true);
		}

		private void ViewButton(object sender, EventArgs e)
		{

		}

		private void DeleteButton(object sender, EventArgs e)
		{
			foreach (var cb in CheckBoxes)
			{
				if (cb.Checked)
				{
					cb.Visible = false;
					CurrentlyUsed[i] = false;
				}
				i++;
			}
			i = 0;
		}

		private void ClearButton(object sender, EventArgs e)
		{
			foreach (var cb in CheckBoxes)
			{
				cb.Visible = false;
				CurrentlyUsed[i] = false;
				i++;
			}
			i = 0;
		}
	}
}

// Add button: alt + a
// Complete button: alt + c
// View button: alt + v
// Delete button: alt + d

