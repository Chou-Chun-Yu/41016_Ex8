namespace _41016_Ex8
{
    partial class Multiplication
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_xStart = new System.Windows.Forms.TextBox();
            this.tb_xEnd = new System.Windows.Forms.TextBox();
            this.tb_yStart = new System.Windows.Forms.TextBox();
            this.tb_yEnd = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.lb_xStart = new System.Windows.Forms.Label();
            this.lb_xEnd = new System.Windows.Forms.Label();
            this.lb_yStart = new System.Windows.Forms.Label();
            this.lb_yEnd = new System.Windows.Forms.Label();
            this.bt_generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_xStart
            // 
            this.tb_xStart.Location = new System.Drawing.Point(81, 27);
            this.tb_xStart.Name = "tb_xStart";
            this.tb_xStart.Size = new System.Drawing.Size(100, 22);
            this.tb_xStart.TabIndex = 0;
            // 
            // tb_xEnd
            // 
            this.tb_xEnd.Location = new System.Drawing.Point(242, 27);
            this.tb_xEnd.Name = "tb_xEnd";
            this.tb_xEnd.Size = new System.Drawing.Size(100, 22);
            this.tb_xEnd.TabIndex = 1;
            // 
            // tb_yStart
            // 
            this.tb_yStart.Location = new System.Drawing.Point(81, 55);
            this.tb_yStart.Name = "tb_yStart";
            this.tb_yStart.Size = new System.Drawing.Size(100, 22);
            this.tb_yStart.TabIndex = 2;
            // 
            // tb_yEnd
            // 
            this.tb_yEnd.Location = new System.Drawing.Point(242, 55);
            this.tb_yEnd.Name = "tb_yEnd";
            this.tb_yEnd.Size = new System.Drawing.Size(100, 22);
            this.tb_yEnd.TabIndex = 3;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(28, 83);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_result.Size = new System.Drawing.Size(329, 222);
            this.tb_result.TabIndex = 4;
            this.tb_result.WordWrap = false;
            // 
            // lb_xStart
            // 
            this.lb_xStart.AutoSize = true;
            this.lb_xStart.Location = new System.Drawing.Point(26, 30);
            this.lb_xStart.Name = "lb_xStart";
            this.lb_xStart.Size = new System.Drawing.Size(49, 12);
            this.lb_xStart.TabIndex = 5;
            this.lb_xStart.Text = "起始值X";
            // 
            // lb_xEnd
            // 
            this.lb_xEnd.AutoSize = true;
            this.lb_xEnd.Location = new System.Drawing.Point(187, 30);
            this.lb_xEnd.Name = "lb_xEnd";
            this.lb_xEnd.Size = new System.Drawing.Size(49, 12);
            this.lb_xEnd.TabIndex = 6;
            this.lb_xEnd.Text = "終止值X";
            // 
            // lb_yStart
            // 
            this.lb_yStart.AutoSize = true;
            this.lb_yStart.Location = new System.Drawing.Point(26, 58);
            this.lb_yStart.Name = "lb_yStart";
            this.lb_yStart.Size = new System.Drawing.Size(49, 12);
            this.lb_yStart.TabIndex = 7;
            this.lb_yStart.Text = "起始值Y";
            // 
            // lb_yEnd
            // 
            this.lb_yEnd.AutoSize = true;
            this.lb_yEnd.Location = new System.Drawing.Point(187, 58);
            this.lb_yEnd.Name = "lb_yEnd";
            this.lb_yEnd.Size = new System.Drawing.Size(49, 12);
            this.lb_yEnd.TabIndex = 8;
            this.lb_yEnd.Text = "終止值Y";
            // 
            // bt_generate
            // 
            this.bt_generate.Location = new System.Drawing.Point(161, 311);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(75, 23);
            this.bt_generate.TabIndex = 9;
            this.bt_generate.Text = "乘法表";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // Multiplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 345);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.lb_yEnd);
            this.Controls.Add(this.lb_yStart);
            this.Controls.Add(this.lb_xEnd);
            this.Controls.Add(this.lb_xStart);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_yEnd);
            this.Controls.Add(this.tb_yStart);
            this.Controls.Add(this.tb_xEnd);
            this.Controls.Add(this.tb_xStart);
            this.Name = "Multiplication";
            this.Text = "乘法表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_xStart;
        private System.Windows.Forms.TextBox tb_xEnd;
        private System.Windows.Forms.TextBox tb_yStart;
        private System.Windows.Forms.TextBox tb_yEnd;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label lb_xStart;
        private System.Windows.Forms.Label lb_xEnd;
        private System.Windows.Forms.Label lb_yStart;
        private System.Windows.Forms.Label lb_yEnd;
        private System.Windows.Forms.Button bt_generate;
    }
}

