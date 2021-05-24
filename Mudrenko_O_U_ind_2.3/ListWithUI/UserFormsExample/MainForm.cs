
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace UserFormsExample
{
	public partial class MainForm : Form
	{
		List<Car> recordList;
		Car currentRecord;
		int totalRecords = 0;
		int currentRecordIndex = -1;
		public MainForm()
		{
			InitializeComponent();
			recordList = new List<Car>();
		}
		private void BindToForm()
		{
			nomer.Text = currentRecord.nomer;
            when_obl_is_start.Text = currentRecord.when_obl_is_start;
            when_obl_is_end.Text = currentRecord.when_obl_is_end;
            year.Text = currentRecord.year;
            color.Text = currentRecord.color;
			nomer_kuzov.Text = Convert.ToString(currentRecord.nomer_kuzov);
		}
		private void BindToObject()
		{
            currentRecord.nomer = nomer.Text;
            currentRecord.when_obl_is_start = when_obl_is_start.Text;
			currentRecord.when_obl_is_end = when_obl_is_end.Text;
            currentRecord.year = year.Text;
            currentRecord.color = color.Text;
			currentRecord.nomer_kuzov = uint.Parse(nomer_kuzov.Text);
		}
		void AddRecordButtonClick(object sender, EventArgs e)
		{
			if (currentRecord != null)
				BindToObject();
			totalRecords++;
			currentRecord = new Car();
			BindToForm();
			recordList.Add(currentRecord);
			currentRecordIndex = totalRecords - 1;
			totalObjects.Text = totalRecords.ToString();
		}
		void PreviousRecordbuttonClick(object sender, EventArgs e)
		{
			if (currentRecord != null)
				BindToObject();
			if (currentRecordIndex > 0)
			{
				currentRecordIndex--;
				currentRecord = recordList[currentRecordIndex];
				BindToForm();
			}
		}

		void NextRecordButtonClick(object sender, EventArgs e)
		{
			if (currentRecord != null)
				BindToObject();
			if (currentRecordIndex < totalRecords - 1)
			{
				currentRecordIndex++;
				currentRecord = recordList[currentRecordIndex];
				BindToForm();
			}
		}
		void SaveListButtonClick(object sender, EventArgs e)
		{
			SaveFileDialog MyFileDlg = new SaveFileDialog();
			MyFileDlg.DefaultExt = ".txt";
			MyFileDlg.Filter = "txt data file (*.txt) *.txt|";
			if (MyFileDlg.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show(MyFileDlg.FileName);
				StreamWriter fwStream = new StreamWriter(MyFileDlg.FileName);
				fwStream.Write(nomer.Text + " "+ when_obl_is_start.Text + " " + when_obl_is_end.Text + " " + nomer_kuzov.Text);
				fwStream.Close();
			}
			
		}
	}
}
