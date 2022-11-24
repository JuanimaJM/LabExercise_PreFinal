using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juanima_CreateFile
{
    public partial class FrmRegistration : Form
    {
        public static String SetFileName;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String getInput = txtStudentNo.Text;
            String getFirstName = txtFirstName.Text;
            String getLastName = txtLastName.Text;
            String getMiddleName = txtMiddleName.Text;
            String getProgram = cbProgram.SelectedItem.ToString();
            String getGender = cbGender.SelectedItem.ToString();
            String getAge = txtAge.Text;
            String getBirthday = dateBirthday.Text;
            String getContactNo = txtContactNo.Text;

            String docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, getInput + ".txt")))
            { 
                outputFile.WriteLine("Student No.: " + getInput);
                outputFile.WriteLine("Full Name: " + getLastName + ", " + getFirstName + ", " + getMiddleName);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Contact No.: " + getContactNo);
                Console.WriteLine(getInput);
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord FrmStudentRecord = new FrmStudentRecord();
            FrmStudentRecord.ShowDialog();
        }
    }
}
