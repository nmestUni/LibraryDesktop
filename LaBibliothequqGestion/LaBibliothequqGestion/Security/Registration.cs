using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaBibliothequqGestion.Security
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            PswField.PasswordChar = '*';
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            string NM, PSW;
            NM = NameField.Text;
            PSW = PswField.Text;

            if(NM.Length< 6 || PSW.Length < 6)
            {

                MessageBox.Show("Name and Pasword should contain minimum 6 letter");

            }
            else {
                //using (Films_dbEntities db = new Films_dbEntities())
                //{
                //    var user = db.Users.Where(x => x.Name.Equals(NM)).FirstOrDefault();
                //    if (user == null)
                //    {
                //        MessageBox.Show("რეგისტაციამ წარმატებით ჩაიარა");

                //        this.Hide();
                        
                //        var t = new User
                //        {
                //            Name = NM,
                //            Password = PSW
                //        };

                //        db.Users.Add(t);
                //        db.SaveChanges();

                //        var g = new Thread(() => Application.Run(new LogIn()));
                //        g.Start();
                //        this.Close();
                //        this.Hide();

                //    }
                //    else
                //    {
                //        MessageBox.Show("მომხმარებელი ესეთი მონაცემებით უკვე არსებობს");
                //        NameField.ResetText();
                //        PswField.ResetText();
                //    }
                //}

            }

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
    
}
