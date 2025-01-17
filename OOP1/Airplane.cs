﻿namespace OOP1
{
    internal class Airplane
    {
        private string _startCity = "Unknown";
        private string _finishCity = "Unknown";
        private Date _startDate = new();
        private Date _finishDate = new();

        public string StartCity
        {
            get { return _startCity; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _startCity = value;
            }
        }

        public string FinishCity
        {
            get { return _finishCity; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _finishCity = value;
            }
        }

        public Date StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public Date FinishDate
        {
            get { return _finishDate; }
            set { _finishDate = value; }
        }

        public Airplane() { }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
        }

        public Airplane(Date startDate, Date finishDate)
        {
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate.Copy();
            FinishDate = airplane.FinishDate.Copy();
        }

        /// <summary>
        /// Create a new copy of this Airplane object.
        /// </summary>
        /// <returns>Airplane</returns>
        public Airplane Copy()
        {
            return new(this);
        }

        /// <summary>
        /// Calculate the total time of the flight in minutes.
        /// </summary>
        /// <returns>Minutes</returns>
        public int GetTotalTime()
        {
            return (int)(FinishDate.TotalTime() - StartDate.TotalTime());
        }

        /// <summary>
        /// Returns true if the airplane arrives on the day of takeoff.
        /// </summary>
        public bool IsArrivingToday()
        {
            return StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month && StartDate.Day == FinishDate.Day;
        }
    }
}
