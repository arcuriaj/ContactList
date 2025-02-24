namespace ContactList;

public partial class ContactList : ContentPage
{
    public List<ContactGroup> Contacts = new List<ContactGroup>();
	public ContactList()
	{
		InitializeComponent();

        Contacts.Add(new ContactGroup("A", new List<Contact> {
            new Contact(){name="Alex Johnson",email="ajohnson@email.com",phone="(123) 456-7890",desc="Best Friend",imgName="contact1.png"},
            new Contact(){name="Arielle Carter",email="acarter@email.com",phone="(123) 456-7890",desc="Coworker",imgName="contact2.png"},
            new Contact(){name="Alice Robinson",email="arobinson@email.com",phone="(123) 456-7890",desc="Baby Sitter",imgName="contact4.png"}}));

        Contacts.Add(new ContactGroup("J", new List<Contact> {
            new Contact(){name="Jayden Gallagher",email="jgallagher@email.com",phone="(123) 456-7890",desc="Coworker",imgName="contact1.png"},
            new Contact(){name="Jake Murray",email="jmurray@email.com",phone="(123) 456-7890",desc="Dad",imgName="contact3.png"},
            new Contact(){name="Joe Davies",email="jdavies@email.com",phone="(123) 456-7890",desc="Coworker",imgName="contact1.png"}}));

        Contacts.Add(new ContactGroup("M", new List<Contact> {
            new Contact(){name="Maya Murray",email="mmurray@email.com",phone="(123) 456-7890",desc="Mom",imgName="contact2.png"},
            new Contact(){name="Malaysia Decker",email="mdecker@email.com",phone="(123) 456-7890",desc="Friend",imgName="contact4.png"},
            new Contact(){name="Mack Melendez",email="mmelendez@email.com",phone="(123) 456-7890",desc="Friend",imgName="contact1.png"}}));

        Contacts.Add(new ContactGroup("P", new List<Contact> {
            new Contact(){name="Patrick Harrison",email="pharrison@email.com",phone="(123) 456-7890",desc="Coworker",imgName="contact1.png"},
            new Contact(){name="Paul Atkinson",email="patkinson@email.com",phone="(123) 456-7890",desc="Coworker",imgName="contact3.png"},
            new Contact(){name="Paige Hunt",email="phunt@email.com",phone="(123) 456-7890",desc="Coworker",imgName="contact4.png"}}));

        Contacts.Add(new ContactGroup("T", new List<Contact> {
            new Contact(){name="Terry Young",email="tyoung@email.com",phone="(123) 456-7890",desc="Friend",imgName="contact2.png"},
            new Contact(){name="Taylor Murray",email="tmurray@email.com",phone="(123) 456-7890",desc="Brother",imgName="contact1.png"},
            new Contact(){name="Tom Martin",email="tmartin@email.com",phone="(123) 456-7890",desc="Coworker",imgName="contact3.png"}}));
        lvContacts.ItemsSource = Contacts;
    }

    private void lvContacts_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Contact;
        if (selectedItem == null) return;
        Navigation.PushAsync(new ContactInfo(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }
}