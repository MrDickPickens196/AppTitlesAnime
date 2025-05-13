namespace AppTitlesAnime
{
    partial class FormListStatus
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
            panel1 = new Panel();
            BtnDeleteStatus = new Button();
            btnUpdateStatus = new Button();
            btnAddStatus = new Button();
            dataGridViewStatus = new DataGridView();
            panelFillStatus = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).BeginInit();
            panelFillStatus.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(BtnDeleteStatus);
            panel1.Controls.Add(btnUpdateStatus);
            panel1.Controls.Add(btnAddStatus);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(912, 55);
            panel1.TabIndex = 0;
            // 
            // BtnDeleteStatus
            // 
            BtnDeleteStatus.AutoSize = true;
            BtnDeleteStatus.Location = new Point(232, 13);
            BtnDeleteStatus.Name = "BtnDeleteStatus";
            BtnDeleteStatus.Size = new Size(75, 29);
            BtnDeleteStatus.TabIndex = 2;
            BtnDeleteStatus.Text = "Удалить";
            BtnDeleteStatus.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.AutoSize = true;
            btnUpdateStatus.Location = new Point(107, 13);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(119, 29);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Редактировать";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += BtnUpdateStatus_Click;
            // 
            // btnAddStatus
            // 
            btnAddStatus.AutoSize = true;
            btnAddStatus.Location = new Point(12, 13);
            btnAddStatus.Name = "btnAddStatus";
            btnAddStatus.Size = new Size(88, 29);
            btnAddStatus.TabIndex = 0;
            btnAddStatus.Text = "Добавить";
            btnAddStatus.UseVisualStyleBackColor = true;
            btnAddStatus.Click += BtnAddStatus_Click;
            // 
            // dataGridViewStatus
            // 
            dataGridViewStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatus.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatus.Dock = DockStyle.Fill;
            dataGridViewStatus.Location = new Point(10, 10);
            dataGridViewStatus.MultiSelect = false;
            dataGridViewStatus.Name = "dataGridViewStatus";
            dataGridViewStatus.ReadOnly = true;
            dataGridViewStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatus.Size = new Size(892, 456);
            dataGridViewStatus.TabIndex = 1;
            // 
            // panelFillStatus
            // 
            panelFillStatus.BackColor = Color.FromArgb(128, 128, 255);
            panelFillStatus.Controls.Add(dataGridViewStatus);
            panelFillStatus.Dock = DockStyle.Fill;
            panelFillStatus.Location = new Point(0, 55);
            panelFillStatus.Name = "panelFillStatus";
            panelFillStatus.Padding = new Padding(10);
            panelFillStatus.Size = new Size(912, 476);
            panelFillStatus.TabIndex = 2;
            // 
            // FormListStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 531);
            Controls.Add(panelFillStatus);
            Controls.Add(panel1);
            Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormListStatus";
            Text = "Список аниме статусов";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatus).EndInit();
            panelFillStatus.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BtnDeleteStatus;
        private Button btnUpdateStatus;
        private Button btnAddStatus;
        private DataGridView dataGridViewStatus;
        private Panel panelFillStatus;
    }
}