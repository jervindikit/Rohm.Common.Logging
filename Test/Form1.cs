using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rohm.Common.Logging;

namespace Test
{
    public partial class Form1 : Form
    {
        private LogFile c_InputValue;
        public LogFile InputValue
        {
            get { return c_InputValue; }
            set { c_InputValue = value; }
        }
        public Form1()
        {
            InitializeComponent();
            c_InputValue = new LogFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBoxFunctionName.Text != "" && comboBoxTypeStatus.Text != "" &&
                textBoxFrom.Text != "" && textBoxTo.Text != "" &&
                textBoxProcessTime.Text != "" && textBoxText1.Text != "" && textBoxText2.Text != "" && comboBoxLogFileName.Text != "")
            {
                CreateLog();
                InputValue.OperationLogging(c_InputValue.ErrorCode,c_InputValue.FunctionName, c_InputValue.TypeStatus,c_InputValue.From,c_InputValue.To,c_InputValue.Processtime,c_InputValue.FunctionNumber,c_InputValue.Text1,c_InputValue.Text2,c_InputValue.MachineNumber,c_InputValue.LogFilePath,c_InputValue.LogFileName);
            }
            else
            {
                MessageBox.Show("Please fill up all fields.");
            }
        }

        void CreateLog()
        {
            c_InputValue.ErrorCode = 12;
            c_InputValue.FunctionName = textBoxFunctionName.Text;
            c_InputValue.TypeStatus = comboBoxTypeStatus.Text;
            c_InputValue.From = textBoxFrom.Text;
            c_InputValue.To = textBoxTo.Text;
            c_InputValue.Processtime = textBoxProcessTime.Text;
            c_InputValue.FunctionNumber = "***yyyyMMddHHmm+UniqueCounter***";
            c_InputValue.Text1 = textBoxText1.Text;
            c_InputValue.Text2 = textBoxText2.Text;
            c_InputValue.MachineNumber = "Machine1";
            c_InputValue.LogFilePath = "C:\\Users\\JERVIN-SYSTEM\\Desktop\\Sample Shared Folder\\";
            c_InputValue.LogFileName = comboBoxLogFileName.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label8.Text = dateTimePicker1.Value.ToString("yyyymmdd_hhmmss");
            label9.Text = dateTimePicker2.Value.ToString("yyyyMMdd_HHmmss");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //InputValue.LogTest("THIS IS A TEST LOG");
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Logger.OperationLogger.Write(12, "FUNCTION_TEST", "TYPE_TEST", "FROM", "TO", "0ms", "FUNCTION_NUMBER", "THIS SAMPLE TEXT 1", "THIS IS SAMPLE TEXT 2");
        }
    }
}
