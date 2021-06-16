
namespace lab67_Mironov
{
    partial class Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PlaceWorkEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BirthdateEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlaceEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.ClientGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaceWorkEdit
            // 
            this.PlaceWorkEdit.Location = new System.Drawing.Point(485, 17);
            this.PlaceWorkEdit.Margin = new System.Windows.Forms.Padding(2);
            this.PlaceWorkEdit.Name = "PlaceWorkEdit";
            this.PlaceWorkEdit.Size = new System.Drawing.Size(148, 20);
            this.PlaceWorkEdit.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Place of work";
            // 
            // BirthdateEdit
            // 
            this.BirthdateEdit.Location = new System.Drawing.Point(485, 52);
            this.BirthdateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BirthdateEdit.Name = "BirthdateEdit";
            this.BirthdateEdit.Size = new System.Drawing.Size(148, 20);
            this.BirthdateEdit.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Birthdate";
            // 
            // PlaceEdit
            // 
            this.PlaceEdit.Location = new System.Drawing.Point(109, 55);
            this.PlaceEdit.Margin = new System.Windows.Forms.Padding(2);
            this.PlaceEdit.Name = "PlaceEdit";
            this.PlaceEdit.Size = new System.Drawing.Size(148, 20);
            this.PlaceEdit.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Place of residence";
            // 
            // FullNameEdit
            // 
            this.FullNameEdit.Location = new System.Drawing.Point(109, 20);
            this.FullNameEdit.Margin = new System.Windows.Forms.Padding(2);
            this.FullNameEdit.Name = "FullNameEdit";
            this.FullNameEdit.Size = new System.Drawing.Size(148, 20);
            this.FullNameEdit.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Full name";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(660, 268);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 32);
            this.deleteButton.TabIndex = 80;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(660, 198);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(99, 32);
            this.updateButton.TabIndex = 79;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(660, 128);
            this.insertButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(99, 32);
            this.insertButton.TabIndex = 78;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // ClientGrid
            // 
            this.ClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.ClientGrid.Location = new System.Drawing.Point(11, 95);
            this.ClientGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ClientGrid.Name = "ClientGrid";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ClientGrid.RowHeadersWidth = 49;
            this.ClientGrid.RowTemplate.Height = 24;
            this.ClientGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientGrid.Size = new System.Drawing.Size(622, 228);
            this.ClientGrid.TabIndex = 77;
            this.ClientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGrid_CellContentClick);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 350);
            this.Controls.Add(this.PlaceWorkEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BirthdateEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlaceEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullNameEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.ClientGrid);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlaceWorkEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BirthdateEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlaceEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView ClientGrid;
    }
}