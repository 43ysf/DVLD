using DVLD_Business.Drivers;
using DVLD_Business.InternationalLicenses;
using DVLD_Business.Licenses;
using System.Data;
using System.Windows.Forms;

namespace DVLD.LicenseManagement
{
    public partial class frmLicenseHistory : Form
    {
        DataTable _International = null;
        DataTable _Local = null;
        clsDriver Driver = null;
      
        public frmLicenseHistory()
        {
            InitializeComponent();
        }
        public frmLicenseHistory(int DriverID)
        {

            InitializeComponent();
            Driver = clsDriver.Find(DriverID);
            this.ctrlFindOrAddUser1.grbFindOrAddGrbEnable(Driver.PersonID);
            _Local = clsLicense.GetAll(DriverID);
            _International = clsInternationalLicense.GetAll(DriverID);
            FillDataGirdeView();

        }
        public void FillDataGirdeView()
        {
            dgvInternationalLicenses.DataSource = _International;
            dgvLocalLicenses.DataSource = _Local;
        }
    }
}
