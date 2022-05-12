using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Fedorets_Popov_tomogram_vizuliazer
{
    public partial class Form1 : Form
    {
        bool loaded = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string str = openFileDialog.FileName;
                var bin = new Bin();
                bin.readBIN(str);
                View.SetupView(glControl1.Widht, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
            }
        }
    }
}