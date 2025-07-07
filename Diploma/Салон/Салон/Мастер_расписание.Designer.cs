namespace Салон
{
    partial class Мастер_расписание
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
            System.Windows.Forms.Label label_ФИО_add;
            System.Windows.Forms.Label label_до_add;
            System.Windows.Forms.Label label_рабвр_add;
            System.Windows.Forms.Label label_деньнедели_add;
            System.Windows.Forms.Label label_от_add;
            System.Windows.Forms.Label label_ФИО_edit;
            System.Windows.Forms.Label label_newдо_edit;
            System.Windows.Forms.Label label_newрабвр_edit;
            System.Windows.Forms.Label label_деньнедели_edit;
            System.Windows.Forms.Label label_newот_edit;
            System.Windows.Forms.Label label_ФИО_del;
            System.Windows.Forms.Label label_деньнедели_del;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Мастер_расписание));
            this.расписание_представлениеDataGridView = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деньНеделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началоРабочегоДняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.конецРабочегоДняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расписаниепредставлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.салон_красотыDataSet = new Салон.Салон_красотыDataSet();
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.radioButton_должность = new System.Windows.Forms.RadioButton();
            this.radioButton_деньнедели = new System.Windows.Forms.RadioButton();
            this.radioButton_ФИО = new System.Windows.Forms.RadioButton();
            this.comboBox_деньНедели = new System.Windows.Forms.ComboBox();
            this.деньНеделиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_должность = new System.Windows.Forms.ComboBox();
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_ShowAll = new System.Windows.Forms.Button();
            this.button_filer = new System.Windows.Forms.Button();
            this.comboBox_ФИО = new System.Windows.Forms.ComboBox();
            this.мастерпредставлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_мастер = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.groupBox_add = new System.Windows.Forms.GroupBox();
            this.label_ADD = new System.Windows.Forms.Label();
            this.comboBox_ФИО_add = new System.Windows.Forms.ComboBox();
            this.textBox_до_add = new System.Windows.Forms.TextBox();
            this.textBox_от_add = new System.Windows.Forms.TextBox();
            this.comboBox_деньнедели_add = new System.Windows.Forms.ComboBox();
            this.button_добавить = new System.Windows.Forms.Button();
            this.groupBox_edit = new System.Windows.Forms.GroupBox();
            this.label_edit = new System.Windows.Forms.Label();
            this.comboBox_ФИО_edit = new System.Windows.Forms.ComboBox();
            this.textBox_newдо_edit = new System.Windows.Forms.TextBox();
            this.textBox_newот_edit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_деньнедели_edit = new System.Windows.Forms.ComboBox();
            this.groupBox_del = new System.Windows.Forms.GroupBox();
            this.label_del = new System.Windows.Forms.Label();
            this.comboBox_ФИО_del = new System.Windows.Forms.ComboBox();
            this.comboBox_деньнедели_del = new System.Windows.Forms.ComboBox();
            this.button_del = new System.Windows.Forms.Button();
            this.расписание_представлениеTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Расписание_представлениеTableAdapter();
            this.мастер_представлениеTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Мастер_представлениеTableAdapter();
            this.день_неделиTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.День_неделиTableAdapter();
            this.должностьTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.ДолжностьTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label_ФИО_add = new System.Windows.Forms.Label();
            label_до_add = new System.Windows.Forms.Label();
            label_рабвр_add = new System.Windows.Forms.Label();
            label_деньнедели_add = new System.Windows.Forms.Label();
            label_от_add = new System.Windows.Forms.Label();
            label_ФИО_edit = new System.Windows.Forms.Label();
            label_newдо_edit = new System.Windows.Forms.Label();
            label_newрабвр_edit = new System.Windows.Forms.Label();
            label_деньнедели_edit = new System.Windows.Forms.Label();
            label_newот_edit = new System.Windows.Forms.Label();
            label_ФИО_del = new System.Windows.Forms.Label();
            label_деньнедели_del = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.расписание_представлениеDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниепредставлениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).BeginInit();
            this.groupBox_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.деньНеделиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерпредставлениеBindingSource)).BeginInit();
            this.groupBox_add.SuspendLayout();
            this.groupBox_edit.SuspendLayout();
            this.groupBox_del.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ФИО_add
            // 
            label_ФИО_add.AutoSize = true;
            label_ФИО_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_ФИО_add.Location = new System.Drawing.Point(10, 19);
            label_ФИО_add.Name = "label_ФИО_add";
            label_ФИО_add.Size = new System.Drawing.Size(51, 20);
            label_ФИО_add.TabIndex = 100;
            label_ФИО_add.Text = "ФИО:";
            // 
            // label_до_add
            // 
            label_до_add.AutoSize = true;
            label_до_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_до_add.Location = new System.Drawing.Point(228, 152);
            label_до_add.Name = "label_до_add";
            label_до_add.Size = new System.Drawing.Size(29, 20);
            label_до_add.TabIndex = 99;
            label_до_add.Text = "до";
            // 
            // label_рабвр_add
            // 
            label_рабвр_add.AutoSize = true;
            label_рабвр_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_рабвр_add.Location = new System.Drawing.Point(11, 128);
            label_рабвр_add.Name = "label_рабвр_add";
            label_рабвр_add.Size = new System.Drawing.Size(62, 20);
            label_рабвр_add.TabIndex = 95;
            label_рабвр_add.Text = "Время:";
            // 
            // label_деньнедели_add
            // 
            label_деньнедели_add.AutoSize = true;
            label_деньнедели_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_деньнедели_add.Location = new System.Drawing.Point(10, 72);
            label_деньнедели_add.Name = "label_деньнедели_add";
            label_деньнедели_add.Size = new System.Drawing.Size(113, 20);
            label_деньнедели_add.TabIndex = 84;
            label_деньнедели_add.Text = "День недели:";
            // 
            // label_от_add
            // 
            label_от_add.AutoSize = true;
            label_от_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_от_add.Location = new System.Drawing.Point(11, 153);
            label_от_add.Name = "label_от_add";
            label_от_add.Size = new System.Drawing.Size(27, 20);
            label_от_add.TabIndex = 97;
            label_от_add.Text = "от";
            // 
            // label_ФИО_edit
            // 
            label_ФИО_edit.AutoSize = true;
            label_ФИО_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_ФИО_edit.Location = new System.Drawing.Point(9, 19);
            label_ФИО_edit.Name = "label_ФИО_edit";
            label_ФИО_edit.Size = new System.Drawing.Size(57, 20);
            label_ФИО_edit.TabIndex = 0;
            label_ФИО_edit.Text = "*ФИО:";
            // 
            // label_newдо_edit
            // 
            label_newдо_edit.AutoSize = true;
            label_newдо_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_newдо_edit.Location = new System.Drawing.Point(227, 151);
            label_newдо_edit.Name = "label_newдо_edit";
            label_newдо_edit.Size = new System.Drawing.Size(29, 20);
            label_newдо_edit.TabIndex = 99;
            label_newдо_edit.Text = "до";
            // 
            // label_newрабвр_edit
            // 
            label_newрабвр_edit.AutoSize = true;
            label_newрабвр_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_newрабвр_edit.Location = new System.Drawing.Point(9, 128);
            label_newрабвр_edit.Name = "label_newрабвр_edit";
            label_newрабвр_edit.Size = new System.Drawing.Size(112, 20);
            label_newрабвр_edit.TabIndex = 95;
            label_newрабвр_edit.Text = "Новое время:";
            // 
            // label_деньнедели_edit
            // 
            label_деньнедели_edit.AutoSize = true;
            label_деньнедели_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_деньнедели_edit.Location = new System.Drawing.Point(9, 73);
            label_деньнедели_edit.Name = "label_деньнедели_edit";
            label_деньнедели_edit.Size = new System.Drawing.Size(119, 20);
            label_деньнедели_edit.TabIndex = 84;
            label_деньнедели_edit.Text = "*День недели:";
            // 
            // label_newот_edit
            // 
            label_newот_edit.AutoSize = true;
            label_newот_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_newот_edit.Location = new System.Drawing.Point(9, 153);
            label_newот_edit.Name = "label_newот_edit";
            label_newот_edit.Size = new System.Drawing.Size(27, 20);
            label_newот_edit.TabIndex = 97;
            label_newот_edit.Text = "от";
            // 
            // label_ФИО_del
            // 
            label_ФИО_del.AutoSize = true;
            label_ФИО_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_ФИО_del.Location = new System.Drawing.Point(17, 20);
            label_ФИО_del.Name = "label_ФИО_del";
            label_ФИО_del.Size = new System.Drawing.Size(51, 20);
            label_ФИО_del.TabIndex = 0;
            label_ФИО_del.Text = "ФИО:";
            // 
            // label_деньнедели_del
            // 
            label_деньнедели_del.AutoSize = true;
            label_деньнедели_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_деньнедели_del.Location = new System.Drawing.Point(379, 20);
            label_деньнедели_del.Name = "label_деньнедели_del";
            label_деньнедели_del.Size = new System.Drawing.Size(113, 20);
            label_деньнедели_del.TabIndex = 84;
            label_деньнедели_del.Text = "День недели:";
            // 
            // расписание_представлениеDataGridView
            // 
            this.расписание_представлениеDataGridView.AllowUserToAddRows = false;
            this.расписание_представлениеDataGridView.AllowUserToDeleteRows = false;
            this.расписание_представлениеDataGridView.AutoGenerateColumns = false;
            this.расписание_представлениеDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.расписание_представлениеDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.расписание_представлениеDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.расписание_представлениеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.расписание_представлениеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.деньНеделиDataGridViewTextBoxColumn,
            this.началоРабочегоДняDataGridViewTextBoxColumn,
            this.конецРабочегоДняDataGridViewTextBoxColumn});
            this.расписание_представлениеDataGridView.DataSource = this.расписаниепредставлениеBindingSource;
            this.расписание_представлениеDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.расписание_представлениеDataGridView.Location = new System.Drawing.Point(12, 56);
            this.расписание_представлениеDataGridView.Name = "расписание_представлениеDataGridView";
            this.расписание_представлениеDataGridView.ReadOnly = true;
            this.расписание_представлениеDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.расписание_представлениеDataGridView.Size = new System.Drawing.Size(1067, 270);
            this.расписание_представлениеDataGridView.TabIndex = 107;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // деньНеделиDataGridViewTextBoxColumn
            // 
            this.деньНеделиDataGridViewTextBoxColumn.DataPropertyName = "День недели";
            this.деньНеделиDataGridViewTextBoxColumn.HeaderText = "День недели";
            this.деньНеделиDataGridViewTextBoxColumn.Name = "деньНеделиDataGridViewTextBoxColumn";
            this.деньНеделиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // началоРабочегоДняDataGridViewTextBoxColumn
            // 
            this.началоРабочегоДняDataGridViewTextBoxColumn.DataPropertyName = "Начало рабочего дня";
            this.началоРабочегоДняDataGridViewTextBoxColumn.HeaderText = "Начало рабочего дня";
            this.началоРабочегоДняDataGridViewTextBoxColumn.Name = "началоРабочегоДняDataGridViewTextBoxColumn";
            this.началоРабочегоДняDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // конецРабочегоДняDataGridViewTextBoxColumn
            // 
            this.конецРабочегоДняDataGridViewTextBoxColumn.DataPropertyName = "Конец рабочего дня";
            this.конецРабочегоДняDataGridViewTextBoxColumn.HeaderText = "Конец рабочего дня";
            this.конецРабочегоДняDataGridViewTextBoxColumn.Name = "конецРабочегоДняDataGridViewTextBoxColumn";
            this.конецРабочегоДняDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // расписаниепредставлениеBindingSource
            // 
            this.расписаниепредставлениеBindingSource.DataMember = "Расписание_представление";
            this.расписаниепредставлениеBindingSource.DataSource = this.салон_красотыDataSet;
            // 
            // салон_красотыDataSet
            // 
            this.салон_красотыDataSet.DataSetName = "Салон_красотыDataSet";
            this.салон_красотыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.Controls.Add(this.radioButton_должность);
            this.groupBox_filter.Controls.Add(this.radioButton_деньнедели);
            this.groupBox_filter.Controls.Add(this.radioButton_ФИО);
            this.groupBox_filter.Controls.Add(this.comboBox_деньНедели);
            this.groupBox_filter.Controls.Add(this.comboBox_должность);
            this.groupBox_filter.Controls.Add(this.button_ShowAll);
            this.groupBox_filter.Controls.Add(this.button_filer);
            this.groupBox_filter.Controls.Add(this.comboBox_ФИО);
            this.groupBox_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_filter.Location = new System.Drawing.Point(747, 329);
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.Size = new System.Drawing.Size(332, 282);
            this.groupBox_filter.TabIndex = 108;
            this.groupBox_filter.TabStop = false;
            this.groupBox_filter.Text = "Фильтрация";
            // 
            // radioButton_должность
            // 
            this.radioButton_должность.AutoSize = true;
            this.radioButton_должность.Location = new System.Drawing.Point(9, 81);
            this.radioButton_должность.Name = "radioButton_должность";
            this.radioButton_должность.Size = new System.Drawing.Size(113, 24);
            this.radioButton_должность.TabIndex = 103;
            this.radioButton_должность.TabStop = true;
            this.radioButton_должность.Text = "Должность";
            this.radioButton_должность.UseVisualStyleBackColor = true;
            // 
            // radioButton_деньнедели
            // 
            this.radioButton_деньнедели.AutoSize = true;
            this.radioButton_деньнедели.Location = new System.Drawing.Point(9, 138);
            this.radioButton_деньнедели.Name = "radioButton_деньнедели";
            this.radioButton_деньнедели.Size = new System.Drawing.Size(127, 24);
            this.radioButton_деньнедели.TabIndex = 102;
            this.radioButton_деньнедели.TabStop = true;
            this.radioButton_деньнедели.Text = "День недели";
            this.radioButton_деньнедели.UseVisualStyleBackColor = true;
            // 
            // radioButton_ФИО
            // 
            this.radioButton_ФИО.AutoSize = true;
            this.radioButton_ФИО.Location = new System.Drawing.Point(14, 24);
            this.radioButton_ФИО.Name = "radioButton_ФИО";
            this.radioButton_ФИО.Size = new System.Drawing.Size(65, 24);
            this.radioButton_ФИО.TabIndex = 101;
            this.radioButton_ФИО.TabStop = true;
            this.radioButton_ФИО.Text = "ФИО";
            this.radioButton_ФИО.UseVisualStyleBackColor = true;
            // 
            // comboBox_деньНедели
            // 
            this.comboBox_деньНедели.DataSource = this.деньНеделиBindingSource;
            this.comboBox_деньНедели.DisplayMember = "Название";
            this.comboBox_деньНедели.FormattingEnabled = true;
            this.comboBox_деньНедели.Location = new System.Drawing.Point(9, 164);
            this.comboBox_деньНедели.Name = "comboBox_деньНедели";
            this.comboBox_деньНедели.Size = new System.Drawing.Size(316, 28);
            this.comboBox_деньНедели.TabIndex = 99;
            this.comboBox_деньНедели.ValueMember = "ID";
            // 
            // деньНеделиBindingSource
            // 
            this.деньНеделиBindingSource.DataMember = "День недели";
            this.деньНеделиBindingSource.DataSource = this.салон_красотыDataSet;
            // 
            // comboBox_должность
            // 
            this.comboBox_должность.DataSource = this.должностьBindingSource;
            this.comboBox_должность.DisplayMember = "Название";
            this.comboBox_должность.FormattingEnabled = true;
            this.comboBox_должность.Location = new System.Drawing.Point(9, 107);
            this.comboBox_должность.Name = "comboBox_должность";
            this.comboBox_должность.Size = new System.Drawing.Size(316, 28);
            this.comboBox_должность.TabIndex = 96;
            this.comboBox_должность.ValueMember = "ID";
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this.салон_красотыDataSet;
            // 
            // button_ShowAll
            // 
            this.button_ShowAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ShowAll.ForeColor = System.Drawing.Color.Black;
            this.button_ShowAll.Location = new System.Drawing.Point(10, 237);
            this.button_ShowAll.Name = "button_ShowAll";
            this.button_ShowAll.Size = new System.Drawing.Size(315, 33);
            this.button_ShowAll.TabIndex = 100;
            this.button_ShowAll.Text = "Показать всё";
            this.button_ShowAll.UseVisualStyleBackColor = false;
            this.button_ShowAll.Click += new System.EventHandler(this.button_ShowAll_Click);
            // 
            // button_filer
            // 
            this.button_filer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_filer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_filer.ForeColor = System.Drawing.Color.Black;
            this.button_filer.Location = new System.Drawing.Point(9, 198);
            this.button_filer.Name = "button_filer";
            this.button_filer.Size = new System.Drawing.Size(316, 33);
            this.button_filer.TabIndex = 81;
            this.button_filer.Text = "Фильтровать";
            this.button_filer.UseVisualStyleBackColor = false;
            this.button_filer.Click += new System.EventHandler(this.button_filer_Click);
            // 
            // comboBox_ФИО
            // 
            this.comboBox_ФИО.DataSource = this.мастерпредставлениеBindingSource;
            this.comboBox_ФИО.DisplayMember = "ФИО";
            this.comboBox_ФИО.FormattingEnabled = true;
            this.comboBox_ФИО.Location = new System.Drawing.Point(9, 50);
            this.comboBox_ФИО.Name = "comboBox_ФИО";
            this.comboBox_ФИО.Size = new System.Drawing.Size(316, 28);
            this.comboBox_ФИО.TabIndex = 97;
            this.comboBox_ФИО.ValueMember = "ID";
            // 
            // мастерпредставлениеBindingSource
            // 
            this.мастерпредставлениеBindingSource.DataMember = "Мастер_представление";
            this.мастерпредставлениеBindingSource.DataSource = this.салон_красотыDataSet;
            // 
            // button_мастер
            // 
            this.button_мастер.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_мастер.Location = new System.Drawing.Point(747, 615);
            this.button_мастер.Name = "button_мастер";
            this.button_мастер.Size = new System.Drawing.Size(165, 40);
            this.button_мастер.TabIndex = 113;
            this.button_мастер.Text = "Мастер";
            this.button_мастер.UseVisualStyleBackColor = true;
            this.button_мастер.Click += new System.EventHandler(this.button_мастер_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(918, 615);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(161, 40);
            this.button_back.TabIndex = 111;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1084, 53);
            this.Title.TabIndex = 109;
            this.Title.Text = "Расписание";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_add
            // 
            this.groupBox_add.Controls.Add(this.label_ADD);
            this.groupBox_add.Controls.Add(this.comboBox_ФИО_add);
            this.groupBox_add.Controls.Add(label_ФИО_add);
            this.groupBox_add.Controls.Add(this.textBox_до_add);
            this.groupBox_add.Controls.Add(label_до_add);
            this.groupBox_add.Controls.Add(this.textBox_от_add);
            this.groupBox_add.Controls.Add(this.comboBox_деньнедели_add);
            this.groupBox_add.Controls.Add(label_рабвр_add);
            this.groupBox_add.Controls.Add(label_деньнедели_add);
            this.groupBox_add.Controls.Add(label_от_add);
            this.groupBox_add.Controls.Add(this.button_добавить);
            this.groupBox_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_add.Location = new System.Drawing.Point(12, 329);
            this.groupBox_add.Name = "groupBox_add";
            this.groupBox_add.Size = new System.Drawing.Size(362, 237);
            this.groupBox_add.TabIndex = 114;
            this.groupBox_add.TabStop = false;
            this.groupBox_add.Text = "Добавление ";
            // 
            // label_ADD
            // 
            this.label_ADD.AutoSize = true;
            this.label_ADD.Location = new System.Drawing.Point(123, 0);
            this.label_ADD.Name = "label_ADD";
            this.label_ADD.Size = new System.Drawing.Size(0, 20);
            this.label_ADD.TabIndex = 87;
            // 
            // comboBox_ФИО_add
            // 
            this.comboBox_ФИО_add.DataSource = this.мастерпредставлениеBindingSource;
            this.comboBox_ФИО_add.DisplayMember = "ФИО";
            this.comboBox_ФИО_add.FormattingEnabled = true;
            this.comboBox_ФИО_add.Location = new System.Drawing.Point(8, 42);
            this.comboBox_ФИО_add.Name = "comboBox_ФИО_add";
            this.comboBox_ФИО_add.Size = new System.Drawing.Size(348, 28);
            this.comboBox_ФИО_add.TabIndex = 101;
            this.comboBox_ФИО_add.ValueMember = "ID";
            // 
            // textBox_до_add
            // 
            this.textBox_до_add.Location = new System.Drawing.Point(277, 150);
            this.textBox_до_add.Name = "textBox_до_add";
            this.textBox_до_add.Size = new System.Drawing.Size(79, 26);
            this.textBox_до_add.TabIndex = 98;
            // 
            // textBox_от_add
            // 
            this.textBox_от_add.Location = new System.Drawing.Point(60, 151);
            this.textBox_от_add.Name = "textBox_от_add";
            this.textBox_от_add.Size = new System.Drawing.Size(79, 26);
            this.textBox_от_add.TabIndex = 96;
            // 
            // comboBox_деньнедели_add
            // 
            this.comboBox_деньнедели_add.DataSource = this.деньНеделиBindingSource;
            this.comboBox_деньнедели_add.DisplayMember = "Название";
            this.comboBox_деньнедели_add.FormattingEnabled = true;
            this.comboBox_деньнедели_add.Location = new System.Drawing.Point(8, 96);
            this.comboBox_деньнедели_add.Name = "comboBox_деньнедели_add";
            this.comboBox_деньнедели_add.Size = new System.Drawing.Size(220, 28);
            this.comboBox_деньнедели_add.TabIndex = 85;
            this.comboBox_деньнедели_add.ValueMember = "ID";
            // 
            // button_добавить
            // 
            this.button_добавить.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_добавить.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_добавить.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_добавить.ForeColor = System.Drawing.Color.Black;
            this.button_добавить.Location = new System.Drawing.Point(7, 189);
            this.button_добавить.Name = "button_добавить";
            this.button_добавить.Size = new System.Drawing.Size(221, 33);
            this.button_добавить.TabIndex = 81;
            this.button_добавить.Text = "Добавить";
            this.button_добавить.UseVisualStyleBackColor = false;
            this.button_добавить.Click += new System.EventHandler(this.button_add_Click);
            // 
            // groupBox_edit
            // 
            this.groupBox_edit.Controls.Add(this.label_edit);
            this.groupBox_edit.Controls.Add(this.comboBox_ФИО_edit);
            this.groupBox_edit.Controls.Add(label_ФИО_edit);
            this.groupBox_edit.Controls.Add(this.textBox_newдо_edit);
            this.groupBox_edit.Controls.Add(label_newдо_edit);
            this.groupBox_edit.Controls.Add(this.textBox_newот_edit);
            this.groupBox_edit.Controls.Add(this.button1);
            this.groupBox_edit.Controls.Add(this.comboBox_деньнедели_edit);
            this.groupBox_edit.Controls.Add(label_newрабвр_edit);
            this.groupBox_edit.Controls.Add(label_деньнедели_edit);
            this.groupBox_edit.Controls.Add(label_newот_edit);
            this.groupBox_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_edit.Location = new System.Drawing.Point(380, 329);
            this.groupBox_edit.Name = "groupBox_edit";
            this.groupBox_edit.Size = new System.Drawing.Size(361, 237);
            this.groupBox_edit.TabIndex = 115;
            this.groupBox_edit.TabStop = false;
            this.groupBox_edit.Text = "Редактирование ";
            // 
            // label_edit
            // 
            this.label_edit.AutoSize = true;
            this.label_edit.Location = new System.Drawing.Point(156, 0);
            this.label_edit.Name = "label_edit";
            this.label_edit.Size = new System.Drawing.Size(0, 20);
            this.label_edit.TabIndex = 100;
            // 
            // comboBox_ФИО_edit
            // 
            this.comboBox_ФИО_edit.DataSource = this.мастерпредставлениеBindingSource;
            this.comboBox_ФИО_edit.DisplayMember = "ФИО";
            this.comboBox_ФИО_edit.FormattingEnabled = true;
            this.comboBox_ФИО_edit.Location = new System.Drawing.Point(6, 42);
            this.comboBox_ФИО_edit.Name = "comboBox_ФИО_edit";
            this.comboBox_ФИО_edit.Size = new System.Drawing.Size(349, 28);
            this.comboBox_ФИО_edit.TabIndex = 83;
            this.comboBox_ФИО_edit.ValueMember = "ID";
            // 
            // textBox_newдо_edit
            // 
            this.textBox_newдо_edit.Location = new System.Drawing.Point(276, 149);
            this.textBox_newдо_edit.Name = "textBox_newдо_edit";
            this.textBox_newдо_edit.Size = new System.Drawing.Size(79, 26);
            this.textBox_newдо_edit.TabIndex = 98;
            // 
            // textBox_newот_edit
            // 
            this.textBox_newот_edit.Location = new System.Drawing.Point(64, 151);
            this.textBox_newот_edit.Name = "textBox_newот_edit";
            this.textBox_newот_edit.Size = new System.Drawing.Size(79, 26);
            this.textBox_newот_edit.TabIndex = 96;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(5, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 33);
            this.button1.TabIndex = 81;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // comboBox_деньнедели_edit
            // 
            this.comboBox_деньнедели_edit.DataSource = this.деньНеделиBindingSource;
            this.comboBox_деньнедели_edit.DisplayMember = "Название";
            this.comboBox_деньнедели_edit.FormattingEnabled = true;
            this.comboBox_деньнедели_edit.Location = new System.Drawing.Point(6, 96);
            this.comboBox_деньнедели_edit.Name = "comboBox_деньнедели_edit";
            this.comboBox_деньнедели_edit.Size = new System.Drawing.Size(221, 28);
            this.comboBox_деньнедели_edit.TabIndex = 85;
            this.comboBox_деньнедели_edit.ValueMember = "ID";
            // 
            // groupBox_del
            // 
            this.groupBox_del.Controls.Add(this.label_del);
            this.groupBox_del.Controls.Add(this.comboBox_ФИО_del);
            this.groupBox_del.Controls.Add(label_ФИО_del);
            this.groupBox_del.Controls.Add(this.comboBox_деньнедели_del);
            this.groupBox_del.Controls.Add(label_деньнедели_del);
            this.groupBox_del.Controls.Add(this.button_del);
            this.groupBox_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_del.Location = new System.Drawing.Point(12, 569);
            this.groupBox_del.Name = "groupBox_del";
            this.groupBox_del.Size = new System.Drawing.Size(729, 85);
            this.groupBox_del.TabIndex = 116;
            this.groupBox_del.TabStop = false;
            this.groupBox_del.Text = "Удаление";
            // 
            // label_del
            // 
            this.label_del.AutoSize = true;
            this.label_del.Location = new System.Drawing.Point(94, 0);
            this.label_del.Name = "label_del";
            this.label_del.Size = new System.Drawing.Size(0, 20);
            this.label_del.TabIndex = 86;
            // 
            // comboBox_ФИО_del
            // 
            this.comboBox_ФИО_del.DataSource = this.мастерпредставлениеBindingSource;
            this.comboBox_ФИО_del.DisplayMember = "ФИО";
            this.comboBox_ФИО_del.FormattingEnabled = true;
            this.comboBox_ФИО_del.Location = new System.Drawing.Point(14, 43);
            this.comboBox_ФИО_del.Name = "comboBox_ФИО_del";
            this.comboBox_ФИО_del.Size = new System.Drawing.Size(356, 28);
            this.comboBox_ФИО_del.TabIndex = 83;
            this.comboBox_ФИО_del.ValueMember = "ID";
            // 
            // comboBox_деньнедели_del
            // 
            this.comboBox_деньнедели_del.DataSource = this.деньНеделиBindingSource;
            this.comboBox_деньнедели_del.DisplayMember = "Название";
            this.comboBox_деньнедели_del.FormattingEnabled = true;
            this.comboBox_деньнедели_del.Location = new System.Drawing.Point(376, 43);
            this.comboBox_деньнедели_del.Name = "comboBox_деньнедели_del";
            this.comboBox_деньнедели_del.Size = new System.Drawing.Size(220, 28);
            this.comboBox_деньнедели_del.TabIndex = 85;
            this.comboBox_деньнедели_del.ValueMember = "ID";
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_del.ForeColor = System.Drawing.Color.Black;
            this.button_del.Location = new System.Drawing.Point(602, 38);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(121, 33);
            this.button_del.TabIndex = 81;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // расписание_представлениеTableAdapter
            // 
            this.расписание_представлениеTableAdapter.ClearBeforeFill = true;
            // 
            // мастер_представлениеTableAdapter
            // 
            this.мастер_представлениеTableAdapter.ClearBeforeFill = true;
            // 
            // день_неделиTableAdapter
            // 
            this.день_неделиTableAdapter.ClearBeforeFill = true;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1027, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Мастер_расписание
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1084, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_del);
            this.Controls.Add(this.groupBox_edit);
            this.Controls.Add(this.groupBox_add);
            this.Controls.Add(this.расписание_представлениеDataGridView);
            this.Controls.Add(this.groupBox_filter);
            this.Controls.Add(this.button_мастер);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Мастер_расписание";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Мастер_расписание_FormClosed);
            this.Load += new System.EventHandler(this.Мастер_расписание_Load);
            ((System.ComponentModel.ISupportInitialize)(this.расписание_представлениеDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниепредставлениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).EndInit();
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.деньНеделиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерпредставлениеBindingSource)).EndInit();
            this.groupBox_add.ResumeLayout(false);
            this.groupBox_add.PerformLayout();
            this.groupBox_edit.ResumeLayout(false);
            this.groupBox_edit.PerformLayout();
            this.groupBox_del.ResumeLayout(false);
            this.groupBox_del.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView расписание_представлениеDataGridView;
        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.ComboBox comboBox_деньНедели;
        private System.Windows.Forms.ComboBox comboBox_должность;
        private System.Windows.Forms.Button button_ShowAll;
        private System.Windows.Forms.Button button_filer;
        private System.Windows.Forms.ComboBox comboBox_ФИО;
        private System.Windows.Forms.Button button_мастер;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RadioButton radioButton_должность;
        private System.Windows.Forms.RadioButton radioButton_деньнедели;
        private System.Windows.Forms.RadioButton radioButton_ФИО;
        private System.Windows.Forms.GroupBox groupBox_add;
        private System.Windows.Forms.Label label_ADD;
        private System.Windows.Forms.ComboBox comboBox_ФИО_add;
        private System.Windows.Forms.TextBox textBox_до_add;
        private System.Windows.Forms.TextBox textBox_от_add;
        private System.Windows.Forms.ComboBox comboBox_деньнедели_add;
        private System.Windows.Forms.Button button_добавить;
        private System.Windows.Forms.GroupBox groupBox_edit;
        private System.Windows.Forms.Label label_edit;
        private System.Windows.Forms.ComboBox comboBox_ФИО_edit;
        private System.Windows.Forms.TextBox textBox_newдо_edit;
        private System.Windows.Forms.TextBox textBox_newот_edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_деньнедели_edit;
        private System.Windows.Forms.GroupBox groupBox_del;
        private System.Windows.Forms.Label label_del;
        private System.Windows.Forms.ComboBox comboBox_ФИО_del;
        private System.Windows.Forms.ComboBox comboBox_деньнедели_del;
        private System.Windows.Forms.Button button_del;
        private Салон_красотыDataSet салон_красотыDataSet;
        private System.Windows.Forms.BindingSource расписаниепредставлениеBindingSource;
        private Салон_красотыDataSetTableAdapters.Расписание_представлениеTableAdapter расписание_представлениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn деньНеделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началоРабочегоДняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn конецРабочегоДняDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource мастерпредставлениеBindingSource;
        private Салон_красотыDataSetTableAdapters.Мастер_представлениеTableAdapter мастер_представлениеTableAdapter;
        private System.Windows.Forms.BindingSource деньНеделиBindingSource;
        private Салон_красотыDataSetTableAdapters.День_неделиTableAdapter день_неделиTableAdapter;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private Салон_красотыDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}