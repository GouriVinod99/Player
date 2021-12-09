using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace Player
{
    public partial class ViewPlayers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPlayers_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;userid=root;password=Mysql;database=ustglobaldb");
            MySqlDataAdapter adap = new MySqlDataAdapter("Select * from Players", con);
            DataSet dsObj = new DataSet();
            adap.Fill(dsObj, "plr");

            grdPlayers.DataSource = dsObj.Tables["plr"];
            grdPlayers.DataBind();
        }
    }
}