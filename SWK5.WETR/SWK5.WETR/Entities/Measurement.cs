using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class Measurement : BaseEntity
    {
        private double value { get; } // measured in measurementUnit
        private double measurementUnitId { get; } // FK on UnitOfMeasurement
        private DateTime timeStamp { get; }
        private double stationId { get; } // FK on Station
        public Measurement(double value, double measurementUnitId, DateTime timeStamp, double stationId, int id = -1) : base(id)
        {
            this.value = value;
            this.measurementUnitId = measurementUnitId;
            this.timeStamp = timeStamp;
            this.stationId = stationId;
        }
		public override string ToString() {
			return base.ToString()
				+ ", value[" + value + "]"
				+ ", measurementUnitId[" + measurementUnitId + "]"
				+ ", timeStamp[" + timeStamp + "]"
				+ ", stationId[" + stationId + "]"
				;
		}
	}
}
