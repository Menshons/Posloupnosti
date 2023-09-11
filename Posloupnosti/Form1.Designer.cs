namespace Posloupnosti
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            textBoxInput = new TextBox();
            panel1 = new Panel();
            labelRangeDash = new Label();
            numericUpDownRangeTo = new NumericUpDown();
            numericUpDownRangeFrom = new NumericUpDown();
            checkBoxRange = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            textBoxSkip = new TextBox();
            textBoxNotes = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCheck = new Button();
            btnClear = new Button();
            btnSave = new Button();
            splitter1 = new Splitter();
            dataGridViewProblems = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRangeTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRangeFrom).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProblems).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.Panel1.Controls.Add(splitter1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewProblems);
            splitContainer1.Size = new Size(660, 621);
            splitContainer1.SplitterDistance = 448;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer2.Location = new Point(4, 0);
            splitContainer2.Margin = new Padding(4);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Size = new Size(444, 621);
            splitContainer2.SplitterDistance = 556;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel1;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(4);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(label3);
            splitContainer3.Panel2.Controls.Add(label2);
            splitContainer3.Panel2.Controls.Add(textBoxSkip);
            splitContainer3.Panel2.Controls.Add(textBoxNotes);
            splitContainer3.Size = new Size(444, 556);
            splitContainer3.SplitterDistance = 140;
            splitContainer3.SplitterWidth = 5;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.IsSplitterFixed = true;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Margin = new Padding(4);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(textBoxInput);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(panel1);
            splitContainer4.Size = new Size(444, 140);
            splitContainer4.SplitterDistance = 107;
            splitContainer4.SplitterWidth = 5;
            splitContainer4.TabIndex = 0;
            // 
            // textBoxInput
            // 
            textBoxInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxInput.Location = new Point(4, 4);
            textBoxInput.Margin = new Padding(4);
            textBoxInput.MaxLength = 131068;
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(429, 99);
            textBoxInput.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelRangeDash);
            panel1.Controls.Add(numericUpDownRangeTo);
            panel1.Controls.Add(numericUpDownRangeFrom);
            panel1.Controls.Add(checkBoxRange);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 28);
            panel1.TabIndex = 0;
            // 
            // labelRangeDash
            // 
            labelRangeDash.AutoSize = true;
            labelRangeDash.Enabled = false;
            labelRangeDash.Location = new Point(273, 3);
            labelRangeDash.Margin = new Padding(4, 0, 4, 0);
            labelRangeDash.Name = "labelRangeDash";
            labelRangeDash.Size = new Size(15, 20);
            labelRangeDash.TabIndex = 3;
            labelRangeDash.Text = "-";
            // 
            // numericUpDownRangeTo
            // 
            numericUpDownRangeTo.Enabled = false;
            numericUpDownRangeTo.Location = new Point(296, 1);
            numericUpDownRangeTo.Margin = new Padding(4);
            numericUpDownRangeTo.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownRangeTo.Name = "numericUpDownRangeTo";
            numericUpDownRangeTo.Size = new Size(109, 27);
            numericUpDownRangeTo.TabIndex = 2;
            // 
            // numericUpDownRangeFrom
            // 
            numericUpDownRangeFrom.Enabled = false;
            numericUpDownRangeFrom.Location = new Point(160, 1);
            numericUpDownRangeFrom.Margin = new Padding(4);
            numericUpDownRangeFrom.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownRangeFrom.Name = "numericUpDownRangeFrom";
            numericUpDownRangeFrom.Size = new Size(109, 27);
            numericUpDownRangeFrom.TabIndex = 1;
            // 
            // checkBoxRange
            // 
            checkBoxRange.AutoSize = true;
            checkBoxRange.Location = new Point(11, 2);
            checkBoxRange.Margin = new Padding(4);
            checkBoxRange.Name = "checkBoxRange";
            checkBoxRange.Size = new Size(142, 24);
            checkBoxRange.TabIndex = 0;
            checkBoxRange.Text = "Nastavit rozmezí";
            checkBoxRange.UseVisualStyleBackColor = true;
            checkBoxRange.CheckedChanged += handleCheckBoxRangeOnChecked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 8);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Vynechat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 134);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Poznámky";
            // 
            // textBoxSkip
            // 
            textBoxSkip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSkip.Location = new Point(11, 32);
            textBoxSkip.Margin = new Padding(4);
            textBoxSkip.Multiline = true;
            textBoxSkip.Name = "textBoxSkip";
            textBoxSkip.Size = new Size(428, 93);
            textBoxSkip.TabIndex = 1;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNotes.Location = new Point(11, 158);
            textBoxNotes.Margin = new Padding(4);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(428, 235);
            textBoxNotes.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCheck);
            flowLayoutPanel1.Controls.Add(btnClear);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(444, 60);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(4, 4);
            btnCheck.Margin = new Padding(4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 29);
            btnCheck.TabIndex = 0;
            btnCheck.Text = "Zkontroluj";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += handleBtnCheckOnClick;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(106, 4);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Vymaž";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += handleBtnClearOnClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(208, 4);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += handleBtnSaveOnClick;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(4);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 621);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // dataGridViewProblems
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewProblems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProblems.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewProblems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewProblems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProblems.Dock = DockStyle.Fill;
            dataGridViewProblems.GridColor = Color.WhiteSmoke;
            dataGridViewProblems.Location = new Point(0, 0);
            dataGridViewProblems.Margin = new Padding(25);
            dataGridViewProblems.Name = "dataGridViewProblems";
            dataGridViewProblems.RowHeadersVisible = false;
            dataGridViewProblems.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewProblems.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewProblems.RowTemplate.Height = 25;
            dataGridViewProblems.ShowCellErrors = false;
            dataGridViewProblems.ShowCellToolTips = false;
            dataGridViewProblems.ShowEditingIcon = false;
            dataGridViewProblems.ShowRowErrors = false;
            dataGridViewProblems.Size = new Size(207, 621);
            dataGridViewProblems.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(684, 645);
            Controls.Add(splitContainer1);
            Margin = new Padding(4);
            MinimumSize = new Size(699, 682);
            Name = "Form1";
            Padding = new Padding(12);
            Text = "Test posloupnosti";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRangeTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRangeFrom).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProblems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Splitter splitter1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCheck;
        private DataGridView dataGridViewProblems;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private TextBox textBoxInput;
        private Panel panel1;
        private NumericUpDown numericUpDownRangeTo;
        private NumericUpDown numericUpDownRangeFrom;
        private CheckBox checkBoxRange;
        private Label labelRangeDash;
        private TextBox textBoxNotes;
        private Button btnClear;
        private Label label2;
        private TextBox textBoxSkip;
        private Label label3;
        private Button btnSave;
    }
}