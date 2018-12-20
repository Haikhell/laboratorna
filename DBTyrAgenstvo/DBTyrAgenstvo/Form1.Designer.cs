namespace DBTyrAgenstvo
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tyrAgenstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.putivkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tyristToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakladToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zvitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zvitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tyristToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTyristToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTyristToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DBTyrAgenstvo.DataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem,
            this.comandsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.commandUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tyrAgenstvoToolStripMenuItem,
            this.moneyToolStripMenuItem,
            this.putivkaToolStripMenuItem,
            this.resultToolStripMenuItem,
            this.tyristToolStripMenuItem,
            this.zakladToolStripMenuItem,
            this.zvitToolStripMenuItem});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.tableToolStripMenuItem.Text = "table";
            // 
            // tyrAgenstvoToolStripMenuItem
            // 
            this.tyrAgenstvoToolStripMenuItem.Name = "tyrAgenstvoToolStripMenuItem";
            this.tyrAgenstvoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tyrAgenstvoToolStripMenuItem.Text = "Tyr Agenstvo";
            this.tyrAgenstvoToolStripMenuItem.Click += new System.EventHandler(this.tyrAgenstvoToolStripMenuItem_Click);
            // 
            // moneyToolStripMenuItem
            // 
            this.moneyToolStripMenuItem.Name = "moneyToolStripMenuItem";
            this.moneyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.moneyToolStripMenuItem.Text = "Money";
            this.moneyToolStripMenuItem.Click += new System.EventHandler(this.moneyToolStripMenuItem_Click);
            // 
            // putivkaToolStripMenuItem
            // 
            this.putivkaToolStripMenuItem.Name = "putivkaToolStripMenuItem";
            this.putivkaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.putivkaToolStripMenuItem.Text = "Putivka";
            this.putivkaToolStripMenuItem.Click += new System.EventHandler(this.putivkaToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.resultToolStripMenuItem.Text = "Result";
            this.resultToolStripMenuItem.Click += new System.EventHandler(this.resultToolStripMenuItem_Click);
            // 
            // tyristToolStripMenuItem
            // 
            this.tyristToolStripMenuItem.Name = "tyristToolStripMenuItem";
            this.tyristToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tyristToolStripMenuItem.Text = "Tyrist";
            this.tyristToolStripMenuItem.Click += new System.EventHandler(this.tyristToolStripMenuItem_Click);
            // 
            // zakladToolStripMenuItem
            // 
            this.zakladToolStripMenuItem.Name = "zakladToolStripMenuItem";
            this.zakladToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.zakladToolStripMenuItem.Text = "Zaklad";
            this.zakladToolStripMenuItem.Click += new System.EventHandler(this.zakladToolStripMenuItem_Click);
            // 
            // zvitToolStripMenuItem
            // 
            this.zvitToolStripMenuItem.Name = "zvitToolStripMenuItem";
            this.zvitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.zvitToolStripMenuItem.Text = "Zvit";
            this.zvitToolStripMenuItem.Click += new System.EventHandler(this.zvitToolStripMenuItem_Click);
            // 
            // comandsToolStripMenuItem
            // 
            this.comandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.correctToolStripMenuItem});
            this.comandsToolStripMenuItem.Name = "comandsToolStripMenuItem";
            this.comandsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.comandsToolStripMenuItem.Text = "Comands";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addToolStripMenuItem.Text = "Add Tyr Agent";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // correctToolStripMenuItem
            // 
            this.correctToolStripMenuItem.Name = "correctToolStripMenuItem";
            this.correctToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.correctToolStripMenuItem.Text = "Correct";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zvitToolStripMenuItem1,
            this.tyristToolStripMenuItem1});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // zvitToolStripMenuItem1
            // 
            this.zvitToolStripMenuItem1.Name = "zvitToolStripMenuItem1";
            this.zvitToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.zvitToolStripMenuItem1.Text = "Zvit";
            this.zvitToolStripMenuItem1.Click += new System.EventHandler(this.zvitToolStripMenuItem1_Click);
            // 
            // tyristToolStripMenuItem1
            // 
            this.tyristToolStripMenuItem1.Name = "tyristToolStripMenuItem1";
            this.tyristToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.tyristToolStripMenuItem1.Text = "Tyrist";
            this.tyristToolStripMenuItem1.Click += new System.EventHandler(this.tyristToolStripMenuItem1_Click);
            // 
            // commandUsersToolStripMenuItem
            // 
            this.commandUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTyristToolStripMenuItem,
            this.deleteTyristToolStripMenuItem});
            this.commandUsersToolStripMenuItem.Name = "commandUsersToolStripMenuItem";
            this.commandUsersToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.commandUsersToolStripMenuItem.Text = "Command Users";
            // 
            // addTyristToolStripMenuItem
            // 
            this.addTyristToolStripMenuItem.Name = "addTyristToolStripMenuItem";
            this.addTyristToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addTyristToolStripMenuItem.Text = "Add tyrist";
            this.addTyristToolStripMenuItem.Click += new System.EventHandler(this.addTyristToolStripMenuItem_Click);
            // 
            // deleteTyristToolStripMenuItem
            // 
            this.deleteTyristToolStripMenuItem.Name = "deleteTyristToolStripMenuItem";
            this.deleteTyristToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteTyristToolStripMenuItem.Text = "Delete tyrist";
            this.deleteTyristToolStripMenuItem.Click += new System.EventHandler(this.deleteTyristToolStripMenuItem_Click);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tyrAgenstvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem putivkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tyristToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakladToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zvitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zvitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tyristToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commandUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTyristToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTyristToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

