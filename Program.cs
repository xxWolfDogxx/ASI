﻿using ASI.Forms.Identification.Authentication;
using System;
using System.Windows.Forms;

namespace ASI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ASI.Forms.Main.ASI());
            Application.Run(new Auth());
        }
    }
}
