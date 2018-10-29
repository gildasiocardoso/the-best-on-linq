namespace MakingLinqEasyTheBestOnLinq
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tcScenario = new System.Windows.Forms.TabControl();
            this.tpArrayOfNumber = new System.Windows.Forms.TabPage();
            this.btnArrayOfNumberWhere = new System.Windows.Forms.Button();
            this.btnArrayOfNumberConcat = new System.Windows.Forms.Button();
            this.btnArrayOfNumberDescendingOrder = new System.Windows.Forms.Button();
            this.btnArrayOfNumberOrderby = new System.Windows.Forms.Button();
            this.btnArrayOfNumberSum = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtArrayOfNumber = new System.Windows.Forms.TextBox();
            this.tpArrayOfString = new System.Windows.Forms.TabPage();
            this.btnArrayOfStringStarstsWithEndsWith = new System.Windows.Forms.Button();
            this.btnArrayOfStringWhereOrderBy = new System.Windows.Forms.Button();
            this.btnArrayOfStringContainCaseInSentitive = new System.Windows.Forms.Button();
            this.btnArrayOfStringContain = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tpClassObject = new System.Windows.Forms.TabPage();
            this.btnClassObjCountry = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.carBrandDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcScenario.SuspendLayout();
            this.tpArrayOfNumber.SuspendLayout();
            this.tpArrayOfString.SuspendLayout();
            this.tpClassObject.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graphical representation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(402, 106);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "\r\nWhen you are working on LINQ the most important thing is to understand the diff" +
    "erences among IEnumerable, ICollection, IList, and IQueryable.\r\nKeep in mind the" +
    "se pictures.\r\n";
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResult.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(408, 366);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(392, 84);
            this.txtResult.TabIndex = 2;
            this.txtResult.TabStop = false;
            // 
            // tcScenario
            // 
            this.tcScenario.Controls.Add(this.tpArrayOfNumber);
            this.tcScenario.Controls.Add(this.tpArrayOfString);
            this.tcScenario.Controls.Add(this.tpClassObject);
            this.tcScenario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcScenario.Location = new System.Drawing.Point(408, 0);
            this.tcScenario.Name = "tcScenario";
            this.tcScenario.Padding = new System.Drawing.Point(16, 10);
            this.tcScenario.SelectedIndex = 0;
            this.tcScenario.Size = new System.Drawing.Size(392, 366);
            this.tcScenario.TabIndex = 4;
            // 
            // tpArrayOfNumber
            // 
            this.tpArrayOfNumber.Controls.Add(this.btnArrayOfNumberWhere);
            this.tpArrayOfNumber.Controls.Add(this.btnArrayOfNumberConcat);
            this.tpArrayOfNumber.Controls.Add(this.btnArrayOfNumberDescendingOrder);
            this.tpArrayOfNumber.Controls.Add(this.btnArrayOfNumberOrderby);
            this.tpArrayOfNumber.Controls.Add(this.btnArrayOfNumberSum);
            this.tpArrayOfNumber.Controls.Add(this.textBox2);
            this.tpArrayOfNumber.Controls.Add(this.txtArrayOfNumber);
            this.tpArrayOfNumber.Location = new System.Drawing.Point(4, 36);
            this.tpArrayOfNumber.Name = "tpArrayOfNumber";
            this.tpArrayOfNumber.Padding = new System.Windows.Forms.Padding(3);
            this.tpArrayOfNumber.Size = new System.Drawing.Size(384, 326);
            this.tpArrayOfNumber.TabIndex = 0;
            this.tpArrayOfNumber.Text = "Array of Numbers";
            this.tpArrayOfNumber.UseVisualStyleBackColor = true;
            // 
            // btnArrayOfNumberWhere
            // 
            this.btnArrayOfNumberWhere.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrayOfNumberWhere.Location = new System.Drawing.Point(3, 166);
            this.btnArrayOfNumberWhere.Name = "btnArrayOfNumberWhere";
            this.btnArrayOfNumberWhere.Size = new System.Drawing.Size(378, 23);
            this.btnArrayOfNumberWhere.TabIndex = 17;
            this.btnArrayOfNumberWhere.Text = "Where (equal or grather than 6)";
            this.btnArrayOfNumberWhere.UseVisualStyleBackColor = true;
            this.btnArrayOfNumberWhere.Click += new System.EventHandler(this.btnArrayOfNumberWhere_Click);
            // 
            // btnArrayOfNumberConcat
            // 
            this.btnArrayOfNumberConcat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrayOfNumberConcat.Location = new System.Drawing.Point(3, 143);
            this.btnArrayOfNumberConcat.Name = "btnArrayOfNumberConcat";
            this.btnArrayOfNumberConcat.Size = new System.Drawing.Size(378, 23);
            this.btnArrayOfNumberConcat.TabIndex = 16;
            this.btnArrayOfNumberConcat.Text = "Concating distinct with another array  { 2, 0, 1, 3, 70, 90, 100, 80 }";
            this.btnArrayOfNumberConcat.UseVisualStyleBackColor = true;
            this.btnArrayOfNumberConcat.Click += new System.EventHandler(this.btnArrayOfNumberConcat_Click);
            // 
            // btnArrayOfNumberDescendingOrder
            // 
            this.btnArrayOfNumberDescendingOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrayOfNumberDescendingOrder.Location = new System.Drawing.Point(3, 120);
            this.btnArrayOfNumberDescendingOrder.Name = "btnArrayOfNumberDescendingOrder";
            this.btnArrayOfNumberDescendingOrder.Size = new System.Drawing.Size(378, 23);
            this.btnArrayOfNumberDescendingOrder.TabIndex = 15;
            this.btnArrayOfNumberDescendingOrder.Text = "Descending Order By";
            this.btnArrayOfNumberDescendingOrder.UseVisualStyleBackColor = true;
            this.btnArrayOfNumberDescendingOrder.Click += new System.EventHandler(this.btnArrayOfNumberDescendingOrder_Click);
            // 
            // btnArrayOfNumberOrderby
            // 
            this.btnArrayOfNumberOrderby.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrayOfNumberOrderby.Location = new System.Drawing.Point(3, 97);
            this.btnArrayOfNumberOrderby.Name = "btnArrayOfNumberOrderby";
            this.btnArrayOfNumberOrderby.Size = new System.Drawing.Size(378, 23);
            this.btnArrayOfNumberOrderby.TabIndex = 14;
            this.btnArrayOfNumberOrderby.Text = "Order By";
            this.btnArrayOfNumberOrderby.UseVisualStyleBackColor = true;
            this.btnArrayOfNumberOrderby.Click += new System.EventHandler(this.btnArrayOfNumberOrderby_Click);
            // 
            // btnArrayOfNumberSum
            // 
            this.btnArrayOfNumberSum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrayOfNumberSum.Location = new System.Drawing.Point(3, 74);
            this.btnArrayOfNumberSum.Name = "btnArrayOfNumberSum";
            this.btnArrayOfNumberSum.Size = new System.Drawing.Size(378, 23);
            this.btnArrayOfNumberSum.TabIndex = 13;
            this.btnArrayOfNumberSum.Text = "Sum";
            this.btnArrayOfNumberSum.UseVisualStyleBackColor = true;
            this.btnArrayOfNumberSum.Click += new System.EventHandler(this.btnArrayOfNumberSum_Click);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(3, 54);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(378, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Visible = false;
            // 
            // txtArrayOfNumber
            // 
            this.txtArrayOfNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtArrayOfNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArrayOfNumber.Location = new System.Drawing.Point(3, 3);
            this.txtArrayOfNumber.Multiline = true;
            this.txtArrayOfNumber.Name = "txtArrayOfNumber";
            this.txtArrayOfNumber.ReadOnly = true;
            this.txtArrayOfNumber.Size = new System.Drawing.Size(378, 51);
            this.txtArrayOfNumber.TabIndex = 7;
            this.txtArrayOfNumber.Text = "\r\nint[] myArrayOfNumber = { 2, 0, 1, 3, 4, 5, 6, 7, 9, 10, 8 };\r\n";
            // 
            // tpArrayOfString
            // 
            this.tpArrayOfString.Controls.Add(this.btnArrayOfStringStarstsWithEndsWith);
            this.tpArrayOfString.Controls.Add(this.btnArrayOfStringWhereOrderBy);
            this.tpArrayOfString.Controls.Add(this.btnArrayOfStringContainCaseInSentitive);
            this.tpArrayOfString.Controls.Add(this.btnArrayOfStringContain);
            this.tpArrayOfString.Controls.Add(this.textBox3);
            this.tpArrayOfString.Location = new System.Drawing.Point(4, 36);
            this.tpArrayOfString.Name = "tpArrayOfString";
            this.tpArrayOfString.Padding = new System.Windows.Forms.Padding(3);
            this.tpArrayOfString.Size = new System.Drawing.Size(384, 326);
            this.tpArrayOfString.TabIndex = 1;
            this.tpArrayOfString.Text = "Array of Strings";
            this.tpArrayOfString.UseVisualStyleBackColor = true;
            // 
            // btnArrayOfStringStarstsWithEndsWith
            // 
            this.btnArrayOfStringStarstsWithEndsWith.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrayOfStringStarstsWithEndsWith.Location = new System.Drawing.Point(3, 123);
            this.btnArrayOfStringStarstsWithEndsWith.Name = "btnArrayOfStringStarstsWithEndsWith";
            this.btnArrayOfStringStarstsWithEndsWith.Size = new System.Drawing.Size(378, 23);
            this.btnArrayOfStringStarstsWithEndsWith.TabIndex = 12;
            this.btnArrayOfStringStarstsWithEndsWith.Text = "StartsWith (\"A\") and EndsWith (\"A\") (case-insesitive)";
            this.btnArrayOfStringStarstsWithEndsWith.UseVisualStyleBackColor = true;
            this.btnArrayOfStringStarstsWithEndsWith.Click += new System.EventHandler(this.btnArrayOfStringStarstsWithEndsWith_Click);
            // 
            // btnArrayOfStringWhereOrderBy
            // 
            this.btnArrayOfStringWhereOrderBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrayOfStringWhereOrderBy.Location = new System.Drawing.Point(3, 100);
            this.btnArrayOfStringWhereOrderBy.Name = "btnArrayOfStringWhereOrderBy";
            this.btnArrayOfStringWhereOrderBy.Size = new System.Drawing.Size(378, 23);
            this.btnArrayOfStringWhereOrderBy.TabIndex = 11;
            this.btnArrayOfStringWhereOrderBy.Text = "Where and OrderBy (contain a case-insesitive)";
            this.btnArrayOfStringWhereOrderBy.UseVisualStyleBackColor = true;
            this.btnArrayOfStringWhereOrderBy.Click += new System.EventHandler(this.btnArrayOfStringWhereOrderBy_Click);
            // 
            // btnArrayOfStringContainCaseInSentitive
            // 
            this.btnArrayOfStringContainCaseInSentitive.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrayOfStringContainCaseInSentitive.Location = new System.Drawing.Point(3, 77);
            this.btnArrayOfStringContainCaseInSentitive.Name = "btnArrayOfStringContainCaseInSentitive";
            this.btnArrayOfStringContainCaseInSentitive.Size = new System.Drawing.Size(378, 23);
            this.btnArrayOfStringContainCaseInSentitive.TabIndex = 10;
            this.btnArrayOfStringContainCaseInSentitive.Text = "Contain \"a\"  (case-insensitive)";
            this.btnArrayOfStringContainCaseInSentitive.UseVisualStyleBackColor = true;
            this.btnArrayOfStringContainCaseInSentitive.Click += new System.EventHandler(this.btnArrayOfStringContainCaseInSentitive_Click);
            // 
            // btnArrayOfStringContain
            // 
            this.btnArrayOfStringContain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrayOfStringContain.Location = new System.Drawing.Point(3, 54);
            this.btnArrayOfStringContain.Name = "btnArrayOfStringContain";
            this.btnArrayOfStringContain.Size = new System.Drawing.Size(378, 23);
            this.btnArrayOfStringContain.TabIndex = 9;
            this.btnArrayOfStringContain.Text = "Contain \"a\" (case-sensitive)";
            this.btnArrayOfStringContain.UseVisualStyleBackColor = true;
            this.btnArrayOfStringContain.Click += new System.EventHandler(this.btnArrayOfStringContain_Click);
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(378, 51);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "\r\nint[] myArrayOfString = { \"Honda\", \"Nissan\", \"Acura\", \"BMW\", \"Volvo\", \"Mazda\", " +
    "\"Audi\", \"Volksvagem\", \"Dodge\", \"Ford\"};\r\n";
            // 
            // tpClassObject
            // 
            this.tpClassObject.Controls.Add(this.btnClassObjCountry);
            this.tpClassObject.Controls.Add(this.groupBox2);
            this.tpClassObject.Location = new System.Drawing.Point(4, 36);
            this.tpClassObject.Name = "tpClassObject";
            this.tpClassObject.Padding = new System.Windows.Forms.Padding(3);
            this.tpClassObject.Size = new System.Drawing.Size(384, 326);
            this.tpClassObject.TabIndex = 2;
            this.tpClassObject.Text = "Class Objects";
            this.tpClassObject.UseVisualStyleBackColor = true;
            // 
            // btnClassObjCountry
            // 
            this.btnClassObjCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClassObjCountry.Location = new System.Drawing.Point(3, 281);
            this.btnClassObjCountry.Name = "btnClassObjCountry";
            this.btnClassObjCountry.Size = new System.Drawing.Size(378, 23);
            this.btnClassObjCountry.TabIndex = 6;
            this.btnClassObjCountry.Text = "Car Brands - Country of Origin";
            this.btnClassObjCountry.UseVisualStyleBackColor = true;
            this.btnClassObjCountry.Click += new System.EventHandler(this.btnClassObjCountry_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.carBrandDataGridView);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 278);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Brands - Class representation and records filled";
            // 
            // carBrandDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.carBrandDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.carBrandDataGridView.AutoGenerateColumns = false;
            this.carBrandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carBrandDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column1});
            this.carBrandDataGridView.DataSource = this.carBrandBindingSource;
            this.carBrandDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carBrandDataGridView.Location = new System.Drawing.Point(3, 140);
            this.carBrandDataGridView.Name = "carBrandDataGridView";
            this.carBrandDataGridView.Size = new System.Drawing.Size(372, 135);
            this.carBrandDataGridView.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HostCountry";
            this.Column1.HeaderText = "Host Country";
            this.Column1.Name = "Column1";
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(3, 16);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(372, 124);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(402, 361);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // carBrandBindingSource
            // 
            this.carBrandBindingSource.DataSource = typeof(MakingLinqEasyTheBestOnLinq.CarBrand);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcScenario);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "The Best On LINQ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcScenario.ResumeLayout(false);
            this.tpArrayOfNumber.ResumeLayout(false);
            this.tpArrayOfNumber.PerformLayout();
            this.tpArrayOfString.ResumeLayout(false);
            this.tpArrayOfString.PerformLayout();
            this.tpClassObject.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TabControl tcScenario;
        private System.Windows.Forms.TabPage tpArrayOfNumber;
        private System.Windows.Forms.TabPage tpArrayOfString;
        private System.Windows.Forms.TextBox txtArrayOfNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnArrayOfNumberConcat;
        private System.Windows.Forms.Button btnArrayOfNumberDescendingOrder;
        private System.Windows.Forms.Button btnArrayOfNumberOrderby;
        private System.Windows.Forms.Button btnArrayOfNumberSum;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnArrayOfNumberWhere;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnArrayOfStringContain;
        private System.Windows.Forms.Button btnArrayOfStringContainCaseInSentitive;
        private System.Windows.Forms.Button btnArrayOfStringWhereOrderBy;
        private System.Windows.Forms.TabPage tpClassObject;
        private System.Windows.Forms.BindingSource carBrandBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClassObjCountry;
        private System.Windows.Forms.DataGridView carBrandDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnArrayOfStringStarstsWithEndsWith;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

