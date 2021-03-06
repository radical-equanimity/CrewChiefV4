﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewChiefV4.UserInterface
{
    public partial class ShowAbout : Form
    {
        public ShowAbout(System.Windows.Forms.Form parent)
        {
            InitializeComponent();
            String path = Configuration.getDefaultFileLocation(CrewChief.Debugging ? "..\\readme.txt" : "readme.txt");
            textBox1.Text = File.ReadAllText(path);
            textBox1.Select(0, 0);
        }
    }
}
