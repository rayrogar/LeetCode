using System.Diagnostics.Metrics;

namespace LeetCode
{
    /// <summary>
    /// Solucion al problema 1396 del portal LeetCode
    /// </summary>
    public class UndergroundSystem
    {
        List<Customer> _customers;
        Dictionary<string, Dictionary<string, List<double>>> _stations;

        public UndergroundSystem()
        {
            _customers = new List<Customer>();
            _stations = new Dictionary<string, Dictionary<string, List<double>>>();
        }

        public void CheckIn(int id, string stationName, int t)
        {
            foreach (var cust in _customers)
            {
                if (cust.ID == id)
                {
                    return;
                }
            }
            _customers.Add(new Customer(stationName, id, t));

            if (!_stations.ContainsKey(stationName))
                _stations.Add(stationName, new Dictionary<string, List<double>>());
        }

        public void CheckOut(int id, string stationName, int t)
        {
            foreach (var cust in _customers)
            {
                if (cust.ID == id)
                {
                    if (!_stations.ContainsKey(stationName))
                        _stations.Add(stationName, new Dictionary<string, List<double>>());

                    if (!_stations[cust.stationIn].ContainsKey(stationName))
                    {
                        _stations[cust.stationIn].Add(stationName, new List<double>());
                        _stations[cust.stationIn][stationName].AddRange(new List<double> { t - cust.timeIn, t - cust.timeIn });
                    }
                    else
                    {
                        _stations[cust.stationIn][stationName].Add(t - cust.timeIn);
                        var destinos = _stations[cust.stationIn][stationName];
                        double total = 0;
                        for (int i = 1; i < destinos.Count; i++)
                            total += destinos[i];
                        _stations[cust.stationIn][stationName][0] = total / (destinos.Count - 1);
                    }
                    Console.WriteLine(string.Join(',', _stations[cust.stationIn][stationName]));
                    _customers.Remove(cust);
                    break;
                }
            }
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            return _stations[startStation][endStation][0];
        }
    }
    partial class Customer
    {
        public string? stationIn { get; set; }
        public int ID { get; set; }
        public int timeIn { get; set; }
        public Customer(string stationName, int id, int t)
        {
            stationIn = stationName;
            ID = id;
            timeIn = t;
        }
    }


}