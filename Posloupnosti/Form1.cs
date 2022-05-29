namespace Posloupnosti
{
    public partial class Form1 : Form
    {
        private ProblemTest problemTest;
        private FileManager fileManager;
        public Form1()
        {
            InitializeComponent();
            fileManager = new FileManager();
            problemTest = new ProblemTest();
            setColumnsData();
            textBoxNotes.Text = fileManager.Load("posloupnost_poznamky.txt");
            textBoxSkip.Text = fileManager.Load("posloupnost_preskocit.txt");
        }

        private void handleBtnCheckOnClick(object sender, EventArgs e)
        {
            Range? range = null;
            if(checkBoxRange.Checked)
            {
                range = new Range((int)numericUpDownRangeFrom.Value, (int)numericUpDownRangeTo.Value);
            }
            problemTest.check(range, textBoxInput.Text, textBoxSkip.Text, dataGridViewProblems);
        }

        private void setColumnsData()
        {
            dataGridViewProblems.DataSource = problemTest.Problems;
            dataGridViewProblems.Columns[0].HeaderText = "Èíslo";
            dataGridViewProblems.Columns[1].HeaderText = "Problém";
            dataGridViewProblems.Columns[0].Width = 70;
            dataGridViewProblems.Columns[1].Width = 90;
        }

        private void handleBtnClearOnClick(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            problemTest.Problems.Clear();
        }

        private void handleCheckBoxRangeOnChecked(object sender, EventArgs e)
        {
            if(checkBoxRange.Checked)
            {
                numericUpDownRangeFrom.Enabled = true;
                numericUpDownRangeTo.Enabled = true;
                labelRangeDash.Enabled = true;
            } 
            else
            {
                numericUpDownRangeFrom.Enabled = false;
                numericUpDownRangeTo.Enabled = false;
                labelRangeDash.Enabled = false;
            }
        }

        private void handleBtnSaveOnClick(object sender, EventArgs e)
        {
            fileManager.Save("posloupnost_poznamky.txt", textBoxNotes.Text);
            fileManager.Save("posloupnost_preskocit.txt", textBoxSkip.Text);
        }
    }
}