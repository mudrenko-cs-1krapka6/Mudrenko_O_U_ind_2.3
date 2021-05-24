/*
 * Created by SharpDevelop.
 * User: Yuriy
 * Date: 06.05.2020
 * Time: 10:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UserFormsExample
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button AddRecordButton;
		private System.Windows.Forms.Button PreviousRecordbutton;
		private System.Windows.Forms.Button NextRecordButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox nomer;
		private System.Windows.Forms.TextBox when_obl_is_start;
		private System.Windows.Forms.TextBox when_obl_is_end;
		private System.Windows.Forms.Button SaveListButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label totalObjects;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.PreviousRecordbutton = new System.Windows.Forms.Button();
            this.NextRecordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomer = new System.Windows.Forms.TextBox();
            this.when_obl_is_start = new System.Windows.Forms.TextBox();
            this.when_obl_is_end = new System.Windows.Forms.TextBox();
            this.SaveListButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalObjects = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.nomer_kuzov = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecordButton.Location = new System.Drawing.Point(209, 285);
            this.AddRecordButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(354, 100);
            this.AddRecordButton.TabIndex = 0;
            this.AddRecordButton.Text = "ADD";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButtonClick);
            // 
            // PreviousRecordbutton
            // 
            this.PreviousRecordbutton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousRecordbutton.Location = new System.Drawing.Point(45, 285);
            this.PreviousRecordbutton.Margin = new System.Windows.Forms.Padding(6);
            this.PreviousRecordbutton.Name = "PreviousRecordbutton";
            this.PreviousRecordbutton.Size = new System.Drawing.Size(138, 100);
            this.PreviousRecordbutton.TabIndex = 1;
            this.PreviousRecordbutton.Text = "<<";
            this.PreviousRecordbutton.UseVisualStyleBackColor = true;
            this.PreviousRecordbutton.Click += new System.EventHandler(this.PreviousRecordbuttonClick);
            // 
            // NextRecordButton
            // 
            this.NextRecordButton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextRecordButton.Location = new System.Drawing.Point(575, 285);
            this.NextRecordButton.Margin = new System.Windows.Forms.Padding(6);
            this.NextRecordButton.Name = "NextRecordButton";
            this.NextRecordButton.Size = new System.Drawing.Size(138, 100);
            this.NextRecordButton.TabIndex = 2;
            this.NextRecordButton.Text = ">>";
            this.NextRecordButton.UseVisualStyleBackColor = true;
            this.NextRecordButton.Click += new System.EventHandler(this.NextRecordButtonClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата постановки на облік";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата зняття з обліку";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Рік випуску";
            // 
            // nomer
            // 
            this.nomer.Location = new System.Drawing.Point(209, 6);
            this.nomer.Name = "nomer";
            this.nomer.Size = new System.Drawing.Size(458, 29);
            this.nomer.TabIndex = 7;
            // 
            // when_obl_is_start
            // 
            this.when_obl_is_start.Location = new System.Drawing.Point(209, 41);
            this.when_obl_is_start.Name = "when_obl_is_start";
            this.when_obl_is_start.Size = new System.Drawing.Size(458, 29);
            this.when_obl_is_start.TabIndex = 8;
            // 
            // when_obl_is_end
            // 
            this.when_obl_is_end.Location = new System.Drawing.Point(209, 74);
            this.when_obl_is_end.Name = "when_obl_is_end";
            this.when_obl_is_end.Size = new System.Drawing.Size(458, 29);
            this.when_obl_is_end.TabIndex = 9;
            // 
            // SaveListButton
            // 
            this.SaveListButton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveListButton.Location = new System.Drawing.Point(209, 438);
            this.SaveListButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveListButton.Name = "SaveListButton";
            this.SaveListButton.Size = new System.Drawing.Size(354, 100);
            this.SaveListButton.TabIndex = 11;
            this.SaveListButton.Text = "SAVE";
            this.SaveListButton.UseVisualStyleBackColor = true;
            this.SaveListButton.Click += new System.EventHandler(this.SaveListButtonClick);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(45, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Objects";
            // 
            // totalObjects
            // 
            this.totalObjects.Location = new System.Drawing.Point(209, 409);
            this.totalObjects.Name = "totalObjects";
            this.totalObjects.Size = new System.Drawing.Size(79, 23);
            this.totalObjects.TabIndex = 13;
            this.totalObjects.Text = "Total Objects";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Колір";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Номер кузову";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(209, 108);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(458, 29);
            this.year.TabIndex = 16;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(209, 140);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(458, 29);
            this.color.TabIndex = 17;
            // 
            // nomer_kuzov
            // 
            this.nomer_kuzov.Location = new System.Drawing.Point(209, 175);
            this.nomer_kuzov.Name = "nomer_kuzov";
            this.nomer_kuzov.Size = new System.Drawing.Size(458, 29);
            this.nomer_kuzov.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 553);
            this.Controls.Add(this.nomer_kuzov);
            this.Controls.Add(this.color);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalObjects);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveListButton);
            this.Controls.Add(this.when_obl_is_end);
            this.Controls.Add(this.when_obl_is_start);
            this.Controls.Add(this.nomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextRecordButton);
            this.Controls.Add(this.PreviousRecordbutton);
            this.Controls.Add(this.AddRecordButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "UserFormsExample";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox nomer_kuzov;
    }
}
