namespace _52屆winform
{
    partial class UserControl_Ship_equipment
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
            this.SuspendLayout();
            // 
            // UserControl_Ship_equipment
            // 
            this.Name = "UserControl_Ship_equipment";
            this.Load += new System.EventHandler(this.UserControl_Ship_equipment_Load_2);
            this.ResumeLayout(false);

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
    }
}
