using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmTicketManagement : Form
    {
        public frmTicketManagement()
        {
            InitializeComponent();
            SetupSimpleUI();

            comboCategory.Items.Clear();
            comboCategory.Items.AddRange(new[]
            {
                "Category One",
                "Category Two",
                "Category Three"
            });
            comboCategory.SelectedIndex = 0;
            radioMale.Checked = true;
        }

        // -------------------------------
        // SIMPLE UI ENHANCEMENTS
        // -------------------------------
        private void SetupSimpleUI()
        {
            // Button hover effects
            AddHover(btnCalculate);
            AddHover(btnClear);
            AddHover(btnExit);

            // Textbox focus highlight
            AddFocus(txtName);
            AddFocus(txtAge);
            AddFocus(txtDistance);

            // Only allow numbers for Age & Distance
            txtAge.KeyPress += OnlyNumbers;
            txtDistance.KeyPress += OnlyNumbers;

            // Cursor polish
            btnCalculate.Cursor = Cursors.Hand;
            btnClear.Cursor = Cursors.Hand;
            btnExit.Cursor = Cursors.Hand;
        }

        // -------------------------------
        // BUTTON HOVER EFFECT
        // -------------------------------
        private void AddHover(Button btn)
        {
            Color original = btn.BackColor;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = ControlPaint.Dark(original);
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = original;
            };
        }

        // -------------------------------
        // TEXTBOX FOCUS EFFECT
        // -------------------------------
        private void AddFocus(TextBox txt)
        {
            txt.Enter += (s, e) =>
            {
                txt.BackColor = Color.LightYellow;
            };

            txt.Leave += (s, e) =>
            {
                txt.BackColor = Color.White;
            };
        }

        // -------------------------------
        // ONLY NUMBERS INPUT
        // -------------------------------
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Designer references this click handler (lblName.Click += rrn;)
        // Provide an empty implementation so the Designer can load.
        private void rrn(object sender, EventArgs e)
        {
            // Intentionally empty - kept to satisfy Designer event hookup.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtDistance.Clear();
            comboCategory.SelectedIndex = 0;
            radioMale.Checked = true;
            lblResult.Text = "R 0.00";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Invalid age");
                return;
            }

            if (!double.TryParse(txtDistance.Text, out double distance))
            {
                MessageBox.Show("Invalid distance");
                return;
            }

            string gender = radioMale.Checked ? "Male" : "Female";
            string category = comboCategory.SelectedItem.ToString();

            // ---- CALCULATIONS ----
            double ratePerKm = category switch
            {
                "Category One" => 20.0,
                "Category Two" => 35.0,
                "Category Three" => 50.0,
                _ => 0.0
            };

            if (age < 12)
            {
                lblResult.Text = "R 0.00";
                lblDiscountResult.Text = "Free";
            }
            else
            {
                double baseFare = ratePerKm * distance;
                double discount = gender == "Female" ? 0.5 : 0.0;
                double total = baseFare * (1 - discount);

                lblResult.Text = $"R {total:F2}";
                lblDiscountResult.Text = $"{discount * 100}%";
            }

            // ---- UPDATE UI FIELDS ----
            lblNameResult.Text = txtName.Text;
            lblCategoryResult.Text = category;
            lblDistanceResult.Text = distance.ToString();
        }

    }
}