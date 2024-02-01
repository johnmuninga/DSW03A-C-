using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace lab3
{
    public partial class UjStaff : System.Web.UI.Page
         Logic logic = new Logic();
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

         //Start EmailAge
        void EmailAgeSetter()
        {
            logic.email = logic.createEmail(TxtName.Text, TxtSurname.Text);
            logic.age = logic.determineAge(TxtID.Text);
        }//End

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
        EmailAgeSetter();
        TxtEmail.Text = logic.email;
        TxtAge.Text = logic.age.ToString();
        }

    protected void BtnRead_Click(object sender, EventArgs e)
    {

        EmailAgeSetter();
        logic.ID = long.Parse(TextBox1.Text);
        logic.Name = TextBox2.Text;
        logic.Surname = TextBox3.Text;

        //Let's now start set the TextBoxes
        string result = logic.writeToDatabase();
        Console.WriteLine(result);
        MessageBox.Show(result);
        TxtID.Text = "";
        TxtName.Text = "";
        TxtSurname.Text = "";
        TxtEmail.Text = "";
        TxtAge.Text = "";
    }
    protected void BtnRead_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = logic.readAllData();
        GridView1.DataBind();
    }
    protected void TxtName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtSurname_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtAge_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TxtID_TextChanged(object sender, EventArgs e)
    {

    }
}
}