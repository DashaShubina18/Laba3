using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBicycle_Click(object sender, EventArgs e)
        {
            
                Bicycle b = new Bicycle();
                fBicycle fb = new fBicycle(b);

                if (fb.ShowDialog() == DialogResult.OK)
                {
                tbBicyclesInfo.Text = string.Format(
                    "Модель: {0}, Рік: {1}, Колір: {2}. Ціна: {3:0.00} грн. Вага: {4:0.00} кг. Максимальне навантаження рами: {5} кг. Максимальна вага пасажира: {6} кг. {7} у використанні. {8} пошкоджений.",
                    b.Model,
                    b.Year,
                    b.Colour,
                    b.Price,
                    b.Weight,
                    b.FrameLoadCapacity,
                    b.CalculateMaxPassengerWeight(),
                    b.WasUsed ? "Був" : "Не був",
                    b.WasDamaged ? "Був" : "Не був"
                );
                }
                else
            {
                MessageBox.Show("Діалог не був завершений успішно");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==DialogResult.OK)
                Application.Exit();
        }
    }
}
