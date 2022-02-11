
namespace GiFast
{
    partial class GiFast
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiFast));
            this.fileText = new System.Windows.Forms.TextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.exchangeBtn = new System.Windows.Forms.Button();
            this.jpegMode = new System.Windows.Forms.RadioButton();
            this.pngMode = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // fileText
            // 
            resources.ApplyResources(this.fileText, "fileText");
            this.fileText.Name = "fileText";
            // 
            // selectBtn
            // 
            resources.ApplyResources(this.selectBtn, "selectBtn");
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exchangeBtn
            // 
            resources.ApplyResources(this.exchangeBtn, "exchangeBtn");
            this.exchangeBtn.Name = "exchangeBtn";
            this.exchangeBtn.UseVisualStyleBackColor = true;
            this.exchangeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // jpegMode
            // 
            resources.ApplyResources(this.jpegMode, "jpegMode");
            this.jpegMode.Name = "jpegMode";
            this.jpegMode.TabStop = true;
            this.jpegMode.UseVisualStyleBackColor = true;
            this.jpegMode.CheckedChanged += new System.EventHandler(this.jpegMode_CheckedChanged);
            // 
            // pngMode
            // 
            resources.ApplyResources(this.pngMode, "pngMode");
            this.pngMode.Name = "pngMode";
            this.pngMode.TabStop = true;
            this.pngMode.UseVisualStyleBackColor = true;
            this.pngMode.CheckedChanged += new System.EventHandler(this.pngMode_CheckedChanged);
            // 
            // GiFast
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pngMode);
            this.Controls.Add(this.jpegMode);
            this.Controls.Add(this.exchangeBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.fileText);
            this.MaximizeBox = false;
            this.Name = "GiFast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button exchangeBtn;
        private System.Windows.Forms.RadioButton jpegMode;
        private System.Windows.Forms.RadioButton pngMode;
    }
}

