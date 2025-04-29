namespace AppTitlesAnime
{
    partial class FormAddGenre
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
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panelFill = new Panel();
            textBoxGenre = new TextBox();
            labelGenre = new Label();
            errorProviderGenre = new ErrorProvider(components);
            flowLayoutPanelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGenre).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.BackColor = Color.FromArgb(128, 128, 255);
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 86);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBottom.Size = new Size(434, 60);
            flowLayoutPanelBottom.TabIndex = 1;
            flowLayoutPanelBottom.Paint += flowLayoutPanelBottom_Paint;
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
            panelFill.Controls.Add(textBoxGenre);
            panelFill.Controls.Add(labelGenre);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(434, 86);
            panelFill.TabIndex = 0;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Dock = DockStyle.Top;
            textBoxGenre.Location = new Point(10, 29);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(414, 26);
            textBoxGenre.TabIndex = 1;
            textBoxGenre.TextChanged += TextBoxGenre_TextChanged;
            textBoxGenre.Validating += textBoxGenre_Validating_1;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Dock = DockStyle.Top;
            labelGenre.Location = new Point(10, 10);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(97, 19);
            labelGenre.TabIndex = 0;
            labelGenre.Text = "Жанр аниме";
            // 
            // errorProviderGenre
            // 
            errorProviderGenre.ContainerControl = this;
            // 
            // FormAddGenre
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 146);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormAddGenre";
            Text = "Информация о жанре аниме";
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGenre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBottom;
        private Panel panelFill;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label labelGenre;
        protected internal TextBox textBoxGenre;
        private ErrorProvider errorProviderGenre;
    }
}