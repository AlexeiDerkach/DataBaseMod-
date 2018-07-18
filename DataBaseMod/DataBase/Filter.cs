using System;

namespace NCE.DataBase
{
    public class Filter
    {
        public DateTime FirstDate { get; set; } = DateTime.Today;
        public DateTime SecondDate { get; set; } = DateTime.Today;
        public string Fio { get; set; } = "";
        public string Shift { get; set; } = "";
        public string Lot { get; set; } = "";
        public string LotNumb { get; set; } = "";
        public string HeatNumb { get; set; } = "";
        public string SerialNumb { get; set; } = "";
        public bool ControlCheckBox { get; set; } = false;
        public int ControlResult { get; set; } = 0;
    }
}
