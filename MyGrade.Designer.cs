
namespace MyOwn
{
    partial class MyGrade
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRnd20 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEveryone = new System.Windows.Forms.Button();
            this.btnRnd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(78, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 33);
            this.txtName.TabIndex = 39;
            // 
            // btnRnd20
            // 
            this.btnRnd20.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRnd20.Location = new System.Drawing.Point(17, 403);
            this.btnRnd20.Name = "btnRnd20";
            this.btnRnd20.Size = new System.Drawing.Size(202, 31);
            this.btnRnd20.TabIndex = 38;
            this.btnRnd20.Text = "隨機加入20筆";
            this.btnRnd20.UseVisualStyleBackColor = true;
            this.btnRnd20.Click += new System.EventHandler(this.btnRnd20_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(17, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(202, 31);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEveryone
            // 
            this.btnEveryone.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEveryone.Location = new System.Drawing.Point(16, 265);
            this.btnEveryone.Name = "btnEveryone";
            this.btnEveryone.Size = new System.Drawing.Size(202, 31);
            this.btnEveryone.TabIndex = 36;
            this.btnEveryone.Text = "各科統計";
            this.btnEveryone.UseVisualStyleBackColor = true;
            // 
            // btnRnd
            // 
            this.btnRnd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRnd.Location = new System.Drawing.Point(16, 228);
            this.btnRnd.Name = "btnRnd";
            this.btnRnd.Size = new System.Drawing.Size(202, 31);
            this.btnRnd.TabIndex = 34;
            this.btnRnd.Text = "隨機儲存資料";
            this.btnRnd.UseVisualStyleBackColor = true;
            this.btnRnd.Click += new System.EventHandler(this.btnRnd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 11.25F);
            this.btnInsert.Location = new System.Drawing.Point(17, 191);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(202, 31);
            this.btnInsert.TabIndex = 33;
            this.btnInsert.Text = "加入學生資料";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(78, 141);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(139, 33);
            this.txtMath.TabIndex = 31;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(78, 97);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(139, 33);
            this.txtEnglish.TabIndex = 30;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(78, 53);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(139, 33);
            this.txtChinese.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 35);
            this.label4.TabIndex = 28;
            this.label4.Text = "數學:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "英文:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 35);
            this.label2.TabIndex = 26;
            this.label2.Text = "國文:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "姓名:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(254, 22);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.labName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.labCount);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.labState);
            this.splitContainer1.Size = new System.Drawing.Size(535, 412);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(518, 16);
            this.label5.TabIndex = 1;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Layout += new System.Windows.Forms.LayoutEventHandler(this.label5_Layout);
            // 
            // labName
            // 
            this.labName.AutoEllipsis = true;
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Gainsboro;
            this.labName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labName.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(3, 20);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(2, 14);
            this.labName.TabIndex = 0;
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labCount
            // 
            this.labCount.BackColor = System.Drawing.Color.Gainsboro;
            this.labCount.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCount.Location = new System.Drawing.Point(425, 7);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(96, 16);
            this.labCount.TabIndex = 3;
            this.labCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 16);
            this.label6.TabIndex = 2;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labState
            // 
            this.labState.Location = new System.Drawing.Point(1, 23);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(560, 124);
            this.labState.TabIndex = 0;
            this.labState.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(234, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 452);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // MyGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRnd20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEveryone);
            this.Controls.Add(this.btnRnd);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyGrade";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRnd20;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEveryone;
        private System.Windows.Forms.Button btnRnd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

