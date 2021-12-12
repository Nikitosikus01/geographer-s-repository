
namespace DateBase
{
    partial class FormSeas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадькмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объёмкмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.протяжённостьБереговойЛиниикмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.средняяГлубинакмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.максимальнаяГлубинакмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заметкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geoDataSet = new DateBase.GeoDataSet();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.textBoxMiddleDepth = new System.Windows.Forms.TextBox();
            this.textBoxLengthOfCoastline = new System.Windows.Forms.TextBox();
            this.textBoxCubic = new System.Windows.Forms.TextBox();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.groupBoxSeas = new System.Windows.Forms.GroupBox();
            this.textBoxMaxDepth = new System.Windows.Forms.TextBox();
            this.labelMaxDepth = new System.Windows.Forms.Label();
            this.labelMiddleDepth = new System.Windows.Forms.Label();
            this.labelLengthOfCoastline = new System.Windows.Forms.Label();
            this.labelCubic = new System.Windows.Forms.Label();
            this.labelSquare = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.seasTableAdapter = new DateBase.GeoDataSetTableAdapters.SeasTableAdapter();
            this.button_Roll_up = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSet)).BeginInit();
            this.groupBoxSeas.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.площадькмDataGridViewTextBoxColumn,
            this.объёмкмDataGridViewTextBoxColumn,
            this.протяжённостьБереговойЛиниикмDataGridViewTextBoxColumn,
            this.средняяГлубинакмDataGridViewTextBoxColumn,
            this.максимальнаяГлубинакмDataGridViewTextBoxColumn,
            this.заметкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 371);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // площадькмDataGridViewTextBoxColumn
            // 
            this.площадькмDataGridViewTextBoxColumn.DataPropertyName = "Площадь(км)";
            this.площадькмDataGridViewTextBoxColumn.HeaderText = "Площадь(км)";
            this.площадькмDataGridViewTextBoxColumn.Name = "площадькмDataGridViewTextBoxColumn";
            // 
            // объёмкмDataGridViewTextBoxColumn
            // 
            this.объёмкмDataGridViewTextBoxColumn.DataPropertyName = "Объём(км)";
            this.объёмкмDataGridViewTextBoxColumn.HeaderText = "Объём(км)";
            this.объёмкмDataGridViewTextBoxColumn.Name = "объёмкмDataGridViewTextBoxColumn";
            // 
            // протяжённостьБереговойЛиниикмDataGridViewTextBoxColumn
            // 
            this.протяжённостьБереговойЛиниикмDataGridViewTextBoxColumn.DataPropertyName = "Протяжённость береговой линии(км)";
            this.протяжённостьБереговойЛиниикмDataGridViewTextBoxColumn.HeaderText = "Протяжённость береговой линии(км)";
            this.протяжённостьБереговойЛиниикмDataGridViewTextBoxColumn.Name = "протяжённостьБереговойЛиниикмDataGridViewTextBoxColumn";
            // 
            // средняяГлубинакмDataGridViewTextBoxColumn
            // 
            this.средняяГлубинакмDataGridViewTextBoxColumn.DataPropertyName = "Средняя глубина(км)";
            this.средняяГлубинакмDataGridViewTextBoxColumn.HeaderText = "Средняя глубина(км)";
            this.средняяГлубинакмDataGridViewTextBoxColumn.Name = "средняяГлубинакмDataGridViewTextBoxColumn";
            // 
            // максимальнаяГлубинакмDataGridViewTextBoxColumn
            // 
            this.максимальнаяГлубинакмDataGridViewTextBoxColumn.DataPropertyName = "Максимальная глубина(км)";
            this.максимальнаяГлубинакмDataGridViewTextBoxColumn.HeaderText = "Максимальная глубина(км)";
            this.максимальнаяГлубинакмDataGridViewTextBoxColumn.Name = "максимальнаяГлубинакмDataGridViewTextBoxColumn";
            // 
            // заметкиDataGridViewTextBoxColumn
            // 
            this.заметкиDataGridViewTextBoxColumn.DataPropertyName = "Заметки";
            this.заметкиDataGridViewTextBoxColumn.HeaderText = "Заметки";
            this.заметкиDataGridViewTextBoxColumn.Name = "заметкиDataGridViewTextBoxColumn";
            // 
            // seasBindingSource
            // 
            this.seasBindingSource.DataMember = "Seas";
            this.seasBindingSource.DataSource = this.geoDataSet;
            // 
            // geoDataSet
            // 
            this.geoDataSet.DataSetName = "GeoDataSet";
            this.geoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNotes.Location = new System.Drawing.Point(70, 96);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(900, 36);
            this.textBoxNotes.TabIndex = 15;
            // 
            // textBoxMiddleDepth
            // 
            this.textBoxMiddleDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleDepth.Location = new System.Drawing.Point(492, 64);
            this.textBoxMiddleDepth.Name = "textBoxMiddleDepth";
            this.textBoxMiddleDepth.Size = new System.Drawing.Size(123, 20);
            this.textBoxMiddleDepth.TabIndex = 14;
            // 
            // textBoxLengthOfCoastline
            // 
            this.textBoxLengthOfCoastline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLengthOfCoastline.Location = new System.Drawing.Point(215, 63);
            this.textBoxLengthOfCoastline.Name = "textBoxLengthOfCoastline";
            this.textBoxLengthOfCoastline.Size = new System.Drawing.Size(123, 20);
            this.textBoxLengthOfCoastline.TabIndex = 13;
            // 
            // textBoxCubic
            // 
            this.textBoxCubic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCubic.Location = new System.Drawing.Point(716, 31);
            this.textBoxCubic.Name = "textBoxCubic";
            this.textBoxCubic.Size = new System.Drawing.Size(123, 20);
            this.textBoxCubic.TabIndex = 12;
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSquare.Location = new System.Drawing.Point(454, 31);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.Size = new System.Drawing.Size(123, 20);
            this.textBoxSquare.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(76, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotes.Location = new System.Drawing.Point(6, 96);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(58, 15);
            this.labelNotes.TabIndex = 9;
            this.labelNotes.Text = "Заметки";
            // 
            // groupBoxSeas
            // 
            this.groupBoxSeas.Controls.Add(this.textBoxMaxDepth);
            this.groupBoxSeas.Controls.Add(this.labelMaxDepth);
            this.groupBoxSeas.Controls.Add(this.textBoxNotes);
            this.groupBoxSeas.Controls.Add(this.textBoxMiddleDepth);
            this.groupBoxSeas.Controls.Add(this.textBoxLengthOfCoastline);
            this.groupBoxSeas.Controls.Add(this.textBoxCubic);
            this.groupBoxSeas.Controls.Add(this.textBoxSquare);
            this.groupBoxSeas.Controls.Add(this.textBoxName);
            this.groupBoxSeas.Controls.Add(this.labelNotes);
            this.groupBoxSeas.Controls.Add(this.labelMiddleDepth);
            this.groupBoxSeas.Controls.Add(this.labelLengthOfCoastline);
            this.groupBoxSeas.Controls.Add(this.labelCubic);
            this.groupBoxSeas.Controls.Add(this.labelSquare);
            this.groupBoxSeas.Controls.Add(this.labelName);
            this.groupBoxSeas.Enabled = false;
            this.groupBoxSeas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSeas.Location = new System.Drawing.Point(12, 68);
            this.groupBoxSeas.Name = "groupBoxSeas";
            this.groupBoxSeas.Size = new System.Drawing.Size(976, 143);
            this.groupBoxSeas.TabIndex = 2;
            this.groupBoxSeas.TabStop = false;
            this.groupBoxSeas.Text = "Моря";
            // 
            // textBoxMaxDepth
            // 
            this.textBoxMaxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxDepth.Location = new System.Drawing.Point(807, 65);
            this.textBoxMaxDepth.Name = "textBoxMaxDepth";
            this.textBoxMaxDepth.Size = new System.Drawing.Size(123, 20);
            this.textBoxMaxDepth.TabIndex = 17;
            // 
            // labelMaxDepth
            // 
            this.labelMaxDepth.AutoSize = true;
            this.labelMaxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxDepth.Location = new System.Drawing.Point(658, 66);
            this.labelMaxDepth.Name = "labelMaxDepth";
            this.labelMaxDepth.Size = new System.Drawing.Size(143, 15);
            this.labelMaxDepth.TabIndex = 16;
            this.labelMaxDepth.Text = "Максимальная глубина";
            // 
            // labelMiddleDepth
            // 
            this.labelMiddleDepth.AutoSize = true;
            this.labelMiddleDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleDepth.Location = new System.Drawing.Point(381, 65);
            this.labelMiddleDepth.Name = "labelMiddleDepth";
            this.labelMiddleDepth.Size = new System.Drawing.Size(105, 15);
            this.labelMiddleDepth.TabIndex = 8;
            this.labelMiddleDepth.Text = "Средняя глубина";
            // 
            // labelLengthOfCoastline
            // 
            this.labelLengthOfCoastline.AutoSize = true;
            this.labelLengthOfCoastline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthOfCoastline.Location = new System.Drawing.Point(6, 64);
            this.labelLengthOfCoastline.Name = "labelLengthOfCoastline";
            this.labelLengthOfCoastline.Size = new System.Drawing.Size(203, 15);
            this.labelLengthOfCoastline.TabIndex = 7;
            this.labelLengthOfCoastline.Text = "Протяжённость береговой линии";
            // 
            // labelCubic
            // 
            this.labelCubic.AutoSize = true;
            this.labelCubic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCubic.Location = new System.Drawing.Point(664, 31);
            this.labelCubic.Name = "labelCubic";
            this.labelCubic.Size = new System.Drawing.Size(46, 15);
            this.labelCubic.TabIndex = 6;
            this.labelCubic.Text = "Объём";
            // 
            // labelSquare
            // 
            this.labelSquare.AutoSize = true;
            this.labelSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSquare.Location = new System.Drawing.Point(388, 31);
            this.labelSquare.Name = "labelSquare";
            this.labelSquare.Size = new System.Drawing.Size(60, 15);
            this.labelSquare.TabIndex = 5;
            this.labelSquare.Text = "Площадь";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(6, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Название";
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(703, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(91, 50);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(897, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(91, 50);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(206, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 50);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(109, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 50);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 50);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // seasTableAdapter
            // 
            this.seasTableAdapter.ClearBeforeFill = true;
            // 
            // button_Roll_up
            // 
            this.button_Roll_up.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Roll_up.FlatAppearance.BorderSize = 2;
            this.button_Roll_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Roll_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Roll_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Roll_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Roll_up.Location = new System.Drawing.Point(800, 12);
            this.button_Roll_up.Name = "button_Roll_up";
            this.button_Roll_up.Size = new System.Drawing.Size(91, 50);
            this.button_Roll_up.TabIndex = 24;
            this.button_Roll_up.Text = "Свернуть";
            this.button_Roll_up.UseVisualStyleBackColor = true;
            this.button_Roll_up.Click += new System.EventHandler(this.button_Roll_up_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearch.Location = new System.Drawing.Point(327, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(337, 50);
            this.groupBoxSearch.TabIndex = 25;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(6, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(244, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(257, 11);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 33);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormSeas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button_Roll_up);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxSeas);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSeas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeas";
            this.Load += new System.EventHandler(this.FormSeas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSet)).EndInit();
            this.groupBoxSeas.ResumeLayout(false);
            this.groupBoxSeas.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxMiddleDepth;
        private System.Windows.Forms.TextBox textBoxLengthOfCoastline;
        private System.Windows.Forms.TextBox textBoxCubic;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.GroupBox groupBoxSeas;
        private System.Windows.Forms.Label labelMiddleDepth;
        private System.Windows.Forms.Label labelLengthOfCoastline;
        private System.Windows.Forms.Label labelCubic;
        private System.Windows.Forms.Label labelSquare;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxMaxDepth;
        private System.Windows.Forms.Label labelMaxDepth;
        private GeoDataSet geoDataSet;
        private System.Windows.Forms.BindingSource seasBindingSource;
        private GeoDataSetTableAdapters.SeasTableAdapter seasTableAdapter;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button_Roll_up;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадькмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объёмкмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn протяжённостьБереговойЛиниикмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn средняяГлубинакмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn максимальнаяГлубинакмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заметкиDataGridViewTextBoxColumn;
    }
}