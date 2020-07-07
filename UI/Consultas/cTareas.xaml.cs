﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SegundoParcial_JoseLuis.BLL;
using SegundoParcial_JoseLuis.Entidades;
using static SegundoParcial_JoseLuis.UI.Registros.rProyectos;

namespace SegundoParcial_JoseLuis.UI.Consultas
{
    public partial class cTareas : Window
    {
        public cTareas()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            List<Proyectos> listado = new List<Proyectos>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = ProyectosBLL.GetList(p => p.ProyectoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                    case 1:
                        listado = ProyectosBLL.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text, StringComparison.OrdinalIgnoreCase));
                        break;
                }
            }
            else
            {
                listado = ProyectosBLL.GetList(c => true);
            }
            if (DesdeDatePicker.SelectedDate != null)
                listado = (List<Proyectos>)ProyectosBLL.GetList(p => p.Fecha.Date >= DesdeDatePicker.SelectedDate);
            if (HastaDatePicker.SelectedDate != null)
                listado = (List<Proyectos>)ProyectosBLL.GetList(p => p.Fecha.Date <= HastaDatePicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}