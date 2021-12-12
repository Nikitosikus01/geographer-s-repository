
namespace DateBase
{
    partial class FormVolcanoes
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
            this.высотаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадькмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.последнееИзвержениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заметкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volcanoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geoDataSet = new DateBase.GeoDataSet();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.textBoxLastActivated = new System.Windows.Forms.TextBox();
            this.textBoxHight = new System.Windows.Forms.TextBox();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelLastActivated = new System.Windows.Forms.Label();
            this.labelHight = new System.Windows.Forms.Label();
            this.labelSquare = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxVolcanoes = new System.Windows.Forms.GroupBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.volcanoesTableAdapter = new DateBase.GeoDataSetTableAdapters.VolcanoesTableAdapter();
            this.button_Roll_up = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volcanoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSet)).BeginInit();
            this.groupBoxVolcanoes.SuspendLayout();
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
            this.высотаDataGridViewTextBoxColumn,
            this.площадькмDataGridViewTextBoxColumn,
            this.последнееИзвержениеDataGridViewTextBoxColumn,
            this.заметкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.volcanoesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 365);
            this.dataGridView1.TabIndex = 3;
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
            // высотаDataGridViewTextBoxColumn
            // 
            this.высотаDataGridViewTextBoxColumn.DataPropertyName = "Высота";
            this.высотаDataGridViewTextBoxColumn.HeaderText = "Высота";
            this.высотаDataGridViewTextBoxColumn.Name = "высотаDataGridViewTextBoxColumn";
            // 
            // площадькмDataGridViewTextBoxColumn
            // 
            this.площадькмDataGridViewTextBoxColumn.DataPropertyName = "Площадь(км)";
            this.площадькмDataGridViewTextBoxColumn.HeaderText = "Площадь(км)";
            this.площадькмDataGridViewTextBoxColumn.Name = "площадькмDataGridViewTextBoxColumn";
            // 
            // последнееИзвержениеDataGridViewTextBoxColumn
            // 
            this.последнееИзвержениеDataGridViewTextBoxColumn.DataPropertyName = "Последнее извержение";
            this.последнееИзвержениеDataGridViewTextBoxColumn.HeaderText = "Последнее извержение";
            this.последнееИзвержениеDataGridViewTextBoxColumn.Name = "последнееИзвержениеDataGridViewTextBoxColumn";
            // 
            // заметкиDataGridViewTextBoxColumn
            // 
            this.заметкиDataGridViewTextBoxColumn.DataPropertyName = "Заметки";
            this.заметкиDataGridViewTextBoxColumn.HeaderText = "Заметки";
            this.заметкиDataGridViewTextBoxColumn.Name = "заметкиDataGridViewTextBoxColumn";
            // 
            // volcanoesBindingSource
            // 
            this.volcanoesBindingSource.DataMember = "Volcanoes";
            this.volcanoesBindingSource.DataSource = this.geoDataSetBindingSource;
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
            this.textBoxNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.volcanoesBindingSource, "Заметки", true));
            this.textBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNotes.Location = new System.Drawing.Point(70, 100);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(900, 36);
            this.textBoxNotes.TabIndex = 15;
            // 
            // textBoxLastActivated
            // 
            this.textBoxLastActivated.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.volcanoesBindingSource, "Последнее извержение", true));
            this.textBoxLastActivated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastActivated.Location = new System.Drawing.Point(157, 63);
            this.textBoxLastActivated.Name = "textBoxLastActivated";
            this.textBoxLastActivated.Size = new System.Drawing.Size(139, 20);
            this.textBoxLastActivated.TabIndex = 13;
            // 
            // textBoxHight
            // 
            this.textBoxHight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.volcanoesBindingSource, "Высота", true));
            this.textBoxHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHight.Location = new System.Drawing.Point(503, 30);
            this.textBoxHight.Name = "textBoxHight";
            this.textBoxHight.Size = new System.Drawing.Size(139, 20);
            this.textBoxHight.TabIndex = 12;
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.volcanoesBindingSource, "Площадь(км)", true));
            this.textBoxSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSquare.Location = new System.Drawing.Point(742, 31);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.Size = new System.Drawing.Size(139, 20);
            this.textBoxSquare.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.AcceptsTab = true;
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.volcanoesBindingSource, "Название", true));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(76, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(329, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotes.Location = new System.Drawing.Point(6, 100);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(58, 15);
            this.labelNotes.TabIndex = 9;
            this.labelNotes.Text = "Заметки";
            // 
            // labelLastActivated
            // 
            this.labelLastActivated.AutoSize = true;
            this.labelLastActivated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastActivated.Location = new System.Drawing.Point(6, 64);
            this.labelLastActivated.Name = "labelLastActivated";
            this.labelLastActivated.Size = new System.Drawing.Size(145, 15);
            this.labelLastActivated.TabIndex = 7;
            this.labelLastActivated.Text = "Последнее извержение";
            // 
            // labelHight
            // 
            this.labelHight.AutoSize = true;
            this.labelHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHight.Location = new System.Drawing.Point(446, 30);
            this.labelHight.Name = "labelHight";
            this.labelHight.Size = new System.Drawing.Size(51, 15);
            this.labelHight.TabIndex = 6;
            this.labelHight.Text = "Высота";
            // 
            // labelSquare
            // 
            this.labelSquare.AutoSize = true;
            this.labelSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSquare.Location = new System.Drawing.Point(676, 31);
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
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
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
            this.buttonDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
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
            this.buttonSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
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
            this.buttonAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
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
            // groupBoxVolcanoes
            // 
            this.groupBoxVolcanoes.Controls.Add(this.textBoxNotes);
            this.groupBoxVolcanoes.Controls.Add(this.textBoxLastActivated);
            this.groupBoxVolcanoes.Controls.Add(this.textBoxHight);
            this.groupBoxVolcanoes.Controls.Add(this.textBoxSquare);
            this.groupBoxVolcanoes.Controls.Add(this.textBoxName);
            this.groupBoxVolcanoes.Controls.Add(this.labelNotes);
            this.groupBoxVolcanoes.Controls.Add(this.labelLastActivated);
            this.groupBoxVolcanoes.Controls.Add(this.labelHight);
            this.groupBoxVolcanoes.Controls.Add(this.labelSquare);
            this.groupBoxVolcanoes.Controls.Add(this.labelName);
            this.groupBoxVolcanoes.Enabled = false;
            this.groupBoxVolcanoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxVolcanoes.Location = new System.Drawing.Point(12, 68);
            this.groupBoxVolcanoes.Name = "groupBoxVolcanoes";
            this.groupBoxVolcanoes.Size = new System.Drawing.Size(976, 149);
            this.groupBoxVolcanoes.TabIndex = 2;
            this.groupBoxVolcanoes.TabStop = false;
            this.groupBoxVolcanoes.Text = "Вулканы";
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(703, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(91, 50);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // volcanoesTableAdapter
            // 
            this.volcanoesTableAdapter.ClearBeforeFill = true;
            // 
            // button_Roll_up
            // 
            this.button_Roll_up.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Roll_up.FlatAppearance.BorderSize = 2;
            this.button_Roll_up.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.button_Roll_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Roll_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Roll_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Roll_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Roll_up.Location = new System.Drawing.Point(800, 12);
            this.button_Roll_up.Name = "button_Roll_up";
            this.button_Roll_up.Size = new System.Drawing.Size(91, 50);
            this.button_Roll_up.TabIndex = 22;
            this.button_Roll_up.Text = "Свернуть";
            this.button_Roll_up.UseVisualStyleBackColor = true;
            this.button_Roll_up.Click += new System.EventHandler(this.button_Roll_up_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearch.Location = new System.Drawing.Point(329, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(337, 50);
            this.groupBoxSearch.TabIndex = 23;
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
            this.buttonSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
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
            // FormVolcanoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button_Roll_up);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxVolcanoes);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVolcanoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVolcanoes";
            this.Load += new System.EventHandler(this.FormVolcanoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volcanoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoDataSet)).EndInit();
            this.groupBoxVolcanoes.ResumeLayout(false);
            this.groupBoxVolcanoes.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxLastActivated;
        private System.Windows.Forms.TextBox textBoxHight;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelLastActivated;
        private System.Windows.Forms.Label labelHight;
        private System.Windows.Forms.Label labelSquare;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource geoDataSetBindingSource;
        private GeoDataSet geoDataSet;
        private System.Windows.Forms.BindingSource volcanoesBindingSource;
        private GeoDataSetTableAdapters.VolcanoesTableAdapter volcanoesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn высотаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадькмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn последнееИзвержениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заметкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button_Roll_up;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxVolcanoes;
    }
}