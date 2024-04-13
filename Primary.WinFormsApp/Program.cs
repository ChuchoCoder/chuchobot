﻿using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Windows.Forms;

namespace ChuchoBot.WinFormsApp;

internal static class Program
{


    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FrmMain());

    }
}
