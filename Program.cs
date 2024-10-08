﻿using DiscordRPC;

namespace VimPig
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            RPC.rpctimestamp = Timestamps.Now;
            RPC.InitializeRPC();

            Application.Run(new Form1());

        }
    }
}