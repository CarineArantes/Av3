﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuaCarteiraEmDia.View.Principal
{
    public partial class UserControlMovimentacao : UserControl
    {
        public UserControlMovimentacao()
        {
            InitializeComponent();
        }

        private void UserControlMovimentacao_Load(object sender, EventArgs e)
        {
           dateTimePicker1.MaxDate = DateTime.Now;
        }
    }
}
