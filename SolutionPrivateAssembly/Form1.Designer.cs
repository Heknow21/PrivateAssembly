
namespace SolutionPrivateAssembly
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
            this.btn_Compute = new System.Windows.Forms.Button();
            this.txtBox_number1 = new System.Windows.Forms.TextBox();
            this.txtBox_number2 = new System.Windows.Forms.TextBox();
            this.ComboBoxOperation = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // btn_Compute
            // 
            this.btn_Compute.Location = new System.Drawing.Point(113, 304);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.Size = new System.Drawing.Size(90, 35);
            this.btn_Compute.TabIndex = 1;
            this.btn_Compute.Text = "Compute";
            this.btn_Compute.UseVisualStyleBackColor = true;
            this.btn_Compute.Click += new System.EventHandler(this.btn_Compute_Click);
            // 
            // txtBox_number1
            // 
            this.txtBox_number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_number1.Location = new System.Drawing.Point(30, 53);
            this.txtBox_number1.Multiline = true;
            this.txtBox_number1.Name = "txtBox_number1";
            this.txtBox_number1.Size = new System.Drawing.Size(259, 40);
            this.txtBox_number1.TabIndex = 2;
            this.txtBox_number1.Text = "0";
            this.txtBox_number1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBox_number2
            // 
            this.txtBox_number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_number2.Location = new System.Drawing.Point(30, 137);
            this.txtBox_number2.Multiline = true;
            this.txtBox_number2.Name = "txtBox_number2";
            this.txtBox_number2.Size = new System.Drawing.Size(259, 45);
            this.txtBox_number2.TabIndex = 3;
            this.txtBox_number2.Text = "0";
            this.txtBox_number2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ComboBoxOperation
            // 
            this.ComboBoxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOperation.FormattingEnabled = true;
            this.ComboBoxOperation.Location = new System.Drawing.Point(133, 99);
            this.ComboBoxOperation.Name = "ComboBoxOperation";
            this.ComboBoxOperation.Size = new System.Drawing.Size(60, 32);
            this.ComboBoxOperation.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 194);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(259, 95);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(318, 351);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ComboBoxOperation);
            this.Controls.Add(this.txtBox_number2);
            this.Controls.Add(this.txtBox_number1);
            this.Controls.Add(this.btn_Compute);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Compute;
        private System.Windows.Forms.TextBox txtBox_number1;
        private System.Windows.Forms.TextBox txtBox_number2;
        private System.Windows.Forms.ComboBox ComboBoxOperation;
        private System.Windows.Forms.ListView listView1;
    }
}

