﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GEMAF
{

	public partial class VentanaLogin : Window
	{
		int intentos=2;
		public VentanaLogin()
		{
			InitializeComponent();
		}

		private void BtnAcceder_Click(object sender, RoutedEventArgs e)
		{
			if(txtUsuario.Text=="" || pwdBox.Password=="")
			{
				MessageBox.Show("Entrez les informations demandées pour accéder à GEMAF", "",
						 MessageBoxButton.OK, MessageBoxImage.Warning);
			}
			else if(txtUsuario.Text=="administrador" && pwdBox.Password=="af2019")
			{
				VentanaMenu menu = new VentanaMenu();
				menu.Show();
				this.Hide();
			}
			else
			{
				if(intentos==0)
				{
					MessageBox.Show("ACCÈS BLOQUÉ.\nESSAYER PLUS TARD", "",
						 MessageBoxButton.OK, MessageBoxImage.Error);
					App.Current.Shutdown();
				}
				else
				{
					MessageBox.Show("Nom d'utilisateur et mot de passe incorrects", "",
						 MessageBoxButton.OK, MessageBoxImage.Warning);
					txtUsuario.Text = "";
					pwdBox.Password = "";
					intentos = intentos - 1;
				}
			}
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			App.Current.Shutdown();
		}
	}
}
