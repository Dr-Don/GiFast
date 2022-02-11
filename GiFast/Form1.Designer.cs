
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.barText1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileText
            // 
            resources.ApplyResources(this.fileText, "fileText");
            this.fileText.ForeColor = System.Drawing.SystemColors.ScrollBar;
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
            this.exchangeBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.exchangeBtn, "exchangeBtn");
            this.exchangeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exchangeBtn.Name = "exchangeBtn";
            this.exchangeBtn.UseVisualStyleBackColor = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.barText1);
            this.groupBox1.Controls.Add(this.exchangeBtn);
            this.groupBox1.Controls.Add(this.jpegMode);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.pngMode);
            this.groupBox1.Controls.Add(this.fileText);
            this.groupBox1.Controls.Add(this.selectBtn);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Gif_DragDrop);
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Gif_DragEnter);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // barText1
            // 
            resources.ApplyResources(this.barText1, "barText1");
            this.barText1.Name = "barText1";
            // 
            // GiFast
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "GiFast";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Gif_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Gif_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button exchangeBtn;
        private System.Windows.Forms.RadioButton jpegMode;
        private System.Windows.Forms.RadioButton pngMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label barText1;
    }
}

