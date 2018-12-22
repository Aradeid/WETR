using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SWK5.Simulator
{
    public class TemperatureViewModel : INotifyPropertyChanged
    {
        private double _trend;
        private double _count;
        private double _currentLecture;
        private bool _isHot;

        public TemperatureViewModel()
        {
            
        }

        public bool IsReading { get; set; } = false;
        
        public double Count
        {
            get { return _count; }
            set
            {
                _count = value;
                OnPropertyChanged("Count");
            }
        }

        public double CurrentLecture
        {
            get { return _currentLecture; }
            set
            {
                _currentLecture = value;
                OnPropertyChanged("CurrentLecture");
            }
        }

        public bool IsHot
        {
            get { return _isHot; }
            set
            {
                var changed = value != _isHot;
                _isHot = value;
                if (changed) OnPropertyChanged("IsHot");
            }
        }

        public ICommand StopCommand()
        {
            return new RelayCommand(param => Stop());
        }

        public ICommand ReadCommand()
        {
            return new RelayCommand(param => Read(), param => !IsReading);
        }

        public ICommand ClearCommand()
        {
            return new RelayCommand(param => Clear());
        }

        private void Stop()
        {
            IsReading = false;
        }

        private void Clear()
        {
            // empty the local storage collection
            //Values.Clear();
        }

        private void Read()
        {
            IsReading = true;

            Action readFromTread = () =>
            {
                while (IsReading)
                {
                    Thread.Sleep(100);
                    var r = new Random();
                    _trend += (r.NextDouble() < 0.5 ? 1 : -1) * r.Next(0, 10) * .001;

                    IsHot = _trend > 0;
                    CurrentLecture = _trend;
                }
            };
            
            Task.Factory.StartNew(readFromTread);
            //Task.Factory.StartNew(readFromTread);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}