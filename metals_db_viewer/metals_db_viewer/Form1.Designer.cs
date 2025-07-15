namespace metals_db_viewer
{
    partial class Form1
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
            this.dataGridView_materials = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_materials)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_materials
            // 
            this.dataGridView_materials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_materials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_materials.Location = new System.Drawing.Point(13, 50);
            this.dataGridView_materials.Name = "dataGridView_materials";
            this.dataGridView_materials.ReadOnly = true;
            this.dataGridView_materials.RowHeadersWidth = 51;
            this.dataGridView_materials.RowTemplate.Height = 24;
            this.dataGridView_materials.Size = new System.Drawing.Size(970, 206);
            this.dataGridView_materials.TabIndex = 0;
            this.dataGridView_materials.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_materials_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Нажмите дважды на материал, чтобы вывести его свойства";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_materials);
            this.Name = "Form1";
            this.Text = "Metals viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_materials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_materials;
        private System.Windows.Forms.Label label1;
    }
}

