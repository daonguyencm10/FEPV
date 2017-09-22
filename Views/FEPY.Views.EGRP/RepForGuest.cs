using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Collections.Generic;
using System.IO;

namespace FEPV.Views
{
    public partial class RepForGuest : DevExpress.XtraReports.UI.XtraReport
    {
        public RepForGuest()
        {
            InitializeComponent();
            bindingSource1.DataSource = listpb;
        }

        List<ModelForGuestRep> listpb = new List<ModelForGuestRep>();

        public void InitializeValues(DataTable dt)
        {
            ModelForGuestRep _ModelForGuestRep;

            foreach (DataRow row in dt.Rows)
            {
                _ModelForGuestRep = new ModelForGuestRep();
                _ModelForGuestRep._VoucherID = row["VoucherID"].ToString();
                _ModelForGuestRep._��Ա���� = row["GuestType"].ToString();
                _ModelForGuestRep._���� = row["GuestName"].ToString();
                _ModelForGuestRep._֤������ = row["IdCard"].ToString();
                _ModelForGuestRep._������λ = row["Enterprise"].ToString();
                _ModelForGuestRep._���� = row["Content"].ToString();
                _ModelForGuestRep._�������� = row["Region"].ToString();
                _ModelForGuestRep._���� = row["CardNO"].ToString();
                _ModelForGuestRep._�ܷ������� = row["RespondentsName"].ToString();
                _ModelForGuestRep._����ʱ�� = row["InTime"].ToString();
                _ModelForGuestRep._����ʱ�� = row["OutTime"].ToString();

                MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                Image image = Image.FromStream(ms, true);                
                _ModelForGuestRep._��Ƭ = image;

                listpb.Add(_ModelForGuestRep);
            }
        }

        public string[] Values
        {
            set
            {
                lblDate.Text = value[0];//����
            }
        }
    }

    public class ModelForGuestRep
    {
        public string _VoucherID { get; set; }
        public string _��Ա���� { get; set; }
        public string _���� { get; set; }
        public string _֤������ { get; set; }
        public string _������λ { get; set; }
        public string _���� { get; set; }
        public string _���� { get; set; }
        public string _�ܷ������� { get; set; }
        public string _�������� { get; set; }
        public string _����ʱ�� { get; set; }
        public string _����ʱ�� { get; set; }
        public Image _��Ƭ { get; set; }
    }
}
