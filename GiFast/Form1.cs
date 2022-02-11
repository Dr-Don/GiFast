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
        string sPathOut = "";
        Dictionary<string, string> srcPath;
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

        void RefreshUI()
        {
            srcPath = new Dictionary<string, string>();
            fileText.Text = "";
            progressBar1.Value = 0;
            barText1.Text = "进度：0%";
        }

        // 选择文件
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "动图(*.gif)|*.gif";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RefreshUI();
                for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                {
                    string path = openFileDialog.FileNames[i];
                    string name = openFileDialog.SafeFileNames[i].Substring(0, openFileDialog.SafeFileNames[i].Length - 4);
                    srcPath.Add(path, name);
                    fileText.Text = fileText.Text + path + ";";
                }
            }
        }


        // 转换
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = srcPath.First().Key;
            saveFileDialog.Filter = mode == Mode.PNG?"图片(*.png)|*.png":"图片(*.jpeg)|*.jpeg";
            saveFileDialog.FileName = "frame";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sPathOut = saveFileDialog.FileName;
                int total = srcPath.Count;
                int success = 0;
                foreach (KeyValuePair<string, string> itr in srcPath)
                {
                    double progress = (double)success / total;
                    progressBar1.Value = (int)(progress*100);
                    barText1.Text = "进度：" + string.Format("{0:N2}", progress);
                    
                    Image imgGif = Image.FromFile(itr.Key, true);
                    var ImgFrmDim = new FrameDimension(imgGif.FrameDimensionsList[0]);
                    int count = imgGif.GetFrameCount(ImgFrmDim);
                    int index = sPathOut.LastIndexOf("\\");

                    // 先创建文件夹
                    string newPath = Path.Combine(sPathOut.Substring(0, index), itr.Value);
                    if (Directory.Exists(newPath) == false)
                    {
                        Directory.CreateDirectory(newPath);
                    }

                    string retPath;
                    if (Directory.Exists(newPath))
                    {
                        retPath = newPath + "\\" + itr.Value;
                    }
                    else
                    {
                        retPath = sPathOut;
                        retPath = mode == Mode.PNG ? retPath.Substring(0, retPath.Length - 4) : retPath.Substring(0, retPath.Length - 5);
                    }
                    for (int i = 0; i < count; i++)
                    {
                        imgGif.SelectActiveFrame(ImgFrmDim, i);
                        switch(mode)
                        {
                            case Mode.PNG:
                                imgGif.Save( retPath + string.Format(@"_{0}.png", i), ImageFormat.Png);
                                break;
                            case Mode.JPEG:
                                imgGif.Save( retPath + string.Format(@"_{0}.jpeg", i), ImageFormat.Jpeg);
                                break;
                            default:
                                break;
                        }
                    }
                    success += 1;
                }
                progressBar1.Value = 100;
                barText1.Text = "进度：100%";
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

        private void Gif_DragDrop(object sender, DragEventArgs e)
        {
            RefreshUI();
            Array data = (System.Array)e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < data.Length; i++)
            {
                string path = data.GetValue(i).ToString();
                if (path.Substring(path.Length - 4) != ".gif") continue;
                int index = path.LastIndexOf("\\") + 1;
                int index2 = path.LastIndexOf(".gif");
                string name = path.Substring(index, index2 - index);
                srcPath.Add(path, name);
                fileText.Text = fileText.Text + path + ";";
            }
        }

        private void Gif_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
