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
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		int intentos=2;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BtnAcceder_Click(object sender, RoutedEventArgs e)
		{

			VentanaMenu menu = new VentanaMenu();
			menu.Show();
			this.Hide();

			/*if(txtUsuario.Text=="" || pwdBox.Password=="")
			{
				MessageBox.Show("Escriba la información solicitada para poder acceder a GEMAF", "",
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
					MessageBox.Show("ACCESO BLOQUEADO.\nINTENTELO MÁS TARDE", "",
						 MessageBoxButton.OK, MessageBoxImage.Error);
					App.Current.Shutdown();
				}
				else
				{
					MessageBox.Show("Usuario y contraseña incorrectos", "",
						 MessageBoxButton.OK, MessageBoxImage.Warning);
					txtUsuario.Text = "";
					pwdBox.Password = "";
					intentos = intentos - 1;
				}
			}*/
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			App.Current.Shutdown();
		}
	}
}
