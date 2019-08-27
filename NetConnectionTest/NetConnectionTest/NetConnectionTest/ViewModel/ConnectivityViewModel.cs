using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using System.ComponentModel;

namespace NetConnectionTest.ViewModel
{

    public class ConnectivityViewModel : INotifyPropertyChanged
    {
        string _connectionStatus = "";
        //event triggered when connectivity changes
        public event PropertyChangedEventHandler PropertyChanged;
        public string ConnectionStatus
        {
            get { return _connectionStatus; }
            set
            {
                _connectionStatus = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ConnectionStatus"));
            }
        }

        public ConnectivityViewModel()
        {
            //load current status
            UpdateConnectionStatus();
            //Using CrossConnectivity class makes it easier to work across different platforms
            CrossConnectivity.Current.ConnectivityChanged += (sender, e) => { this.UpdateConnectionStatus(); };
        }

        void UpdateConnectionStatus()
        {
            //loop through all connectivity options available.
            if (CrossConnectivity.Current != null && CrossConnectivity.Current.IsConnected == true)
            {
                var str = "";
                foreach (ConnectionType type in CrossConnectivity.Current.ConnectionTypes)
                    str += type.ToString() + " ";
                ConnectionStatus = string.Format("Connected to {0}", str);
            }
            else
                ConnectionStatus = "Not Connected";
        }
    }
}
