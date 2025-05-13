namespace AppTitlesAnime
{
    partial class FormAddStatus
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
            flowLayoutPanelBottomStatus = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            labelStatus = new Label();
            textBoxStatus = new TextBox();
            panelFill = new Panel();
            textBoxGenre = new TextBox();
            labelGenre = new Label();
            flowLayoutPanelBottomStatus.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelBottomStatus
            // 
            flowLayoutPanelBottomStatus.AutoSize = true;
            flowLayoutPanelBottomStatus.BackColor = Color.FromArgb(128, 128, 255);
            flowLayoutPanelBottomStatus.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottomStatus.Controls.Add(btnCancel);
            flowLayoutPanelBottomStatus.Dock = DockStyle.Bottom;
            flowLayoutPanelBottomStatus.Location = new Point(0, 72);
            flowLayoutPanelBottomStatus.Margin = new Padding(4);
            flowLayoutPanelBottomStatus.Name = "flowLayoutPanelBottomStatus";
            flowLayoutPanelBottomStatus.Padding = new Padding(10);
            flowLayoutPanelBottomStatus.Size = new Size(366, 55);
            flowLayoutPanelBottomStatus.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(88, 29);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(107, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(10, 10);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(105, 19);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Статус аниме";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(13, 31);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(100, 23);
            textBoxStatus.TabIndex = 1;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.FromArgb(192, 192, 255);
            panelFill.Controls.Add(textBoxGenre);
            panelFill.Controls.Add(labelGenre);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(366, 72);
            panelFill.TabIndex = 2;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Dock = DockStyle.Top;
            textBoxGenre.Location = new Point(10, 29);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(346, 26);
            textBoxGenre.TabIndex = 1;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Dock = DockStyle.Top;
            labelGenre.Location = new Point(10, 10);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(105, 19);
            labelGenre.TabIndex = 0;
            labelGenre.Text = "Статус аниме";
            // 
            // FormAddStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 127);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottomStatus);
            Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormAddStatus";
            Text = "FormAddStatus";
            flowLayoutPanelBottomStatus.ResumeLayout(false);
            flowLayoutPanelBottomStatus.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelBottomStatus;
        private Panel panelFillStatus;
        private Button btnCancel;
        private Button btnSaveChanges;
        private Label labelStatus;
        private TextBox textBoxStatus;
        private Panel panelFill;
        protected internal TextBox textBoxGenre;
        private Label labelGenre;
    }
}