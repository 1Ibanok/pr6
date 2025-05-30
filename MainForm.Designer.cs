using System.Drawing;

namespace PR6
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            saveBtn = new Button();
            pictureBoxLogo = new PictureBox();
            sales = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Font = new Font("Segoe UI", 9F);
            dataGridView1.Location = new Point(13, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(897, 339);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(194, 195, 195);
            comboBox1.Font = new Font("Times New Roman", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(916, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 24);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(916, 11);
            label1.Name = "label1";
            label1.Size = new Size(115, 16);
            label1.TabIndex = 2;
            label1.Text = "Выберите таблицу:";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(1, 142, 196);
            saveBtn.Font = new Font("Times New Roman", 10.2F);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(916, 66);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(168, 30);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Сохранить";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(916, 138);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(84, 64);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 5;
            pictureBoxLogo.TabStop = false;
            // 
            // sales
            // 
            sales.BackColor = Color.FromArgb(1, 142, 196);
            sales.Font = new Font("Times New Roman", 10.2F);
            sales.ForeColor = Color.White;
            sales.Location = new Point(916, 102);
            sales.Name = "sales";
            sales.Size = new Size(168, 30);
            sales.TabIndex = 6;
            sales.Text = "Скидки";
            sales.UseVisualStyleBackColor = false;
            sales.Click += sales_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1095, 366);
            Controls.Add(sales);
            Controls.Add(pictureBoxLogo);
            Controls.Add(saveBtn);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 10.2F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Button sales;
    }
}
