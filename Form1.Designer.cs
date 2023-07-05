namespace Discrete
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
            this.lbl1_numberOne = new System.Windows.Forms.Label();
            this.txtBox_inputOne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1_numberTwo = new System.Windows.Forms.Label();
            this.txtBox_inputTwo = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_proving = new System.Windows.Forms.Label();
            this.lbl_steps = new System.Windows.Forms.Label();
            this.lbl_provingTxt = new System.Windows.Forms.Label();
            this.lbl_gcfTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1_numberOne
            // 
            this.lbl1_numberOne.AutoSize = true;
            this.lbl1_numberOne.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_numberOne.Location = new System.Drawing.Point(155, 68);
            this.lbl1_numberOne.Name = "lbl1_numberOne";
            this.lbl1_numberOne.Size = new System.Drawing.Size(185, 26);
            this.lbl1_numberOne.TabIndex = 0;
            this.lbl1_numberOne.Text = "Enter First Number: ";
            // 
            // txtBox_inputOne
            // 
            this.txtBox_inputOne.Location = new System.Drawing.Point(366, 74);
            this.txtBox_inputOne.Name = "txtBox_inputOne";
            this.txtBox_inputOne.Size = new System.Drawing.Size(191, 20);
            this.txtBox_inputOne.TabIndex = 1;
            this.txtBox_inputOne.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akira Expanded", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Euclidean Algorithm";
            // 
            // lbl1_numberTwo
            // 
            this.lbl1_numberTwo.AutoSize = true;
            this.lbl1_numberTwo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_numberTwo.Location = new System.Drawing.Point(155, 94);
            this.lbl1_numberTwo.Name = "lbl1_numberTwo";
            this.lbl1_numberTwo.Size = new System.Drawing.Size(207, 26);
            this.lbl1_numberTwo.TabIndex = 3;
            this.lbl1_numberTwo.Text = "Enter Second Number: ";
            // 
            // txtBox_inputTwo
            // 
            this.txtBox_inputTwo.Location = new System.Drawing.Point(366, 100);
            this.txtBox_inputTwo.Name = "txtBox_inputTwo";
            this.txtBox_inputTwo.Size = new System.Drawing.Size(191, 20);
            this.txtBox_inputTwo.TabIndex = 4;
            this.txtBox_inputTwo.TextChanged += new System.EventHandler(this.txtBox_inputTwo_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_submit.Location = new System.Drawing.Point(455, 138);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(102, 35);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Brown;
            this.btn_delete.Location = new System.Drawing.Point(347, 138);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 35);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_proving
            // 
            this.lbl_proving.AutoSize = true;
            this.lbl_proving.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proving.Location = new System.Drawing.Point(383, 363);
            this.lbl_proving.Name = "lbl_proving";
            this.lbl_proving.Size = new System.Drawing.Size(0, 33);
            this.lbl_proving.TabIndex = 7;
            // 
            // lbl_steps
            // 
            this.lbl_steps.AutoSize = true;
            this.lbl_steps.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_steps.Location = new System.Drawing.Point(202, 221);
            this.lbl_steps.Name = "lbl_steps";
            this.lbl_steps.Size = new System.Drawing.Size(0, 17);
            this.lbl_steps.TabIndex = 8;
            // 
            // lbl_provingTxt
            // 
            this.lbl_provingTxt.AutoSize = true;
            this.lbl_provingTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_provingTxt.Location = new System.Drawing.Point(291, 187);
            this.lbl_provingTxt.Name = "lbl_provingTxt";
            this.lbl_provingTxt.Size = new System.Drawing.Size(120, 20);
            this.lbl_provingTxt.TabIndex = 9;
            this.lbl_provingTxt.Text = "Proving Steps";
            // 
            // lbl_gcfTitle
            // 
            this.lbl_gcfTitle.AutoSize = true;
            this.lbl_gcfTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gcfTitle.Location = new System.Drawing.Point(289, 363);
            this.lbl_gcfTitle.Name = "lbl_gcfTitle";
            this.lbl_gcfTitle.Size = new System.Drawing.Size(98, 33);
            this.lbl_gcfTitle.TabIndex = 10;
            this.lbl_gcfTitle.Text = "GCF: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.lbl_gcfTitle);
            this.Controls.Add(this.lbl_provingTxt);
            this.Controls.Add(this.lbl_steps);
            this.Controls.Add(this.lbl_proving);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtBox_inputTwo);
            this.Controls.Add(this.lbl1_numberTwo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_inputOne);
            this.Controls.Add(this.lbl1_numberOne);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Euclidean Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1_numberOne;
        private System.Windows.Forms.TextBox txtBox_inputOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1_numberTwo;
        private System.Windows.Forms.TextBox txtBox_inputTwo;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_proving;
        private System.Windows.Forms.Label lbl_steps;
        private System.Windows.Forms.Label lbl_provingTxt;
        private System.Windows.Forms.Label lbl_gcfTitle;
    }
}

