namespace Салон
{
    partial class Клиент
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label_ФИО;
            System.Windows.Forms.Label label_тел_filter;
            System.Windows.Forms.Label label_ФИО_filter;
            System.Windows.Forms.Label label_тел_add;
            System.Windows.Forms.Label label_ФИО_add;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Клиент));
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_filter = new System.Windows.Forms.Button();
            this.comboBox_тел_filter = new System.Windows.Forms.ComboBox();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.салон_красотыDataSet = new Салон.Салон_красотыDataSet();
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.comboBox_ФИО_filter = new System.Windows.Forms.ComboBox();
            this.button_back = new System.Windows.Forms.Button();
            this.comboBox_ФИО = new System.Windows.Forms.ComboBox();
            this.textBox_newтел = new System.Windows.Forms.TextBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.textBox_newФИО = new System.Windows.Forms.TextBox();
            this.groupBox_edit = new System.Windows.Forms.GroupBox();
            this.radioButton_ФИО = new System.Windows.Forms.RadioButton();
            this.radioButton_тел = new System.Windows.Forms.RadioButton();
            this.label_edit = new System.Windows.Forms.Label();
            this.groupBox_adit_del = new System.Windows.Forms.GroupBox();
            this.groupBox_del = new System.Windows.Forms.GroupBox();
            this.label_del = new System.Windows.Forms.Label();
            this.button_del = new System.Windows.Forms.Button();
            this.textBox_тел_add = new System.Windows.Forms.TextBox();
            this.label_ADD = new System.Windows.Forms.Label();
            this.textBox_ФИО_add = new System.Windows.Forms.TextBox();
            this.groupBox_add = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клинетdataGridView = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процедурDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.КлиентTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label_ФИО = new System.Windows.Forms.Label();
            label_тел_filter = new System.Windows.Forms.Label();
            label_ФИО_filter = new System.Windows.Forms.Label();
            label_тел_add = new System.Windows.Forms.Label();
            label_ФИО_add = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).BeginInit();
            this.groupBox_filter.SuspendLayout();
            this.groupBox_edit.SuspendLayout();
            this.groupBox_adit_del.SuspendLayout();
            this.groupBox_del.SuspendLayout();
            this.groupBox_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клинетdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ФИО
            // 
            label_ФИО.AutoSize = true;
            label_ФИО.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_ФИО.Location = new System.Drawing.Point(16, 22);
            label_ФИО.Name = "label_ФИО";
            label_ФИО.Size = new System.Drawing.Size(57, 20);
            label_ФИО.TabIndex = 98;
            label_ФИО.Text = "*ФИО:";
            // 
            // label_тел_filter
            // 
            label_тел_filter.AutoSize = true;
            label_тел_filter.Location = new System.Drawing.Point(17, 82);
            label_тел_filter.Name = "label_тел_filter";
            label_тел_filter.Size = new System.Drawing.Size(146, 20);
            label_тел_filter.TabIndex = 97;
            label_тел_filter.Text = "Номер телефона:";
            // 
            // label_ФИО_filter
            // 
            label_ФИО_filter.AutoSize = true;
            label_ФИО_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_ФИО_filter.Location = new System.Drawing.Point(17, 26);
            label_ФИО_filter.Name = "label_ФИО_filter";
            label_ФИО_filter.Size = new System.Drawing.Size(51, 20);
            label_ФИО_filter.TabIndex = 84;
            label_ФИО_filter.Text = "ФИО:";
            // 
            // label_тел_add
            // 
            label_тел_add.AutoSize = true;
            label_тел_add.Location = new System.Drawing.Point(17, 76);
            label_тел_add.Name = "label_тел_add";
            label_тел_add.Size = new System.Drawing.Size(146, 20);
            label_тел_add.TabIndex = 95;
            label_тел_add.Text = "Номер телефона:";
            // 
            // label_ФИО_add
            // 
            label_ФИО_add.AutoSize = true;
            label_ФИО_add.Location = new System.Drawing.Point(16, 23);
            label_ФИО_add.Name = "label_ФИО_add";
            label_ФИО_add.Size = new System.Drawing.Size(51, 20);
            label_ФИО_add.TabIndex = 94;
            label_ФИО_add.Text = "ФИО:";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер телефона";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_filter.ForeColor = System.Drawing.Color.Black;
            this.button_filter.Location = new System.Drawing.Point(16, 139);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(317, 33);
            this.button_filter.TabIndex = 89;
            this.button_filter.Text = "Фильтровать";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // comboBox_тел_filter
            // 
            this.comboBox_тел_filter.DataSource = this.клиентBindingSource;
            this.comboBox_тел_filter.DisplayMember = "Номер телефона";
            this.comboBox_тел_filter.FormattingEnabled = true;
            this.comboBox_тел_filter.Location = new System.Drawing.Point(15, 105);
            this.comboBox_тел_filter.Name = "comboBox_тел_filter";
            this.comboBox_тел_filter.Size = new System.Drawing.Size(322, 28);
            this.comboBox_тел_filter.TabIndex = 101;
            this.comboBox_тел_filter.ValueMember = "ID";
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.салон_красотыDataSet;
            // 
            // салон_красотыDataSet
            // 
            this.салон_красотыDataSet.DataSetName = "Салон_красотыDataSet";
            this.салон_красотыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.Controls.Add(label_тел_filter);
            this.groupBox_filter.Controls.Add(this.comboBox_тел_filter);
            this.groupBox_filter.Controls.Add(this.buttonShowAll);
            this.groupBox_filter.Controls.Add(this.button_filter);
            this.groupBox_filter.Controls.Add(this.comboBox_ФИО_filter);
            this.groupBox_filter.Controls.Add(label_ФИО_filter);
            this.groupBox_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_filter.Location = new System.Drawing.Point(720, 55);
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.Size = new System.Drawing.Size(352, 218);
            this.groupBox_filter.TabIndex = 117;
            this.groupBox_filter.TabStop = false;
            this.groupBox_filter.Text = "Фильтрация:";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAll.ForeColor = System.Drawing.Color.Black;
            this.buttonShowAll.Location = new System.Drawing.Point(16, 178);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(317, 33);
            this.buttonShowAll.TabIndex = 100;
            this.buttonShowAll.Text = "Показать всё";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // comboBox_ФИО_filter
            // 
            this.comboBox_ФИО_filter.DataSource = this.клиентBindingSource;
            this.comboBox_ФИО_filter.DisplayMember = "ФИО";
            this.comboBox_ФИО_filter.FormattingEnabled = true;
            this.comboBox_ФИО_filter.Location = new System.Drawing.Point(15, 49);
            this.comboBox_ФИО_filter.Name = "comboBox_ФИО_filter";
            this.comboBox_ФИО_filter.Size = new System.Drawing.Size(322, 28);
            this.comboBox_ФИО_filter.TabIndex = 85;
            this.comboBox_ФИО_filter.ValueMember = "ID";
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(926, 614);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(146, 40);
            this.button_back.TabIndex = 114;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // comboBox_ФИО
            // 
            this.comboBox_ФИО.DataSource = this.клиентBindingSource;
            this.comboBox_ФИО.DisplayMember = "ФИО";
            this.comboBox_ФИО.FormattingEnabled = true;
            this.comboBox_ФИО.Location = new System.Drawing.Point(14, 45);
            this.comboBox_ФИО.Name = "comboBox_ФИО";
            this.comboBox_ФИО.Size = new System.Drawing.Size(322, 28);
            this.comboBox_ФИО.TabIndex = 100;
            this.comboBox_ФИО.ValueMember = "ID";
            // 
            // textBox_newтел
            // 
            this.textBox_newтел.Location = new System.Drawing.Point(15, 53);
            this.textBox_newтел.Name = "textBox_newтел";
            this.textBox_newтел.Size = new System.Drawing.Size(319, 26);
            this.textBox_newтел.TabIndex = 98;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit.ForeColor = System.Drawing.Color.Black;
            this.button_edit.Location = new System.Drawing.Point(357, 102);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(157, 33);
            this.button_edit.TabIndex = 110;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_newФИО
            // 
            this.textBox_newФИО.Location = new System.Drawing.Point(15, 109);
            this.textBox_newФИО.Name = "textBox_newФИО";
            this.textBox_newФИО.Size = new System.Drawing.Size(322, 26);
            this.textBox_newФИО.TabIndex = 111;
            // 
            // groupBox_edit
            // 
            this.groupBox_edit.Controls.Add(this.radioButton_ФИО);
            this.groupBox_edit.Controls.Add(this.radioButton_тел);
            this.groupBox_edit.Controls.Add(this.label_edit);
            this.groupBox_edit.Controls.Add(this.textBox_newтел);
            this.groupBox_edit.Controls.Add(this.button_edit);
            this.groupBox_edit.Controls.Add(this.textBox_newФИО);
            this.groupBox_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_edit.Location = new System.Drawing.Point(366, 12);
            this.groupBox_edit.Name = "groupBox_edit";
            this.groupBox_edit.Size = new System.Drawing.Size(521, 143);
            this.groupBox_edit.TabIndex = 110;
            this.groupBox_edit.TabStop = false;
            this.groupBox_edit.Text = "Редактирование";
            // 
            // radioButton_ФИО
            // 
            this.radioButton_ФИО.AutoSize = true;
            this.radioButton_ФИО.Location = new System.Drawing.Point(18, 82);
            this.radioButton_ФИО.Name = "radioButton_ФИО";
            this.radioButton_ФИО.Size = new System.Drawing.Size(117, 24);
            this.radioButton_ФИО.TabIndex = 116;
            this.radioButton_ФИО.TabStop = true;
            this.radioButton_ФИО.Text = "Новое ФИО";
            this.radioButton_ФИО.UseVisualStyleBackColor = true;
            // 
            // radioButton_тел
            // 
            this.radioButton_тел.AutoSize = true;
            this.radioButton_тел.Location = new System.Drawing.Point(18, 28);
            this.radioButton_тел.Name = "radioButton_тел";
            this.radioButton_тел.Size = new System.Drawing.Size(224, 24);
            this.radioButton_тел.TabIndex = 115;
            this.radioButton_тел.TabStop = true;
            this.radioButton_тел.Text = "Новый нормер телефона:";
            this.radioButton_тел.UseVisualStyleBackColor = true;
            // 
            // label_edit
            // 
            this.label_edit.AutoSize = true;
            this.label_edit.Location = new System.Drawing.Point(148, 0);
            this.label_edit.Name = "label_edit";
            this.label_edit.Size = new System.Drawing.Size(0, 20);
            this.label_edit.TabIndex = 114;
            // 
            // groupBox_adit_del
            // 
            this.groupBox_adit_del.Controls.Add(this.groupBox_edit);
            this.groupBox_adit_del.Controls.Add(this.comboBox_ФИО);
            this.groupBox_adit_del.Controls.Add(label_ФИО);
            this.groupBox_adit_del.Controls.Add(this.groupBox_del);
            this.groupBox_adit_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_adit_del.Location = new System.Drawing.Point(12, 492);
            this.groupBox_adit_del.Name = "groupBox_adit_del";
            this.groupBox_adit_del.Size = new System.Drawing.Size(893, 162);
            this.groupBox_adit_del.TabIndex = 115;
            this.groupBox_adit_del.TabStop = false;
            this.groupBox_adit_del.Text = "Редактирование и удаление";
            // 
            // groupBox_del
            // 
            this.groupBox_del.Controls.Add(this.label_del);
            this.groupBox_del.Controls.Add(this.button_del);
            this.groupBox_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_del.Location = new System.Drawing.Point(14, 85);
            this.groupBox_del.Name = "groupBox_del";
            this.groupBox_del.Size = new System.Drawing.Size(340, 70);
            this.groupBox_del.TabIndex = 109;
            this.groupBox_del.TabStop = false;
            this.groupBox_del.Text = "Удаление";
            // 
            // label_del
            // 
            this.label_del.AutoSize = true;
            this.label_del.Location = new System.Drawing.Point(98, 0);
            this.label_del.Name = "label_del";
            this.label_del.Size = new System.Drawing.Size(0, 20);
            this.label_del.TabIndex = 97;
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_del.ForeColor = System.Drawing.Color.Black;
            this.button_del.Location = new System.Drawing.Point(6, 29);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(221, 33);
            this.button_del.TabIndex = 81;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // textBox_тел_add
            // 
            this.textBox_тел_add.Location = new System.Drawing.Point(17, 102);
            this.textBox_тел_add.Name = "textBox_тел_add";
            this.textBox_тел_add.Size = new System.Drawing.Size(319, 26);
            this.textBox_тел_add.TabIndex = 96;
            // 
            // label_ADD
            // 
            this.label_ADD.AutoSize = true;
            this.label_ADD.Location = new System.Drawing.Point(114, 0);
            this.label_ADD.Name = "label_ADD";
            this.label_ADD.Size = new System.Drawing.Size(0, 20);
            this.label_ADD.TabIndex = 82;
            // 
            // textBox_ФИО_add
            // 
            this.textBox_ФИО_add.Location = new System.Drawing.Point(17, 47);
            this.textBox_ФИО_add.Name = "textBox_ФИО_add";
            this.textBox_ФИО_add.Size = new System.Drawing.Size(318, 26);
            this.textBox_ФИО_add.TabIndex = 93;
            // 
            // groupBox_add
            // 
            this.groupBox_add.Controls.Add(this.textBox_тел_add);
            this.groupBox_add.Controls.Add(this.label_ADD);
            this.groupBox_add.Controls.Add(label_тел_add);
            this.groupBox_add.Controls.Add(label_ФИО_add);
            this.groupBox_add.Controls.Add(this.button_add);
            this.groupBox_add.Controls.Add(this.textBox_ФИО_add);
            this.groupBox_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_add.Location = new System.Drawing.Point(720, 312);
            this.groupBox_add.Name = "groupBox_add";
            this.groupBox_add.Size = new System.Drawing.Size(352, 174);
            this.groupBox_add.TabIndex = 116;
            this.groupBox_add.TabStop = false;
            this.groupBox_add.Text = "Добавление";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(18, 134);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(318, 33);
            this.button_add.TabIndex = 81;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1084, 53);
            this.Title.TabIndex = 112;
            this.Title.Text = "Клиент";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // клинетdataGridView
            // 
            this.клинетdataGridView.AllowUserToAddRows = false;
            this.клинетdataGridView.AllowUserToDeleteRows = false;
            this.клинетdataGridView.AutoGenerateColumns = false;
            this.клинетdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.клинетdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.клинетdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.клинетdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клинетdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.процедурDataGridViewTextBoxColumn});
            this.клинетdataGridView.DataSource = this.клиентBindingSource;
            this.клинетdataGridView.Location = new System.Drawing.Point(12, 55);
            this.клинетdataGridView.Name = "клинетdataGridView";
            this.клинетdataGridView.ReadOnly = true;
            this.клинетdataGridView.Size = new System.Drawing.Size(702, 431);
            this.клинетdataGridView.TabIndex = 118;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // процедурDataGridViewTextBoxColumn
            // 
            this.процедурDataGridViewTextBoxColumn.DataPropertyName = "Процедур";
            this.процедурDataGridViewTextBoxColumn.HeaderText = "Процедур";
            this.процедурDataGridViewTextBoxColumn.Name = "процедурDataGridViewTextBoxColumn";
            this.процедурDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1027, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Клиент
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1084, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.клинетdataGridView);
            this.Controls.Add(this.groupBox_filter);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.groupBox_adit_del);
            this.Controls.Add(this.groupBox_add);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Клиент";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Клиент_FormClosed);
            this.Load += new System.EventHandler(this.Клиент_Load);
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).EndInit();
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            this.groupBox_edit.ResumeLayout(false);
            this.groupBox_edit.PerformLayout();
            this.groupBox_adit_del.ResumeLayout(false);
            this.groupBox_adit_del.PerformLayout();
            this.groupBox_del.ResumeLayout(false);
            this.groupBox_del.PerformLayout();
            this.groupBox_add.ResumeLayout(false);
            this.groupBox_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клинетdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.ComboBox comboBox_тел_filter;
        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.ComboBox comboBox_ФИО_filter;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ComboBox comboBox_ФИО;
        private System.Windows.Forms.TextBox textBox_newтел;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textBox_newФИО;
        private System.Windows.Forms.GroupBox groupBox_edit;
        private System.Windows.Forms.GroupBox groupBox_adit_del;
        private System.Windows.Forms.GroupBox groupBox_del;
        private System.Windows.Forms.Label label_del;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.TextBox textBox_тел_add;
        private System.Windows.Forms.Label label_ADD;
        private System.Windows.Forms.TextBox textBox_ФИО_add;
        private System.Windows.Forms.GroupBox groupBox_add;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView клинетdataGridView;
        private Салон_красотыDataSet салон_красоты_11_1DataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label_edit;
        private System.Windows.Forms.RadioButton radioButton_ФИО;
        private System.Windows.Forms.RadioButton radioButton_тел;
        private Салон_красотыDataSet салон_красотыDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private Салон_красотыDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процедурDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}