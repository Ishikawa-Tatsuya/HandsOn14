namespace EmployeeManagement
{
    partial class AddForm
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
            this._buttonEntry = new System.Windows.Forms.Button();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._radioButtonWoman = new System.Windows.Forms.RadioButton();
            this._radioButtonMan = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _buttonEntry
            // 
            this._buttonEntry.Location = new System.Drawing.Point(197, 63);
            this._buttonEntry.Name = "_buttonEntry";
            this._buttonEntry.Size = new System.Drawing.Size(75, 23);
            this._buttonEntry.TabIndex = 0;
            this._buttonEntry.Text = "登録";
            this._buttonEntry.UseVisualStyleBackColor = true;
            this._buttonEntry.Click += new System.EventHandler(this.ButtonEntryClick);
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(53, 12);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(219, 19);
            this._textBoxName.TabIndex = 1;
            // 
            // _textBoxAddress
            // 
            this._textBoxAddress.Location = new System.Drawing.Point(53, 37);
            this._textBoxAddress.Name = "_textBoxAddress";
            this._textBoxAddress.Size = new System.Drawing.Size(219, 19);
            this._textBoxAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "住所";
            // 
            // _radioButtonWoman
            // 
            this._radioButtonWoman.AutoSize = true;
            this._radioButtonWoman.Location = new System.Drawing.Point(106, 63);
            this._radioButtonWoman.Name = "_radioButtonWoman";
            this._radioButtonWoman.Size = new System.Drawing.Size(47, 16);
            this._radioButtonWoman.TabIndex = 5;
            this._radioButtonWoman.TabStop = true;
            this._radioButtonWoman.Text = "女性";
            this._radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // _radioButtonMan
            // 
            this._radioButtonMan.AutoSize = true;
            this._radioButtonMan.Location = new System.Drawing.Point(53, 63);
            this._radioButtonMan.Name = "_radioButtonMan";
            this._radioButtonMan.Size = new System.Drawing.Size(47, 16);
            this._radioButtonMan.TabIndex = 6;
            this._radioButtonMan.TabStop = true;
            this._radioButtonMan.Text = "男性";
            this._radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "性別";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 102);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._radioButtonMan);
            this.Controls.Add(this._radioButtonWoman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBoxAddress);
            this.Controls.Add(this._textBoxName);
            this.Controls.Add(this._buttonEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonEntry;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.TextBox _textBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton _radioButtonWoman;
        private System.Windows.Forms.RadioButton _radioButtonMan;
        private System.Windows.Forms.Label label3;
    }
}