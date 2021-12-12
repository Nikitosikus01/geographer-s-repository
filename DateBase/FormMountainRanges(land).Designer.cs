
namespace DateBase
{
    partial class FormMountainRanges_land_
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.протяжённостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.высшаяТочкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.высотаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заметкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mountainrangeslandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geoDataSet = new DateBase.GeoDataSet();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.textBoxHight = new System.Windows.Forms.TextBox();
            this.textBoxHightPointName = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelHight = new System.Windows.Forms.Label();
            this.labelHightPointName = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxMRLand = new System.Windows.Forms.GroupBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.mountain_ranges_land_TableAdapter = new DateBase.GeoDataSetTableAdapters.Mountain_ranges_land_TableAdapter();
            this.button_Roll_up = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountainrangeslandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSet)).BeginInit();
            this.groupBoxMRLand.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(97, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(356, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(8, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Название";
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
            this.протяжённостьDataGridViewTextBoxColumn,
            this.высшаяТочкаDataGridViewTextBoxColumn,
            this.высотаDataGridViewTextBoxColumn,
            this.заметкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mountainrangeslandBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 344);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // протяжённостьDataGridViewTextBoxColumn
            // 
            this.протяжённостьDataGridViewTextBoxColumn.DataPropertyName = "Протяжённость";
            this.протяжённостьDataGridViewTextBoxColumn.HeaderText = "Протяжённость";
            this.протяжённостьDataGridViewTextBoxColumn.Name = "протяжённостьDataGridViewTextBoxColumn";
            // 
            // высшаяТочкаDataGridViewTextBoxColumn
            // 
            this.высшаяТочкаDataGridViewTextBoxColumn.DataPropertyName = "Высшая точка";
            this.высшаяТочкаDataGridViewTextBoxColumn.HeaderText = "Высшая точка";
            this.высшаяТочкаDataGridViewTextBoxColumn.Name = "высшаяТочкаDataGridViewTextBoxColumn";
            // 
            // высотаDataGridViewTextBoxColumn
            // 
            this.высотаDataGridViewTextBoxColumn.DataPropertyName = "Высота";
            this.высотаDataGridViewTextBoxColumn.HeaderText = "Высота";
            this.высотаDataGridViewTextBoxColumn.Name = "высотаDataGridViewTextBoxColumn";
            // 
            // заметкиDataGridViewTextBoxColumn
            // 
            this.заметкиDataGridViewTextBoxColumn.DataPropertyName = "Заметки";
            this.заметкиDataGridViewTextBoxColumn.HeaderText = "Заметки";
            this.заметкиDataGridViewTextBoxColumn.Name = "заметкиDataGridViewTextBoxColumn";
            // 
            // mountainrangeslandBindingSource
            // 
            this.mountainrangeslandBindingSource.DataMember = "Mountain_ranges(land)";
            this.mountainrangeslandBindingSource.DataSource = this.geoDataSetBindingSource;
            // 
            // geoDataSetBindingSource
            // 
            this.geoDataSetBindingSource.DataSource = this.geoDataSet;
            this.geoDataSetBindingSource.Position = 0;
            // 
            // geoDataSet
            // 
            this.geoDataSet.DataSetName = "GeoDataSet";
            this.geoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNotes.Location = new System.Drawing.Point(84, 110);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(815, 36);
            this.textBoxNotes.TabIndex = 15;
            // 
            // textBoxHight
            // 
            this.textBoxHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHight.Location = new System.Drawing.Point(698, 73);
            this.textBoxHight.Name = "textBoxHight";
            this.textBoxHight.Size = new System.Drawing.Size(147, 20);
            this.textBoxHight.TabIndex = 14;
            // 
            // textBoxHightPointName
            // 
            this.textBoxHightPointName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHightPointName.Location = new System.Drawing.Point(184, 74);
            this.textBoxHightPointName.Name = "textBoxHightPointName";
            this.textBoxHightPointName.Size = new System.Drawing.Size(356, 20);
            this.textBoxHightPointName.TabIndex = 13;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLength.Location = new System.Drawing.Point(652, 39);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(147, 20);
            this.textBoxLength.TabIndex = 11;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotes.Location = new System.Drawing.Point(8, 111);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(58, 15);
            this.labelNotes.TabIndex = 9;
            this.labelNotes.Text = "Заметки";
            // 
            // labelHight
            // 
            this.labelHight.AutoSize = true;
            this.labelHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHight.Location = new System.Drawing.Point(619, 75);
            this.labelHight.Name = "labelHight";
            this.labelHight.Size = new System.Drawing.Size(51, 15);
            this.labelHight.TabIndex = 8;
            this.labelHight.Text = "Высота";
            // 
            // labelHightPointName
            // 
            this.labelHightPointName.AutoSize = true;
            this.labelHightPointName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHightPointName.Location = new System.Drawing.Point(8, 75);
            this.labelHightPointName.Name = "labelHightPointName";
            this.labelHightPointName.Size = new System.Drawing.Size(148, 15);
            this.labelHightPointName.TabIndex = 7;
            this.labelHightPointName.Text = "Название высшей точки";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.Location = new System.Drawing.Point(526, 39);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(101, 15);
            this.labelLength.TabIndex = 5;
            this.labelLength.Text = "Протяжённость";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(476, 136);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 24);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
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
            this.buttonDelete.Size = new System.Drawing.Size(91, 48);
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
            this.buttonSave.Size = new System.Drawing.Size(91, 48);
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
            this.buttonAdd.Size = new System.Drawing.Size(91, 48);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxMRLand
            // 
            this.groupBoxMRLand.Controls.Add(this.textBoxNotes);
            this.groupBoxMRLand.Controls.Add(this.textBoxHight);
            this.groupBoxMRLand.Controls.Add(this.textBoxHightPointName);
            this.groupBoxMRLand.Controls.Add(this.textBoxLength);
            this.groupBoxMRLand.Controls.Add(this.textBoxName);
            this.groupBoxMRLand.Controls.Add(this.labelNotes);
            this.groupBoxMRLand.Controls.Add(this.labelHight);
            this.groupBoxMRLand.Controls.Add(this.labelHightPointName);
            this.groupBoxMRLand.Controls.Add(this.labelLength);
            this.groupBoxMRLand.Controls.Add(this.labelName);
            this.groupBoxMRLand.Enabled = false;
            this.groupBoxMRLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMRLand.Location = new System.Drawing.Point(12, 68);
            this.groupBoxMRLand.Name = "groupBoxMRLand";
            this.groupBoxMRLand.Size = new System.Drawing.Size(976, 151);
            this.groupBoxMRLand.TabIndex = 4;
            this.groupBoxMRLand.TabStop = false;
            this.groupBoxMRLand.Text = "Горные хребты на суше";
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(712, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(88, 48);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // mountain_ranges_land_TableAdapter
            // 
            this.mountain_ranges_land_TableAdapter.ClearBeforeFill = true;
            // 
            // button_Roll_up
            // 
            this.button_Roll_up.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Roll_up.FlatAppearance.BorderSize = 2;
            this.button_Roll_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Roll_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Roll_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Roll_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Roll_up.Location = new System.Drawing.Point(806, 12);
            this.button_Roll_up.Name = "button_Roll_up";
            this.button_Roll_up.Size = new System.Drawing.Size(88, 48);
            this.button_Roll_up.TabIndex = 22;
            this.button_Roll_up.Text = "Свернуть";
            this.button_Roll_up.UseVisualStyleBackColor = true;
            this.button_Roll_up.Click += new System.EventHandler(this.button_Roll_up_Click);
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Close.FlatAppearance.BorderSize = 2;
            this.button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.Location = new System.Drawing.Point(900, 12);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(88, 48);
            this.button_Close.TabIndex = 23;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearch.Location = new System.Drawing.Point(328, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(349, 48);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(6, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(244, 20);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(258, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(85, 31);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormMountainRanges_land_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button_Roll_up);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxMRLand);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMountainRanges_land_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMountainRanges_land_";
            this.Load += new System.EventHandler(this.FormMountainRanges_land__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountainrangeslandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSet)).EndInit();
            this.groupBoxMRLand.ResumeLayout(false);
            this.groupBoxMRLand.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxHight;
        private System.Windows.Forms.TextBox textBoxHightPointName;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelHight;
        private System.Windows.Forms.Label labelHightPointName;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxMRLand;
        private System.Windows.Forms.BindingSource geoDataSetBindingSource;
        private GeoDataSet geoDataSet;
        private System.Windows.Forms.BindingSource mountainrangeslandBindingSource;
        private GeoDataSetTableAdapters.Mountain_ranges_land_TableAdapter mountain_ranges_land_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn протяжённостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn высшаяТочкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn высотаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заметкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button_Roll_up;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}