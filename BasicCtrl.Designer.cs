namespace H.H.tool
{
    partial class HouseHoldTool
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.TotalAmount = new System.Windows.Forms.Label();
            this.FixBtn = new System.Windows.Forms.Button();
            this.HH_List = new System.Windows.Forms.ListBox();
            this.DateSelect = new System.Windows.Forms.DateTimePicker();
            this.AmountTxt = new System.Windows.Forms.NumericUpDown();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.Outgo = new System.Windows.Forms.Label();
            this.Income = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15F);
            this.TotalAmount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TotalAmount.Location = new System.Drawing.Point(263, 259);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(147, 20);
            this.TotalAmount.TabIndex = 0;
            this.TotalAmount.Text = "\\100,000,000";
            // 
            // FixBtn
            // 
            this.FixBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FixBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FixBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FixBtn.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.FixBtn.Location = new System.Drawing.Point(343, 86);
            this.FixBtn.Name = "FixBtn";
            this.FixBtn.Size = new System.Drawing.Size(75, 23);
            this.FixBtn.TabIndex = 4;
            this.FixBtn.Text = "Fix";
            this.FixBtn.UseVisualStyleBackColor = false;
            this.FixBtn.Click += new System.EventHandler(this.FixBtn_Click);
            // 
            // HH_List
            // 
            this.HH_List.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.HH_List.FormattingEnabled = true;
            this.HH_List.Location = new System.Drawing.Point(59, 139);
            this.HH_List.Name = "HH_List";
            this.HH_List.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.HH_List.Size = new System.Drawing.Size(267, 82);
            this.HH_List.TabIndex = 7;
            // 
            // DateSelect
            // 
            this.DateSelect.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.DateSelect.Location = new System.Drawing.Point(59, 32);
            this.DateSelect.Name = "DateSelect";
            this.DateSelect.Size = new System.Drawing.Size(144, 21);
            this.DateSelect.TabIndex = 8;
            // 
            // AmountTxt
            // 
            this.AmountTxt.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.AmountTxt.Location = new System.Drawing.Point(237, 87);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(89, 21);
            this.AmountTxt.TabIndex = 9;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.DeleteBtn.Location = new System.Drawing.Point(343, 168);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.AmountLabel.Location = new System.Drawing.Point(183, 90);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(54, 14);
            this.AmountLabel.TabIndex = 11;
            this.AmountLabel.Text = "金額  \\";
            // 
            // Outgo
            // 
            this.Outgo.AutoSize = true;
            this.Outgo.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.Outgo.Location = new System.Drawing.Point(234, 39);
            this.Outgo.Name = "Outgo";
            this.Outgo.Size = new System.Drawing.Size(35, 14);
            this.Outgo.TabIndex = 11;
            this.Outgo.Text = "支出";
            // 
            // Income
            // 
            this.Income.AutoSize = true;
            this.Income.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 10F);
            this.Income.Location = new System.Drawing.Point(322, 39);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(35, 14);
            this.Income.TabIndex = 11;
            this.Income.Text = "収入";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15F);
            this.Balance.ForeColor = System.Drawing.Color.Crimson;
            this.Balance.Location = new System.Drawing.Point(212, 258);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(49, 20);
            this.Balance.TabIndex = 11;
            this.Balance.Text = "残高";
            // 
            // HouseHoldTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(463, 300);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.Outgo);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.DateSelect);
            this.Controls.Add(this.HH_List);
            this.Controls.Add(this.FixBtn);
            this.Controls.Add(this.TotalAmount);
            this.Name = "HouseHoldTool";
            this.Text = "HouseHold";
            ((System.ComponentModel.ISupportInitialize)(this.AmountTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Button FixBtn;
        private System.Windows.Forms.ListBox HH_List;
        private System.Windows.Forms.DateTimePicker DateSelect;
        private System.Windows.Forms.NumericUpDown AmountTxt;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label Outgo;
        private System.Windows.Forms.Label Income;
        private System.Windows.Forms.Label Balance;
    }
}

