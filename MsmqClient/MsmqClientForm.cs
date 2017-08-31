using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MsmqClient
{
    public partial class MsmqClientForm : Form
    {
        MsmqContractClient client = new MsmqContractClient("MsmqService");

        public MsmqClientForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            client.SendMessage(messageTextBox.Text);
        }
    }
}
