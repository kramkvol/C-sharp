namespace Салон
{
    partial class Мастер
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
            System.Windows.Forms.Label label_ФИО_add;
            System.Windows.Forms.Label label_должность_add;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Мастер));
            this.groupBox_adit_del = new System.Windows.Forms.GroupBox();
            this.groupBox_edit = new System.Windows.Forms.GroupBox();
            this.radioButton_должность_edit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_ФИО_edit = new System.Windows.Forms.RadioButton();
            this.label_edit = new System.Windows.Forms.Label();
            this.comboBox_newдолжность = new System.Windows.Forms.ComboBox();
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.салон_красотыDataSet = new Салон.Салон_красотыDataSet();
            this.button_edit = new System.Windows.Forms.Button();
            this.textBox_newФИО = new System.Windows.Forms.TextBox();
            this.comboBox_ФИО = new System.Windows.Forms.ComboBox();
            this.мастерпредставлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_del = new System.Windows.Forms.GroupBox();
            this.label_del = new System.Windows.Forms.Label();
            this.button_del = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.comboBox_ФИО_filter = new System.Windows.Forms.ComboBox();
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.radioButton_ФИО = new System.Windows.Forms.RadioButton();
            this.radioButton_должность = new System.Windows.Forms.RadioButton();
            this.comboBox_должность_filter = new System.Windows.Forms.ComboBox();
            this.должностьBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button_filter = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_расписание = new System.Windows.Forms.Button();
            this.groupBox_add = new System.Windows.Forms.GroupBox();
            this.label_ADD = new System.Windows.Forms.Label();
            this.comboBox_должность_add = new System.Windows.Forms.ComboBox();
            this.должностьBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_ФИО_add = new System.Windows.Forms.TextBox();
            this.мастерdataGridView = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процедурDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мастер_представлениеTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Мастер_представлениеTableAdapter();
            this.должностьTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.ДолжностьTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label_ФИО = new System.Windows.Forms.Label();
            label_ФИО_add = new System.Windows.Forms.Label();
            label_должность_add = new System.Windows.Forms.Label();
            this.groupBox_adit_del.SuspendLayout();
            this.groupBox_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерпредставлениеBindingSource)).BeginInit();
            this.groupBox_del.SuspendLayout();
            this.groupBox_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource2)).BeginInit();
            this.groupBox_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерdataGridView)).BeginInit();
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
            // label_ФИО_add
            // 
            label_ФИО_add.AutoSize = true;
            label_ФИО_add.Location = new System.Drawing.Point(30, 24);
            label_ФИО_add.Name = "label_ФИО_add";
            label_ФИО_add.Size = new System.Drawing.Size(51, 20);
            label_ФИО_add.TabIndex = 94;
            label_ФИО_add.Text = "ФИО:";
            // 
            // label_должность_add
            // 
            label_должность_add.AutoSize = true;
            label_должность_add.Location = new System.Drawing.Point(30, 76);
            label_должность_add.Name = "label_должность_add";
            label_должность_add.Size = new System.Drawing.Size(99, 20);
            label_должность_add.TabIndex = 114;
            label_должность_add.Text = "Должность:";
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
            this.groupBox_adit_del.TabIndex = 117;
            this.groupBox_adit_del.TabStop = false;
            this.groupBox_adit_del.Text = "Редактирование и удаление";
            // 
            // groupBox_edit
            // 
            this.groupBox_edit.Controls.Add(this.radioButton_должность_edit);
            this.groupBox_edit.Controls.Add(this.label1);
            this.groupBox_edit.Controls.Add(this.radioButton_ФИО_edit);
            this.groupBox_edit.Controls.Add(this.label_edit);
            this.groupBox_edit.Controls.Add(this.comboBox_newдолжность);
            this.groupBox_edit.Controls.Add(this.button_edit);
            this.groupBox_edit.Controls.Add(this.textBox_newФИО);
            this.groupBox_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_edit.Location = new System.Drawing.Point(366, 15);
            this.groupBox_edit.Name = "groupBox_edit";
            this.groupBox_edit.Size = new System.Drawing.Size(521, 140);
            this.groupBox_edit.TabIndex = 110;
            this.groupBox_edit.TabStop = false;
            this.groupBox_edit.Text = "Редактирование";
            // 
            // radioButton_должность_edit
            // 
            this.radioButton_должность_edit.AutoSize = true;
            this.radioButton_должность_edit.Location = new System.Drawing.Point(10, 81);
            this.radioButton_должность_edit.Name = "radioButton_должность_edit";
            this.radioButton_должность_edit.Size = new System.Drawing.Size(168, 24);
            this.radioButton_должность_edit.TabIndex = 120;
            this.radioButton_должность_edit.TabStop = true;
            this.radioButton_должность_edit.Text = "Новая должность:";
            this.radioButton_должность_edit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 123;
            // 
            // radioButton_ФИО_edit
            // 
            this.radioButton_ФИО_edit.AutoSize = true;
            this.radioButton_ФИО_edit.Location = new System.Drawing.Point(10, 26);
            this.radioButton_ФИО_edit.Name = "radioButton_ФИО_edit";
            this.radioButton_ФИО_edit.Size = new System.Drawing.Size(121, 24);
            this.radioButton_ФИО_edit.TabIndex = 120;
            this.radioButton_ФИО_edit.TabStop = true;
            this.radioButton_ФИО_edit.Text = "Новое ФИО:";
            this.radioButton_ФИО_edit.UseVisualStyleBackColor = true;
            // 
            // label_edit
            // 
            this.label_edit.AutoSize = true;
            this.label_edit.Location = new System.Drawing.Point(148, 0);
            this.label_edit.Name = "label_edit";
            this.label_edit.Size = new System.Drawing.Size(0, 20);
            this.label_edit.TabIndex = 122;
            // 
            // comboBox_newдолжность
            // 
            this.comboBox_newдолжность.DataSource = this.должностьBindingSource;
            this.comboBox_newдолжность.DisplayMember = "Название";
            this.comboBox_newдолжность.FormattingEnabled = true;
            this.comboBox_newдолжность.Location = new System.Drawing.Point(6, 107);
            this.comboBox_newдолжность.Name = "comboBox_newдолжность";
            this.comboBox_newдолжность.Size = new System.Drawing.Size(509, 28);
            this.comboBox_newдолжность.TabIndex = 111;
            this.comboBox_newдолжность.ValueMember = "ID";
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this.салон_красотыDataSet;
            // 
            // салон_красотыDataSet
            // 
            this.салон_красотыDataSet.DataSetName = "Салон_красотыDataSet";
            this.салон_красотыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit.ForeColor = System.Drawing.Color.Black;
            this.button_edit.Location = new System.Drawing.Point(358, 45);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(157, 33);
            this.button_edit.TabIndex = 110;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_newФИО
            // 
            this.textBox_newФИО.Location = new System.Drawing.Point(6, 52);
            this.textBox_newФИО.Name = "textBox_newФИО";
            this.textBox_newФИО.Size = new System.Drawing.Size(322, 26);
            this.textBox_newФИО.TabIndex = 111;
            // 
            // comboBox_ФИО
            // 
            this.comboBox_ФИО.DataSource = this.мастерпредставлениеBindingSource;
            this.comboBox_ФИО.DisplayMember = "ФИО";
            this.comboBox_ФИО.FormattingEnabled = true;
            this.comboBox_ФИО.Location = new System.Drawing.Point(14, 45);
            this.comboBox_ФИО.Name = "comboBox_ФИО";
            this.comboBox_ФИО.Size = new System.Drawing.Size(322, 28);
            this.comboBox_ФИО.TabIndex = 100;
            this.comboBox_ФИО.ValueMember = "ID";
            // 
            // мастерпредставлениеBindingSource
            // 
            this.мастерпредставлениеBindingSource.DataMember = "Мастер_представление";
            this.мастерпредставлениеBindingSource.DataSource = this.салон_красотыDataSet;
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
            this.groupBox_del.Text = "Увольнение";
            // 
            // label_del
            // 
            this.label_del.AutoSize = true;
            this.label_del.Location = new System.Drawing.Point(96, 0);
            this.label_del.Name = "label_del";
            this.label_del.Size = new System.Drawing.Size(0, 20);
            this.label_del.TabIndex = 122;
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
            this.button_del.Text = "Уволить";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAll.ForeColor = System.Drawing.Color.Black;
            this.buttonShowAll.Location = new System.Drawing.Point(15, 178);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(320, 33);
            this.buttonShowAll.TabIndex = 100;
            this.buttonShowAll.Text = "Показать всё";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // comboBox_ФИО_filter
            // 
            this.comboBox_ФИО_filter.DataSource = this.мастерпредставлениеBindingSource;
            this.comboBox_ФИО_filter.DisplayMember = "ФИО";
            this.comboBox_ФИО_filter.FormattingEnabled = true;
            this.comboBox_ФИО_filter.Location = new System.Drawing.Point(15, 49);
            this.comboBox_ФИО_filter.Name = "comboBox_ФИО_filter";
            this.comboBox_ФИО_filter.Size = new System.Drawing.Size(322, 28);
            this.comboBox_ФИО_filter.TabIndex = 85;
            this.comboBox_ФИО_filter.ValueMember = "ID";
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.Controls.Add(this.radioButton_ФИО);
            this.groupBox_filter.Controls.Add(this.radioButton_должность);
            this.groupBox_filter.Controls.Add(this.comboBox_должность_filter);
            this.groupBox_filter.Controls.Add(this.buttonShowAll);
            this.groupBox_filter.Controls.Add(this.button_filter);
            this.groupBox_filter.Controls.Add(this.comboBox_ФИО_filter);
            this.groupBox_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_filter.Location = new System.Drawing.Point(720, 55);
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.Size = new System.Drawing.Size(352, 217);
            this.groupBox_filter.TabIndex = 119;
            this.groupBox_filter.TabStop = false;
            this.groupBox_filter.Text = "Фильтрация:";
            // 
            // radioButton_ФИО
            // 
            this.radioButton_ФИО.AutoSize = true;
            this.radioButton_ФИО.Location = new System.Drawing.Point(16, 23);
            this.radioButton_ФИО.Name = "radioButton_ФИО";
            this.radioButton_ФИО.Size = new System.Drawing.Size(69, 24);
            this.radioButton_ФИО.TabIndex = 119;
            this.radioButton_ФИО.TabStop = true;
            this.radioButton_ФИО.Text = "ФИО:";
            this.radioButton_ФИО.UseVisualStyleBackColor = true;
            // 
            // radioButton_должность
            // 
            this.radioButton_должность.AutoSize = true;
            this.radioButton_должность.Location = new System.Drawing.Point(16, 79);
            this.radioButton_должность.Name = "radioButton_должность";
            this.radioButton_должность.Size = new System.Drawing.Size(117, 24);
            this.radioButton_должность.TabIndex = 118;
            this.radioButton_должность.TabStop = true;
            this.radioButton_должность.Text = "Должность:";
            this.radioButton_должность.UseVisualStyleBackColor = true;
            // 
            // comboBox_должность_filter
            // 
            this.comboBox_должность_filter.DataSource = this.должностьBindingSource2;
            this.comboBox_должность_filter.DisplayMember = "Название";
            this.comboBox_должность_filter.FormattingEnabled = true;
            this.comboBox_должность_filter.Location = new System.Drawing.Point(15, 105);
            this.comboBox_должность_filter.Name = "comboBox_должность_filter";
            this.comboBox_должность_filter.Size = new System.Drawing.Size(322, 28);
            this.comboBox_должность_filter.TabIndex = 117;
            this.comboBox_должность_filter.ValueMember = "ID";
            // 
            // должностьBindingSource2
            // 
            this.должностьBindingSource2.DataMember = "Должность";
            this.должностьBindingSource2.DataSource = this.салон_красотыDataSet;
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_filter.ForeColor = System.Drawing.Color.Black;
            this.button_filter.Location = new System.Drawing.Point(15, 139);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(320, 33);
            this.button_filter.TabIndex = 89;
            this.button_filter.Text = "Фильтровать";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(926, 614);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(146, 40);
            this.button_back.TabIndex = 116;
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
            this.Title.TabIndex = 113;
            this.Title.Text = "Мастер";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // button_расписание
            // 
            this.button_расписание.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_расписание.Location = new System.Drawing.Point(926, 567);
            this.button_расписание.Name = "button_расписание";
            this.button_расписание.Size = new System.Drawing.Size(146, 40);
            this.button_расписание.TabIndex = 120;
            this.button_расписание.Text = "Расписание";
            this.button_расписание.UseVisualStyleBackColor = true;
            this.button_расписание.Click += new System.EventHandler(this.button_расписание_Click);
            // 
            // groupBox_add
            // 
            this.groupBox_add.Controls.Add(this.label_ADD);
            this.groupBox_add.Controls.Add(this.comboBox_должность_add);
            this.groupBox_add.Controls.Add(label_должность_add);
            this.groupBox_add.Controls.Add(label_ФИО_add);
            this.groupBox_add.Controls.Add(this.button_add);
            this.groupBox_add.Controls.Add(this.textBox_ФИО_add);
            this.groupBox_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_add.Location = new System.Drawing.Point(720, 312);
            this.groupBox_add.Name = "groupBox_add";
            this.groupBox_add.Size = new System.Drawing.Size(352, 174);
            this.groupBox_add.TabIndex = 118;
            this.groupBox_add.TabStop = false;
            this.groupBox_add.Text = "Добавление";
            // 
            // label_ADD
            // 
            this.label_ADD.AutoSize = true;
            this.label_ADD.Location = new System.Drawing.Point(118, 0);
            this.label_ADD.Name = "label_ADD";
            this.label_ADD.Size = new System.Drawing.Size(0, 20);
            this.label_ADD.TabIndex = 122;
            // 
            // comboBox_должность_add
            // 
            this.comboBox_должность_add.DataSource = this.должностьBindingSource1;
            this.comboBox_должность_add.DisplayMember = "Название";
            this.comboBox_должность_add.FormattingEnabled = true;
            this.comboBox_должность_add.Location = new System.Drawing.Point(15, 100);
            this.comboBox_должность_add.Name = "comboBox_должность_add";
            this.comboBox_должность_add.Size = new System.Drawing.Size(320, 28);
            this.comboBox_должность_add.TabIndex = 115;
            this.comboBox_должность_add.ValueMember = "ID";
            // 
            // должностьBindingSource1
            // 
            this.должностьBindingSource1.DataMember = "Должность";
            this.должностьBindingSource1.DataSource = this.салон_красотыDataSet;
            // 
            // textBox_ФИО_add
            // 
            this.textBox_ФИО_add.Location = new System.Drawing.Point(15, 47);
            this.textBox_ФИО_add.Name = "textBox_ФИО_add";
            this.textBox_ФИО_add.Size = new System.Drawing.Size(320, 26);
            this.textBox_ФИО_add.TabIndex = 93;
            // 
            // мастерdataGridView
            // 
            this.мастерdataGridView.AllowUserToAddRows = false;
            this.мастерdataGridView.AllowUserToDeleteRows = false;
            this.мастерdataGridView.AutoGenerateColumns = false;
            this.мастерdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.мастерdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.мастерdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.мастерdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.мастерdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.процедурDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.мастерdataGridView.DataSource = this.мастерпредставлениеBindingSource;
            this.мастерdataGridView.Location = new System.Drawing.Point(12, 55);
            this.мастерdataGridView.Name = "мастерdataGridView";
            this.мастерdataGridView.ReadOnly = true;
            this.мастерdataGridView.Size = new System.Drawing.Size(702, 431);
            this.мастерdataGridView.TabIndex = 121;
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
            // процедурDataGridViewTextBoxColumn
            // 
            this.процедурDataGridViewTextBoxColumn.DataPropertyName = "Процедур";
            this.процедурDataGridViewTextBoxColumn.HeaderText = "Процедур";
            this.процедурDataGridViewTextBoxColumn.Name = "процедурDataGridViewTextBoxColumn";
            this.процедурDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // мастер_представлениеTableAdapter
            // 
            this.мастер_представлениеTableAdapter.ClearBeforeFill = true;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1027, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Мастер
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1084, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.мастерdataGridView);
            this.Controls.Add(this.groupBox_adit_del);
            this.Controls.Add(this.groupBox_filter);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button_расписание);
            this.Controls.Add(this.groupBox_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Мастер";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Мастер_FormClosed);
            this.Load += new System.EventHandler(this.Мастер_Load);
            this.groupBox_adit_del.ResumeLayout(false);
            this.groupBox_adit_del.PerformLayout();
            this.groupBox_edit.ResumeLayout(false);
            this.groupBox_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.салон_красотыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерпредставлениеBindingSource)).EndInit();
            this.groupBox_del.ResumeLayout(false);
            this.groupBox_del.PerformLayout();
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource2)).EndInit();
            this.groupBox_add.ResumeLayout(false);
            this.groupBox_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мастерdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_adit_del;
        private System.Windows.Forms.GroupBox groupBox_edit;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.ComboBox comboBox_ФИО;
        private System.Windows.Forms.GroupBox groupBox_del;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.ComboBox comboBox_ФИО_filter;
        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_расписание;
        private System.Windows.Forms.GroupBox groupBox_add;
        private System.Windows.Forms.TextBox textBox_ФИО_add;
        private System.Windows.Forms.TextBox textBox_newФИО;
        private System.Windows.Forms.ComboBox comboBox_newдолжность;
        private System.Windows.Forms.ComboBox comboBox_должность_add;
        private System.Windows.Forms.DataGridView мастерdataGridView;
        private System.Windows.Forms.ComboBox comboBox_должность_filter;
        private System.Windows.Forms.Label label_edit;
        private System.Windows.Forms.Label label_del;
        private System.Windows.Forms.Label label_ADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_ФИО;
        private System.Windows.Forms.RadioButton radioButton_должность;
        private System.Windows.Forms.RadioButton radioButton_ФИО_edit;
        private System.Windows.Forms.RadioButton radioButton_должность_edit;
        private Салон_красотыDataSet салон_красотыDataSet;
        private System.Windows.Forms.BindingSource мастерпредставлениеBindingSource;
        private Салон_красотыDataSetTableAdapters.Мастер_представлениеTableAdapter мастер_представлениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процедурDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private Салон_красотыDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private System.Windows.Forms.BindingSource должностьBindingSource2;
        private System.Windows.Forms.BindingSource должностьBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}