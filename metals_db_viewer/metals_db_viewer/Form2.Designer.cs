namespace metals_db_viewer
{
    partial class Form2
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
            this.dataGridView_phys_mech_prop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_sources = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_properties_2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_sources_2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phys_mech_prop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_properties_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sources_2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_phys_mech_prop
            // 
            this.dataGridView_phys_mech_prop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_phys_mech_prop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phys_mech_prop.Location = new System.Drawing.Point(16, 44);
            this.dataGridView_phys_mech_prop.Name = "dataGridView_phys_mech_prop";
            this.dataGridView_phys_mech_prop.RowHeadersWidth = 51;
            this.dataGridView_phys_mech_prop.RowTemplate.Height = 24;
            this.dataGridView_phys_mech_prop.Size = new System.Drawing.Size(1524, 205);
            this.dataGridView_phys_mech_prop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dataGridView_sources
            // 
            this.dataGridView_sources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sources.Location = new System.Drawing.Point(16, 277);
            this.dataGridView_sources.Name = "dataGridView_sources";
            this.dataGridView_sources.RowHeadersWidth = 51;
            this.dataGridView_sources.RowTemplate.Height = 24;
            this.dataGridView_sources.Size = new System.Drawing.Size(1524, 146);
            this.dataGridView_sources.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Источник данных";
            // 
            // dataGridView_properties_2
            // 
            this.dataGridView_properties_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_properties_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_properties_2.Location = new System.Drawing.Point(16, 445);
            this.dataGridView_properties_2.Name = "dataGridView_properties_2";
            this.dataGridView_properties_2.RowHeadersWidth = 51;
            this.dataGridView_properties_2.RowTemplate.Height = 24;
            this.dataGridView_properties_2.Size = new System.Drawing.Size(1524, 150);
            this.dataGridView_properties_2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Характеристика Zt длительной прочности и пластичности";
            // 
            // dataGridView_sources_2
            // 
            this.dataGridView_sources_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sources_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sources_2.Location = new System.Drawing.Point(16, 620);
            this.dataGridView_sources_2.Name = "dataGridView_sources_2";
            this.dataGridView_sources_2.RowHeadersWidth = 51;
            this.dataGridView_sources_2.RowTemplate.Height = 24;
            this.dataGridView_sources_2.Size = new System.Drawing.Size(1524, 150);
            this.dataGridView_sources_2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Источник данных";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 782);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_sources_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_properties_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_sources);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_phys_mech_prop);
            this.Name = "Form2";
            this.Text = "Properties viewer";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phys_mech_prop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_properties_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sources_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_phys_mech_prop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_sources;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_properties_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_sources_2;
        private System.Windows.Forms.Label label4;
    }
}