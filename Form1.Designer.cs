namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShowtxt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowPDF = new System.Windows.Forms.Button();
            this.btnConvertRTF = new System.Windows.Forms.Button();
            this.btnConvertJPG = new System.Windows.Forms.Button();
            this.btnConvertPDF = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPDF2Doc = new System.Windows.Forms.Button();
            this.btnPDF2Excel = new System.Windows.Forms.Button();
            this.btnPDF2Html = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(601, 305);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(12, 323);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 36);
            this.textBox1.TabIndex = 1;
            // 
            // btnShowtxt
            // 
            this.btnShowtxt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShowtxt.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowtxt.Location = new System.Drawing.Point(619, 323);
            this.btnShowtxt.Name = "btnShowtxt";
            this.btnShowtxt.Size = new System.Drawing.Size(138, 39);
            this.btnShowtxt.TabIndex = 3;
            this.btnShowtxt.Text = "文檔顯示";
            this.btnShowtxt.UseVisualStyleBackColor = false;
            this.btnShowtxt.Click += new System.EventHandler(this.btnShowtxt_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(619, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "文檔儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowPDF
            // 
            this.btnShowPDF.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShowPDF.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowPDF.Location = new System.Drawing.Point(619, 368);
            this.btnShowPDF.Name = "btnShowPDF";
            this.btnShowPDF.Size = new System.Drawing.Size(138, 39);
            this.btnShowPDF.TabIndex = 5;
            this.btnShowPDF.Text = "PDF顯示";
            this.btnShowPDF.UseVisualStyleBackColor = false;
            this.btnShowPDF.Click += new System.EventHandler(this.btnShowPDF_Click);
            // 
            // btnConvertRTF
            // 
            this.btnConvertRTF.BackColor = System.Drawing.Color.Yellow;
            this.btnConvertRTF.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConvertRTF.Location = new System.Drawing.Point(619, 188);
            this.btnConvertRTF.Name = "btnConvertRTF";
            this.btnConvertRTF.Size = new System.Drawing.Size(138, 39);
            this.btnConvertRTF.TabIndex = 6;
            this.btnConvertRTF.Text = "PDF轉RTF";
            this.btnConvertRTF.UseVisualStyleBackColor = false;
            this.btnConvertRTF.Click += new System.EventHandler(this.btnConvertRTF_Click);
            // 
            // btnConvertJPG
            // 
            this.btnConvertJPG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConvertJPG.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConvertJPG.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnConvertJPG.Location = new System.Drawing.Point(619, 143);
            this.btnConvertJPG.Name = "btnConvertJPG";
            this.btnConvertJPG.Size = new System.Drawing.Size(138, 39);
            this.btnConvertJPG.TabIndex = 8;
            this.btnConvertJPG.Text = "PDF轉JPG";
            this.btnConvertJPG.UseVisualStyleBackColor = false;
            this.btnConvertJPG.Click += new System.EventHandler(this.btnConvertJPG_Click);
            // 
            // btnConvertPDF
            // 
            this.btnConvertPDF.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConvertPDF.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConvertPDF.ForeColor = System.Drawing.Color.Black;
            this.btnConvertPDF.Location = new System.Drawing.Point(619, 233);
            this.btnConvertPDF.Name = "btnConvertPDF";
            this.btnConvertPDF.Size = new System.Drawing.Size(138, 39);
            this.btnConvertPDF.TabIndex = 9;
            this.btnConvertPDF.Text = "Doc轉PDF";
            this.btnConvertPDF.UseVisualStyleBackColor = false;
            this.btnConvertPDF.Click += new System.EventHandler(this.btnConvertPDF_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpen.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpen.Location = new System.Drawing.Point(527, 368);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(86, 39);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(527, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPDF2Doc
            // 
            this.btnPDF2Doc.BackColor = System.Drawing.Color.Blue;
            this.btnPDF2Doc.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPDF2Doc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDF2Doc.Location = new System.Drawing.Point(619, 12);
            this.btnPDF2Doc.Name = "btnPDF2Doc";
            this.btnPDF2Doc.Size = new System.Drawing.Size(138, 39);
            this.btnPDF2Doc.TabIndex = 11;
            this.btnPDF2Doc.Text = "PDF轉Doc";
            this.btnPDF2Doc.UseVisualStyleBackColor = false;
            this.btnPDF2Doc.Click += new System.EventHandler(this.btnPDF2Doc_Click);
            // 
            // btnPDF2Excel
            // 
            this.btnPDF2Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPDF2Excel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPDF2Excel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDF2Excel.Location = new System.Drawing.Point(619, 53);
            this.btnPDF2Excel.Name = "btnPDF2Excel";
            this.btnPDF2Excel.Size = new System.Drawing.Size(138, 39);
            this.btnPDF2Excel.TabIndex = 12;
            this.btnPDF2Excel.Text = "PDF轉Excel";
            this.btnPDF2Excel.UseVisualStyleBackColor = false;
            this.btnPDF2Excel.Click += new System.EventHandler(this.btnPDF2Excel_Click);
            // 
            // btnPDF2Html
            // 
            this.btnPDF2Html.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF2Html.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPDF2Html.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDF2Html.Location = new System.Drawing.Point(619, 98);
            this.btnPDF2Html.Name = "btnPDF2Html";
            this.btnPDF2Html.Size = new System.Drawing.Size(138, 39);
            this.btnPDF2Html.TabIndex = 13;
            this.btnPDF2Html.Text = "PDF轉Html";
            this.btnPDF2Html.UseVisualStyleBackColor = false;
            this.btnPDF2Html.Click += new System.EventHandler(this.btnPDF2Html_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(771, 428);
            this.Controls.Add(this.btnPDF2Html);
            this.Controls.Add(this.btnPDF2Excel);
            this.Controls.Add(this.btnPDF2Doc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConvertPDF);
            this.Controls.Add(this.btnConvertJPG);
            this.Controls.Add(this.btnConvertRTF);
            this.Controls.Add(this.btnShowPDF);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowtxt);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "期末報告 - 物件導向程式設計_線上文件轉檔";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShowtxt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowPDF;
        private System.Windows.Forms.Button btnConvertRTF;
        private System.Windows.Forms.Button btnConvertJPG;
        private System.Windows.Forms.Button btnConvertPDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPDF2Doc;
        private System.Windows.Forms.Button btnPDF2Excel;
        private System.Windows.Forms.Button btnPDF2Html;
    }
}

