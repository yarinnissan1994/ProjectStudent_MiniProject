using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using ProjectStudent.entities;
using ProjectStudent.model;

namespace ProjectStudent.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            StudentsManager.AddStudentsToHashTable(int.Parse(idTxtBox.Text), nameTxtBox.Text, int.Parse(ageTxtBox.Text), addressTxtBox.Text);
            StudentsManager.AddStudentsToDB(idTxtBox.Text, nameTxtBox.Text, ageTxtBox.Text, addressTxtBox.Text);
        }

        private void SearchIdBtn_Click(object sender, EventArgs e)
        {
            Student s = StudentsManager.SearchStudentById(int.Parse(idTxtBox.Text));
            if (s != null)
            {
                nameTxtBox.Text = s.Name;
                ageTxtBox.Text = s.Age.ToString();
                addressTxtBox.Text = s.Address;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            StudentsManager.LoadStudentsList();
        }
    }
}
