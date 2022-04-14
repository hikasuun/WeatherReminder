﻿/*
 * LoadingForm.cs
 * Language: C#
 * Displayed when location data is loading
 * Janurary 2022 - April 2022
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherNode
{
    public partial class LoadingForm : Form
    {
        private BaseForm form;
        public LoadingForm(BaseForm frm)
        {
            InitializeComponent();
            form = frm;
        }
    }
}
 