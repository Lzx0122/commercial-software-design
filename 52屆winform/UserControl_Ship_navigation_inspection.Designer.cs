namespace _52屆winform
{
    partial class UserControl_Ship_navigation_inspection
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.IMO_combobox = new System.Windows.Forms.ComboBox();
            this.港口名稱_combobox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.查詢 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.狀態 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.航線名稱 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.時間 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IMO_combobox
            // 
            this.IMO_combobox.FormattingEnabled = true;
            this.IMO_combobox.Location = new System.Drawing.Point(75, 15);
            this.IMO_combobox.Name = "IMO_combobox";
            this.IMO_combobox.Size = new System.Drawing.Size(121, 20);
            this.IMO_combobox.TabIndex = 40;
            // 
            // 港口名稱_combobox
            // 
            this.港口名稱_combobox.FormattingEnabled = true;
            this.港口名稱_combobox.Location = new System.Drawing.Point(424, 15);
            this.港口名稱_combobox.Name = "港口名稱_combobox";
            this.港口名稱_combobox.Size = new System.Drawing.Size(121, 20);
            this.港口名稱_combobox.TabIndex = 39;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(465, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 查詢
            // 
            this.查詢.Location = new System.Drawing.Point(638, 98);
            this.查詢.Name = "查詢";
            this.查詢.Size = new System.Drawing.Size(100, 22);
            this.查詢.TabIndex = 37;
            this.查詢.TextChanged += new System.EventHandler(this.查詢_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "刪除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(893, 324);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "港口名稱";
            // 
            // 狀態
            // 
            this.狀態.Location = new System.Drawing.Point(624, 13);
            this.狀態.Name = "狀態";
            this.狀態.Size = new System.Drawing.Size(100, 22);
            this.狀態.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "狀態";
            // 
            // 航線名稱
            // 
            this.航線名稱.Location = new System.Drawing.Point(258, 15);
            this.航線名稱.Name = "航線名稱";
            this.航線名稱.Size = new System.Drawing.Size(100, 22);
            this.航線名稱.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "航線名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "IMO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "時間";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 43;
            this.label6.Text = "查詢";
            // 
            // 時間
            // 
            this.時間.Location = new System.Drawing.Point(75, 69);
            this.時間.Name = "時間";
            this.時間.Size = new System.Drawing.Size(150, 22);
            this.時間.TabIndex = 44;
            // 
            // UserControl_Ship_navigation_inspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.時間);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IMO_combobox);
            this.Controls.Add(this.港口名稱_combobox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.查詢);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.狀態);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.航線名稱);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Ship_navigation_inspection";
            this.Size = new System.Drawing.Size(899, 466);
            this.Load += new System.EventHandler(this.UserControl_Ship_navigation_inspection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IMO_combobox;
        private System.Windows.Forms.ComboBox 港口名稱_combobox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox 查詢;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 狀態;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 航線名稱;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 時間;
    }
}
