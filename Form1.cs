using System;
using System.Windows.Forms;

namespace RegistrationFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // إضافة عناصر إلى ComboBox عند تحميل النموذج
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // قراءة البيانات من الحقول
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string gender = cmbGender.SelectedItem?.ToString() ?? "Not Selected";

            // عرض البيانات داخل MessageBox
            string message = $"Name: {name}\nEmail: {email}\nPhone: {phone}\nGender: {gender}";
            MessageBox.Show(message, "Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

