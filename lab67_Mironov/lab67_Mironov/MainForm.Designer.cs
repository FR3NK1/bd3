
namespace lab67_Mironov
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showInsuranceBtn = new System.Windows.Forms.Button();
            this.showClientsBtn = new System.Windows.Forms.Button();
            this.toClientBtn = new System.Windows.Forms.Button();
            this.toInsuranceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Выполнение SQL-скриптов в приложении";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Работа с таблицами из приложения";
            // 
            // showInsuranceBtn
            // 
            this.showInsuranceBtn.Location = new System.Drawing.Point(184, 163);
            this.showInsuranceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.showInsuranceBtn.Name = "showInsuranceBtn";
            this.showInsuranceBtn.Size = new System.Drawing.Size(121, 34);
            this.showInsuranceBtn.TabIndex = 38;
            this.showInsuranceBtn.Text = "Вывести страховку по ФИО клиента";
            this.showInsuranceBtn.UseVisualStyleBackColor = true;
            this.showInsuranceBtn.Click += new System.EventHandler(this.showInsuranceBtn_Click);
            // 
            // showClientsBtn
            // 
            this.showClientsBtn.Location = new System.Drawing.Point(11, 163);
            this.showClientsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.showClientsBtn.Name = "showClientsBtn";
            this.showClientsBtn.Size = new System.Drawing.Size(121, 34);
            this.showClientsBtn.TabIndex = 37;
            this.showClientsBtn.Text = "Вывести клиентов по типу страховки";
            this.showClientsBtn.UseVisualStyleBackColor = true;
            this.showClientsBtn.Click += new System.EventHandler(this.showClientsBtn_Click);
            // 
            // toClientBtn
            // 
            this.toClientBtn.Location = new System.Drawing.Point(11, 60);
            this.toClientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.toClientBtn.Name = "toClientBtn";
            this.toClientBtn.Size = new System.Drawing.Size(121, 34);
            this.toClientBtn.TabIndex = 34;
            this.toClientBtn.Text = "Перейти к Client";
            this.toClientBtn.UseVisualStyleBackColor = true;
            this.toClientBtn.Click += new System.EventHandler(this.toClientBtn_Click);
            // 
            // toInsuranceBtn
            // 
            this.toInsuranceBtn.Location = new System.Drawing.Point(184, 60);
            this.toInsuranceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.toInsuranceBtn.Name = "toInsuranceBtn";
            this.toInsuranceBtn.Size = new System.Drawing.Size(121, 34);
            this.toInsuranceBtn.TabIndex = 33;
            this.toInsuranceBtn.Text = "Перейти к Insurance";
            this.toInsuranceBtn.UseVisualStyleBackColor = true;
            this.toInsuranceBtn.Click += new System.EventHandler(this.toInsuranceBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showInsuranceBtn);
            this.Controls.Add(this.showClientsBtn);
            this.Controls.Add(this.toClientBtn);
            this.Controls.Add(this.toInsuranceBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showInsuranceBtn;
        private System.Windows.Forms.Button showClientsBtn;
        private System.Windows.Forms.Button toClientBtn;
        private System.Windows.Forms.Button toInsuranceBtn;
    }
}

