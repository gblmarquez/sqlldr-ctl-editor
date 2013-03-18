using SqlLoaderEditor.Core;
using System.ComponentModel;

namespace SqlLoaderEditor.Models
{
    public class FixedSizeFieldModel : FieldModel
    {
        private int _length;
        private int _positionEnd;

        public int PositionStart { get; set; }
        public int Length
        {
            get { return _length; }
            set
            {
                if (value != this._length)
                {
                    this._length = value;
                    this.PositionEnd = this.PositionStart + value;
                    NotifyPropertyChanged("Length");
                }
            }
        }
        public int PositionEnd
        {
            get { return _positionEnd; }
            set
            {
                if (value != this._positionEnd)
                {
                    this._positionEnd = value;
                    NotifyPropertyChanged("PositionEnd");
                }
            }
        }
    }

    public class FieldModel : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public DataTypes DataType { get; set; }
        public bool IsFiller { get; set; }
        public bool DataTypeIsExternal { get; set; }
        public string Operators { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
