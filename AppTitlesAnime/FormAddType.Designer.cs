namespace AppTitlesAnime
{
    partial class FormAddType
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panelFill = new Panel();
            textBoxTypeName = new TextBox();
            labelTypeName = new Label();
            flowLayoutPanel1.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnSaveChanges);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 91);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(434, 55);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(88, 29);
            btnSaveChanges.TabIndex = 2;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(107, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxTypeName);
            panelFill.Controls.Add(labelTypeName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(434, 91);
            panelFill.TabIndex = 2;
            // 
            // textBoxTypeName
            // 
            textBoxTypeName.Dock = DockStyle.Top;
            textBoxTypeName.Location = new Point(10, 29);
            textBoxTypeName.Name = "textBoxTypeName";
            textBoxTypeName.Size = new Size(414, 26);
            textBoxTypeName.TabIndex = 1;
            // 
            // labelTypeName
            // 
            labelTypeName.AutoSize = true;
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Location = new Point(10, 10);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(85, 19);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Тип аниме";
            // 
            // FormAddType
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 146);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormAddType";
            Text = "Информация о типе аниме";
            Load += FormAddType_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Panel panelFill;
        private TextBox textBoxTypeName;
        private Label labelTypeName;
    }
}