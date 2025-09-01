using System.ComponentModel;

namespace RichiMaui.PageModels
{
    /// <summary>
    /// 计算点数的绑定模板。
    /// </summary>
    public class FanshuModel : INotifyPropertyChanged
    {
        object
            zhuangOrXianjia,
            zimoOrRong,
            fan,
            fu;

        string benChang;
        
        public object ZhuangOrXianjia
        {
            get => zhuangOrXianjia;
            set
            {
                zhuangOrXianjia = value;
                OnPropertyChanged(nameof(ZhuangOrXianjia));
            }
        }

        public object ZimoOrRong
        {
            get => zimoOrRong;
            set
            {
                zimoOrRong = value;
                OnPropertyChanged(nameof(ZimoOrRong));
            }
        }

        public string BenChang
        {
            get => benChang;
            set
            {
                benChang = value;
                OnPropertyChanged(nameof(BenChang));
            }
        }

        public object Fan
        {
            get => fan;
            set
            {
                fan = value;
                OnPropertyChanged(nameof(Fan));
            }
        }

        public object Fu
        {
            get => fu;
            set
            {
                fu = value;
                OnPropertyChanged(nameof(Fu));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}