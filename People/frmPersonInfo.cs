using System;
using System.Windows.Forms;
using DVLD_Business.People;

namespace DVLD.People
{
    public partial class frmPersonInfo : Form
    {
        public frmPersonInfo(int PersonID)
        {
            InitializeComponent();
            clsPerson Person = clsPerson.Find(PersonID);
            ctrlPersonInfo.FillPersonInfo(Person);
        }

        // ctrlPersonInfo ctr = new ctrlPersonInfo();


    }
}
