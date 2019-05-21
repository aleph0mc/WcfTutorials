﻿namespace WindowsServiceHost
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.srvProcInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.srvInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // srvProcInstaller
            // 
            this.srvProcInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.srvProcInstaller.Password = null;
            this.srvProcInstaller.Username = null;
            // 
            // srvInstaller
            // 
            this.srvInstaller.DisplayName = "My Math Service";
            this.srvInstaller.ServiceName = "MathService";
            this.srvInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.srvProcInstaller,
            this.srvInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller srvProcInstaller;
        private System.ServiceProcess.ServiceInstaller srvInstaller;
    }
}