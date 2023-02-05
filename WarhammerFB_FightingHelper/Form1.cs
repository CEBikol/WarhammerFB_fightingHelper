
namespace WarhammerFB_FightingHelper
{
    public partial class Form1 : Form
    {

        public bool ebf, bleeding, blinded, panic, stunned, rooted, tired, poisoned, knocked, deafened, cog;
        public string name, path;
        public float BBz, DBz, initz;
        public Form1()
        {
            InitializeComponent();
            path = Properties.Settings.Default.Pathsave;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }
            Properties.Settings.Default.Pathsave = path;
            Properties.Settings.Default.Save();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}