
namespace CW_02._3_Button_Array
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
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mvalue = new System.Windows.Forms.MaskedTextBox();
            this.SizeValue = new System.Windows.Forms.MaskedTextBox();
            this.DistanceValue = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nvalue = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 149);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(209, 55);
            this.start.TabIndex = 0;
            this.start.Text = "Let\'s go!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ButtonArray[m;n]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Distance:";
            // 
            // Mvalue
            // 
            this.Mvalue.Location = new System.Drawing.Point(81, 39);
            this.Mvalue.Margin = new System.Windows.Forms.Padding(4);
            this.Mvalue.Mask = "00";
            this.Mvalue.Name = "Mvalue";
            this.Mvalue.Size = new System.Drawing.Size(25, 25);
            this.Mvalue.TabIndex = 4;
            this.Mvalue.ValidatingType = typeof(int);
            // 
            // SizeValue
            // 
            this.SizeValue.Location = new System.Drawing.Point(93, 75);
            this.SizeValue.Margin = new System.Windows.Forms.Padding(4);
            this.SizeValue.Mask = "000";
            this.SizeValue.Name = "SizeValue";
            this.SizeValue.Size = new System.Drawing.Size(36, 25);
            this.SizeValue.TabIndex = 5;
            this.SizeValue.ValidatingType = typeof(int);
            // 
            // DistanceValue
            // 
            this.DistanceValue.Location = new System.Drawing.Point(124, 108);
            this.DistanceValue.Margin = new System.Windows.Forms.Padding(4);
            this.DistanceValue.Mask = "000";
            this.DistanceValue.Name = "DistanceValue";
            this.DistanceValue.Size = new System.Drawing.Size(38, 25);
            this.DistanceValue.TabIndex = 6;
            this.DistanceValue.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "M:";
            // 
            // Nvalue
            // 
            this.Nvalue.Location = new System.Drawing.Point(151, 39);
            this.Nvalue.Margin = new System.Windows.Forms.Padding(4);
            this.Nvalue.Mask = "00";
            this.Nvalue.Name = "Nvalue";
            this.Nvalue.Size = new System.Drawing.Size(27, 25);
            this.Nvalue.TabIndex = 9;
            this.Nvalue.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "N:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(234, 221);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nvalue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DistanceValue);
            this.Controls.Add(this.SizeValue);
            this.Controls.Add(this.Mvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Mvalue;
        private System.Windows.Forms.MaskedTextBox SizeValue;
        private System.Windows.Forms.MaskedTextBox DistanceValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Nvalue;
        private System.Windows.Forms.Label label5;
    }
}

