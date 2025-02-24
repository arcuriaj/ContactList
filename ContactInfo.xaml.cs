namespace ContactList;

public partial class ContactInfo : ContentPage
{
	public ContactInfo(Contact item)
	{
		InitializeComponent();
		contactPhoto.Source = item.imgName;
		lblName.Text = item.name;
		lblDesc.Text = item.desc;
		lblPhone.Text = "Phone: " + item.phone;
		lblEmail.Text = "Email: " + item.email;
	}
}