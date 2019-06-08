using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace LaBibliothequqGestion
{
    public partial class ProgramMain : Form
    {
        private AsyncMethods clientMethods = new AsyncMethods("http://172.16.0.234/");

        public ProgramMain()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        #region Users
        private void UsertabTage_Enter(object sender, EventArgs e)
        {
            this.BooksDataGridView.AutoGenerateColumns = false;
            this.BooksDataGridView.DataSource = null;
            var result = Task.Run(async () => { return await clientMethods.GetAllBooks(); }).Result;
            this.BooksDataGridView.DataSource = result;
        }

        private List<Book> testc()
        {
            var test =  clientMethods.GetAllBooks();
            test.Wait();
            var result = test.Result;
            return result;
        }

        private void BooksDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (sender != null)
            {
                if (e.RowIndex >= 0)
                {
                   //book = ()this.BooksDataGridView.Rows[e.RowIndex].DataBoundItem;
                }
                else
                {
                    if (this.BooksDataGridView.CurrentRow != null)
                    {
                        //book = ()this.BooksDataGridView.CurrentRow.DataBoundItem;
                    }
                }
            }
        }

        private void BookAddButton_Click(object sender, EventArgs e)
        {

        }

        private void BookDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("წავშალოთ მონაცემი ?", "წაშლა", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
               //var BookModel = (Modelis saxeli)this.BooksDataGridView.CurrentRow.DataBoundItem;
            }
        }

        #endregion

        #region Author

        private void AuthorTabPage_Enter(object sender, EventArgs e)
        {
            this.AuthorsDataGridView.DataSource = null;
            //this.AuthorsDataGridView.AutoGenerateColumns = false;
        }

        private void AuthorsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (sender != null)
            {
                if (e.RowIndex >= 0)
                {
                    //author = ()this.AuthorsDataGridView.Rows[e.RowIndex].DataBoundItem;
                }
                else
                {
                    if (this.AuthorsDataGridView.CurrentRow != null)
                    {
                        //author = ()this.AuthorsDataGridView.CurrentRow.DataBoundItem;
                    }
                }
            }
        }

        private void AuthorAddButton_Click(object sender, EventArgs e)
        {

        }

        private void AuthorDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("წავშალოთ მონაცემი ?", "წაშლა", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                //var AuthorModel = (Modelis saxeli)this.AuthorsDataGridView.CurrentRow.DataBoundItem;
            }
        }

        #endregion

        #region Orders
        private void OrderTabPage_Enter(object sender, EventArgs e)
        {
            this.OrderGridView.DataSource = null;
            //this.OrderGridView.AutoGenerateColumns = false;
            this.UserComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void OrderGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (sender != null)
            {
                if (e.RowIndex >= 0)
                {
                    //order = ()this.OrderGridView.Rows[e.RowIndex].DataBoundItem;
                }
                else
                {
                    if (this.AuthorsDataGridView.CurrentRow != null)
                    {
                        //order = ()this.OrderGridView.CurrentRow.DataBoundItem;
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            System.Convert.ToInt32(this.UserComboBox.SelectedValue);
        }

        private void OrderConfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("დავადასტუროთ შეკვეთა ?", "დადასტურება", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                //var AuthorModel = (Modelis saxeli)this.AuthorsDataGridView.CurrentRow.DataBoundItem;

            }
        }

        private void OrderDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("დავასრულოთ შეკვეთა ?", "დასრულება", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {

            }
        }

        #endregion


    }
}
