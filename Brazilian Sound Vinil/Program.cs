﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Brazilian_Sound_Vinil
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

            //instância do formulário login
            Login login = new Login();

            //Se o resultado do dialogo for ok
            //ou seja se o usuario e login constarem no bd
            if (login.ShowDialog() == DialogResult.OK)
            {
                //abro o formulário principal
                Application.Run(new FrmPrincipal());
            }

            else
            {   
                //Se não mostro a mensagem
                MessageBox.Show("Usuário ou Login inválidos!");
                
            }
            
        }
    }
}
