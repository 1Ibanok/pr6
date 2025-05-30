namespace PR6
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            salesList = new FlowLayoutPanel();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            back = new Button();
            SuspendLayout();
            // 
            // salesList
            // 
            salesList.AutoScroll = true;
            salesList.Location = new Point(14, 16);
            salesList.Margin = new Padding(3, 4, 3, 4);
            salesList.Name = "salesList";
            salesList.Size = new Size(600, 304);
            salesList.TabIndex = 0;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(1, 142, 196);
            back.Font = new Font("Segoe UI", 9F);
            back.ForeColor = Color.White;
            back.Location = new Point(465, 327);
            back.Name = "back";
            back.Size = new Size(149, 32);
            back.TabIndex = 7;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(627, 368);
            Controls.Add(back);
            Controls.Add(salesList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "SalesForm";
            Text = "SalesForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel salesList;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button back;
    }
}