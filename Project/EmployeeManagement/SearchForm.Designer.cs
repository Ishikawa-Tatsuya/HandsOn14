namespace EmployeeManagement
{
    partial class SearchForm
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
            this._buttonExecute = new System.Windows.Forms.Button();
            this._textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._listBoxEmployee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _buttonExecute
            // 
            this._buttonExecute.Location = new System.Drawing.Point(104, 37);
            this._buttonExecute.Name = "_buttonExecute";
            this._buttonExecute.Size = new System.Drawing.Size(71, 23);
            this._buttonExecute.TabIndex = 0;
            this._buttonExecute.Text = "実行";
            this._buttonExecute.UseVisualStyleBackColor = true;
            this._buttonExecute.Click += new System.EventHandler(this.ButtonExecuteClick);
            // 
            // _textBoxSearch
            // 
            this._textBoxSearch.Location = new System.Drawing.Point(71, 12);
            this._textBoxSearch.Name = "_textBoxSearch";
            this._textBoxSearch.Size = new System.Drawing.Size(202, 19);
            this._textBoxSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "検索文字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "検索結果";
            // 
            // _listBoxEmployee
            // 
            this._listBoxEmployee.FormattingEnabled = true;
            this._listBoxEmployee.ItemHeight = 12;
            this._listBoxEmployee.Location = new System.Drawing.Point(12, 93);
            this._listBoxEmployee.Name = "_listBoxEmployee";
            this._listBoxEmployee.Size = new System.Drawing.Size(261, 160);
            this._listBoxEmployee.TabIndex = 5;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._listBoxEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBoxSearch);
            this.Controls.Add(this._buttonExecute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForm";
            this.Text = "住所検索(部分一致)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonExecute;
        private System.Windows.Forms.TextBox _textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox _listBoxEmployee;
    }
}