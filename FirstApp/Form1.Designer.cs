namespace FirstApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.btn_add_label = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_changeBackImg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_label
            // 
            this.btn_add_label.AutoSize = true;
            this.btn_add_label.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_add_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add_label.Location = new System.Drawing.Point(672, 189);
            this.btn_add_label.Name = "btn_add_label";
            this.btn_add_label.Size = new System.Drawing.Size(116, 40);
            this.btn_add_label.TabIndex = 0;
            this.btn_add_label.Text = "Add Label";
            this.btn_add_label.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_add_label.UseVisualStyleBackColor = false;
            this.btn_add_label.Click += new System.EventHandler(this.btn_add_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "MouseEnter&Leave";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "ChangeBackColor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_time.Location = new System.Drawing.Point(12, 209);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(194, 45);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "Baki vaxti ile";
            this.lbl_time.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lbl_time.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apply.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_apply.Location = new System.Drawing.Point(613, 24);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(175, 63);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Hakuna";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_changeBackImg
            // 
            this.btn_changeBackImg.AutoSize = true;
            this.btn_changeBackImg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_changeBackImg.Location = new System.Drawing.Point(632, 390);
            this.btn_changeBackImg.Name = "btn_changeBackImg";
            this.btn_changeBackImg.Size = new System.Drawing.Size(156, 31);
            this.btn_changeBackImg.TabIndex = 3;
            this.btn_changeBackImg.Text = "Change Back Image";
            this.btn_changeBackImg.UseVisualStyleBackColor = true;
            this.btn_changeBackImg.Click += new System.EventHandler(this.btn_changeBackImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FirstApp.Properties.Resources.Azerbaijan_Satellite_Map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_changeBackImg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_add_label);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion



    private Button btn_add_label;
    private Label label1;
    private Button button1;
    private Label lbl_time;
    private Button btn_apply;
    private Button btn_changeBackImg;
}
