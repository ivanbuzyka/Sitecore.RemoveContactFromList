using Sitecore.Configuration;
using Sitecore.EmailCampaign.Cm;
using Sitecore.SecurityModel;
using Sitecore.sitecore.admin;
using Sitecore.XConnect;
using System;

namespace RemoveFromOptOut
{
  public partial class RemoveFromGlobalOptOut : AdminPage
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void Remove_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(Email.Text))
      {
        StatusLiteral.Text = "Please enter E-Mail address <br />";
        return;
      }
      if (string.IsNullOrEmpty(ContactListId.Text))
      {
        StatusLiteral.Text = "Please enter Contact Lst ID <br />";
        return;
      }

      var contactList = new Guid(ContactListId.Text);

      using (new SecurityDisabler())
      {
        (Factory.CreateObject("exm/subscriptionManager", true) as ISubscriptionManager).RemoveContactFromList(new ContactIdentifier("ListManager", Email.Text, ContactIdentifierType.Known), contactList);
      }

      StatusLiteral.Text = string.Format("Removed {0} from ontact list {1}", Email.Text, ContactListId.Text);
      Email.Text = string.Empty;
      ContactListId.Text = string.Empty;
    }
  }
}