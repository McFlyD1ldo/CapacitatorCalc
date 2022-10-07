namespace wfCapacitator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            libValueService.ValueService vs = new();
            comboBox1.DataSource = vs.PostFactors.Select(x => x.TextShort += "F").ToList();
            comboBox2.DataSource = vs.PostFactors.Select(x => x.TextShort.Replace('F', 's')).ToList();
            comboBox3.DataSource = vs.PostFactors.Select(x => x.TextShort.Replace('F', 's')).ToList();
            comboBox4.DataSource = vs.PostFactors.Select(x => x.TextShort.Replace('F', 'A')).ToList();
            comboBox5.DataSource = vs.PostFactors.Select(x => x.TextShort.Replace('F', 'Ω')).ToList();
            comboBox6.DataSource = vs.PostFactors.Select(x => x.TextShort.Replace('F', 'V')).ToList();
        }

        private void clbToDo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //allow user to only check one item at a time
            for (int i = 0; i < clbToDo.Items.Count; ++i) if (i != e.Index) clbToDo.SetItemChecked(i, false);
            if(e.Index == 0)
            {
                textBox2.Enabled = true;
                textBox5.Enabled = true;
            }
        }

        
    }
}