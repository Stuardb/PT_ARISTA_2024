using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Front.Classes;
using System.Threading.Tasks;


namespace Front
{
    public partial class LandingPage : System.Web.UI.Page
    {
        object[] DataControls = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataControls = new object[] { TxtName, TxtSName, TxtMail, TxtPhone, TxtAdress, TxtZipCode, LbCountry, TxtMessage };
        }

        protected void BtnSend_Click(object sender, EventArgs e)
        {
            if (!ErrorInData())
            {
                ClientData ClientData = new ClientData
                {
                    Name = TxtName.Text,
                    SName = TxtSName.Text,
                    Phone = Convert.ToInt32(TxtPhone.Text),
                    Adress = TxtAdress.Text,
                    ZipCode = TxtZipCode.Text,
                    Mail = TxtMail.Text,
                    Message = TxtMessage.Text,
                };
                string json = JsonConvert.SerializeObject(ClientData);
                ShowMessage("Correcto", $"Sus datos son:\\n{json}.");

                Task.Run(() => POST_ClientDataAsync(ClientData));
            }
            else
            {
                ShowMessage("Error", "Hubo un problema con los datos.");
            }
        }
        private async Task POST_ClientDataAsync(ClientData clientData)
        {
            POST WEB_API = new POST();
            await WEB_API.POST_ClientData(clientData);
        }
        protected bool ErrorInData()
        {            
            bool Error = false;            
            try
            {
                foreach (object Control in DataControls)
                {
                    if (ErrorInDataType(Control))
                    {
                        Error = true;
                        throw new Exception($"Verifica el campo {((TextBox)Control).Attributes["placeholder"]}");
                    }
                }                
            }
            catch (Exception e) 
            {
                ShowMessage("Error", $"Error: {e.Message}.");
            }
            return Error;
        }
        protected bool ErrorInDataType(Object Control)
        {
            if (Control is TextBox)
            {
                TextBox TextBox = (TextBox)Control;                
                switch (TextBox.TextMode.ToString())
                {
                    case "Phone":
                        if (!int.TryParse(TextBox.Text, out int phone) || TextBox.Text.Length != 8) return true;
                        break;
                    case "Number":
                        if (TextBox.Text.Length != 5) return true;
                        break;
                    case "SingleLine":
                        if (TextBox.Text.Length == 0) return true;
                        break;
                }
            }
            return false;
        }
        protected void ShowMessage(string Title, string Message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), $"{Title}", $"alert('{Message}');", true);
        }

    }
}