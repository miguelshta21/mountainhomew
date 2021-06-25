
namespace Iron.mountain.test
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
            this.button1 = new System.Windows.Forms.Button();
            this.eid = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // eid
            // 
            this.eid.AccessibleName = "";
            this.eid.AutoSize = true;
            this.eid.Location = new System.Drawing.Point(58, 115);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(73, 15);
            this.eid.TabIndex = 1;
            this.eid.Text = "Employee ID";
            this.eid.Click += new System.EventHandler(this.eid_Click);
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(58, 168);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(63, 15);
            this.lname.TabIndex = 2;
            this.lname.Text = "Last Name";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(58, 212);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(64, 15);
            this.a.TabIndex = 3;
            this.a.Text = "First Name";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dob.Location = new System.Drawing.Point(58, 261);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(92, 16);
            this.dob.TabIndex = 4;
            this.dob.Text = "Date of birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(156, 112);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 23);
            this.idtxt.TabIndex = 7;
            this.idtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 23);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 347);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.a);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label eid;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

