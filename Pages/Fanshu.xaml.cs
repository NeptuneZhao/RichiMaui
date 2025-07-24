namespace RichiMaui.Pages;

public partial class Fanshu : ContentPage
{
	public Fanshu()
	{
		InitializeComponent();
		BindingContext = new FanshuModel();
	}

    public void OnBenchangCompleted(object sender, EventArgs e)
	{
		((FanshuModel)BindingContext).BenChang = ((Editor)sender).Text;
	}
}