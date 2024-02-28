using System.Linq.Expressions;

namespace WWHCS {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public SetColor colorSetter = new SetColor();

        private void button1_Click(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                try {
                    colorSetter.SetCustomValues(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            } else {
                colorSetter.SetHeaderColors(comboBox1.SelectedIndex);
            }
        }
    }
}