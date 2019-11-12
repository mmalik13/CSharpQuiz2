namespace Quiz2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.clearform = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.countusers = new System.Windows.Forms.Button();
            this.deleteusers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(310, 147);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(201, 20);
            this.fname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(310, 202);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(201, 20);
            this.lname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telephone Number";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(310, 259);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(201, 20);
            this.tel.TabIndex = 5;
            // 
            // clearform
            // 
            this.clearform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearform.Location = new System.Drawing.Point(245, 365);
            this.clearform.Name = "clearform";
            this.clearform.Size = new System.Drawing.Size(118, 41);
            this.clearform.TabIndex = 6;
            this.clearform.Text = "Clear Form";
            this.clearform.UseVisualStyleBackColor = true;
            this.clearform.Click += new System.EventHandler(this.clearform_Click);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(245, 318);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(118, 41);
            this.register.TabIndex = 7;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // countusers
            // 
            this.countusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countusers.Location = new System.Drawing.Point(369, 318);
            this.countusers.Name = "countusers";
            this.countusers.Size = new System.Drawing.Size(118, 41);
            this.countusers.TabIndex = 8;
            this.countusers.Text = "Count Of Users";
            this.countusers.UseVisualStyleBackColor = true;
            this.countusers.Click += new System.EventHandler(this.countusers_Click);
            // 
            // deleteusers
            // 
            this.deleteusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteusers.Location = new System.Drawing.Point(369, 365);
            this.deleteusers.Name = "deleteusers";
            this.deleteusers.Size = new System.Drawing.Size(118, 41);
            this.deleteusers.TabIndex = 9;
            this.deleteusers.Text = "Delete Users";
            this.deleteusers.UseVisualStyleBackColor = true;
            this.deleteusers.Click += new System.EventHandler(this.deleteusers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteusers);
            this.Controls.Add(this.countusers);
            this.Controls.Add(this.register);
            this.Controls.Add(this.clearform);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname);
            this.Name = "Form1";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Button clearform;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button countusers;
        private System.Windows.Forms.Button deleteusers;
    }
}

