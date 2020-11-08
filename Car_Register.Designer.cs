namespace Final_Project
{
    partial class Car_Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.aboutus_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.register_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.fie_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.model_tb = new System.Windows.Forms.TextBox();
            this.company_tb = new System.Windows.Forms.TextBox();
            this.yr = new System.Windows.Forms.Label();
            this.plate_no_tb = new System.Windows.Forms.TextBox();
            this.product = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.engine_no_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.year_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Buying_price_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.color_combo = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Load_img = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Register Car";
            // 
            // aboutus_menu
            // 
            this.aboutus_menu.Name = "aboutus_menu";
            this.aboutus_menu.Size = new System.Drawing.Size(68, 20);
            this.aboutus_menu.Text = "About Us";
            this.aboutus_menu.Click += new System.EventHandler(this.aboutus_menu_Click);
            // 
            // cutomerToolStripMenuItem
            // 
            this.cutomerToolStripMenuItem.Name = "cutomerToolStripMenuItem";
            this.cutomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutomerToolStripMenuItem.Text = "Cutomer";
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // register_menu
            // 
            this.register_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carToolStripMenuItem,
            this.cutomerToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.register_menu.Name = "register_menu";
            this.register_menu.Size = new System.Drawing.Size(61, 20);
            this.register_menu.Text = "Register";
            this.register_menu.Click += new System.EventHandler(this.register_menu_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // view_menu
            // 
            this.view_menu.Name = "view_menu";
            this.view_menu.Size = new System.Drawing.Size(44, 20);
            this.view_menu.Text = "View";
            // 
            // fie_menu
            // 
            this.fie_menu.Name = "fie_menu";
            this.fie_menu.Size = new System.Drawing.Size(37, 20);
            this.fie_menu.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fie_menu,
            this.view_menu,
            this.register_menu,
            this.aboutus_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // model_tb
            // 
            this.model_tb.Location = new System.Drawing.Point(153, 83);
            this.model_tb.Name = "model_tb";
            this.model_tb.Size = new System.Drawing.Size(174, 20);
            this.model_tb.TabIndex = 8;
            // 
            // company_tb
            // 
            this.company_tb.Location = new System.Drawing.Point(153, 150);
            this.company_tb.Name = "company_tb";
            this.company_tb.Size = new System.Drawing.Size(174, 20);
            this.company_tb.TabIndex = 10;
            // 
            // yr
            // 
            this.yr.AutoSize = true;
            this.yr.Location = new System.Drawing.Point(42, 157);
            this.yr.Name = "yr";
            this.yr.Size = new System.Drawing.Size(51, 13);
            this.yr.TabIndex = 9;
            this.yr.Text = "Company";
            // 
            // plate_no_tb
            // 
            this.plate_no_tb.Location = new System.Drawing.Point(153, 117);
            this.plate_no_tb.Name = "plate_no_tb";
            this.plate_no_tb.Size = new System.Drawing.Size(174, 20);
            this.plate_no_tb.TabIndex = 12;
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Location = new System.Drawing.Point(42, 120);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(51, 13);
            this.product.TabIndex = 11;
            this.product.Text = "Plate No.";
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(200, 400);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(76, 23);
            this.register_btn.TabIndex = 13;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Color";
            // 
            // engine_no_tb
            // 
            this.engine_no_tb.Location = new System.Drawing.Point(153, 255);
            this.engine_no_tb.Name = "engine_no_tb";
            this.engine_no_tb.Size = new System.Drawing.Size(174, 20);
            this.engine_no_tb.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Engine No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Type";
            // 
            // year_tb
            // 
            this.year_tb.Location = new System.Drawing.Point(153, 292);
            this.year_tb.Name = "year_tb";
            this.year_tb.Size = new System.Drawing.Size(174, 20);
            this.year_tb.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Production Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Picture";
            // 
            // Buying_price_tb
            // 
            this.Buying_price_tb.Location = new System.Drawing.Point(153, 325);
            this.Buying_price_tb.Name = "Buying_price_tb";
            this.Buying_price_tb.Size = new System.Drawing.Size(174, 20);
            this.Buying_price_tb.TabIndex = 25;
            this.Buying_price_tb.TextChanged += new System.EventHandler(this.Buying_price_tb_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Buying Price";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // type_combo
            // 
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Location = new System.Drawing.Point(153, 192);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(174, 21);
            this.type_combo.TabIndex = 26;
            this.type_combo.DropDown += new System.EventHandler(this.type_combo_SelectedIndexChanged);
            // 
            // color_combo
            // 
            this.color_combo.FormattingEnabled = true;
            this.color_combo.Location = new System.Drawing.Point(153, 222);
            this.color_combo.Name = "color_combo";
            this.color_combo.Size = new System.Drawing.Size(174, 21);
            this.color_combo.TabIndex = 27;
            this.color_combo.DropDown += new System.EventHandler(this.color_combo_SelectedIndexChanged);
            this.color_combo.SelectedIndexChanged += new System.EventHandler(this.color_combo_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Load_img
            // 
            this.Load_img.Location = new System.Drawing.Point(153, 351);
            this.Load_img.Name = "Load_img";
            this.Load_img.Size = new System.Drawing.Size(75, 23);
            this.Load_img.TabIndex = 28;
            this.Load_img.Text = "Load Image";
            this.Load_img.UseVisualStyleBackColor = true;
            this.Load_img.Click += new System.EventHandler(this.Load_img_Click);
            // 
            // Car_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Load_img);
            this.Controls.Add(this.color_combo);
            this.Controls.Add(this.type_combo);
            this.Controls.Add(this.Buying_price_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.year_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.engine_no_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.plate_no_tb);
            this.Controls.Add(this.product);
            this.Controls.Add(this.company_tb);
            this.Controls.Add(this.yr);
            this.Controls.Add(this.model_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Car_Register";
            this.Text = "Car_Register";
            this.Load += new System.EventHandler(this.Car_Register_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem aboutus_menu;
        private System.Windows.Forms.ToolStripMenuItem cutomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem register_menu;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_menu;
        private System.Windows.Forms.ToolStripMenuItem fie_menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox model_tb;
        private System.Windows.Forms.TextBox company_tb;
        private System.Windows.Forms.Label yr;
        private System.Windows.Forms.TextBox plate_no_tb;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox engine_no_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox year_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Buying_price_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.ComboBox color_combo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Load_img;
    }
}