// Logic Development - Wian Sandenbengh
using System;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp1
{
    //Connecting to Form1
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Connecting the drop down box
            comboCategory.Items.Clear();
            comboCategory.Items.AddRange(new[]{"Category One", "Category Two", "Category Three"});
            comboCategory.SelectedIndex = 0;
            //Conecting the Gender radio
            comboGender.Items.Clear();
            comboGender.Items.AddRange(new[]{"Male", "Female"});
            comboGender.SelectedIndex = 0;
            //Connecting all the buttons to my program
            btnCalculate.Click += BtnCalculate_Click;
            btnClear.Click += BtnClear_Click;
            btnExit.Click += BtnExit;
    }
    //Calculate Button Logic Implementation
    private void BtnCalculate_Click(object sender, EventArgs e)
    {
        //Making sure the label empty for us to send to later
        lblResult.Text = string.Empty;
        //Checking for valid input
        if (!double.TryParse(txtDistance.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out double distance)|| distance < 0)
        {
            lblResult.Text = "Enter a valid non-negative distance.";
            return;
        }
        //Checking for valid input
        if (!int.TryParse(txtAge.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int age)|| age < 0)
        {
            lblResult.Text = "Enter a valid non-negative age.";
            return;
        }
        //Checking if age is < 12 to give a free ticket
        if (age <12)
        {
            //Sending output to the Result label
            lblResult.Text = "Total: Free (age under 12)";
            return;
        }
        //Creating a ratePerKm var and checking what Category is chosen the applying the price to the var
        double ratePerKm = comboCategory.SelectedItem switch
        {
            string s when s == "Category One" => 20.0,
            string s when s == "Category Two" => 35.0,
            string s when s == "Category Three" => 50.0,
            //Setting default setcase
            _ => 0.0
        };

        //Checking for valid input
        if (ratePerKm <= 0)
        {
            lblResult.Text = "Select a valid category.";
            return;
        }
        
        //Setting an baseFare var
        double baseFare = ratePerKm * distance;
        //Setting an var that checks if the user is female so we can test for the discount later
        bool isFemale = (comboGender.SelectedItem as string)?.Equals("Female", StringComparison.OrdinallgnoreCase) == true;
        //Setting an var that sets the discount to 0 or 50% if they are female
        double discount = isFemale ? 0.5 : 0.0;
        //Setting an var that gets the total 
        double total = baseFare * (1.0 - discount);
        //Sending output to the Result label
        lblResult.Text $"Base: {baseFare:C2} Discount: {discount * 100}% Total: {total:C2}";
    }
    //Clear Button Logic Implementation
    private void BtnClear_Click(object sender, EventArgs e)
    {
        txtAge.Clear();
        comboGender.SelectedIndex = 0;
        comboCategory.SelectedIndex = 0;
        lblResult.Text = string.Empty;
        txtDistance.Clear();
    }
    //Exit Button Logic Implementation
    private void BtnExit_Click(object sender, EventArgs e)
    {
        Close();
    }
    //---------------------------------------------------------
    private static void InvokeCalculate(Form1 form)
{
    // Simulate button click
    form.GetType().GetMethod("BtnCalculate\_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
        ?.Invoke(form, new object[] { null, EventArgs.Empty });
}

private static void InvokeClear(Form1 form)
{
    form.GetType().GetMethod("BtnClear\_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
        ?.Invoke(form, new object[] { null, EventArgs.Empty });
}

private static void InvokeExit(Form1 form)
{
    form.GetType().GetMethod("BtnExit\_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
        ?.Invoke(form, new object[] { null, EventArgs.Empty });
}

public static void RunAll()
{
    using var form = new Form1();

    void PrintAndReset(string testName)
    {
        Console.WriteLine(\$"[{testName}] Result label: \"{form.lblResult.Text}\"");
        InvokeClear(form);
    }

    // 1) Invalid distance
    SetControls(form, "abc", "30", "Category One", "Male");
    InvokeCalculate(form);
    PrintAndReset("Invalid distance");

    // 2) Negative age
    SetControls(form, "10", "-5", "Category One", "Male");
    InvokeCalculate(form);
    PrintAndReset("Negative age");

    // 3) Free under 12
    SetControls(form, "100", "10", "Category Two", "Female");
    InvokeCalculate(form);
    PrintAndReset("Free under 12");

    // 4) Invalid category (simulate wrong selection)
    SetControls(form, "50", "20", "Invalid Category", "Male");
    InvokeCalculate(form);
    PrintAndReset("Invalid category");

    // 5) Female discount applied
    SetControls(form, "10", "25", "Category Three", "Female");
    InvokeCalculate(form);
    PrintAndReset("Female discount");

    // 6) Male no discount
    SetControls(form, "10", "25", "Category Three", "Male");
    InvokeCalculate(form);
    PrintAndReset("Male no discount");

    // 7) Clear button behavior
    SetControls(form, "123", "45", "Category One", "Female");
    InvokeClear(form);
    Console.WriteLine("[Clear button] txtDistance empty: " + string.IsNullOrEmpty(form.txtDistance.Text));

    // 8) Exit (invokes Close)
    SetControls(form, "1", "30", "Category One", "Male");
    InvokeExit(form);
    Console.WriteLine("[Exit] Form closed state cannot be directly observed here; ensure Close() was wired correctly.");
}
    //---------------------------------------------------------
        }
    }
}