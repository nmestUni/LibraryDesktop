using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaBibliothequqGestion.Operations
{
    public partial class AuthorUpload : Form
    {
        public AuthorUpload()
        {
            InitializeComponent();

            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BookUploadButton_Click(object sender, EventArgs e)
        {
            try
            {

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
