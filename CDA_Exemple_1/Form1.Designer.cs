namespace CDA_Exemple_1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddStudentFirstNameInput = new System.Windows.Forms.TextBox();
            this.AddStudentLabel = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddStudentLastNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.UncheckBoxes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentFirstNameInput
            // 
            this.AddStudentFirstNameInput.Location = new System.Drawing.Point(658, 64);
            this.AddStudentFirstNameInput.Name = "AddStudentFirstNameInput";
            this.AddStudentFirstNameInput.Size = new System.Drawing.Size(100, 20);
            this.AddStudentFirstNameInput.TabIndex = 0;
            // 
            // AddStudentLabel
            // 
            this.AddStudentLabel.AutoSize = true;
            this.AddStudentLabel.Location = new System.Drawing.Point(658, 45);
            this.AddStudentLabel.Name = "AddStudentLabel";
            this.AddStudentLabel.Size = new System.Drawing.Size(69, 13);
            this.AddStudentLabel.TabIndex = 1;
            this.AddStudentLabel.Text = "Ajouter élève";
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(658, 116);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(75, 23);
            this.AddStudentButton.TabIndex = 2;
            this.AddStudentButton.Text = "Ajouter";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AllowUserToDeleteRows = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(229, 25);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(346, 399);
            this.studentsDataGridView.TabIndex = 4;
            this.studentsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataGridView_CellValueChanged);
            this.studentsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.studentsDataGridView_DataBindingComplete);
            // 
            // AddStudentLastNameInput
            // 
            this.AddStudentLastNameInput.Location = new System.Drawing.Point(658, 90);
            this.AddStudentLastNameInput.Name = "AddStudentLastNameInput";
            this.AddStudentLastNameInput.Size = new System.Drawing.Size(100, 20);
            this.AddStudentLastNameInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prénom:";
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(658, 145);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteStudentButton.TabIndex = 8;
            this.DeleteStudentButton.Text = "Supprimer";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // UncheckBoxes
            // 
            this.UncheckBoxes.Location = new System.Drawing.Point(658, 379);
            this.UncheckBoxes.Name = "UncheckBoxes";
            this.UncheckBoxes.Size = new System.Drawing.Size(75, 45);
            this.UncheckBoxes.TabIndex = 9;
            this.UncheckBoxes.Text = "Décocher cases";
            this.UncheckBoxes.UseVisualStyleBackColor = true;
            this.UncheckBoxes.Click += new System.EventHandler(this.UncheckBoxes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UncheckBoxes);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddStudentLastNameInput);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.AddStudentLabel);
            this.Controls.Add(this.AddStudentFirstNameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddStudentFirstNameInput;
        private System.Windows.Forms.Label AddStudentLabel;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.TextBox AddStudentLastNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button UncheckBoxes;
    }
}

