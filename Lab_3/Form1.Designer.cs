namespace Lab_3
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbl_count = new System.Windows.Forms.Label();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bn_Add = new System.Windows.Forms.Button();
            this.tb_countEl = new System.Windows.Forms.TextBox();
            this.lbl_CountEl = new System.Windows.Forms.Label();
            this.lb_res = new System.Windows.Forms.ListBox();
            this.tb_index = new System.Windows.Forms.TextBox();
            this.lbl_index = new System.Windows.Forms.Label();
            this.bn_delByIndex = new System.Windows.Forms.Button();
            this.lbl_indexSublist = new System.Windows.Forms.Label();
            this.tb_elSublist = new System.Windows.Forms.TextBox();
            this.rb_AddFirst = new System.Windows.Forms.RadioButton();
            this.rb_AddLast = new System.Windows.Forms.RadioButton();
            this.rb_AddAfter = new System.Windows.Forms.RadioButton();
            this.rb_AddBefore = new System.Windows.Forms.RadioButton();
            this.bn_AddSublist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(544, 264);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(34, 93);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(158, 17);
            this.lbl_count.TabIndex = 2;
            this.lbl_count.Text = "Type count of el to add/del";
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(215, 93);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(100, 23);
            this.tb_count.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bn_Add
            // 
            this.bn_Add.Location = new System.Drawing.Point(239, 129);
            this.bn_Add.Name = "bn_Add";
            this.bn_Add.Size = new System.Drawing.Size(195, 23);
            this.bn_Add.TabIndex = 0;
            this.bn_Add.Text = "Add";
            this.bn_Add.UseVisualStyleBackColor = true;
            this.bn_Add.Click += new System.EventHandler(this.bn_Add_Click);
            // 
            // tb_countEl
            // 
            this.tb_countEl.Location = new System.Drawing.Point(239, 81);
            this.tb_countEl.Name = "tb_countEl";
            this.tb_countEl.Size = new System.Drawing.Size(100, 23);
            this.tb_countEl.TabIndex = 1;
            // 
            // lbl_CountEl
            // 
            this.lbl_CountEl.AutoSize = true;
            this.lbl_CountEl.Location = new System.Drawing.Point(239, 43);
            this.lbl_CountEl.Name = "lbl_CountEl";
            this.lbl_CountEl.Size = new System.Drawing.Size(98, 17);
            this.lbl_CountEl.TabIndex = 2;
            this.lbl_CountEl.Text = "Type count of el";
            // 
            // lb_res
            // 
            this.lb_res.FormattingEnabled = true;
            this.lb_res.ItemHeight = 17;
            this.lb_res.Location = new System.Drawing.Point(38, 184);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(928, 412);
            this.lb_res.TabIndex = 3;
            // 
            // tb_index
            // 
            this.tb_index.Location = new System.Drawing.Point(381, 81);
            this.tb_index.Name = "tb_index";
            this.tb_index.Size = new System.Drawing.Size(100, 23);
            this.tb_index.TabIndex = 4;
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Location = new System.Drawing.Point(381, 43);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(107, 17);
            this.lbl_index.TabIndex = 5;
            this.lbl_index.Text = "Type index of list";
            // 
            // bn_delByIndex
            // 
            this.bn_delByIndex.Location = new System.Drawing.Point(440, 129);
            this.bn_delByIndex.Name = "bn_delByIndex";
            this.bn_delByIndex.Size = new System.Drawing.Size(178, 23);
            this.bn_delByIndex.TabIndex = 7;
            this.bn_delByIndex.Text = "Del by index";
            this.bn_delByIndex.UseVisualStyleBackColor = true;
            this.bn_delByIndex.Click += new System.EventHandler(this.bn_delByIndex_Click);
            // 
            // lbl_indexSublist
            // 
            this.lbl_indexSublist.AutoSize = true;
            this.lbl_indexSublist.Location = new System.Drawing.Point(518, 43);
            this.lbl_indexSublist.Name = "lbl_indexSublist";
            this.lbl_indexSublist.Size = new System.Drawing.Size(106, 17);
            this.lbl_indexSublist.TabIndex = 9;
            this.lbl_indexSublist.Text = "Type el of sublist";
            // 
            // tb_elSublist
            // 
            this.tb_elSublist.Location = new System.Drawing.Point(518, 81);
            this.tb_elSublist.Name = "tb_elSublist";
            this.tb_elSublist.Size = new System.Drawing.Size(100, 23);
            this.tb_elSublist.TabIndex = 8;
            // 
            // rb_AddFirst
            // 
            this.rb_AddFirst.AutoSize = true;
            this.rb_AddFirst.Location = new System.Drawing.Point(661, 85);
            this.rb_AddFirst.Name = "rb_AddFirst";
            this.rb_AddFirst.Size = new System.Drawing.Size(94, 21);
            this.rb_AddFirst.TabIndex = 10;
            this.rb_AddFirst.Text = "Add to begin";
            this.rb_AddFirst.UseVisualStyleBackColor = true;
            // 
            // rb_AddLast
            // 
            this.rb_AddLast.AutoSize = true;
            this.rb_AddLast.Checked = true;
            this.rb_AddLast.Location = new System.Drawing.Point(661, 112);
            this.rb_AddLast.Name = "rb_AddLast";
            this.rb_AddLast.Size = new System.Drawing.Size(84, 21);
            this.rb_AddLast.TabIndex = 11;
            this.rb_AddLast.TabStop = true;
            this.rb_AddLast.Text = "Add to end";
            this.rb_AddLast.UseVisualStyleBackColor = true;
            // 
            // rb_AddAfter
            // 
            this.rb_AddAfter.AutoSize = true;
            this.rb_AddAfter.Location = new System.Drawing.Point(981, 630);
            this.rb_AddAfter.Name = "rb_AddAfter";
            this.rb_AddAfter.Size = new System.Drawing.Size(80, 21);
            this.rb_AddAfter.TabIndex = 12;
            this.rb_AddAfter.Text = "Add after";
            this.rb_AddAfter.UseVisualStyleBackColor = true;
            // 
            // rb_AddBefore
            // 
            this.rb_AddBefore.AutoSize = true;
            this.rb_AddBefore.Location = new System.Drawing.Point(981, 657);
            this.rb_AddBefore.Name = "rb_AddBefore";
            this.rb_AddBefore.Size = new System.Drawing.Size(84, 21);
            this.rb_AddBefore.TabIndex = 13;
            this.rb_AddBefore.Text = "AddBefore";
            this.rb_AddBefore.UseVisualStyleBackColor = true;
            // 
            // bn_AddSublist
            // 
            this.bn_AddSublist.Location = new System.Drawing.Point(658, 56);
            this.bn_AddSublist.Name = "bn_AddSublist";
            this.bn_AddSublist.Size = new System.Drawing.Size(97, 23);
            this.bn_AddSublist.TabIndex = 14;
            this.bn_AddSublist.Text = "Add Sublist";
            this.bn_AddSublist.UseVisualStyleBackColor = true;
            this.bn_AddSublist.Click += new System.EventHandler(this.bn_AddSublist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Variant 16, Palochkin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bn_AddSublist);
            this.Controls.Add(this.rb_AddBefore);
            this.Controls.Add(this.rb_AddAfter);
            this.Controls.Add(this.rb_AddLast);
            this.Controls.Add(this.rb_AddFirst);
            this.Controls.Add(this.lbl_indexSublist);
            this.Controls.Add(this.tb_elSublist);
            this.Controls.Add(this.bn_delByIndex);
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.tb_index);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.lbl_CountEl);
            this.Controls.Add(this.tb_countEl);
            this.Controls.Add(this.bn_Add);
            this.Name = "Form1";
            this.Text = " Lab_3_Palochkin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListView listView1;
        private Label lbl_count;
        private TextBox tb_count;
        private Button button1;
        private Button bn_Add;
        private TextBox tb_countEl;
        private Label lbl_CountEl;
        private ListBox lb_res;
        private TextBox tb_index;
        private Label lbl_index;
        private Button bn_delByIndex;
        private Label lbl_indexSublist;
        private TextBox tb_elSublist;
        private RadioButton rb_AddFirst;
        private RadioButton rb_AddLast;
        private RadioButton rb_AddAfter;
        private RadioButton rb_AddBefore;
        private Button bn_AddSublist;
        private Label label1;
    }
}