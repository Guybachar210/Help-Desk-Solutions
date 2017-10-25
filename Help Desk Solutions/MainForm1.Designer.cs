namespace Help_Desk_Solutions
{
    partial class MainUIForm
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
            this.paperJamCB = new System.Windows.Forms.CheckBox();
            this.printerErrorCB = new System.Windows.Forms.CheckBox();
            this.tonerLowCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drumLowCB = new System.Windows.Forms.CheckBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.notesTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printerTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paperJamCB
            // 
            this.paperJamCB.AutoSize = true;
            this.paperJamCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.paperJamCB.Location = new System.Drawing.Point(37, 19);
            this.paperJamCB.Name = "paperJamCB";
            this.paperJamCB.Size = new System.Drawing.Size(89, 20);
            this.paperJamCB.TabIndex = 0;
            this.paperJamCB.Text = "Paper jam";
            this.paperJamCB.UseVisualStyleBackColor = true;
            // 
            // printerErrorCB
            // 
            this.printerErrorCB.AutoSize = true;
            this.printerErrorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.printerErrorCB.Location = new System.Drawing.Point(37, 45);
            this.printerErrorCB.Name = "printerErrorCB";
            this.printerErrorCB.Size = new System.Drawing.Size(140, 20);
            this.printerErrorCB.TabIndex = 1;
            this.printerErrorCB.Text = "Printer dosen\'t print";
            this.printerErrorCB.UseVisualStyleBackColor = true;
            // 
            // tonerLowCB
            // 
            this.tonerLowCB.AutoSize = true;
            this.tonerLowCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tonerLowCB.Location = new System.Drawing.Point(37, 75);
            this.tonerLowCB.Name = "tonerLowCB";
            this.tonerLowCB.Size = new System.Drawing.Size(86, 20);
            this.tonerLowCB.TabIndex = 2;
            this.tonerLowCB.Text = "Toner low";
            this.tonerLowCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(153, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Printer Solutions";
            // 
            // drumLowCB
            // 
            this.drumLowCB.AutoSize = true;
            this.drumLowCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.drumLowCB.Location = new System.Drawing.Point(37, 105);
            this.drumLowCB.Name = "drumLowCB";
            this.drumLowCB.Size = new System.Drawing.Size(82, 20);
            this.drumLowCB.TabIndex = 4;
            this.drumLowCB.Text = "Drum low\r\n";
            this.drumLowCB.UseVisualStyleBackColor = true;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(272, 353);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 42);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(198, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select your problems";
            // 
            // notesTB
            // 
            this.notesTB.Location = new System.Drawing.Point(334, 215);
            this.notesTB.Multiline = true;
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(243, 121);
            this.notesTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notes for IT:";
            // 
            // printerTB
            // 
            this.printerTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.printerTB.Location = new System.Drawing.Point(314, 90);
            this.printerTB.Name = "printerTB";
            this.printerTB.ReadOnly = true;
            this.printerTB.Size = new System.Drawing.Size(260, 24);
            this.printerTB.TabIndex = 9;
            this.printerTB.TextChanged += new System.EventHandler(this.printerTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(117, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your default printer is:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.printerErrorCB);
            this.groupBox1.Controls.Add(this.paperJamCB);
            this.groupBox1.Controls.Add(this.tonerLowCB);
            this.groupBox1.Controls.Add(this.drumLowCB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(84, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 137);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue";
            // 
            // MainUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.printerTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notesTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainUIForm";
            this.Text = "Printer Solutions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox paperJamCB;
        private System.Windows.Forms.CheckBox printerErrorCB;
        private System.Windows.Forms.CheckBox tonerLowCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox drumLowCB;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox notesTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox printerTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }

   

}


