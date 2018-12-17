using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWK5.WETR.Entities;

namespace SWK5.WETR.DataLayer {
    interface IDataLayer {
        #region user
        ICollection<User> getAllUsers();
        User getUserById(int id);
        void addUser(User user);
        void updateUser(User user);
        void deleteUser(User user);
        #endregion

        #region station
        ICollection<Station> getAllStations();
        Station getStationById(int id);
        void addStation(Station station);
        void updateStation(Station station);
        void deleteStation(Station station);
        #endregion

        #region location
        ICollection<Location> getAllLocations();
        Location getLocationById(int id);
        void addLocation(Location location);
        void updateLocation(Location location);
        void deleteLocation(Location location);
        #endregion

        #region unitOfMeasurement
        ICollection<UnitOfMeasurement> getAllUnitOfMeanurements();
        UnitOfMeasurement getUnitOfMeanurementById(int id);
        void addUnitOfMeanurement(UnitOfMeasurement unit);
        void updateUnitOfMeanurement(UnitOfMeasurement unit);
        void deleteUnitOfMeanurement(UnitOfMeasurement unit);
        #endregion

        #region measurement
        ICollection<Measurement> getAllMeasurements();
        Measurement getMeasurementById(int id);
        Measurement getMeasurementByUnit(UnitOfMeasurement unit);
        ICollection<Measurement> getMeasurementsBetween(DateTime startTime, DateTime endTime);
        void addMeasurement(Measurement measurement);
        void updateMeasurement(Measurement measurement);
        void deleteMeasurement(Measurement measurement);
        #endregion
    }
}
