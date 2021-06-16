
namespace lab67_Mironov
{
    partial class InsuranceByClient
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
            this.SelectButton = new System.Windows.Forms.Button();
            this.FullNameEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InsuranceGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(157, 262);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(99, 32);
            this.SelectButton.TabIndex = 45;
            this.SelectButton.Text = "Найти";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // FullNameEdit
            // 
            this.FullNameEdit.Location = new System.Drawing.Point(10, 38);
            this.FullNameEdit.Margin = new System.Windows.Forms.Padding(2);
            this.FullNameEdit.Name = "FullNameEdit";
            this.FullNameEdit.Size = new System.Drawing.Size(388, 20);
            this.FullNameEdit.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Введите ФИО, для которого необходимо найти страховки";
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
            this.InsuranceGrid.Location = new System.Drawing.Point(11, 73);
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
            this.InsuranceGrid.Size = new System.Drawing.Size(387, 167);
            this.InsuranceGrid.TabIndex = 42;
            this.InsuranceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InsuranceGrid_CellContentClick);
            // 
            // InsuranceByClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 305);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.FullNameEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InsuranceGrid);
            this.Name = "InsuranceByClient";
            this.Text = "InsuranceByClient";
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.TextBox FullNameEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView InsuranceGrid;
    }
}