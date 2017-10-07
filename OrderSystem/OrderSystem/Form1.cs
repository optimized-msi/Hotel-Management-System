using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using GsmComm.Server;

namespace SendingSMS
{
    public partial class Form1 : Form
    {
        private GsmCommMain comm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComPort.Items.Add("COM1");
            ComPort.Items.Add("COM2");
            ComPort.Items.Add("COM3");
            ComPort.Items.Add("COM4");
            ComPort.Items.Add("COM5");
        }

        private void CntBtn_Click(object sender, EventArgs e)
        {
            if (ComPort.Text == "")
            {
                MessageBox.Show("Invalid Port Name");
                return;
            }
            comm = new GsmCommMain(ComPort.Text, 9600, 150);
            Cursor.Current = Cursors.Default;
            bool retry;
            do
            {
                retry = false;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    comm.Open();
                    

                    MessageBox.Show("Modem Connected Sucessfully");
                    CntBtn.Enabled = false;
                    status.Text = "Modem is connected";
                }
                catch (Exception)
                {
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show(this, "GSM Modem is not available", "Check",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                        retry = true;
                    else
                    { return; }
                }
            }
            while (retry);
        }

        private void SndBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                Cursor.Current = Cursors.WaitCursor;
                SmsSubmitPdu pdu;
                    Cursor.Current = Cursors.Default;
                    byte dcs = (byte)DataCodingScheme.GeneralCoding.Alpha7BitDefault;
                    pdu = new SmsSubmitPdu(SMSTxt.Text, NumTxt.Text);
                    int times = 1;
                    for (int i = 0; i < times; i++)
                    {
                        comm.SendMessage(pdu);
                    }

                MessageBox.Show("Message Sent Succesfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
