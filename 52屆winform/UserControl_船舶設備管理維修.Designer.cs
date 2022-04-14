
namespace _52屆winform
{
    partial class UserControl_船舶設備管理維修
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
            this.刷新 = new System.Windows.Forms.Button();
            this.設備狀態 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.零件_combobox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.設備 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.部分 = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.Label();
            this.負責人_combobox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.查詢 = new System.Windows.Forms.TextBox();
            this.時間BOX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IMO_combox = new System.Windows.Forms.ComboBox();
            this.新增 = new System.Windows.Forms.Button();
            this.修改 = new System.Windows.Forms.Button();
            this.刪除 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // 刷新
            // 
            this.刷新.Location = new System.Drawing.Point(800, 91);
            this.刷新.Name = "刷新";
            this.刷新.Size = new System.Drawing.Size(75, 23);
            this.刷新.TabIndex = 66;
            this.刷新.Text = "刷新";
            this.刷新.UseVisualStyleBackColor = true;
            this.刷新.Click += new System.EventHandler(this.刷新_Click);
            // 
            // 設備狀態
            // 
            this.設備狀態.Location = new System.Drawing.Point(444, 23);
            this.設備狀態.Name = "設備狀態";
            this.設備狀態.Size = new System.Drawing.Size(97, 22);
            this.設備狀態.TabIndex = 65;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(409, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 64;
            this.label14.Text = "狀態";
            // 
            // 零件_combobox
            // 
            this.零件_combobox.FormattingEnabled = true;
            this.零件_combobox.Location = new System.Drawing.Point(558, 58);
            this.零件_combobox.Name = "零件_combobox";
            this.零件_combobox.Size = new System.Drawing.Size(121, 20);
            this.零件_combobox.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 62;
            this.label13.Text = "零件";
            // 
            // 設備
            // 
            this.設備.Enabled = false;
            this.設備.Location = new System.Drawing.Point(411, 58);
            this.設備.Name = "設備";
            this.設備.Size = new System.Drawing.Size(97, 22);
            this.設備.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 60;
            this.label11.Text = "設備";
            // 
            // 部分
            // 
            this.部分.Enabled = false;
            this.部分.Location = new System.Drawing.Point(262, 61);
            this.部分.Name = "部分";
            this.部分.Size = new System.Drawing.Size(97, 22);
            this.部分.TabIndex = 59;
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.Location = new System.Drawing.Point(227, 64);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(29, 12);
            this.table.TabIndex = 58;
            this.table.Text = "部分";
            // 
            // 負責人_combobox
            // 
            this.負責人_combobox.FormattingEnabled = true;
            this.負責人_combobox.Location = new System.Drawing.Point(276, 23);
            this.負責人_combobox.Name = "負責人_combobox";
            this.負責人_combobox.Size = new System.Drawing.Size(121, 20);
            this.負責人_combobox.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 56;
            this.label10.Text = "負責人";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 55;
            this.label8.Text = "IMO";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 139);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(893, 324);
            this.dataGridView2.TabIndex = 54;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(637, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 53;
            this.label12.Text = "查詢";
            // 
            // 查詢
            // 
            this.查詢.Location = new System.Drawing.Point(672, 23);
            this.查詢.Name = "查詢";
            this.查詢.Size = new System.Drawing.Size(100, 22);
            this.查詢.TabIndex = 52;
            this.查詢.TextChanged += new System.EventHandler(this.查詢_TextChanged);
            // 
            // 時間BOX
            // 
            this.時間BOX.Location = new System.Drawing.Point(56, 58);
            this.時間BOX.Name = "時間BOX";
            this.時間BOX.Size = new System.Drawing.Size(97, 22);
            this.時間BOX.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 50;
            this.label9.Text = "時間";
            // 
            // IMO_combox
            // 
            this.IMO_combox.FormattingEnabled = true;
            this.IMO_combox.Location = new System.Drawing.Point(56, 23);
            this.IMO_combox.Name = "IMO_combox";
            this.IMO_combox.Size = new System.Drawing.Size(121, 20);
            this.IMO_combox.TabIndex = 49;
            // 
            // 新增
            // 
            this.新增.Location = new System.Drawing.Point(719, 62);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(75, 23);
            this.新增.TabIndex = 67;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = true;
            this.新增.Click += new System.EventHandler(this.新增_Click);
            // 
            // 修改
            // 
            this.修改.Location = new System.Drawing.Point(719, 91);
            this.修改.Name = "修改";
            this.修改.Size = new System.Drawing.Size(75, 23);
            this.修改.TabIndex = 68;
            this.修改.Text = "修改";
            this.修改.UseVisualStyleBackColor = true;
            this.修改.Click += new System.EventHandler(this.修改_Click);
            // 
            // 刪除
            // 
            this.刪除.Location = new System.Drawing.Point(800, 61);
            this.刪除.Name = "刪除";
            this.刪除.Size = new System.Drawing.Size(75, 23);
            this.刪除.TabIndex = 69;
            this.刪除.Text = "刪除";
            this.刪除.UseVisualStyleBackColor = true;
            this.刪除.Click += new System.EventHandler(this.刪除_Click);
            // 
            // UserControl_船舶設備管理維修
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.刪除);
            this.Controls.Add(this.修改);
            this.Controls.Add(this.新增);
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
            this.Name = "UserControl_船舶設備管理維修";
            this.Size = new System.Drawing.Size(899, 466);
            this.Load += new System.EventHandler(this.UserControl_船舶設備管理維修_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 刷新;
        private System.Windows.Forms.TextBox 設備狀態;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox 零件_combobox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox 設備;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox 部分;
        private System.Windows.Forms.Label table;
        private System.Windows.Forms.ComboBox 負責人_combobox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox 查詢;
        private System.Windows.Forms.TextBox 時間BOX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox IMO_combox;
        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.Button 修改;
        private System.Windows.Forms.Button 刪除;
    }
}
