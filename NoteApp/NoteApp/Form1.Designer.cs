namespace NoteApp
{
    partial class Form1
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
            this.newbtn = new System.Windows.Forms.Button();
            this.openbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.idlabel = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Label();
            this.textlabel = new System.Windows.Forms.Label();
            this.listlabel = new System.Windows.Forms.Label();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.inputtxt = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(102, 278);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(75, 23);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "New Note";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // openbtn
            // 
            this.openbtn.Location = new System.Drawing.Point(359, 278);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(75, 23);
            this.openbtn.TabIndex = 1;
            this.openbtn.Text = "Open";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(207, 278);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save Note";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(524, 278);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete Note";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(61, 91);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(18, 13);
            this.idlabel.TabIndex = 4;
            this.idlabel.Text = "ID";
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Location = new System.Drawing.Point(61, 115);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(27, 13);
            this.titlelabel.TabIndex = 5;
            this.titlelabel.Text = "Title";
            this.titlelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // textlabel
            // 
            this.textlabel.AutoSize = true;
            this.textlabel.Location = new System.Drawing.Point(61, 144);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(28, 13);
            this.textlabel.TabIndex = 6;
            this.textlabel.Text = "Text";
            // 
            // listlabel
            // 
            this.listlabel.AutoSize = true;
            this.listlabel.Location = new System.Drawing.Point(449, 72);
            this.listlabel.Name = "listlabel";
            this.listlabel.Size = new System.Drawing.Size(49, 13);
            this.listlabel.TabIndex = 7;
            this.listlabel.Text = "All Notes";
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(102, 112);
            this.titletxt.MaxLength = 10;
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(100, 20);
            this.titletxt.TabIndex = 8;
            this.titletxt.Text = "CLICK NEW NOTE";
            // 
            // idtxt
            // 
            this.idtxt.AcceptsReturn = true;
            this.idtxt.Location = new System.Drawing.Point(102, 88);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(100, 20);
            this.idtxt.TabIndex = 9;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // inputtxt
            // 
            this.inputtxt.Location = new System.Drawing.Point(102, 141);
            this.inputtxt.Name = "inputtxt";
            this.inputtxt.Size = new System.Drawing.Size(180, 131);
            this.inputtxt.TabIndex = 10;
            this.inputtxt.Text = "CLICK NEW NOTE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(240, 184);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inputtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.listlabel);
            this.Controls.Add(this.textlabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.openbtn);
            this.Controls.Add(this.newbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label textlabel;
        private System.Windows.Forms.Label listlabel;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.RichTextBox inputtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

