using System.ComponentModel;

namespace RichiMaui.PageModels
{
	/// <summary>
	/// 计算符页面的绑定模板。
	/// </summary>
	public class CalculatorBindingModel : INotifyPropertyChanged
	{
		string groupName;
		object selection;

		object hupaiType, tingpaiType, mianzi1Type, mianzi2Type, mianzi3Type, mianzi4Type, quetouType;

		public string GroupName
		{
			get => groupName;
			set
			{
				groupName = value;
				OnPropertyChanged(nameof(GroupName));
			}
		}

		public object Selection
		{
			get => selection;
			set
			{
				selection = value;
				OnPropertyChanged(nameof(Selection));
			}
		}

		public object HupaiType
		{
			get => hupaiType;
			set
			{
				hupaiType = value;
				OnPropertyChanged(nameof(HupaiType));
			}
		}

		public object TingpaiType
		{
			get => tingpaiType;
			set
			{
				tingpaiType = value;
				OnPropertyChanged(nameof(TingpaiType));
			}
		}

		public object Mianzi1Type
		{
			get => mianzi1Type;
			set
			{
				mianzi1Type = value;
				OnPropertyChanged(nameof(Mianzi1Type));
			}
		}

		public object Mianzi2Type
		{
			get => mianzi2Type;
			set
			{
				mianzi2Type = value;
				OnPropertyChanged(nameof(Mianzi2Type));
			}
		}

		public object Mianzi3Type
		{
			get => mianzi3Type;
			set
			{
				mianzi3Type = value;
				OnPropertyChanged(nameof(Mianzi3Type));
			}
		}

		public object Mianzi4Type
		{
			get => mianzi4Type;
			set
			{
				mianzi4Type = value;
				OnPropertyChanged(nameof(Mianzi4Type));
			}
		}

		public object QuetouType
		{
			get => quetouType;
			set
			{
				quetouType = value;
				OnPropertyChanged(nameof(QuetouType));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}