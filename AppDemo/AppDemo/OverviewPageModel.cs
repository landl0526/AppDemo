using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppDemo
{
    public class OverviewPageModel : INotifyPropertyChanged
    {
        VehicleStatePageModel vehicleState;
        public VehicleStatePageModel VehicleState
        {
            get
            {
                return vehicleState;
            }
            set
            {
                vehicleState = value;
                OnPropertyChanged("VehicleState");
            }
        }

        public OverviewPageModel()
        {
            VehicleState = new VehicleStatePageModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class VehicleStatePageModel : INotifyPropertyChanged
    {
        TiresPageModel tires;
        public TiresPageModel Tires
        {
            get
            {
                return tires;
            }
            set
            {
                tires = value;
                OnPropertyChanged("Tires");
            }
        }

        public VehicleStatePageModel()
        {
            Tires = new TiresPageModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class TiresPageModel : INotifyPropertyChanged
    {
        int typeSelectedIndex;
        public int TypeSelectedIndex
        {
            get
            {
                return typeSelectedIndex;
            }
            set
            {
                if (typeSelectedIndex != value)
                {
                    typeSelectedIndex = value;
                    OnPropertyChanged("TypeSelectedIndex");
                }
            }
        }

        List<string> tiresTypeList;
        public List<string> TiresTypeList
        {
            set
            {
                tiresTypeList = value;
                OnPropertyChanged("TiresTypeList");
            }
            get
            {
                return tiresTypeList;
            }
        }

        public TiresPageModel()
        {
            TiresTypeList = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                TiresTypeList.Add("item" + i);
            }

            TypeSelectedIndex = 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
