using System;

namespace alignment
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
            this.matchValue = new System.Windows.Forms.TextBox();
            this.match = new System.Windows.Forms.Label();
            this.misMatch = new System.Windows.Forms.Label();
            this.misMatchValue = new System.Windows.Forms.TextBox();
            this.gap = new System.Windows.Forms.Label();
            this.gapValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dna1 = new System.Windows.Forms.TextBox();
            this.dna2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // matchValue
            // 
            this.matchValue.Location = new System.Drawing.Point(231, 24);
            this.matchValue.Name = "matchValue";
            this.matchValue.Size = new System.Drawing.Size(100, 22);
            this.matchValue.TabIndex = 0;
            this.matchValue.TextChanged += new System.EventHandler(this.MatchValue_TextChanged);
            // 
            // match
            // 
            this.match.AutoSize = true;
            this.match.Location = new System.Drawing.Point(82, 28);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(43, 16);
            this.match.TabIndex = 1;
            this.match.Text = "match";
            // 
            // misMatch
            // 
            this.misMatch.AutoSize = true;
            this.misMatch.Location = new System.Drawing.Point(82, 74);
            this.misMatch.Name = "misMatch";
            this.misMatch.Size = new System.Drawing.Size(64, 16);
            this.misMatch.TabIndex = 3;
            this.misMatch.Text = "misMatch";
            // 
            // misMatchValue
            // 
            this.misMatchValue.Location = new System.Drawing.Point(231, 70);
            this.misMatchValue.Name = "misMatchValue";
            this.misMatchValue.Size = new System.Drawing.Size(100, 22);
            this.misMatchValue.TabIndex = 2;
            // 
            // gap
            // 
            this.gap.AutoSize = true;
            this.gap.Location = new System.Drawing.Point(82, 122);
            this.gap.Name = "gap";
            this.gap.Size = new System.Drawing.Size(31, 16);
            this.gap.TabIndex = 5;
            this.gap.Text = "gap";
            // 
            // gapValue
            // 
            this.gapValue.Location = new System.Drawing.Point(231, 118);
            this.gapValue.Name = "gapValue";
            this.gapValue.Size = new System.Drawing.Size(100, 22);
            this.gapValue.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Çalıştır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 425);
            this.dataGridView1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Çalışma Zamanı:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // dna1
            // 
            this.dna1.Location = new System.Drawing.Point(535, 42);
            this.dna1.Name = "dna1";
            this.dna1.Size = new System.Drawing.Size(229, 22);
            this.dna1.TabIndex = 11;
            // 
            // dna2
            // 
            this.dna2.Location = new System.Drawing.Point(894, 42);
            this.dna2.Name = "dna2";
            this.dna2.Size = new System.Drawing.Size(249, 22);
            this.dna2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "DNA1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "DNA2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dna2);
            this.Controls.Add(this.dna1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gap);
            this.Controls.Add(this.gapValue);
            this.Controls.Add(this.misMatch);
            this.Controls.Add(this.misMatchValue);
            this.Controls.Add(this.match);
            this.Controls.Add(this.matchValue);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox matchValue;
        private System.Windows.Forms.Label match;
        private System.Windows.Forms.Label misMatch;
        private System.Windows.Forms.TextBox misMatchValue;
        private System.Windows.Forms.Label gap;
        private System.Windows.Forms.TextBox gapValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox dna1;
        private System.Windows.Forms.TextBox dna2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

