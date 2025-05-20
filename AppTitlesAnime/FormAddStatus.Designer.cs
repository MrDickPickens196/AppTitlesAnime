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
            components = new System.ComponentModel.Container();
            flowLayoutPanelBottomStatus = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panelFill = new Panel();
            textBoxStatus = new TextBox();
            labelStatus = new Label();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelBottomStatus.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
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
            btnSaveChanges.DialogResult = DialogResult.OK;
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
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(107, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.FromArgb(192, 192, 255);
            panelFill.Controls.Add(textBoxStatus);
            panelFill.Controls.Add(labelStatus);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(366, 72);
            panelFill.TabIndex = 0;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Dock = DockStyle.Top;
            textBoxStatus.Location = new Point(10, 29);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(346, 26);
            textBoxStatus.TabIndex = 1;
            textBoxStatus.TextChanged += textBoxStatus_TextChanged;
            textBoxStatus.Validating += TextBoxStatus_Validating;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Dock = DockStyle.Top;
            labelStatus.Location = new Point(10, 10);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(105, 19);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Статус аниме";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
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
            Text = "Информация о статусе аниме";
            flowLayoutPanelBottomStatus.ResumeLayout(false);
            flowLayoutPanelBottomStatus.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelBottomStatus;
        private Button btnSaveChanges;
        private Panel panelFill;
        protected internal TextBox textBoxStatus;
        private Label labelStatus;
        private Button btnCancel;
        private ErrorProvider errorProvider;
    }
}