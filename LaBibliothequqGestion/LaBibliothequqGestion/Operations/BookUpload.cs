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
    public partial class BookUpload : Form
    {
        public BookUpload()
        {
            InitializeComponent();

            try
            {
                this.AuthorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                BookPagesNumericUpDown.Maximum = long.MaxValue;

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
