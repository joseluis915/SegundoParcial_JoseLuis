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

namespace SegundoParcial_JoseLuis.UI.Registros
{
    public partial class rProyectos : Window
    {
        private Proyectos proyectos = new Proyectos();
        public rProyectos()
        {
            InitializeComponent();
            this.DataContext = proyectos;

            //—————————————————————————————————————[ VALORES DEL ComboBox ]—————————————————————————————————————
            TipoTareaComboBox.SelectedValuePath = "TareasId";
            TipoTareaComboBox.DisplayMemberPath = "TipoTarea";
            TipoTareaComboBox.ItemsSource = TareasBLL.GetList();
        }
        //——————————————————————————————————————————————————————————————[ Cargar ]———————————————————————————————————————————————————————————————
        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = proyectos;
        }
        //——————————————————————————————————————————————————————————————[ Limpiar ]——————————————————————————————————————————————————————————————
        private void Limpiar()
        {
            this.proyectos = new Proyectos();
            this.DataContext = proyectos;
        }
        //——————————————————————————————————————————————————————————————[ Validar ]——————————————————————————————————————————————————————————————
        private bool Validar()
        {
            bool Validado = true;
            if (ProyectoIdTextbox.Text.Length == 0)
            {
                Validado = false;
                MessageBox.Show("Transaccion Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return Validado;
        }
        //——————————————————————————————————————————————————————————————[ Buscar ]———————————————————————————————————————————————————————————————
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Proyectos encontrado = ProyectosBLL.Buscar(proyectos.ProyectoId);

            if (encontrado != null)
            {
                proyectos = encontrado;
                Cargar();
                MessageBox.Show("Proyecto Encontrado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Este Proyecto no fue encontrado.\n\nAsegurese que existe o cree uno nuevo.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
                //—————————————————————————————————————[ Limpiar y hacer focus en el Id]—————————————————————————————————————
                ProyectoIdTextbox.Text = "";
                ProyectoIdTextbox.Focus();
            }
        }
        //——————————————————————————————————————————————————————————————[ Agregar Fila ]———————————————————————————————————————————————————————————————
        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            var filaDetalle = new ProyectosDetalle
            {
                TareaId = Convert.ToInt32(TipoTareaComboBox.SelectedValue.ToString()),
                Requerimiento = (RequerimientoTextBox.Text.ToString()),
                Tiempo = Convert.ToDouble(TiempoTextBox.Text.ToString()),
            };

            this.proyectos.Detalle.Add(filaDetalle);
            Cargar();

            TipoTareaComboBox.SelectedIndex = -1;
            RequerimientoTextBox.Clear();
            TiempoTextBox.Clear();
        }
        //——————————————————————————————————————————————————————————————[ Remover Fila ]———————————————————————————————————————————————————————————————
        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                proyectos.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }
        //——————————————————————————————————————————————————————————————[ Nuevo ]———————————————————————————————————————————————————————————————
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        //——————————————————————————————————————————————————————————————[ Guardar ]———————————————————————————————————————————————————————————————
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                var paso = ProyectosBLL.Guardar(this.proyectos);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transaccion Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        //——————————————————————————————————————————————————————————————[ Eliminar ]———————————————————————————————————————————————————————————————
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }
        //——————————————————————————————————————————————————————————————[ Tiempo Total ]———————————————————————————————————————————————————————————————
        private void TiempoTotalTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
