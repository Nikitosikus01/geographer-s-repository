
namespace DateBase
{
    partial class FormOceans
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxOceans = new System.Windows.Forms.GroupBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.oceansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geoDataSet = new DateBase.GeoDataSet();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.textBoxDepthPointName = new System.Windows.Forms.TextBox();
            this.textBoxCubic = new System.Windows.Forms.TextBox();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelDepthPointName = new System.Windows.Forms.Label();
            this.labelCubic = new System.Windows.Forms.Label();
            this.labelSquare = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.oceansTableAdapter = new DateBase.GeoDataSetTableAdapters.OceansTableAdapter();
            this.oceansBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадькмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объёмкмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеСамойГлубокойТочкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.глубинакмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заметкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Roll_up = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxOceans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oceansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceansBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOceans
            // 
            this.groupBoxOceans.Controls.Add(this.textBoxNotes);
            this.groupBoxOceans.Controls.Add(this.textBoxDepth);
            this.groupBoxOceans.Controls.Add(this.textBoxDepthPointName);
            this.groupBoxOceans.Controls.Add(this.textBoxCubic);
            this.groupBoxOceans.Controls.Add(this.textBoxSquare);
            this.groupBoxOceans.Controls.Add(this.textBoxName);
            this.groupBoxOceans.Controls.Add(this.labelNotes);
            this.groupBoxOceans.Controls.Add(this.labelDepth);
            this.groupBoxOceans.Controls.Add(this.labelDepthPointName);
            this.groupBoxOceans.Controls.Add(this.labelCubic);
            this.groupBoxOceans.Controls.Add(this.labelSquare);
            this.groupBoxOceans.Controls.Add(this.labelName);
            this.groupBoxOceans.Enabled = false;
            this.groupBoxOceans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOceans.Location = new System.Drawing.Point(12, 68);
            this.groupBoxOceans.Name = "groupBoxOceans";
            this.groupBoxOceans.Size = new System.Drawing.Size(976, 165);
            this.groupBoxOceans.TabIndex = 0;
            this.groupBoxOceans.TabStop = false;
            this.groupBoxOceans.Text = "Океаны";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oceansBindingSource, "Заметки", true));
            this.textBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNotes.Location = new System.Drawing.Point(70, 107);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(900, 45);
            this.textBoxNotes.TabIndex = 15;
            // 
            // oceansBindingSource
            // 
            this.oceansBindingSource.DataMember = "Oceans";
            this.oceansBindingSource.DataSource = this.geoDataSet;
            // 
            // geoDataSet
            // 
            this.geoDataSet.DataSetName = "GeoDataSet";
            this.geoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oceansBindingSource, "Глубина(км)", true));
            this.textBoxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDepth.Location = new System.Drawing.Point(621, 67);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(179, 20);
            this.textBoxDepth.TabIndex = 14;
            // 
            // textBoxDepthPointName
            // 
            this.textBoxDepthPointName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oceansBindingSource, "Название самой глубокой точки", true));
            this.textBoxDepthPointName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDepthPointName.Location = new System.Drawing.Point(205, 67);
            this.textBoxDepthPointName.Name = "textBoxDepthPointName";
            this.textBoxDepthPointName.Size = new System.Drawing.Size(317, 20);
            this.textBoxDepthPointName.TabIndex = 13;
            // 
            // textBoxCubic
            // 
            this.textBoxCubic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oceansBindingSource, "Объём(км)", true));
            this.textBoxCubic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCubic.Location = new System.Drawing.Point(791, 27);
            this.textBoxCubic.Name = "textBoxCubic";
            this.textBoxCubic.Size = new System.Drawing.Size(179, 20);
            this.textBoxCubic.TabIndex = 12;
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oceansBindingSource, "Площадь(км)", true));
            this.textBoxSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSquare.Location = new System.Drawing.Point(516, 27);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.Size = new System.Drawing.Size(179, 20);
            this.textBoxSquare.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oceansBindingSource, "Название", true));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(76, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(317, 20);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotes.Location = new System.Drawing.Point(6, 108);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(58, 15);
            this.labelNotes.TabIndex = 9;
            this.labelNotes.Text = "Заметки";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepth.Location = new System.Drawing.Point(561, 68);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(54, 15);
            this.labelDepth.TabIndex = 8;
            this.labelDepth.Text = "Глубина";
            // 
            // labelDepthPointName
            // 
            this.labelDepthPointName.AutoSize = true;
            this.labelDepthPointName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepthPointName.Location = new System.Drawing.Point(6, 68);
            this.labelDepthPointName.Name = "labelDepthPointName";
            this.labelDepthPointName.Size = new System.Drawing.Size(193, 15);
            this.labelDepthPointName.TabIndex = 7;
            this.labelDepthPointName.Text = "Название самой глубокой точки";
            // 
            // labelCubic
            // 
            this.labelCubic.AutoSize = true;
            this.labelCubic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCubic.Location = new System.Drawing.Point(739, 29);
            this.labelCubic.Name = "labelCubic";
            this.labelCubic.Size = new System.Drawing.Size(46, 15);
            this.labelCubic.TabIndex = 6;
            this.labelCubic.Text = "Объём";
            // 
            // labelSquare
            // 
            this.labelSquare.AutoSize = true;
            this.labelSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSquare.Location = new System.Drawing.Point(450, 29);
            this.labelSquare.Name = "labelSquare";
            this.labelSquare.Size = new System.Drawing.Size(60, 15);
            this.labelSquare.TabIndex = 5;
            this.labelSquare.Text = "Площадь";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(6, 29);
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
            this.buttonBack.TabIndex = 17;
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
            // oceansTableAdapter
            // 
            this.oceansTableAdapter.ClearBeforeFill = true;
            // 
            // oceansBindingSource1
            // 
            this.oceansBindingSource1.DataMember = "Oceans";
            this.oceansBindingSource1.DataSource = this.geoDataSet;
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
            this.названиеСамойГлубокойТочкиDataGridViewTextBoxColumn,
            this.глубинакмDataGridViewTextBoxColumn,
            this.заметкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oceansBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 339);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // названиеСамойГлубокойТочкиDataGridViewTextBoxColumn
            // 
            this.названиеСамойГлубокойТочкиDataGridViewTextBoxColumn.DataPropertyName = "Название самой глубокой точки";
            this.названиеСамойГлубокойТочкиDataGridViewTextBoxColumn.HeaderText = "Название самой глубокой точки";
            this.названиеСамойГлубокойТочкиDataGridViewTextBoxColumn.Name = "названиеСамойГлубокойТочкиDataGridViewTextBoxColumn";
            // 
            // глубинакмDataGridViewTextBoxColumn
            // 
            this.глубинакмDataGridViewTextBoxColumn.DataPropertyName = "Глубина(км)";
            this.глубинакмDataGridViewTextBoxColumn.HeaderText = "Глубина(км)";
            this.глубинакмDataGridViewTextBoxColumn.Name = "глубинакмDataGridViewTextBoxColumn";
            // 
            // заметкиDataGridViewTextBoxColumn
            // 
            this.заметкиDataGridViewTextBoxColumn.DataPropertyName = "Заметки";
            this.заметкиDataGridViewTextBoxColumn.HeaderText = "Заметки";
            this.заметкиDataGridViewTextBoxColumn.Name = "заметкиDataGridViewTextBoxColumn";
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
            this.button_Roll_up.TabIndex = 23;
            this.button_Roll_up.Text = "Свернуть";
            this.button_Roll_up.UseVisualStyleBackColor = true;
            this.button_Roll_up.Click += new System.EventHandler(this.button_Roll_up_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearch.Location = new System.Drawing.Point(331, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(337, 50);
            this.groupBoxSearch.TabIndex = 24;
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
            this.buttonSearch.Location = new System.Drawing.Point(257, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 32);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormOceans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button_Roll_up);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxOceans);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOceans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOceans";
            this.Load += new System.EventHandler(this.FormOceans_Load);
            this.groupBoxOceans.ResumeLayout(false);
            this.groupBoxOceans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oceansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oceansBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOceans;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.TextBox textBoxDepthPointName;
        private System.Windows.Forms.TextBox textBoxCubic;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelDepthPointName;
        private System.Windows.Forms.Label labelCubic;
        private System.Windows.Forms.Label labelSquare;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private GeoDataSet geoDataSet;
        private System.Windows.Forms.BindingSource oceansBindingSource;
        private GeoDataSetTableAdapters.OceansTableAdapter oceansTableAdapter;
        private System.Windows.Forms.BindingSource oceansBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button_Roll_up;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадькмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объёмкмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеСамойГлубокойТочкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn глубинакмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заметкиDataGridViewTextBoxColumn;
    }
}

