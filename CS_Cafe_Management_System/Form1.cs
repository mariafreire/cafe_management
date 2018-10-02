using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Cafe_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAfricanCoffee.Text = "0";
            txtAmericanCoffee.Text = "0";
            txtBlackFlorest.Text = "0";
            txtBostonCream.Text = "0";
            txtCappuccino.Text = "0";
            txtCarltonHill.Text = "0";
            txtCoffeeCake.Text = "0";
            txtEspresso.Text = "0";
            txtIcedCappuccino.Text = "0";
            txtIcedLatte.Text = "0";
            txtKilbur.Text = "0";
            txtLagosChocolate.Text = "0";
            txtLatte.Text = "0";
            txtQueenPark.Text = "0";
            txtRedVelvet.Text = "0";
            txtValeCoffee.Text = "0";
            lblCakes.Text = "0";
            lblCostDrinks.Text = "0";
            lblServiceCharge.Text = "1.75";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";
            rtbDisplay.Text = "";

            chkAfricanCoffee.Checked = false;
            chkAmericanCoffee.Checked = false;
            chkBlackFlorest.Checked = false;
            chkBostonCream.Checked = false;
            chkCappuccino.Checked = false;
            chkCarltonHill.Checked = false;
            chkCoffee.Checked = false;
            chkEspresso.Checked = false;
            chkIcedCappuccino.Checked = false;
            chkIcedLatte.Checked = false;
            chkKilbur.Checked = false;
            chkLagos.Checked = false;
            chkLatte.Checked = false;
            chkQueenPark.Checked = false;
            chkRedVelvet.Checked = false;
            chkValeCoffee.Checked = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txtAfricanCoffee.Text = "0";
            txtAmericanCoffee.Text = "0";
            txtBlackFlorest.Text = "0";
            txtBostonCream.Text = "0";
            txtCappuccino.Text = "0";
            txtCarltonHill.Text = "0";
            txtCoffeeCake.Text = "0";
            txtEspresso.Text = "0";
            txtIcedCappuccino.Text = "0";
            txtIcedLatte.Text = "0";
            txtKilbur.Text = "0";
            txtLagosChocolate.Text = "0";
            txtLatte.Text = "0";
            txtQueenPark.Text = "0";
            txtRedVelvet.Text = "0";
            txtValeCoffee.Text = "0";
            lblCakes.Text = "0";
            lblCostDrinks.Text = "0";
            lblServiceCharge.Text = "1.75";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void chkAfricanCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfricanCoffee.Checked == true)
            {
                txtAfricanCoffee.Enabled = true;
            }
            else
            {
                txtAfricanCoffee.Enabled = false;
                txtAfricanCoffee.Text = "0";
            }
        }

        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked == true)
            {
                txtLatte.Enabled = true;
            }
            else
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                txtEspresso.Enabled = true;
            }
            else
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void chkIcedLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedLatte.Checked == true)
            {
                txtIcedLatte.Enabled = true;
            }
            else
            {
                txtIcedLatte.Enabled = false;
                txtIcedLatte.Text = "0";
            }
        }

        private void chkValeCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValeCoffee.Checked == true)
            {
                txtValeCoffee.Enabled = true;
            }
            else
            {
                txtValeCoffee.Enabled = false;
                txtValeCoffee.Text = "0";
            }
        }

        private void chkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                txtCappuccino.Enabled = true;
            }
            else
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void chkAmericanCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmericanCoffee.Checked == true)
            {
                txtAmericanCoffee.Enabled = true;
            }
            else
            {
                txtAmericanCoffee.Enabled = false;
                txtAfricanCoffee.Text = "0";
            }
        }

        private void chkIcedCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedCappuccino.Checked == true)
            {
                txtIcedCappuccino.Enabled = true;
            }
            else
            {
                txtIcedCappuccino.Enabled = false;
                txtIcedCappuccino.Text = "0";
            }
        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked == true)
            {
                txtCoffeeCake.Enabled = true;
            }
            else
            {
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.Text = "0";
            }
        }

        private void chkRedVelvet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedVelvet.Checked == true)
            {
                txtRedVelvet.Enabled = true;
                
            }
            else
            {
                txtRedVelvet.Enabled = false;
                txtRedVelvet.Text = "0";
            }
        }

        private void chkBlackFlorest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackFlorest.Checked == true)
            {
                txtBlackFlorest.Enabled = true;
            }
            else
            {
                txtBlackFlorest.Enabled = false;
                txtBlackFlorest.Text = "0";
            }
        }

        private void chkBostonCream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBostonCream.Checked == true)
            {
                txtBostonCream.Enabled = true;
            }
            else
            {
                txtBostonCream.Enabled = false;
                txtBostonCream.Text = "0";
            }
        }

        private void chkLagos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLagos.Checked == true)
            {
                txtLagosChocolate.Enabled = true;
            }
            else
            {
                txtLagosChocolate.Enabled = false;
                txtLagosChocolate.Text = "0";
            }
        }

        private void chkKilbur_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKilbur.Checked == true)
            {
                txtKilbur.Enabled = true;
            }
            else
            {
                txtKilbur.Enabled = false;
                txtKilbur.Text = "0";
            }
        }

        private void chkCarltonHill_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarltonHill.Checked == true)
            {
                txtCarltonHill.Enabled = true;
            }
            else
            {
                txtCarltonHill.Enabled = false;
                txtCarltonHill.Text = "0";
            }
        }

        private void chkQueenPark_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQueenPark.Checked == true)
            {
                txtQueenPark.Enabled = true;
            }
            else
            {
                txtQueenPark.Enabled = false;
                txtQueenPark.Text = "0";
            }
        }

        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = "";
        }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
        }

        private void txtIcedLatte_Click(object sender, EventArgs e)
        {
            txtIcedLatte.Text = "";
        }

        private void txtVale_Click(object sender, EventArgs e)
        {
            txtValeCoffee.Text = "";
        }

        private void txtCappuccino_Click(object sender, EventArgs e)
        {
            txtCappuccino.Text = "";
        }

        private void txtAfrican_Click(object sender, EventArgs e)
        {
            txtAfricanCoffee.Text = "";
        }

        private void txtAmerican_Click(object sender, EventArgs e)
        {
            txtAmericanCoffee.Text = "";
        }

        private void txtIcedCappuccino_Click(object sender, EventArgs e)
        {
            txtIcedCappuccino.Text = "";
        }

        private void txtCoffeeCake_Click(object sender, EventArgs e)
        {
            txtCoffeeCake.Text = "";
        }

        private void txtRedVelvet_Click(object sender, EventArgs e)
        {
            txtRedVelvet.Text = "";
        }

        private void txtBlackFlorest_Click(object sender, EventArgs e)
        {
            txtBlackFlorest.Text = "";
        }

        private void txtBostonCream_Click(object sender, EventArgs e)
        {
            txtBostonCream.Text = "";
        }

        private void txtLagos_Click(object sender, EventArgs e)
        {
            txtLagosChocolate.Text = "";
        }

        private void txtKilbur_Click(object sender, EventArgs e)
        {
            txtKilbur.Text = "";
        }

        private void txtCarltonHill_Click(object sender, EventArgs e)
        {
            txtCarltonHill.Text = "";
        }

        private void txtQueenPark_Click(object sender, EventArgs e)
        {
            txtQueenPark.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbDisplay.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtbDisplay.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtbDisplay.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtbDisplay.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtbDisplay.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtbDisplay.Text);
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            rtbDisplay.AppendText(Environment.NewLine);
            rtbDisplay.AppendText("--------------------------------------------------------" + Environment.NewLine);
            rtbDisplay.AppendText("\t\t" + "Just Do Coffee" + Environment.NewLine);
            rtbDisplay.AppendText("--------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
            rtbDisplay.AppendText("Latte \t\t\t\t\t" + txtLatte.Text + Environment.NewLine);
            rtbDisplay.AppendText("Espresso \t\t\t\t" + txtEspresso.Text + Environment.NewLine);
            rtbDisplay.AppendText("Iced Latte \t\t\t\t" + txtIcedLatte.Text + Environment.NewLine);
            rtbDisplay.AppendText("Vale Coffe t\t\t\t" + txtValeCoffee.Text + Environment.NewLine);
            rtbDisplay.AppendText("Cappuccino \t\t\t" + txtCappuccino.Text + Environment.NewLine);
            rtbDisplay.AppendText("African Coffee \t\t\t" + txtAfricanCoffee.Text + Environment.NewLine);
            rtbDisplay.AppendText("Ameriacn Coffee \t\t\t" + txtAmericanCoffee.Text + Environment.NewLine);
            rtbDisplay.AppendText("Iced Cappuccino \t\t\t" + txtIcedCappuccino.Text + Environment.NewLine);

            rtbDisplay.AppendText("Coffee Cake t\t\t\t" + txtCoffeeCake.Text + Environment.NewLine);
            rtbDisplay.AppendText("Red Velvet Cake t\t\t" + txtRedVelvet.Text + Environment.NewLine);
            rtbDisplay.AppendText("Black Florest Cake \t\t" + txtBlackFlorest.Text + Environment.NewLine);
            rtbDisplay.AppendText("Boston Cream Cake \t\t" + txtBostonCream.Text + Environment.NewLine);
            rtbDisplay.AppendText("Lagos Chocolate Cake \t\t" + txtLagosChocolate.Text + Environment.NewLine);
            rtbDisplay.AppendText("Kilbur Chocolate Cake \t\t" + txtKilbur.Text + Environment.NewLine);
            rtbDisplay.AppendText("Carlton Hill Cake \t\t\t" + txtCarltonHill.Text + Environment.NewLine);
            rtbDisplay.AppendText("Queen's Park Cake \t\t" + txtQueenPark.Text + Environment.NewLine);
            rtbDisplay.AppendText("--------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
            rtbDisplay.AppendText("Service Charge \t\t\t" + lblServiceCharge.Text + Environment.NewLine);
            rtbDisplay.AppendText("--------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
            rtbDisplay.AppendText("SubTotal\t\t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtbDisplay.AppendText("Tax\t\t\t\t\t" + lblTax.Text + Environment.NewLine);   
            rtbDisplay.AppendText("Total\t\t\t\t\t" + lblTotal.Text + Environment.NewLine);
            rtbDisplay.AppendText("--------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
            rtbDisplay.AppendText(lblTime.Text + "\t\t" + lblDate.Text);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            
            double latte, ilatte, capp, icapp, african, american, vale, espresso;
            double coffee, velvet, florest, queen, carlton, kilburn, lagos, boston;

            latte = 1.00; ilatte = 1.25; capp = 1.50; icapp = 1.75; african = 2.00; american = 2.25; vale = 2.50; espresso = 2.75;
            double cf_latte = Convert.ToDouble(txtLatte.Text);
            double cf_ilatte = Convert.ToDouble(txtIcedLatte.Text);
            double cf_capp = Convert.ToDouble(txtCappuccino.Text);
            double cf_icapp = Convert.ToDouble(txtIcedCappuccino.Text);
            double cf_african = Convert.ToDouble(txtAfricanCoffee.Text);
            double cf_american = Convert.ToDouble(txtAmericanCoffee.Text);
            double cf_vale = Convert.ToDouble(txtValeCoffee.Text);
            double cf_espresso = Convert.ToDouble(txtEspresso.Text);

            coffee = 3.00; velvet = 3.25; florest = 3.50; queen = 3.75; carlton = 4.00; kilburn = 4.25; lagos = 4.50; boston = 4.75;
            double ck_coffee = Convert.ToDouble(txtCoffeeCake.Text);
            double ck_velvet = Convert.ToDouble(txtRedVelvet.Text);
            double ck_florest = Convert.ToDouble(txtBlackFlorest.Text);
            double ck_queen = Convert.ToDouble(txtQueenPark.Text);
            double ck_carlton = Convert.ToDouble(txtCarltonHill.Text);
            double ck_kilburn = Convert.ToDouble(txtKilbur.Text);
            double ck_lagos = Convert.ToDouble(txtLagosChocolate.Text);
            double ck_boston = Convert.ToDouble(txtBostonCream.Text);

            Cafe eat_in_cafe = new Cafe(cf_latte,cf_ilatte,cf_capp,cf_icapp, cf_african, cf_american, cf_vale, cf_espresso, ck_coffee,
                ck_velvet,ck_florest,ck_queen,ck_carlton,ck_kilburn,ck_lagos, ck_boston);

            double cost_drinks = (cf_latte * latte) + (cf_ilatte * ilatte) + (cf_capp * capp) + (cf_icapp * icapp) + 
                (cf_african * african) + (cf_american * american) + (cf_vale * vale) + (cf_espresso * espresso);
            lblCostDrinks.Text = cost_drinks.ToString("C");//Convert.ToString(cost_drinks);

            double cost_cakes = (ck_coffee * coffee) + (ck_velvet * velvet) +
                (ck_florest * florest) + (ck_queen * queen) + (ck_carlton * carlton) +
                (ck_kilburn * kilburn) + (ck_lagos * lagos) + (ck_boston * boston);
            lblCakes.Text = cost_cakes.ToString("c");//Convert.ToString(cost_cakes);

            // this try-cacth created because without it, the code launch an expection on lblServiceCharge.Text
            // when we reclick on total to update changing on item qte.
            try
            {
                double service_charge = Convert.ToDouble(lblServiceCharge.Text);

                if (lblServiceCharge.Text != "")
                {
                    double txServ;
                    txServ = 1.75; 
                    lblServiceCharge.Text = txServ.ToString();
                                        
                    //double service_charge = Convert.ToDouble(lblServiceCharge.Text);
                }
            
                lblCakes.Text = cost_cakes.ToString("c");//String.Format("{0:C}", cost_cakes);
                lblCostDrinks.Text = String.Format("{0:C}", cost_drinks);
                lblServiceCharge.Text = String.Format("{0:C}", service_charge);
                                               
            }
            catch { }

            double subtotal2, txS;
            txS = 1.75; // this value 1.75 appears 2 more times: one on load default and another in try-cacht before
            subtotal2 = cost_cakes + cost_drinks + txS;
            lblSubTotal.Text = subtotal2.ToString("c");

            double tax;
            tax = 0.45;
            lblTax.Text = Convert.ToString(((cost_cakes + cost_drinks + txS) * tax) / 100);
            double iTax = Convert.ToDouble(lblTax.Text);
            lblTax.Text = String.Format("{0:C}", iTax);

            lblTotal.Text = String.Format("{0:C}", (cost_cakes + cost_drinks + txS + iTax));
        }

    }
    
}
