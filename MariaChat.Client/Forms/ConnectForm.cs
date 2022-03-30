﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariaChat.Client.Forms
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNickname.Text))
            {
                MessageBox.Show(
                    "You need to give yourself a nickname.",
                    "Nickname",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                return;
            }

          
        }
    }
}
