namespace Final_Project
{
	partial class TaskPlanner
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.colorDialog2 = new System.Windows.Forms.ColorDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportAsSVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.button4 = new System.Windows.Forms.Button();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.generalToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(342, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.newToolStripMenuItem,
            this.exportAsSVGToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// exportAsSVGToolStripMenuItem
			// 
			this.exportAsSVGToolStripMenuItem.Name = "exportAsSVGToolStripMenuItem";
			this.exportAsSVGToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.exportAsSVGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.exportAsSVGToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
			this.exportAsSVGToolStripMenuItem.Text = "Export as SVG";
			this.exportAsSVGToolStripMenuItem.Click += new System.EventHandler(this.exportAsSVGToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Q";
			this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// generalToolStripMenuItem
			// 
			this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem});
			this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
			this.generalToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
			this.generalToolStripMenuItem.Text = "General";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
			this.cutToolStripMenuItem.Text = "Cut";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
			this.undoToolStripMenuItem.Text = "Undo";
			this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 161);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.AddButton);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(81, 161);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "&View";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ViewButton);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(162, 161);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "&Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.DeleteButton);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(0, 31);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(95, 20);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.Visible = false;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(0, 57);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(95, 20);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "checkBox2";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.Visible = false;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(243, 161);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "&Clear";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.ClearButton);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(0, 83);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(95, 20);
			this.checkBox3.TabIndex = 8;
			this.checkBox3.Text = "checkBox3";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.Visible = false;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(0, 109);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(95, 20);
			this.checkBox4.TabIndex = 9;
			this.checkBox4.Text = "checkBox4";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.Visible = false;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(0, 135);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(95, 20);
			this.checkBox5.TabIndex = 10;
			this.checkBox5.Text = "checkBox5";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.Visible = false;
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new System.Drawing.Point(175, 31);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(95, 20);
			this.checkBox6.TabIndex = 11;
			this.checkBox6.Text = "checkBox6";
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox6.Visible = false;
			// 
			// checkBox7
			// 
			this.checkBox7.AutoSize = true;
			this.checkBox7.Location = new System.Drawing.Point(175, 57);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(95, 20);
			this.checkBox7.TabIndex = 12;
			this.checkBox7.Text = "checkBox7";
			this.checkBox7.UseVisualStyleBackColor = true;
			this.checkBox7.Visible = false;
			// 
			// checkBox8
			// 
			this.checkBox8.AutoSize = true;
			this.checkBox8.Location = new System.Drawing.Point(175, 83);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(95, 20);
			this.checkBox8.TabIndex = 13;
			this.checkBox8.Text = "checkBox8";
			this.checkBox8.UseVisualStyleBackColor = true;
			this.checkBox8.Visible = false;
			// 
			// checkBox9
			// 
			this.checkBox9.AutoSize = true;
			this.checkBox9.Location = new System.Drawing.Point(175, 109);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(95, 20);
			this.checkBox9.TabIndex = 14;
			this.checkBox9.Text = "checkBox9";
			this.checkBox9.UseVisualStyleBackColor = true;
			this.checkBox9.Visible = false;
			// 
			// checkBox10
			// 
			this.checkBox10.AutoSize = true;
			this.checkBox10.Location = new System.Drawing.Point(175, 135);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(102, 20);
			this.checkBox10.TabIndex = 15;
			this.checkBox10.Text = "checkBox10";
			this.checkBox10.UseVisualStyleBackColor = true;
			this.checkBox10.Visible = false;
			// 
			// TaskPlanner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 191);
			this.Controls.Add(this.checkBox10);
			this.Controls.Add(this.checkBox9);
			this.Controls.Add(this.checkBox8);
			this.Controls.Add(this.checkBox7);
			this.Controls.Add(this.checkBox6);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "TaskPlanner";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ColorDialog colorDialog2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportAsSVGToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox10;
	}
}

