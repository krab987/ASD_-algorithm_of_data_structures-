namespace Lab_4_window
{
    partial class Lab_4_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_4_window));
            this.lbl_inf = new System.Windows.Forms.Label();
            this.tb_inf = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.rb_left = new System.Windows.Forms.RadioButton();
            this.rb_right = new System.Windows.Forms.RadioButton();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_inf
            // 
            this.lbl_inf.AutoSize = true;
            this.lbl_inf.Location = new System.Drawing.Point(164, 20);
            this.lbl_inf.Name = "lbl_inf";
            this.lbl_inf.Size = new System.Drawing.Size(375, 78);
            this.lbl_inf.TabIndex = 0;
            this.lbl_inf.Text = resources.GetString("lbl_inf.Text");
            this.lbl_inf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_inf
            // 
            this.tb_inf.Location = new System.Drawing.Point(67, 153);
            this.tb_inf.Name = "tb_inf";
            this.tb_inf.Size = new System.Drawing.Size(100, 20);
            this.tb_inf.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(188, 153);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Додати";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // rb_left
            // 
            this.rb_left.AutoSize = true;
            this.rb_left.Checked = true;
            this.rb_left.Location = new System.Drawing.Point(95, 201);
            this.rb_left.Name = "rb_left";
            this.rb_left.Size = new System.Drawing.Size(52, 17);
            this.rb_left.TabIndex = 3;
            this.rb_left.TabStop = true;
            this.rb_left.Text = "Вліво";
            this.rb_left.UseVisualStyleBackColor = true;
            // 
            // rb_right
            // 
            this.rb_right.AutoSize = true;
            this.rb_right.Location = new System.Drawing.Point(95, 224);
            this.rb_right.Name = "rb_right";
            this.rb_right.Size = new System.Drawing.Size(62, 17);
            this.rb_right.TabIndex = 4;
            this.rb_right.Text = "Вправо";
            this.rb_right.UseVisualStyleBackColor = true;
            this.rb_right.Visible = false;
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(338, 155);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(229, 210);
            this.tb_output.TabIndex = 5;
            // 
            // Lab_4_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.rb_right);
            this.Controls.Add(this.rb_left);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.tb_inf);
            this.Controls.Add(this.lbl_inf);
            this.Name = "Lab_4_window";
            this.Text = "Lab_4_Palochkin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inf;
        private System.Windows.Forms.TextBox tb_inf;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.RadioButton rb_left;
        private System.Windows.Forms.RadioButton rb_right;
        private System.Windows.Forms.TextBox tb_output;
    }
}

