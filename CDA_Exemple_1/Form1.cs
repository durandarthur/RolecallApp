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

namespace CDA_Exemple_1
{
    public partial class Form1 : Form
    {
        private DataTable StudentsDT = new DataTable();

        public Form1()
        {
            InitializeComponent();

            if (!System.IO.Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListeEleves")))
                System.IO.Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListeEleves"));

            if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListeEleves", "liste.xml")))
                StudentsDT = SetupDataTable();
            else
                StudentsDT.ReadXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListeEleves", "liste.xml"));

            studentsDataGridView.DataSource = StudentsDT;

            // MessageBox.Show(studentsDataGridView[2, 0].Value.ToString(), "DebugPrint");
        }
        

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(AddStudentFirstNameInput.Text) && !String.IsNullOrEmpty(AddStudentLastNameInput.Text))
            {
                AddStudent();

                AddStudentFirstNameInput.Clear();
                AddStudentLastNameInput.Clear();
            }
               
        }

        private DataTable SetupDataTable()
        {
            DataTable table = new DataTable();

            table.TableName = "Students";

            DataColumn firstName = table.Columns.Add("Prénom", typeof(System.String));
            DataColumn lastName = table.Columns.Add("Nom", typeof(System.String));
            DataColumn present = table.Columns.Add("Présent", typeof(System.Boolean));

            table.PrimaryKey = new DataColumn[] { firstName, lastName };

            return table;

        }

        private void AddStudent()
        {
            // MessageBox.Show("The table has " + StudentsDT.Columns.Count + " columns", "DebugPrint");

            try
            {
                StudentsDT.Rows.Add(AddStudentFirstNameInput.Text, AddStudentLastNameInput.Text, false);
                StudentsDT.AcceptChanges();
            } catch (System.Data.ConstraintException)
            {
                MessageBox.Show("Cet élève est déjà dans la liste !", "Erreur");
            }
            
            

            StudentsDT.WriteXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListeEleves", "liste.xml"), XmlWriteMode.WriteSchema);

            studentsDataGridView.DataSource = null;
            studentsDataGridView.DataSource = StudentsDT;
        }

        private void studentsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(e.ColumnIndex + " " + e.RowIndex, "DebugPrint");

            StudentsDT.Rows[e.RowIndex][e.ColumnIndex] = studentsDataGridView[e.ColumnIndex, e.RowIndex].Value;
            
            StudentsDT.AcceptChanges();

            StudentsDT.WriteXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListeEleves", "liste.xml"), XmlWriteMode.WriteSchema);
        }

        private void studentsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            studentsDataGridView.Columns[0].ReadOnly = true;
            studentsDataGridView.Columns[1].ReadOnly = true;
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            List<int> rowIndexes = new List<int>();

            rowIndexes = studentsDataGridView.SelectedCells.Cast<DataGridViewCell>().Select(cell => cell.OwningRow.Index).Distinct().ToList();

            if (rowIndexes != null)
            {
                // MessageBox.Show(string.Join(",", rowIndexes.ToArray()), "DebugPrint");

                DialogResult result = MessageBox.Show("Supprimer la sélection ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    foreach (int index in rowIndexes)
                    {
                        StudentsDT.Rows.RemoveAt(index);
                    }

                    StudentsDT.AcceptChanges();

                    StudentsDT.WriteXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListeEleves", "liste.xml"), XmlWriteMode.WriteSchema);
                }
            }
        }

        private void UncheckBoxes_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in StudentsDT.Rows)
            {
                row[2] = false;
            }

            StudentsDT.AcceptChanges();

            StudentsDT.WriteXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ListeEleves", "liste.xml"), XmlWriteMode.WriteSchema);
        }
    }
}
