namespace Lab_3_normal
{
    partial class Lab_3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_elToDel = new System.Windows.Forms.Label();
            this.tb_elToDel = new System.Windows.Forms.TextBox();
            this.lb_res = new System.Windows.Forms.ListBox();
            this.lbl_key = new System.Windows.Forms.Label();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.FirstEl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Variant 16, Palochkin";
            // 
            // lbl_elToDel
            // 
            this.lbl_elToDel.AutoSize = true;
            this.lbl_elToDel.Location = new System.Drawing.Point(52, 109);
            this.lbl_elToDel.Name = "lbl_elToDel";
            this.lbl_elToDel.Size = new System.Drawing.Size(93, 15);
            this.lbl_elToDel.TabIndex = 24;
            this.lbl_elToDel.Text = "Type el to Delete";
            // 
            // tb_elToDel
            // 
            this.tb_elToDel.Location = new System.Drawing.Point(163, 104);
            this.tb_elToDel.Name = "tb_elToDel";
            this.tb_elToDel.Size = new System.Drawing.Size(92, 23);
            this.tb_elToDel.TabIndex = 23;
            // 
            // lb_res
            // 
            this.lb_res.FormattingEnabled = true;
            this.lb_res.ItemHeight = 15;
            this.lb_res.Location = new System.Drawing.Point(52, 179);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(360, 169);
            this.lb_res.TabIndex = 19;
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Location = new System.Drawing.Point(52, 63);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(52, 15);
            this.lbl_key.TabIndex = 18;
            this.lbl_key.Text = "Type key";
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(114, 63);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(92, 23);
            this.tb_key.TabIndex = 17;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(286, 63);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(92, 20);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.bn_Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(286, 104);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 20);
            this.Delete.TabIndex = 30;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // FirstEl
            // 
            this.FirstEl.Location = new System.Drawing.Point(286, 139);
            this.FirstEl.Name = "FirstEl";
            this.FirstEl.Size = new System.Drawing.Size(92, 20);
            this.FirstEl.TabIndex = 31;
            this.FirstEl.Text = "ShowFirstEl";
            this.FirstEl.UseVisualStyleBackColor = true;
            this.FirstEl.Click += new System.EventHandler(this.FirstEl_Click);
            // 
            // Lab_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 404);
            this.Controls.Add(this.FirstEl);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_elToDel);
            this.Controls.Add(this.tb_elToDel);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.Add);
            this.Name = "Lab_3";
            this.Text = "Lab_3_Palochkin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_elToDel;
        private TextBox tb_elToDel;
        private ListBox lb_res;
        private Label lbl_key;
        private TextBox tb_key;
        private Button Add;
        private Button Delete;
        private Button FirstEl;
    }
}