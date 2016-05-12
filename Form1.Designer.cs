namespace IZI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.actionTabControl = new System.Windows.Forms.TabControl();
            this.feedingTabPage = new System.Windows.Forms.TabPage();
            this.feedingFoodComboBox = new System.Windows.Forms.ComboBox();
            this.foodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iziDataSet = new IZI.iziDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.feedingAnimalComboBox = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receivingTabPage = new System.Windows.Forms.TabPage();
            this.inventoryTabPage = new System.Windows.Forms.TabPage();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.animalsTableAdapter = new IZI.iziDataSetTableAdapters.animalsTableAdapter();
            this.foodsTableAdapter = new IZI.iziDataSetTableAdapters.foodsTableAdapter();
            this.foodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.zooChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.zoosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zoosTableAdapter = new IZI.iziDataSetTableAdapters.zoosTableAdapter();
            this.feedingSaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.actionTabControl.SuspendLayout();
            this.feedingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iziDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            this.receivingTabPage.SuspendLayout();
            this.inventoryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "International Zoo Institute";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // actionTabControl
            // 
            this.actionTabControl.Controls.Add(this.feedingTabPage);
            this.actionTabControl.Controls.Add(this.receivingTabPage);
            this.actionTabControl.Controls.Add(this.inventoryTabPage);
            this.actionTabControl.Controls.Add(this.reportsTabPage);
            this.actionTabControl.Location = new System.Drawing.Point(13, 78);
            this.actionTabControl.Name = "actionTabControl";
            this.actionTabControl.SelectedIndex = 0;
            this.actionTabControl.Size = new System.Drawing.Size(486, 263);
            this.actionTabControl.TabIndex = 3;
            // 
            // feedingTabPage
            // 
            this.feedingTabPage.Controls.Add(this.feedingSaveButton);
            this.feedingTabPage.Controls.Add(this.numericUpDown1);
            this.feedingTabPage.Controls.Add(this.label4);
            this.feedingTabPage.Controls.Add(this.feedingFoodComboBox);
            this.feedingTabPage.Controls.Add(this.label2);
            this.feedingTabPage.Controls.Add(this.label3);
            this.feedingTabPage.Controls.Add(this.feedingAnimalComboBox);
            this.feedingTabPage.Location = new System.Drawing.Point(4, 22);
            this.feedingTabPage.Name = "feedingTabPage";
            this.feedingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.feedingTabPage.Size = new System.Drawing.Size(478, 237);
            this.feedingTabPage.TabIndex = 0;
            this.feedingTabPage.Text = "Feeding";
            this.feedingTabPage.UseVisualStyleBackColor = true;
            // 
            // feedingFoodComboBox
            // 
            this.feedingFoodComboBox.DataSource = this.foodsBindingSource;
            this.feedingFoodComboBox.DisplayMember = "description";
            this.feedingFoodComboBox.FormattingEnabled = true;
            this.feedingFoodComboBox.Location = new System.Drawing.Point(83, 48);
            this.feedingFoodComboBox.Name = "feedingFoodComboBox";
            this.feedingFoodComboBox.Size = new System.Drawing.Size(121, 21);
            this.feedingFoodComboBox.TabIndex = 3;
            // 
            // foodsBindingSource
            // 
            this.foodsBindingSource.DataMember = "foods";
            this.foodsBindingSource.DataSource = this.iziDataSet;
            // 
            // iziDataSet
            // 
            this.iziDataSet.DataSetName = "iziDataSet";
            this.iziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Food";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Animal";
            // 
            // feedingAnimalComboBox
            // 
            this.feedingAnimalComboBox.DataSource = this.animalsBindingSource;
            this.feedingAnimalComboBox.DisplayMember = "name";
            this.feedingAnimalComboBox.FormattingEnabled = true;
            this.feedingAnimalComboBox.Location = new System.Drawing.Point(83, 21);
            this.feedingAnimalComboBox.Name = "feedingAnimalComboBox";
            this.feedingAnimalComboBox.Size = new System.Drawing.Size(121, 21);
            this.feedingAnimalComboBox.TabIndex = 0;
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "animals";
            this.animalsBindingSource.DataSource = this.iziDataSet;
            // 
            // receivingTabPage
            // 
            this.receivingTabPage.Controls.Add(this.button1);
            this.receivingTabPage.Controls.Add(this.numericUpDown2);
            this.receivingTabPage.Controls.Add(this.label6);
            this.receivingTabPage.Controls.Add(this.comboBox1);
            this.receivingTabPage.Controls.Add(this.label5);
            this.receivingTabPage.Location = new System.Drawing.Point(4, 22);
            this.receivingTabPage.Name = "receivingTabPage";
            this.receivingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.receivingTabPage.Size = new System.Drawing.Size(478, 237);
            this.receivingTabPage.TabIndex = 1;
            this.receivingTabPage.Text = "Food Receiving";
            this.receivingTabPage.UseVisualStyleBackColor = true;
            // 
            // inventoryTabPage
            // 
            this.inventoryTabPage.Controls.Add(this.button2);
            this.inventoryTabPage.Controls.Add(this.numericUpDown3);
            this.inventoryTabPage.Controls.Add(this.label7);
            this.inventoryTabPage.Controls.Add(this.comboBox2);
            this.inventoryTabPage.Controls.Add(this.label8);
            this.inventoryTabPage.Location = new System.Drawing.Point(4, 22);
            this.inventoryTabPage.Name = "inventoryTabPage";
            this.inventoryTabPage.Size = new System.Drawing.Size(478, 237);
            this.inventoryTabPage.TabIndex = 2;
            this.inventoryTabPage.Text = "Food Inventory";
            this.inventoryTabPage.UseVisualStyleBackColor = true;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Location = new System.Drawing.Point(4, 22);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Size = new System.Drawing.Size(478, 237);
            this.reportsTabPage.TabIndex = 3;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // foodsTableAdapter
            // 
            this.foodsTableAdapter.ClearBeforeFill = true;
            // 
            // foodsBindingSource1
            // 
            this.foodsBindingSource1.DataMember = "foods";
            this.foodsBindingSource1.DataSource = this.iziDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 75);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.foodsBindingSource;
            this.comboBox1.DisplayMember = "description";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Food";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(83, 60);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(83, 63);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Amount";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.foodsBindingSource;
            this.comboBox2.DisplayMember = "description";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Food";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Zoo:";
            // 
            // zooChoiceComboBox
            // 
            this.zooChoiceComboBox.DataSource = this.zoosBindingSource;
            this.zooChoiceComboBox.DisplayMember = "name";
            this.zooChoiceComboBox.FormattingEnabled = true;
            this.zooChoiceComboBox.Location = new System.Drawing.Point(136, 51);
            this.zooChoiceComboBox.Name = "zooChoiceComboBox";
            this.zooChoiceComboBox.Size = new System.Drawing.Size(121, 21);
            this.zooChoiceComboBox.TabIndex = 5;
            // 
            // zoosBindingSource
            // 
            this.zoosBindingSource.DataMember = "zoos";
            this.zoosBindingSource.DataSource = this.iziDataSet;
            // 
            // zoosTableAdapter
            // 
            this.zoosTableAdapter.ClearBeforeFill = true;
            // 
            // feedingSaveButton
            // 
            this.feedingSaveButton.Location = new System.Drawing.Point(83, 128);
            this.feedingSaveButton.Name = "feedingSaveButton";
            this.feedingSaveButton.Size = new System.Drawing.Size(75, 23);
            this.feedingSaveButton.TabIndex = 6;
            this.feedingSaveButton.Text = "&Save";
            this.feedingSaveButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "&Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 353);
            this.Controls.Add(this.zooChoiceComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.actionTabControl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Zoo Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.actionTabControl.ResumeLayout(false);
            this.feedingTabPage.ResumeLayout(false);
            this.feedingTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iziDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            this.receivingTabPage.ResumeLayout(false);
            this.receivingTabPage.PerformLayout();
            this.inventoryTabPage.ResumeLayout(false);
            this.inventoryTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl actionTabControl;
        private System.Windows.Forms.TabPage feedingTabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox feedingAnimalComboBox;
        private System.Windows.Forms.TabPage receivingTabPage;
        private System.Windows.Forms.TabPage inventoryTabPage;
        private System.Windows.Forms.TabPage reportsTabPage;
        private iziDataSet iziDataSet;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private iziDataSetTableAdapters.animalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.ComboBox feedingFoodComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource foodsBindingSource;
        private iziDataSetTableAdapters.foodsTableAdapter foodsTableAdapter;
        private System.Windows.Forms.BindingSource foodsBindingSource1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox zooChoiceComboBox;
        private System.Windows.Forms.BindingSource zoosBindingSource;
        private iziDataSetTableAdapters.zoosTableAdapter zoosTableAdapter;
        private System.Windows.Forms.Button feedingSaveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

