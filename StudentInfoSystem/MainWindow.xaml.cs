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

namespace StudentInfoSystem_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Clears all form controls
        private void ClearForm()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtFaculty.Text = "";
            txtSpecialty.Text = "";
            txtDegree.Text = "";
            txtStatus.Text = "";
            txtFacultyNumber.Text = "";
            txtYear.Text = "";
            txtPotok.Text = "";
            txtGroup.Text = "";
        }

        // Displays student data in form controls
        private void DisplayStudentData(Student student)
        {
            txtName.Text = student.Name;
            txtSurname.Text = student.Surname;
            txtFaculty.Text = student.Faculty;
            txtSpecialty.Text = student.Specialty;
            txtDegree.Text = student.Degree;
            txtStatus.Text = student.Status;
            txtFacultyNumber.Text = student.FacultyNumber;
            txtYear.Text = student.Year.ToString();
            txtPotok.Text = student.Potok;
            txtGroup.Text = student.Group.ToString();
        }

        // Disables all form controls
        private void DisableForm()
        {
            txtName.IsEnabled = false;
            txtSurname.IsEnabled = false;
            txtFaculty.IsEnabled = false;
            txtSpecialty.IsEnabled = false;
            txtDegree.IsEnabled = false;
            txtStatus.IsEnabled = false;
            txtFacultyNumber.IsEnabled = false;
            txtYear.IsEnabled = false;
            txtPotok.IsEnabled = false;
            txtGroup.IsEnabled = false;
        }

        // Enables all form controls
        private void EnableForm()
        {
            txtName.IsEnabled = true;
            txtSurname.IsEnabled = true;
            txtFaculty.IsEnabled = true;
            txtSpecialty.IsEnabled = true;
            txtDegree.IsEnabled = true;
            txtStatus.IsEnabled = true;
            txtFacultyNumber.IsEnabled = true;
            txtYear.IsEnabled = true;
            txtPotok.IsEnabled = true;
            txtGroup.IsEnabled = true;
        }
    }
}
