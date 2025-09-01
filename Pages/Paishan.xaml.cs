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
        DiceResultLabel.Text = $"骰子点数：{dice}";

        string startPlayer = dice switch
        {
            1 or 5 or 9 => "自己",
            2 or 6 or 10 => "下家",
            3 or 7 or 11 => "对家",
            4 or 8 or 12 => "上家",
            _ => "未知"
        };
        StartPlayerLabel.Text = $"起抓玩家：{startPlayer}";

        // 确定切点：这里我假设每人 17 摞，顺时针排列：自己[1-17] 下家[18-34] 对家[35-51] 上家[52-68]
        int baseIndex = startPlayer switch
        {
            "自己" => 0,
            "下家" => 17,
            "对家" => 34,
            "上家" => 51,
            _ => 0
        };

        int splitIndex = baseIndex + dice;
        if (splitIndex > 68) splitIndex -= 68; // 环绕

        SplitStackLabel.Text = $"切牌摞号：{splitIndex}";

        // 高亮显示切点
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