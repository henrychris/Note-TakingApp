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
            this.button2 = new System.Windows.Forms.Button();
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
            this.newbtn.Location = new System.Drawing.Point(240, 37);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(75, 23);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "New Note";
            this.newbtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(662, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(345, 37);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save Note";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(345, 277);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete Note";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(199, 90);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(18, 13);
            this.idlabel.TabIndex = 4;
            this.idlabel.Text = "ID";
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Location = new System.Drawing.Point(199, 114);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(27, 13);
            this.titlelabel.TabIndex = 5;
            this.titlelabel.Text = "Title";
            this.titlelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // textlabel
            // 
            this.textlabel.AutoSize = true;
            this.textlabel.Location = new System.Drawing.Point(199, 143);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(28, 13);
            this.textlabel.TabIndex = 6;
            this.textlabel.Text = "Text";
            // 
            // listlabel
            // 
            this.listlabel.AutoSize = true;
            this.listlabel.Location = new System.Drawing.Point(587, 71);
            this.listlabel.Name = "listlabel";
            this.listlabel.Size = new System.Drawing.Size(49, 13);
            this.listlabel.TabIndex = 7;
            this.listlabel.Text = "All Notes";
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(240, 111);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(100, 20);
            this.titletxt.TabIndex = 8;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(240, 87);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 20);
            this.idtxt.TabIndex = 9;
            // 
            // inputtxt
            // 
            this.inputtxt.Location = new System.Drawing.Point(240, 140);
            this.inputtxt.Name = "inputtxt";
            this.inputtxt.Size = new System.Drawing.Size(180, 131);
            this.inputtxt.TabIndex = 10;
            this.inputtxt.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(497, 87);
            this.dataGridView1.Name = "dataGridView1";
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button button2;
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

