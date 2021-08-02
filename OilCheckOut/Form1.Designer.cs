
namespace OilCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_oil_type = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tb_liter = new System.Windows.Forms.TextBox();
            this.tb_total_sum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_hotdog = new System.Windows.Forms.CheckBox();
            this.cb_fries = new System.Windows.Forms.CheckBox();
            this.cb_cheetos = new System.Windows.Forms.CheckBox();
            this.cb_ozmo = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_ozmo = new System.Windows.Forms.TextBox();
            this.txt_cheetos = new System.Windows.Forms.TextBox();
            this.txt_fries = new System.Windows.Forms.TextBox();
            this.txt_hotdog = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_food_sum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lb_oil_type
            // 
            this.lb_oil_type.FormattingEnabled = true;
            resources.ApplyResources(this.lb_oil_type, "lb_oil_type");
            this.lb_oil_type.Items.AddRange(new object[] {
            resources.GetString("lb_oil_type.Items"),
            resources.GetString("lb_oil_type.Items1"),
            resources.GetString("lb_oil_type.Items2"),
            resources.GetString("lb_oil_type.Items3")});
            this.lb_oil_type.Name = "lb_oil_type";
            this.lb_oil_type.SelectedIndexChanged += new System.EventHandler(this.lb_oil_type_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tb_price
            // 
            resources.ApplyResources(this.tb_price, "tb_price");
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tb_liter
            // 
            resources.ApplyResources(this.tb_liter, "tb_liter");
            this.tb_liter.Name = "tb_liter";
            this.tb_liter.ReadOnly = true;
            this.tb_liter.TextChanged += new System.EventHandler(this.tb_liter_TextChanged);
            // 
            // tb_total_sum
            // 
            resources.ApplyResources(this.tb_total_sum, "tb_total_sum");
            this.tb_total_sum.Name = "tb_total_sum";
            this.tb_total_sum.ReadOnly = true;
            this.tb_total_sum.TextChanged += new System.EventHandler(this.tb_total_sum_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // cb_hotdog
            // 
            resources.ApplyResources(this.cb_hotdog, "cb_hotdog");
            this.cb_hotdog.Name = "cb_hotdog";
            this.cb_hotdog.UseVisualStyleBackColor = true;
            this.cb_hotdog.CheckedChanged += new System.EventHandler(this.cb_hotdog_CheckedChanged);
            // 
            // cb_fries
            // 
            resources.ApplyResources(this.cb_fries, "cb_fries");
            this.cb_fries.Name = "cb_fries";
            this.cb_fries.UseVisualStyleBackColor = true;
            this.cb_fries.CheckedChanged += new System.EventHandler(this.cb_fries_CheckedChanged);
            // 
            // cb_cheetos
            // 
            resources.ApplyResources(this.cb_cheetos, "cb_cheetos");
            this.cb_cheetos.Name = "cb_cheetos";
            this.cb_cheetos.UseVisualStyleBackColor = true;
            this.cb_cheetos.CheckedChanged += new System.EventHandler(this.cb_cheetos_CheckedChanged);
            // 
            // cb_ozmo
            // 
            resources.ApplyResources(this.cb_ozmo, "cb_ozmo");
            this.cb_ozmo.Name = "cb_ozmo";
            this.cb_ozmo.UseVisualStyleBackColor = true;
            this.cb_ozmo.CheckedChanged += new System.EventHandler(this.cb_ozmo_CheckedChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            // 
            // txt_ozmo
            // 
            resources.ApplyResources(this.txt_ozmo, "txt_ozmo");
            this.txt_ozmo.Name = "txt_ozmo";
            this.txt_ozmo.TextChanged += new System.EventHandler(this.txt_ozmo_TextChanged);
            // 
            // txt_cheetos
            // 
            resources.ApplyResources(this.txt_cheetos, "txt_cheetos");
            this.txt_cheetos.Name = "txt_cheetos";
            this.txt_cheetos.TextChanged += new System.EventHandler(this.txt_cheetos_TextChanged);
            // 
            // txt_fries
            // 
            resources.ApplyResources(this.txt_fries, "txt_fries");
            this.txt_fries.Name = "txt_fries";
            this.txt_fries.TextChanged += new System.EventHandler(this.txt_fries_TextChanged);
            // 
            // txt_hotdog
            // 
            resources.ApplyResources(this.txt_hotdog, "txt_hotdog");
            this.txt_hotdog.Name = "txt_hotdog";
            this.txt_hotdog.TextChanged += new System.EventHandler(this.txt_hotdog_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // lbl_food_sum
            // 
            resources.ApplyResources(this.lbl_food_sum, "lbl_food_sum");
            this.lbl_food_sum.Name = "lbl_food_sum";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // btn_buy
            // 
            resources.ApplyResources(this.btn_buy, "btn_buy");
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_food_sum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ozmo);
            this.Controls.Add(this.txt_cheetos);
            this.Controls.Add(this.txt_fries);
            this.Controls.Add(this.txt_hotdog);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_ozmo);
            this.Controls.Add(this.cb_cheetos);
            this.Controls.Add(this.cb_fries);
            this.Controls.Add(this.cb_hotdog);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_total_sum);
            this.Controls.Add(this.tb_liter);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_oil_type);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_oil_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tb_liter;
        private System.Windows.Forms.TextBox tb_total_sum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_hotdog;
        private System.Windows.Forms.CheckBox cb_fries;
        private System.Windows.Forms.CheckBox cb_cheetos;
        private System.Windows.Forms.CheckBox cb_ozmo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_ozmo;
        private System.Windows.Forms.TextBox txt_cheetos;
        private System.Windows.Forms.TextBox txt_fries;
        private System.Windows.Forms.TextBox txt_hotdog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_food_sum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_buy;
    }
}

