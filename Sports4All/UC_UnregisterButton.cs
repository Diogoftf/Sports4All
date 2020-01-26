﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_UnregisterButton : UserControl
    {
        public UC_UnregisterButton()
        {
            InitializeComponent();
        }

        private MyEventsController _eventsController = new MyEventsController();
        public int Eventid { get; set; }
        public string Username { get; set; }

    }
}