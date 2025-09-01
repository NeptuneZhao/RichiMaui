using System;
using System.Collections.ObjectModel;

namespace RichiMaui.Pages;

public partial class Paishan : ContentPage
{
    private ObservableCollection<StackItem> wallStacks = new();

    public Paishan()
    {
        InitializeComponent();
        BuildWall();
    }

    private void BuildWall()
    {
        wallStacks.Clear();
        for (int i = 1; i <= 68; i++)
        {
            wallStacks.Add(new StackItem { Index = i, Color = Colors.LightGray });
        }
        WallView.ItemsSource = wallStacks;
    }

    private void OnRollDiceClicked(object sender, EventArgs e)
    {
        var rnd = new Random();
        int dice = rnd.Next(2, 13); // 2~12
        DiceResultLabel.Text = $"���ӵ�����{dice}";

        string startPlayer = dice switch
        {
            1 or 5 or 9 => "�Լ�",
            2 or 6 or 10 => "�¼�",
            3 or 7 or 11 => "�Լ�",
            4 or 8 or 12 => "�ϼ�",
            _ => "δ֪"
        };
        StartPlayerLabel.Text = $"��ץ��ң�{startPlayer}";

        // ȷ���е㣺�����Ҽ���ÿ�� 17 ����˳ʱ�����У��Լ�[1-17] �¼�[18-34] �Լ�[35-51] �ϼ�[52-68]
        int baseIndex = startPlayer switch
        {
            "�Լ�" => 0,
            "�¼�" => 17,
            "�Լ�" => 34,
            "�ϼ�" => 51,
            _ => 0
        };

        int splitIndex = baseIndex + dice;
        if (splitIndex > 68) splitIndex -= 68; // ����

        SplitStackLabel.Text = $"�������ţ�{splitIndex}";

        // ������ʾ�е�
        foreach (var s in wallStacks)
            s.Color = Colors.LightGray;
        wallStacks[splitIndex - 1].Color = Colors.Orange;
    }
}

public class StackItem
{
    public int Index { get; set; }
    public Color Color { get; set; }
}