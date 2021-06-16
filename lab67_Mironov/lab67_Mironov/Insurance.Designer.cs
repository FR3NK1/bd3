
namespace lab67_Mironov
{
    partial class Insurance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idClientEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.InsuranceGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DateEdit
            // 
            this.DateEdit.Location = new System.Drawing.Point(367, 19);
            this.DateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.DateEdit.Name = "DateEdit";
            this.DateEdit.Size = new System.Drawing.Size(88, 20);
            this.DateEdit.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Date of time";
            // 
            // idClientEdit
            // 
            this.idClientEdit.Location = new System.Drawing.Point(642, 19);
            this.idClientEdit.Margin = new System.Windows.Forms.Padding(2);
            this.idClientEdit.Name = "idClientEdit";
            this.idClientEdit.Size = new System.Drawing.Size(24, 20);
            this.idClientEdit.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "idClient";
            // 
            // TypeEdit
            // 
            this.TypeEdit.Location = new System.Drawing.Point(63, 19);
            this.TypeEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TypeEdit.Name = "TypeEdit";
            this.TypeEdit.Size = new System.Drawing.Size(148, 20);
            this.TypeEdit.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Type";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(582, 181);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 32);
            this.deleteButton.TabIndex = 68;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(582, 128);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(99, 32);
            this.updateButton.TabIndex = 67;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(582, 74);
            this.insertButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(99, 32);
            this.insertButton.TabIndex = 66;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // InsuranceGrid
            // 
            this.InsuranceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InsuranceGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.InsuranceGrid.Location = new System.Drawing.Point(11, 58);
            this.InsuranceGrid.Margin = new System.Windows.Forms.Padding(2);
            this.InsuranceGrid.Name = "InsuranceGrid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InsuranceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InsuranceGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.InsuranceGrid.RowTemplate.Height = 24;
            this.InsuranceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InsuranceGrid.Size = new System.Drawing.Size(550, 167);
            this.InsuranceGrid.TabIndex = 65;
            this.InsuranceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InsuranceGrid_CellContentClick);
            // 
            // Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 259);
            this.Controls.Add(this.DateEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idClientEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.InsuranceGrid);
            this.Name = "Insurance";
            this.Text = "Insurance";
            this.Load += new System.EventHandler(this.Insurance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DateEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idClientEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TypeEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView InsuranceGrid;
    }
}