namespace RichiMaui.Pages;

public partial class Fanshu : ContentPage
{
	public Fanshu()
	{
		InitializeComponent();
		BindingContext = new FanshuModel();
		DaDianLabel.Text = "";
		MessageDisplay.Text = "";
	}

	private async void CalDaDian(object sender, EventArgs e)
	{
		FanshuModel model = (FanshuModel)BindingContext;

		bool displayAlert = false;
		string title = "�㻹ûѡ��Щ���ݣ�";
		string msg = string.Empty;
		if (model.ZhuangOrXianjia is null)
		{
			msg += "ׯ��/�мң�";
			displayAlert = true;
		}
		if (model.ZimoOrRong is null)
		{
			msg += "����/�٣�";
			displayAlert = true;
		}
		if (model.Fan is null)
		{
			msg += "������";
			displayAlert = true;
		}
		int fan = 0, fu = 0;
		if (model.Fan is not null)
		{
			fan = int.Parse(model.Fan.ToString());
			if (fan < 5)
			{
				if (model.Fu is null)
				{
					msg += "����";
					displayAlert = true;
				}
				else
				{
					fu = int.Parse(model.Fu.ToString());
				}
			}
		}
		if (displayAlert)
		{
			await DisplayAlert(title, msg, "֪����");
			return;
		}

		int zhuang = int.Parse(model.ZhuangOrXianjia.ToString()),
			zimo = int.Parse(model.ZimoOrRong.ToString());

		string messageDisplay =
			(zhuang == 6 ? "ׯ�� " : "�м� ") +
			(zimo == 0 ? "���� " : "�ٺ� ") +
			(model.BenChang is null ? 0 : model.BenChang.ToString()) + "���� ";

		int normalDian;

		if ((fan == 3 && fu >= 70) || (fan == 4 && fu >= 40) || fan == 5)
			normalDian = 2000;
		else if (fan == 6)
			normalDian = 3000;
		else if (fan == 8)
			normalDian = 4000;
		else if (fan == 11)
			normalDian = 6000;
		else if (fan == 13)
			normalDian = 8000;
		else if (fan == 26)
			normalDian = 16000;
		else
		{
			normalDian = fu;
			for (int i = 0; i < fan + 2; i++)
				normalDian *= 2;

		}
			int benChang = model.BenChang is null ? 0 : int.Parse(model.BenChang.ToString());
		string show = string.Empty;
		if (zhuang == 6)
		{
			if (zimo == 0)
			{
				show = $"{Upper(normalDian * 2) + 100 * benChang} ALL";
			}
			else
				show = $"{Upper(normalDian * 6) + 300 * benChang}";
		}
		else
		{
			if (zimo == 0)
			{
				show = $"{Upper(normalDian) + 100 * benChang} / {Upper(normalDian * 2) + 100 * benChang}";
			}
			else
				show = $"{Upper(normalDian * 4) + 300 * benChang}";

		}
		DaDianLabel.Text = show;
		MessageDisplay.Text = messageDisplay + "�� " + show;
	}

	private static int Upper(int value)
	{
		// ����100���Ͻ�
		if (value % 100 == 0)
			return value;
		else
			return 100 * ((int)(value / 100.0) + 1);
	}
}