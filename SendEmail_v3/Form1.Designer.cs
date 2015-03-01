namespace SendEmail_v3
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.left = new System.Windows.Forms.Panel();
            this.middle = new System.Windows.Forms.Panel();
            this.right = new System.Windows.Forms.Panel();
            this.up = new System.Windows.Forms.DataGridView();
            this.down = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.ComboBox();
            this.Checks = new System.Windows.Forms.CheckedListBox();
            this.submit = new System.Windows.Forms.Button();
            this.left.SuspendLayout();
            this.middle.SuspendLayout();
            this.right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.left.Controls.Add(this.Names);
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(147, 374);
            this.left.TabIndex = 0;
            // 
            // middle
            // 
            this.middle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middle.Controls.Add(this.down);
            this.middle.Controls.Add(this.up);
            this.middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middle.Location = new System.Drawing.Point(147, 0);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(636, 374);
            this.middle.TabIndex = 1;
            // 
            // right
            // 
            this.right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.right.Controls.Add(this.submit);
            this.right.Controls.Add(this.Checks);
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(633, 0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(150, 374);
            this.right.TabIndex = 2;
            // 
            // up
            // 
            this.up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.up.BackgroundColor = System.Drawing.SystemColors.Control;
            this.up.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.up.Location = new System.Drawing.Point(-1, -1);
            this.up.Name = "up";
            this.up.RowTemplate.Height = 23;
            this.up.Size = new System.Drawing.Size(489, 155);
            this.up.TabIndex = 0;
            // 
            // down
            // 
            this.down.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.down.BackgroundColor = System.Drawing.SystemColors.Control;
            this.down.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.down.Location = new System.Drawing.Point(-1, 154);
            this.down.Name = "down";
            this.down.RowTemplate.Height = 23;
            this.down.Size = new System.Drawing.Size(489, 215);
            this.down.TabIndex = 1;
            // 
            // Names
            // 
            this.Names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.Names.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Names.FormattingEnabled = true;
            this.Names.Location = new System.Drawing.Point(11, 11);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(121, 350);
            this.Names.TabIndex = 0;
            this.Names.SelectedIndexChanged += new System.EventHandler(this.Names_SelectedIndexChanged);
            // 
            // Checks
            // 
            this.Checks.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Checks.FormattingEnabled = true;
            this.Checks.Location = new System.Drawing.Point(17, 11);
            this.Checks.Name = "Checks";
            this.Checks.Size = new System.Drawing.Size(120, 276);
            this.Checks.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(41, 309);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 42);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 374);
            this.Controls.Add(this.right);
            this.Controls.Add(this.middle);
            this.Controls.Add(this.left);
            this.Name = "MainForm";
            this.Text = "SendEmail";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.left.ResumeLayout(false);
            this.middle.ResumeLayout(false);
            this.right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel left;
        private System.Windows.Forms.Panel middle;
        private System.Windows.Forms.Panel right;
        private System.Windows.Forms.DataGridView down;
        private System.Windows.Forms.DataGridView up;
        private System.Windows.Forms.ComboBox Names;
        private System.Windows.Forms.CheckedListBox Checks;
        private System.Windows.Forms.Button submit;
    }
}

