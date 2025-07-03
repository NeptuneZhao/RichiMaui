namespace RichiMaui.Pages;

using System.Reflection;

public partial class Calculator : ContentPage
{
	public Calculator()
	{
		InitializeComponent();
		BindingContext = new CalculatorBindingModel();
        FushuLabel.Text = "";
	}

	private void CalculateFu(object sender, EventArgs e)
	{
		CalculatorBindingModel model = (CalculatorBindingModel)BindingContext;
        int Fu = 20 +
			ValueOf(model.HupaiType) + ValueOf(model.TingpaiType) +
			ValueOf(model.Mianzi1Type) + ValueOf(model.Mianzi2Type) +
			ValueOf(model.Mianzi3Type) + ValueOf(model.Mianzi4Type) +
			ValueOf(model.QuetouType);
        // 将 Fu 不足 10 的情况处理为 10,例如：52变为60
		if (Fu % 10 == 0)
			FushuLabel.Text = Fu.ToString();
		else
		{
			Fu = 10 * ((int)(Fu / 10.0) + 1);
            FushuLabel.Text = Fu.ToString();
        }
    }

	private static int ValueOf(object e) => Math.Abs(Convert.ToInt32(e));
}