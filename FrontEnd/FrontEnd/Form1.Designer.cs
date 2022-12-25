namespace FrontEnd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.by = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Push = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Change = new System.Windows.Forms.Button();
            this.Free = new System.Windows.Forms.Button();
            this.Poll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(525, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web API Simple Example";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(131, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "BY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(131, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(131, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // by
            // 
            this.by.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.by.Location = new System.Drawing.Point(223, 289);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(162, 29);
            this.by.TabIndex = 4;
            this.by.KeyDown += new System.Windows.Forms.KeyEventHandler(this.by_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(382, 184);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Push
            // 
            this.Push.BackColor = System.Drawing.Color.RoyalBlue;
            this.Push.ForeColor = System.Drawing.Color.White;
            this.Push.Location = new System.Drawing.Point(819, 287);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(117, 36);
            this.Push.TabIndex = 8;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = false;
            this.Push.Click += new System.EventHandler(this.Push_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 359);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 32);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(223, 429);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(162, 29);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.RoyalBlue;
            this.Change.ForeColor = System.Drawing.Color.White;
            this.Change.Location = new System.Drawing.Point(819, 329);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(117, 36);
            this.Change.TabIndex = 11;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Free
            // 
            this.Free.BackColor = System.Drawing.Color.RoyalBlue;
            this.Free.ForeColor = System.Drawing.Color.White;
            this.Free.Location = new System.Drawing.Point(819, 422);
            this.Free.Name = "Free";
            this.Free.Size = new System.Drawing.Size(117, 36);
            this.Free.TabIndex = 13;
            this.Free.Text = "Free";
            this.Free.UseVisualStyleBackColor = false;
            this.Free.Click += new System.EventHandler(this.Free_Click);
            // 
            // Poll
            // 
            this.Poll.BackColor = System.Drawing.Color.RoyalBlue;
            this.Poll.ForeColor = System.Drawing.Color.White;
            this.Poll.Location = new System.Drawing.Point(819, 380);
            this.Poll.Name = "Poll";
            this.Poll.Size = new System.Drawing.Size(117, 36);
            this.Poll.TabIndex = 14;
            this.Poll.Text = "Pull";
            this.Poll.UseVisualStyleBackColor = false;
            this.Poll.Click += new System.EventHandler(this.Poll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1206, 568);
            this.Controls.Add(this.Poll);
            this.Controls.Add(this.Free);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Push);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.by);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox by;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Push;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button Change;
        //private System.Windows.Forms.Button Pull;
        private System.Windows.Forms.Button Free;
        private System.Windows.Forms.Button Poll;
    }
}

