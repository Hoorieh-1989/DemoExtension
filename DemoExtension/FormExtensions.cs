using DemoExtensions.NewFolder;

namespace DemoExtension
{
    public partial class FormExtensions : Form
    {
        public FormExtensions()
        {
            InitializeComponent();

            string s = "";
            int count = s.WordCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text= textBox1.Text;
            int count = text.WordCount();


            List<string> words = text.GetWordArray();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)


        {

        }
    }
}
