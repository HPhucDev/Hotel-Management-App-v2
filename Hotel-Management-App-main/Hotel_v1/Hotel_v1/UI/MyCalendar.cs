﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_v1
{
    public partial class MyCalendar : Form
    {
        public MyCalendar()
        {
            InitializeComponent();
        }

        private void MyCalendar_Load(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien();
            calendarDataGridView.DataSource = nhanvien.getMyCalendar(Global.globalUserID);

        }
    }
}
