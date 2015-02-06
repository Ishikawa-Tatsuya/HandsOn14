namespace EmployeeManagement
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this._listBoxEmployee = new System.Windows.Forms.ListBox();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _listBoxEmployee
            // 
            this._listBoxEmployee.FormattingEnabled = true;
            this._listBoxEmployee.ItemHeight = 12;
            this._listBoxEmployee.Location = new System.Drawing.Point(12, 12);
            this._listBoxEmployee.Name = "_listBoxEmployee";
            this._listBoxEmployee.Size = new System.Drawing.Size(260, 208);
            this._listBoxEmployee.TabIndex = 0;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(116, 226);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonAdd.TabIndex = 1;
            this._buttonAdd.Text = "追加";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // _buttonSearch
            // 
            this._buttonSearch.Location = new System.Drawing.Point(197, 226);
            this._buttonSearch.Name = "_buttonSearch";
            this._buttonSearch.Size = new System.Drawing.Size(75, 23);
            this._buttonSearch.TabIndex = 2;
            this._buttonSearch.Text = "検索";
            this._buttonSearch.UseVisualStyleBackColor = true;
            this._buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._buttonSearch);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this._listBoxEmployee);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "社員管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _listBoxEmployee;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.Button _buttonSearch;
    }
}

