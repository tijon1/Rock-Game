
namespace RockplanetsEditor
{
    partial class Testing
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
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.wizardPage1 = new AeroWizard.WizardPage();
            this.themedTableLayoutPanel1 = new AeroWizard.ThemedTableLayoutPanel();
            this.commandLink1 = new MyAPKapp.VistaUIFramework.CommandLink();
            this.commandLink2 = new MyAPKapp.VistaUIFramework.CommandLink();
            this.commandLink3 = new MyAPKapp.VistaUIFramework.CommandLink();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardPage1.SuspendLayout();
            this.themedTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackColor = System.Drawing.Color.White;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.wizardPage1);
            this.wizardControl1.ShowProgressInTaskbarIcon = true;
            this.wizardControl1.Size = new System.Drawing.Size(800, 450);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Text = "Wizard Title";
            this.wizardControl1.Title = "Rockplanets Stuff";
            this.wizardControl1.SelectedPageChanged += new System.EventHandler(this.wizardControl1_SelectedPageChanged);
            // 
            // wizardPage1
            // 
            this.wizardPage1.AllowNext = false;
            this.wizardPage1.Controls.Add(this.themedTableLayoutPanel1);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.ShowNext = false;
            this.wizardPage1.Size = new System.Drawing.Size(753, 302);
            this.wizardPage1.TabIndex = 0;
            this.wizardPage1.Text = "Page Title";
            this.wizardPage1.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.wizardPage1_Commit);
            // 
            // themedTableLayoutPanel1
            // 
            this.themedTableLayoutPanel1.ColumnCount = 1;
            this.themedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.themedTableLayoutPanel1.Controls.Add(this.commandLink3, 0, 2);
            this.themedTableLayoutPanel1.Controls.Add(this.commandLink2, 0, 1);
            this.themedTableLayoutPanel1.Controls.Add(this.commandLink1, 0, 0);
            this.themedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themedTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.themedTableLayoutPanel1.Name = "themedTableLayoutPanel1";
            this.themedTableLayoutPanel1.RowCount = 3;
            this.themedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.themedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.themedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.themedTableLayoutPanel1.Size = new System.Drawing.Size(753, 302);
            this.themedTableLayoutPanel1.TabIndex = 0;
            // 
            // commandLink1
            // 
            this.commandLink1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandLink1.Location = new System.Drawing.Point(3, 3);
            this.commandLink1.Name = "commandLink1";
            this.commandLink1.Size = new System.Drawing.Size(747, 94);
            this.commandLink1.TabIndex = 0;
            this.commandLink1.Text = "commandLink1";
            this.commandLink1.UseVisualStyleBackColor = true;
            // 
            // commandLink2
            // 
            this.commandLink2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandLink2.Location = new System.Drawing.Point(3, 103);
            this.commandLink2.Name = "commandLink2";
            this.commandLink2.Size = new System.Drawing.Size(747, 94);
            this.commandLink2.TabIndex = 1;
            this.commandLink2.Text = "commandLink2";
            this.commandLink2.UseVisualStyleBackColor = true;
            // 
            // commandLink3
            // 
            this.commandLink3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandLink3.Location = new System.Drawing.Point(3, 203);
            this.commandLink3.Name = "commandLink3";
            this.commandLink3.Note = "This will create a new map, ";
            this.commandLink3.Size = new System.Drawing.Size(747, 96);
            this.commandLink3.TabIndex = 2;
            this.commandLink3.Text = "Create a new map\r\n";
            this.commandLink3.UseVisualStyleBackColor = true;
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wizardControl1);
            this.Name = "Testing";
            this.Text = "Testing";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardPage1.ResumeLayout(false);
            this.themedTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage wizardPage1;
        private AeroWizard.ThemedTableLayoutPanel themedTableLayoutPanel1;
        private MyAPKapp.VistaUIFramework.CommandLink commandLink3;
        private MyAPKapp.VistaUIFramework.CommandLink commandLink2;
        private MyAPKapp.VistaUIFramework.CommandLink commandLink1;
    }
}