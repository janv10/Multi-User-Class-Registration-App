﻿//
//Multi-User Coursemo application for UIC Course Registrations
//
//Jahnvi Patel (jpate201)
//U. of Illinois, Chicago
//CS480, Summer 2018
//Project #4
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
