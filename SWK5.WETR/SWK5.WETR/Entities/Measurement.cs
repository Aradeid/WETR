using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class Measurement : BaseEntity
    {       
        private double airTemperature { get; }
        private double airPressure { get; }
        private int precipitation { get; }
        private double humidity { get; }
        private double windSpeed { get; }
        private int windDirection { get; } // in degreees
        private double value { get; } // measured in measurementUnit
        private double measurementUnitId { get; } // FK on UnitOfMeasurement
        private DateTime timeStamp { get; }
        private double stationId { get; } // FK on Station
        public Measurement(double airTemperature, double airPressure, int precipitation, double humidity, double windSpeed, int windDirection, double value, double measurementUnitId, DateTime timeStamp, double stationId, int id = -1) : base(id)
        {
            this.airTemperature = airTemperature;
            this.airPressure = airPressure;
            this.precipitation = precipitation;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
            this.windDirection = windDirection;
            this.value = value;
            this.measurementUnitId = measurementUnitId;
            this.timeStamp = timeStamp;
            this.stationId = stationId;
        }
		public override string ToString() {
			return base.ToString()
				+ ", airTemperature[" + airTemperature + "]"
				+ ", airPressure[" + airPressure + "]"
				+ ", precipitation[" + precipitation + "]"
				+ ", humidity[" + humidity + "]"
				+ ", windSpeed[" + windSpeed + "]"
				+ ", windDirection[" + windDirection + "]"
				+ ", value[" + value + "]"
				+ ", measurementUnitId[" + measurementUnitId + "]"
				+ ", timeStamp[" + timeStamp + "]"
				+ ", stationId[" + stationId + "]"
				;
		}
	}
}
