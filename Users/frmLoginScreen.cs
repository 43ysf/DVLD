using DVLD_Business.Users;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using DVLD;

namespace DVLD_Presentation.Users
{
    public partial class frmLoginScreen : Form
    {
        private string _docPath = "C:\\Users\\Yousif\\source\\repos\\DVLD_Presentation\\RememberMe.text";
        //clsUser User = null;

        // Importing necessary functions from user32.dll
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;





        public frmLoginScreen()
        {
            InitializeComponent();

            if(_FileHasRows(_docPath))
            {
                //string[] info = File.ReadAllText(_docPath).Split('#') ;


                string[] info = File.ReadAllText(_docPath).Split(new string[] { "##" },
                    StringSplitOptions.None);



                txtUsetName.Text = info[0];
                txtPassword.Text = info[1];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }




        private bool _FileHasRows(string filePath)
        {
            // تحقق مما إذا كان الملف موجودًا
            if (!File.Exists(filePath))
            {
                return false;
            }

            // قراءة الملف والتحقق من وجود أسطر
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadLine() != null;
            }
        }

        private void _Login(string username, string password)
        {
            clsUser user = clsUser.Find(username, password);
            if (user == null )
            {
                MessageBox.Show("Invalid username or passowrd ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!user.IsActive)
            {
                MessageBox.Show("sorry user is not active ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //MessageBox.Show("The name of user is: " + user.Person.FirstName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                frmMain frm = new frmMain(user);
                frm.Show();
                this.Hide();

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtUsetName.Text))
            {
                MessageBox.Show("Username must not be empty", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsetName.Focus();
                return;
            }


            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                {
                    MessageBox.Show("Password must not be empty", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;

                }
            }



            if (cbRememberMe.Checked)
            {
                
                
                File.WriteAllText(_docPath, txtUsetName.Text + "##" + txtPassword.Text);


            }
            else
            {
                File.Create(_docPath).Close();

            }

            _Login(txtUsetName.Text, txtPassword.Text);




        }
    }
}
