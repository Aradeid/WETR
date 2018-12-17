using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWK5.WETR.Entities;

namespace SWK5.WETR.DataLayer {
    class MockDataLayer : IDataLayer {
        #region static properties
        private static int globalUserId = 0;
        private static ICollection<User> userCollection = new List<User>();

        private static int globalStationId = 0;
        private static ICollection<Station> stationCollection = new List<Station>();

        private static int globalLocationId = 0;
        private static ICollection<Location> locationCollection = new List<Location>();

        private static int globalUnitId = 0;
        private static ICollection<UnitOfMeasurement> unitCollection = new List<UnitOfMeasurement>();

        private static int globalMeasurementId = 0;
        private static ICollection<Measurement> measurementCollection = new List<Measurement>();
        #endregion

        #region user
        public ICollection<User> getAllUsers() {
            return userCollection;
        }
        public User getUserById(int id) {
            foreach (User user in userCollection) {
                if (user.Id == id) {
                    return user;
                }
            }

            throw new ArgumentException(id + " is not a valid Id");
        }
        public void addUser(User user) {
            try {
                getUserById(user.Id);

                throw new ArgumentException(user + " cannot be added as its Id is already in the database.");
            } catch (ArgumentException ae) {
                userCollection.Add(user);
            }
        }
        public void updateUser(User user) {
            foreach (User u in userCollection) {
                if (u.Id == user.Id) {
                    u.Name = user.Name;
                    u.PrivilegeId = user.PrivilegeId;
                    u.StationId = user.StationId;
                    return;
                }
            }

            throw new ArgumentException(user + " does not exist in the database and therefore cannot be updated.");
        }
        public void deleteUser(User user) {
            userCollection.Remove(user);
            /*
            foreach (User u in userCollection) {
                if (u.Id == user.Id) {
                    userCollection.Remove(u);
                    return;
                }
            }
            */
        }
        #endregion

        #region station
        public ICollection<Station> getAllStations() {
            return stationCollection;
        }
        public Station getStationById(int id) {
            foreach (Station station in stationCollection) {
                if (station.Id == id) {
                    return station;
                }
            }

            throw new ArgumentException(id + " is not a valid Id");
        }
        public void addStation(Station station) {
            try {
                getStationById(station.Id);

                throw new ArgumentException(station + " cannot be added as its Id is already in the database.");
            } catch (ArgumentException ae) {
                stationCollection.Add(station);
            }
        }
        public void updateStation(Station station) {
            foreach (Station s in stationCollection) {
                if (s.Id == station.Id) {
                    s.LocationId = station.LocationId;
                    s.Name = station.Name;
                    s.Type = station.Type;
                    return;
                }
            }

            throw new ArgumentException(station + " does not exist in the database and therefore cannot be updated.");
        }
        public void deleteStation(Station station) {
            stationCollection.Remove(station);
        }
        #endregion

        #region location
        public ICollection<Location> getAllLocations() {
            return locationCollection;
        }
        public Location getLocationById(int id) {
            foreach (Location location in locationCollection) {
                if (location.Id == id) {
                    return location;
                }
            }

            throw new ArgumentException(id + " is not a valid Id");
        }
        public void addLocation(Location location) {
            try {
                getStationById(location.Id);

                throw new ArgumentException(location + " cannot be added as its Id is already in the database.");
            } catch (ArgumentException ae) {
                locationCollection.Add(location);
            }
        }
        public void updateLocation(Location location) {
            foreach (Location l in locationCollection) {
                if (l.Id == location.Id) {
                    l.Address = location.Address;
                    l.Latitude = location.Latitude;
                    l.Longitude = location.Longitude;
                    l.Zip = location.Zip;
                    return;
                }
            }

            throw new ArgumentException(location + " does not exist in the database and therefore cannot be updated.");
        }
        public void deleteLocation(Location location) {
            locationCollection.Remove(location);
        }
        #endregion

        #region unitOfMeasurement
        public ICollection<UnitOfMeasurement> getAllUnitOfMeasurements() {
            return unitCollection;
        }
        public UnitOfMeasurement getUnitOfMeasurementById(int id) {
            foreach (UnitOfMeasurement unit in unitCollection) {
                if (unit.Id == id) {
                    return unit;
                }
            }

            throw new ArgumentException(id + " is not a valid Id");
        }
        public void addUnitOfMeasurement(UnitOfMeasurement unit) {
            try {
                getUnitOfMeasurementById(unit.Id);

                throw new ArgumentException(unit + " cannot be added as its Id is already in the database.");
            } catch (ArgumentException ae) {
                unitCollection.Add(unit);
            }
        }
        public void updateUnitOfMeasurement(UnitOfMeasurement unit) {
            foreach (UnitOfMeasurement u in unitCollection) {
                if (u.Id == unit.Id) {
                    u.Unit = unit.Unit;
                    u.Description = unit.Description;
                    return;
                }
            }

            throw new ArgumentException(unit + " does not exist in the database and therefore cannot be updated.");
        }
        public void deleteUnitOfMeasurement(UnitOfMeasurement unit) {
            unitCollection.Remove(unit);
        }
        #endregion

        #region measurement
        public ICollection<Measurement> getAllMeasurements() {
            return measurementCollection;
        }
        public Measurement getMeasurementById(int id) {
            foreach (Measurement measurement in measurementCollection) {
                if (measurement.Id == id) {
                    return measurement;
                }
            }

            throw new ArgumentException(id + " is not a valid Id");
        }
        public ICollection<Measurement> getMeasurementsByUnit(UnitOfMeasurement unit) {
            return (ICollection<Measurement>)measurementCollection.Where(measurement => measurement.MeasurementUnitId == unit.Id);
        }
        public ICollection<Measurement> getMeasurementsBetween(DateTime startTime, DateTime endTime) {
            return (ICollection<Measurement>)measurementCollection.Where(measurement => measurement.TimeStamp >= startTime && measurement.TimeStamp <= endTime);
        }
        public void addMeasurement(Measurement measurement) {
            try {
                getMeasurementById(measurement.Id);

                throw new ArgumentException(measurement + " cannot be added as its Id is already in the database.");
            } catch (ArgumentException ae) {
                measurementCollection.Add(measurement);
            }
        }
        public void updateMeasurement(Measurement measurement) {
            foreach (Measurement m in measurementCollection) {
                if (m.Id == measurement.Id) {
                    m.Value = measurement.Value;
                    m.MeasurementUnitId = measurement.MeasurementUnitId;
                    m.StationId = measurement.StationId;
                    m.TimeStamp = measurement.TimeStamp;
                    return;
                }
            }

            throw new ArgumentException(measurement + " does not exist in the database and therefore cannot be updated.");
        }
        public void deleteMeasurement(Measurement measurement) {
            measurementCollection.Remove(measurement);
        }
        #endregion
    }
}
