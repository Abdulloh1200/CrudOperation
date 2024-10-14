namespace CrudOperation
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
            tabControl1 = new TabControl();
            Read = new TabPage();
            dataGridViewReadAll = new DataGridView();
            TCCreate = new TabPage();
            tabControl2 = new TabControl();
            tabPage2 = new TabPage();
            BTCreate = new Button();
            CBCreatePerson = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            TBCreatePerson = new TextBox();
            dataGridViewCreateStud = new DataGridView();
            tabPage3 = new TabPage();
            BTCreateSub = new Button();
            label3 = new Label();
            TBCreateSub = new TextBox();
            dataGridViewCreateSub = new DataGridView();
            TCUpdate = new TabPage();
            tabControl3 = new TabControl();
            PersonTc = new TabPage();
            label6 = new Label();
            CBUpdateSelect = new ComboBox();
            BTUpdatePerson = new Button();
            TBUpdatePerson = new TextBox();
            CBUpdatePerson = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            dataGridViewUpdatePerson = new DataGridView();
            TCStud = new TabPage();
            TBUpdateSub = new Button();
            label8 = new Label();
            label7 = new Label();
            CBUpdateSub = new ComboBox();
            TBUpdateSubject = new TextBox();
            dataGridViewUpdateSub = new DataGridView();
            TCDelte = new TabPage();
            tabControl4 = new TabControl();
            tabPage1 = new TabPage();
            BTDeletePerson = new Button();
            CBDeletePerson = new ComboBox();
            label9 = new Label();
            dataGridViewDeletePerson = new DataGridView();
            tabPage4 = new TabPage();
            BTDeleteSub = new Button();
            CBDeleteSubject = new ComboBox();
            label10 = new Label();
            dataGridViewDeleteSub = new DataGridView();
            tabControl1.SuspendLayout();
            Read.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAll).BeginInit();
            TCCreate.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCreateStud).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCreateSub).BeginInit();
            TCUpdate.SuspendLayout();
            tabControl3.SuspendLayout();
            PersonTc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdatePerson).BeginInit();
            TCStud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdateSub).BeginInit();
            TCDelte.SuspendLayout();
            tabControl4.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeletePerson).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeleteSub).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Read);
            tabControl1.Controls.Add(TCCreate);
            tabControl1.Controls.Add(TCUpdate);
            tabControl1.Controls.Add(TCDelte);
            tabControl1.Location = new Point(6, 4);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(957, 673);
            tabControl1.TabIndex = 0;
            // 
            // Read
            // 
            Read.Controls.Add(dataGridViewReadAll);
            Read.Location = new Point(4, 29);
            Read.Margin = new Padding(3, 4, 3, 4);
            Read.Name = "Read";
            Read.Padding = new Padding(3, 4, 3, 4);
            Read.Size = new Size(949, 640);
            Read.TabIndex = 0;
            Read.Text = "Read";
            Read.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReadAll
            // 
            dataGridViewReadAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadAll.Location = new Point(0, 0);
            dataGridViewReadAll.Margin = new Padding(3, 4, 3, 4);
            dataGridViewReadAll.Name = "dataGridViewReadAll";
            dataGridViewReadAll.RowHeadersWidth = 51;
            dataGridViewReadAll.Size = new Size(947, 636);
            dataGridViewReadAll.TabIndex = 0;
            // 
            // TCCreate
            // 
            TCCreate.Controls.Add(tabControl2);
            TCCreate.Location = new Point(4, 29);
            TCCreate.Margin = new Padding(3, 4, 3, 4);
            TCCreate.Name = "TCCreate";
            TCCreate.Size = new Size(949, 640);
            TCCreate.TabIndex = 1;
            TCCreate.Text = "Create";
            TCCreate.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Location = new Point(3, 4);
            tabControl2.Margin = new Padding(3, 4, 3, 4);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(944, 632);
            tabControl2.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BTCreate);
            tabPage2.Controls.Add(CBCreatePerson);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(TBCreatePerson);
            tabPage2.Controls.Add(dataGridViewCreateStud);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(936, 599);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Person";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTCreate
            // 
            BTCreate.Location = new Point(666, 393);
            BTCreate.Margin = new Padding(3, 4, 3, 4);
            BTCreate.Name = "BTCreate";
            BTCreate.Size = new Size(86, 31);
            BTCreate.TabIndex = 4;
            BTCreate.Text = "Create";
            BTCreate.UseVisualStyleBackColor = true;
            BTCreate.Click += BTCreate_Click;
            // 
            // CBCreatePerson
            // 
            CBCreatePerson.FormattingEnabled = true;
            CBCreatePerson.Location = new Point(607, 296);
            CBCreatePerson.Margin = new Padding(3, 4, 3, 4);
            CBCreatePerson.Name = "CBCreatePerson";
            CBCreatePerson.Size = new Size(205, 28);
            CBCreatePerson.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(679, 247);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Subject";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(679, 127);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // TBCreatePerson
            // 
            TBCreatePerson.Location = new Point(607, 173);
            TBCreatePerson.Margin = new Padding(3, 4, 3, 4);
            TBCreatePerson.Name = "TBCreatePerson";
            TBCreatePerson.Size = new Size(205, 27);
            TBCreatePerson.TabIndex = 1;
            // 
            // dataGridViewCreateStud
            // 
            dataGridViewCreateStud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCreateStud.Location = new Point(-5, 0);
            dataGridViewCreateStud.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCreateStud.Name = "dataGridViewCreateStud";
            dataGridViewCreateStud.RowHeadersWidth = 51;
            dataGridViewCreateStud.Size = new Size(462, 596);
            dataGridViewCreateStud.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(BTCreateSub);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(TBCreateSub);
            tabPage3.Controls.Add(dataGridViewCreateSub);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(936, 599);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Subject";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BTCreateSub
            // 
            BTCreateSub.Location = new Point(648, 325);
            BTCreateSub.Margin = new Padding(3, 4, 3, 4);
            BTCreateSub.Name = "BTCreateSub";
            BTCreateSub.Size = new Size(86, 31);
            BTCreateSub.TabIndex = 3;
            BTCreateSub.Text = "Create";
            BTCreateSub.UseVisualStyleBackColor = true;
            BTCreateSub.Click += BTCreateSub_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(643, 157);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Subject name";
            // 
            // TBCreateSub
            // 
            TBCreateSub.Location = new Point(616, 227);
            TBCreateSub.Margin = new Padding(3, 4, 3, 4);
            TBCreateSub.Name = "TBCreateSub";
            TBCreateSub.Size = new Size(153, 27);
            TBCreateSub.TabIndex = 1;
            // 
            // dataGridViewCreateSub
            // 
            dataGridViewCreateSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCreateSub.Location = new Point(0, 4);
            dataGridViewCreateSub.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCreateSub.Name = "dataGridViewCreateSub";
            dataGridViewCreateSub.RowHeadersWidth = 51;
            dataGridViewCreateSub.Size = new Size(449, 587);
            dataGridViewCreateSub.TabIndex = 0;
            // 
            // TCUpdate
            // 
            TCUpdate.Controls.Add(tabControl3);
            TCUpdate.Location = new Point(4, 29);
            TCUpdate.Margin = new Padding(3, 4, 3, 4);
            TCUpdate.Name = "TCUpdate";
            TCUpdate.Size = new Size(949, 640);
            TCUpdate.TabIndex = 2;
            TCUpdate.Text = "Update";
            TCUpdate.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(PersonTc);
            tabControl3.Controls.Add(TCStud);
            tabControl3.Location = new Point(0, 4);
            tabControl3.Margin = new Padding(3, 4, 3, 4);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(952, 637);
            tabControl3.TabIndex = 0;
            // 
            // PersonTc
            // 
            PersonTc.Controls.Add(label6);
            PersonTc.Controls.Add(CBUpdateSelect);
            PersonTc.Controls.Add(BTUpdatePerson);
            PersonTc.Controls.Add(TBUpdatePerson);
            PersonTc.Controls.Add(CBUpdatePerson);
            PersonTc.Controls.Add(label5);
            PersonTc.Controls.Add(label4);
            PersonTc.Controls.Add(dataGridViewUpdatePerson);
            PersonTc.Location = new Point(4, 29);
            PersonTc.Margin = new Padding(3, 4, 3, 4);
            PersonTc.Name = "PersonTc";
            PersonTc.Padding = new Padding(3, 4, 3, 4);
            PersonTc.Size = new Size(944, 604);
            PersonTc.TabIndex = 0;
            PersonTc.Text = "Person";
            PersonTc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(672, 60);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 6;
            label6.Text = "Person Id";
            // 
            // CBUpdateSelect
            // 
            CBUpdateSelect.FormattingEnabled = true;
            CBUpdateSelect.Location = new Point(610, 109);
            CBUpdateSelect.Margin = new Padding(3, 4, 3, 4);
            CBUpdateSelect.Name = "CBUpdateSelect";
            CBUpdateSelect.Size = new Size(183, 28);
            CBUpdateSelect.TabIndex = 5;
            // 
            // BTUpdatePerson
            // 
            BTUpdatePerson.Location = new Point(661, 400);
            BTUpdatePerson.Margin = new Padding(3, 4, 3, 4);
            BTUpdatePerson.Name = "BTUpdatePerson";
            BTUpdatePerson.Size = new Size(86, 31);
            BTUpdatePerson.TabIndex = 4;
            BTUpdatePerson.Text = "Update";
            BTUpdatePerson.UseVisualStyleBackColor = true;
            BTUpdatePerson.Click += BTUpdatePerson_Click;
            // 
            // TBUpdatePerson
            // 
            TBUpdatePerson.Location = new Point(610, 211);
            TBUpdatePerson.Margin = new Padding(3, 4, 3, 4);
            TBUpdatePerson.Name = "TBUpdatePerson";
            TBUpdatePerson.Size = new Size(183, 27);
            TBUpdatePerson.TabIndex = 3;
            // 
            // CBUpdatePerson
            // 
            CBUpdatePerson.FormattingEnabled = true;
            CBUpdatePerson.Location = new Point(610, 297);
            CBUpdatePerson.Margin = new Padding(3, 4, 3, 4);
            CBUpdatePerson.Name = "CBUpdatePerson";
            CBUpdatePerson.Size = new Size(183, 28);
            CBUpdatePerson.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(672, 257);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 1;
            label5.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(672, 172);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 1;
            label4.Text = "Name";
            // 
            // dataGridViewUpdatePerson
            // 
            dataGridViewUpdatePerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUpdatePerson.Location = new Point(0, 0);
            dataGridViewUpdatePerson.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUpdatePerson.Name = "dataGridViewUpdatePerson";
            dataGridViewUpdatePerson.RowHeadersWidth = 51;
            dataGridViewUpdatePerson.Size = new Size(455, 600);
            dataGridViewUpdatePerson.TabIndex = 0;
            // 
            // TCStud
            // 
            TCStud.Controls.Add(TBUpdateSub);
            TCStud.Controls.Add(label8);
            TCStud.Controls.Add(label7);
            TCStud.Controls.Add(CBUpdateSub);
            TCStud.Controls.Add(TBUpdateSubject);
            TCStud.Controls.Add(dataGridViewUpdateSub);
            TCStud.Location = new Point(4, 29);
            TCStud.Margin = new Padding(3, 4, 3, 4);
            TCStud.Name = "TCStud";
            TCStud.Padding = new Padding(3, 4, 3, 4);
            TCStud.Size = new Size(944, 604);
            TCStud.TabIndex = 1;
            TCStud.Text = "Subject";
            TCStud.UseVisualStyleBackColor = true;
            // 
            // TBUpdateSub
            // 
            TBUpdateSub.Location = new Point(661, 337);
            TBUpdateSub.Margin = new Padding(3, 4, 3, 4);
            TBUpdateSub.Name = "TBUpdateSub";
            TBUpdateSub.Size = new Size(86, 31);
            TBUpdateSub.TabIndex = 4;
            TBUpdateSub.Text = "Update";
            TBUpdateSub.UseVisualStyleBackColor = true;
            TBUpdateSub.Click += TBUpdateSub_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(532, 153);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 3;
            label8.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(532, 242);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 3;
            label7.Text = "Choose";
            // 
            // CBUpdateSub
            // 
            CBUpdateSub.FormattingEnabled = true;
            CBUpdateSub.Location = new Point(617, 239);
            CBUpdateSub.Margin = new Padding(3, 4, 3, 4);
            CBUpdateSub.Name = "CBUpdateSub";
            CBUpdateSub.Size = new Size(180, 28);
            CBUpdateSub.TabIndex = 2;
            // 
            // TBUpdateSubject
            // 
            TBUpdateSubject.Location = new Point(617, 150);
            TBUpdateSubject.Margin = new Padding(3, 4, 3, 4);
            TBUpdateSubject.Name = "TBUpdateSubject";
            TBUpdateSubject.Size = new Size(180, 27);
            TBUpdateSubject.TabIndex = 1;
            // 
            // dataGridViewUpdateSub
            // 
            dataGridViewUpdateSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUpdateSub.Location = new Point(0, 4);
            dataGridViewUpdateSub.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUpdateSub.Name = "dataGridViewUpdateSub";
            dataGridViewUpdateSub.RowHeadersWidth = 51;
            dataGridViewUpdateSub.Size = new Size(410, 596);
            dataGridViewUpdateSub.TabIndex = 0;
            // 
            // TCDelte
            // 
            TCDelte.Controls.Add(tabControl4);
            TCDelte.Location = new Point(4, 29);
            TCDelte.Name = "TCDelte";
            TCDelte.Size = new Size(949, 640);
            TCDelte.TabIndex = 3;
            TCDelte.Text = "Delete";
            TCDelte.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            tabControl4.Controls.Add(tabPage1);
            tabControl4.Controls.Add(tabPage4);
            tabControl4.Location = new Point(0, 3);
            tabControl4.Name = "tabControl4";
            tabControl4.SelectedIndex = 0;
            tabControl4.Size = new Size(953, 641);
            tabControl4.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BTDeletePerson);
            tabPage1.Controls.Add(CBDeletePerson);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(dataGridViewDeletePerson);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(945, 608);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Person";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTDeletePerson
            // 
            BTDeletePerson.Location = new Point(627, 247);
            BTDeletePerson.Name = "BTDeletePerson";
            BTDeletePerson.Size = new Size(94, 29);
            BTDeletePerson.TabIndex = 3;
            BTDeletePerson.Text = "Delete";
            BTDeletePerson.UseVisualStyleBackColor = true;
            BTDeletePerson.Click += BTDeletePerson_Click;
            // 
            // CBDeletePerson
            // 
            CBDeletePerson.FormattingEnabled = true;
            CBDeletePerson.Location = new Point(567, 151);
            CBDeletePerson.Name = "CBDeletePerson";
            CBDeletePerson.Size = new Size(198, 28);
            CBDeletePerson.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(458, 154);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 1;
            label9.Text = "Choose";
            // 
            // dataGridViewDeletePerson
            // 
            dataGridViewDeletePerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeletePerson.Location = new Point(0, 0);
            dataGridViewDeletePerson.Name = "dataGridViewDeletePerson";
            dataGridViewDeletePerson.RowHeadersWidth = 51;
            dataGridViewDeletePerson.Size = new Size(407, 490);
            dataGridViewDeletePerson.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(BTDeleteSub);
            tabPage4.Controls.Add(CBDeleteSubject);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(dataGridViewDeleteSub);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(945, 608);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Subject";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // BTDeleteSub
            // 
            BTDeleteSub.Location = new Point(679, 289);
            BTDeleteSub.Name = "BTDeleteSub";
            BTDeleteSub.Size = new Size(94, 29);
            BTDeleteSub.TabIndex = 3;
            BTDeleteSub.Text = "Delete";
            BTDeleteSub.UseVisualStyleBackColor = true;
            BTDeleteSub.Click += BTDeleteSub_Click;
            // 
            // CBDeleteSubject
            // 
            CBDeleteSubject.FormattingEnabled = true;
            CBDeleteSubject.Location = new Point(620, 187);
            CBDeleteSubject.Name = "CBDeleteSubject";
            CBDeleteSubject.Size = new Size(200, 28);
            CBDeleteSubject.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(506, 190);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 1;
            label10.Text = "Subject";
            // 
            // dataGridViewDeleteSub
            // 
            dataGridViewDeleteSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeleteSub.Location = new Point(0, 0);
            dataGridViewDeleteSub.Name = "dataGridViewDeleteSub";
            dataGridViewDeleteSub.RowHeadersWidth = 51;
            dataGridViewDeleteSub.Size = new Size(394, 608);
            dataGridViewDeleteSub.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 675);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            Read.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadAll).EndInit();
            TCCreate.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCreateStud).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCreateSub).EndInit();
            TCUpdate.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            PersonTc.ResumeLayout(false);
            PersonTc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdatePerson).EndInit();
            TCStud.ResumeLayout(false);
            TCStud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdateSub).EndInit();
            TCDelte.ResumeLayout(false);
            tabControl4.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeletePerson).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeleteSub).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Read;
        private TabPage Create;
        private DataGridView dataGridViewReadAll;
        private TabPage TCCreate;
        private TabControl tabControl2;
        private TabPage tabPage2;
        private Button BTCreate;
        private ComboBox CBCreatePerson;
        private Label label2;
        private Label label1;
        private TextBox TBCreatePerson;
        private DataGridView dataGridViewCreateStud;
        private TabPage tabPage3;
        private Button BTCreateSub;
        private Label label3;
        private TextBox TBCreateSub;
        private DataGridView dataGridViewCreateSub;
        private TabPage TCUpdate;
        private TabControl tabControl3;
        private TabPage PersonTc;
        private TabPage TCStud;
        private DataGridView dataGridViewUpdatePerson;
        private Button BTUpdatePerson;
        private TextBox TBUpdatePerson;
        private ComboBox CBUpdatePerson;
        private Label label5;
        private Label label4;
        private Label label6;
        private ComboBox CBUpdateSelect;
        private Button TBUpdateSub;
        private Label label8;
        private Label label7;
        private ComboBox CBUpdateSub;
        private TextBox TBUpdateSubject;
        private DataGridView dataGridViewUpdateSub;
        private TabPage TCDelte;
        private TabControl tabControl4;
        private TabPage tabPage1;
        private TabPage tabPage4;
        private Button BTDeletePerson;
        private ComboBox CBDeletePerson;
        private Label label9;
        private DataGridView dataGridViewDeletePerson;
        private Button BTDeleteSub;
        private ComboBox CBDeleteSubject;
        private Label label10;
        private DataGridView dataGridViewDeleteSub;
    }
}
