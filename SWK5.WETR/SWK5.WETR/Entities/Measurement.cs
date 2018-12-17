using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class Measurement : BaseEntity
    {
        public double Value { get; set; } // measured in measurementUnit
        public double MeasurementUnitId { get; set; } // FK on UnitOfMeasurement
        public DateTime TimeStamp { get; set; }
        public double StationId { get; set; } // FK on Station
        public Measurement(double value, double measurementUnitId, DateTime timeStamp, double stationId, int id = -1) : base(id)
        {
            this.Value = value;
            this.MeasurementUnitId = measurementUnitId;
            this.TimeStamp = timeStamp;
            this.StationId = stationId;
        }
		public override string ToString() {
			return base.ToString()
				+ ", Value[" + Value + "]"
				+ ", MeasurementUnitId[" + MeasurementUnitId + "]"
				+ ", TimeStamp[" + TimeStamp + "]"
				+ ", StationId[" + StationId + "]"
				;
		}
	}
}
