using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilCheckOut
{
    public partial class Form1 : Form
    {
        public double BarrelPrice { get; set; }
        public double TotalSum { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            tb_liter.Enabled = false;
            tb_total_sum.Enabled = false;
            label7.Text = "0";
            lbl_food_sum.Text = "0";
        }

        private void lb_oil_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_oil_type.Text == "Diesel")
            {
                tb_price.Text = "0.55";
                BarrelPrice = .55;
            }
            else if (lb_oil_type.Text == "A-91")
            {
                tb_price.Text = "1.12";
                BarrelPrice = 1.12;
            }
            else if (lb_oil_type.Text == "A-92")
            {
                tb_price.Text = "1.45";
                BarrelPrice = 1.45;
            }
            else if (lb_oil_type.Text == "Premium")
            {
                tb_price.Text = "1.92";
                BarrelPrice = 1.92;
            }

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tb_liter.Enabled = true;
            tb_liter.ReadOnly = false;
            tb_total_sum.ReadOnly = true;
            tb_total_sum.Clear();
            tb_liter.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tb_total_sum.Enabled = true;
            tb_total_sum.ReadOnly = false;
            tb_liter.ReadOnly = true;
            tb_total_sum.Clear();
            tb_liter.Clear();
        }

        private void tb_liter_TextChanged(object sender, EventArgs e)
        {
            if (tb_liter.Text != "") tb_total_sum.Text = Convert.ToString(Convert.ToDouble(tb_liter.Text) * BarrelPrice);
            label7.Text = tb_total_sum.Text;
            calcPrice();
        }

        private void tb_total_sum_TextChanged(object sender, EventArgs e)
        {
            if(tb_total_sum.Text != "") tb_liter.Text = Convert.ToString(Convert.ToDouble(tb_total_sum.Text) / BarrelPrice);
            label7.Text = tb_total_sum.Text;
            calcPrice();
        }

        private void cb_hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hotdog.Checked) txt_hotdog.Enabled = true;
            else
            {
                txt_hotdog.Text = "0";
                txt_hotdog.Enabled = false;
            }
        }

        private void cb_fries_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_fries.Checked) txt_fries.Enabled = true;
            else
            {
                txt_fries.Text = "0";
                txt_fries.Enabled = false;
            }
        }

        private void cb_cheetos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cheetos.Checked) txt_cheetos.Enabled = true;
            else
            {
                txt_cheetos.Text = "0";
                txt_cheetos.Enabled = false;
            }
        }

        private void cb_ozmo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ozmo.Checked) txt_ozmo.Enabled = true;
            else
            {
                txt_ozmo.Text = "0";
                txt_ozmo.Enabled = false;
            }
        }

        private void txt_ozmo_TextChanged(object sender, EventArgs e)
        {
            if (txt_ozmo.Text != "") calcPrice();
        }
        private void txt_cheetos_TextChanged(object sender, EventArgs e)
        {
            if (txt_cheetos.Text != "") calcPrice();
        }
        private void txt_fries_TextChanged(object sender, EventArgs e)
        {
            if (txt_fries.Text != "") calcPrice();
        }
        private void txt_hotdog_TextChanged(object sender, EventArgs e)
        {
            if (txt_hotdog.Text != "") calcPrice();
        }
        private void calcPrice()
        {
            lbl_food_sum.Text = Convert.ToString((Convert.ToDouble(txt_ozmo.Text) * 2.8) + (Convert.ToDouble(txt_hotdog.Text) * 2.4) + (Convert.ToDouble(txt_fries.Text) * 1.6) + (Convert.ToDouble(txt_cheetos.Text) * 0.8));
            label11.Text = Convert.ToString((Convert.ToDouble(lbl_food_sum.Text) + Convert.ToDouble(tb_total_sum.Text)));
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Oil Type: {lb_oil_type.Text}\nOil Price: {BarrelPrice}\nAmount: {tb_liter.Text}\nHot dog: {txt_hotdog.Text}\nFries: {txt_fries.Text}\nCheetos: {txt_cheetos.Text}\nOzmo: {txt_ozmo.Text}\n\nTotal Price: {label11.Text}");
        }
    }
}
