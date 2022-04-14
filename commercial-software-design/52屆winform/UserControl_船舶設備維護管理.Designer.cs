namespace _52屆winform
{
    partial class UserControl_船舶設備維護管理
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
            this.IMO_combox = new System.Windows.Forms.ComboBox();
            this.時間BOX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.查詢 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.負責人_combobox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.部分 = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.Label();
            this.設備 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.零件_combobox = new System.Windows.Forms.ComboBox();
            this.設備狀態 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.刷新 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // IMO_combox
            // 
            this.IMO_combox.FormattingEnabled = true;
            this.IMO_combox.Location = new System.Drawing.Point(56, 43);
            this.IMO_combox.Name = "IMO_combox";
            this.IMO_combox.Size = new System.Drawing.Size(121, 20);
            this.IMO_combox.TabIndex = 31;
            // 
            // 時間BOX
            // 
            this.時間BOX.Enabled = false;
            this.時間BOX.Location = new System.Drawing.Point(56, 78);
            this.時間BOX.Name = "時間BOX";
            this.時間BOX.Size = new System.Drawing.Size(97, 22);
            this.時間BOX.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "時間";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(637, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "查詢";
            // 
            // 查詢
            // 
            this.查詢.Location = new System.Drawing.Point(672, 43);
            this.查詢.Name = "查詢";
            this.查詢.Size = new System.Drawing.Size(100, 22);
            this.查詢.TabIndex = 34;
            this.查詢.TextChanged += new System.EventHandler(this.查詢_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 139);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(893, 324);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 37;
            this.label8.Text = "IMO";
            // 
            // 負責人_combobox
            // 
            this.負責人_combobox.FormattingEnabled = true;
            this.負責人_combobox.Location = new System.Drawing.Point(276, 43);
            this.負責人_combobox.Name = "負責人_combobox";
            this.負責人_combobox.Size = new System.Drawing.Size(121, 20);
            this.負責人_combobox.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 38;
            this.label10.Text = "負責人";
            // 
            // 部分
            // 
            this.部分.Enabled = false;
            this.部分.Location = new System.Drawing.Point(262, 81);
            this.部分.Name = "部分";
            this.部分.Size = new System.Drawing.Size(97, 22);
            this.部分.TabIndex = 41;
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.Location = new System.Drawing.Point(227, 84);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(29, 12);
            this.table.TabIndex = 40;
            this.table.Text = "部分";
            // 
            // 設備
            // 
            this.設備.Enabled = false;
            this.設備.Location = new System.Drawing.Point(411, 78);
            this.設備.Name = "設備";
            this.設備.Size = new System.Drawing.Size(97, 22);
            this.設備.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "設備";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 44;
            this.label13.Text = "零件";
            // 
            // 零件_combobox
            // 
            this.零件_combobox.FormattingEnabled = true;
            this.零件_combobox.Location = new System.Drawing.Point(558, 78);
            this.零件_combobox.Name = "零件_combobox";
            this.零件_combobox.Size = new System.Drawing.Size(121, 20);
            this.零件_combobox.TabIndex = 45;
            // 
            // 設備狀態
            // 
            this.設備狀態.Enabled = false;
            this.設備狀態.Location = new System.Drawing.Point(444, 43);
            this.設備狀態.Name = "設備狀態";
            this.設備狀態.Size = new System.Drawing.Size(97, 22);
            this.設備狀態.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(409, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 46;
            this.label14.Text = "狀態";
            // 
            // 刷新
            // 
            this.刷新.Location = new System.Drawing.Point(800, 81);
            this.刷新.Name = "刷新";
            this.刷新.Size = new System.Drawing.Size(75, 23);
            this.刷新.TabIndex = 48;
            this.刷新.Text = "刷新";
            this.刷新.UseVisualStyleBackColor = true;
            this.刷新.Click += new System.EventHandler(this.刷新_Click);
            // 
            // UserControl_船舶設備維護管理
            // 
            this.Controls.Add(this.刷新);
            this.Controls.Add(this.設備狀態);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.零件_combobox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.設備);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.部分);
            this.Controls.Add(this.table);
            this.Controls.Add(this.負責人_combobox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.查詢);
            this.Controls.Add(this.時間BOX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IMO_combox);
            this.Name = "UserControl_船舶設備維護管理";
            this.Size = new System.Drawing.Size(899, 466);
            this.Load += new System.EventHandler(this.UserControl_Ship_equipment_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox 港口名稱_combobox;
        private System.Windows.Forms.ComboBox 船種ID_combobox;
        private System.Windows.Forms.Button updata;
        private System.Windows.Forms.TextBox 搜尋;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox 時間;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 狀態;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox 航線名稱;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IMO_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IMO_combox;
        private System.Windows.Forms.TextBox 時間BOX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox 查詢;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox 負責人_combobox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox 部分;
        private System.Windows.Forms.Label table;
        private System.Windows.Forms.TextBox 設備;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox 零件_combobox;
        private System.Windows.Forms.TextBox 設備狀態;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button 刷新;
    }
}
