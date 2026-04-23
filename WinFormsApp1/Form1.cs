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
    }
}