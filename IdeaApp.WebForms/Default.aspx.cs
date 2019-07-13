using IdeaApp.Models;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IdeaApp.WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            using (var context = new IdeaAppDbContext())
            {
                this.GridView1.DataSource = context.Ideas.ToList();
                this.GridView1.DataBind();
            }
        }
    }
}