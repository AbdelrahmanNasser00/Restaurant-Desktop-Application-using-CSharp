
namespace Login_Form
{
    partial class FoodControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodControl));
            this.gunaLinePanel1_valid = new Guna.UI.WinForms.GunaLinePanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaGradientButton1_valid = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLinePanel1_valid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1_valid
            // 
            this.gunaLinePanel1_valid.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1_valid.Controls.Add(this.gunaGradientButton1_valid);
            this.gunaLinePanel1_valid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1_valid.LineBottom = 4;
            this.gunaLinePanel1_valid.LineColor = System.Drawing.Color.Aqua;
            this.gunaLinePanel1_valid.LineLeft = 4;
            this.gunaLinePanel1_valid.LineRight = 4;
            this.gunaLinePanel1_valid.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1_valid.LineTop = 4;
            this.gunaLinePanel1_valid.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1_valid.Name = "gunaLinePanel1_valid";
            this.gunaLinePanel1_valid.Size = new System.Drawing.Size(150, 150);
            this.gunaLinePanel1_valid.TabIndex = 3;
            this.gunaLinePanel1_valid.Visible = false;
            this.gunaLinePanel1_valid.Click += new System.EventHandler(this.gunaLinePanel1_valid_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Red;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 120);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(106, 27);
            this.guna2Panel1.TabIndex = 5;
            // 
            // gunaGradientButton1_valid
            // 
            this.gunaGradientButton1_valid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientButton1_valid.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1_valid.AnimationSpeed = 0.03F;
            this.gunaGradientButton1_valid.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1_valid.BaseColor1 = System.Drawing.Color.Aqua;
            this.gunaGradientButton1_valid.BaseColor2 = System.Drawing.Color.Aqua;
            this.gunaGradientButton1_valid.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1_valid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1_valid.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1_valid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1_valid.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1_valid.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradientButton1_valid.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1_valid.Image")));
            this.gunaGradientButton1_valid.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1_valid.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1_valid.Location = new System.Drawing.Point(118, 120);
            this.gunaGradientButton1_valid.Name = "gunaGradientButton1_valid";
            this.gunaGradientButton1_valid.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1_valid.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1_valid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1_valid.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1_valid.OnHoverImage = null;
            this.gunaGradientButton1_valid.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1_valid.Radius = 4;
            this.gunaGradientButton1_valid.Size = new System.Drawing.Size(29, 27);
            this.gunaGradientButton1_valid.TabIndex = 0;
            this.gunaGradientButton1_valid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1_valid.Visible = false;
            // 
            // FoodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gunaLinePanel1_valid);
            this.Name = "FoodControl";
            this.Click += new System.EventHandler(this.FoodControl_Click);
            this.gunaLinePanel1_valid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1_valid;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1_valid;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
