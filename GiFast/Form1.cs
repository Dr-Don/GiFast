using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace GiFast
{
    public partial class GiFast : Form
    {
        string sPath = "";
        string sPathOut = "";
        enum Mode
        {
            PNG = 1,
            JPEG = 2
        }
        Mode mode = Mode.PNG;

        public GiFast()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            pngMode.Checked = true;
        }

        // 选择文件
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "动图(*.gif)|*.gif";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sPath = openFileDialog.FileName;
                fileText.Text = sPath;
            }
        }


        // 转换
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = sPath;
            saveFileDialog.Filter = mode == Mode.PNG?"图片(*.png)|*.png":"图片(*.jpeg)|*.jpeg";
            saveFileDialog.FileName = "frame";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sPathOut = saveFileDialog.FileName;
                Image imgGif = Image.FromFile(sPath, true);
                var ImgFrmDim = new FrameDimension(imgGif.FrameDimensionsList[0]);
                int count = imgGif.GetFrameCount(ImgFrmDim);
                for (int i = 0; i < count; i++)
                {
                    imgGif.SelectActiveFrame(ImgFrmDim, i);
                    switch(mode)
                    {
                        case Mode.PNG:
                            imgGif.Save(sPathOut.Substring(0, sPathOut.Length - 4) + string.Format(@"{0}.png", i), ImageFormat.Png);
                            break;
                        case Mode.JPEG:
                            imgGif.Save(sPathOut.Substring(0, sPathOut.Length - 5) + string.Format(@"{0}.jpeg", i), ImageFormat.Jpeg);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void pngMode_CheckedChanged(object sender, EventArgs e)
        {
            mode = Mode.PNG;
        }

        private void jpegMode_CheckedChanged(object sender, EventArgs e)
        {
            mode = Mode.JPEG;
        }
    }
}
