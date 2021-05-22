using System;
using System.Collections.Generic;
using System.Threading;

namespace MultiThreadProject
{
    //  Bus stations
    //  На маршруте несколько остановок. 
    //  На одной остановке может останавливаться несколько автобусов одновременно,
    //  но не более заданного числа.
    
    class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Bus stations");

            int maxBus = 3;
            int handleTime = 2000;
            int toAnotherStation = 2500;
            
            Dictionary<int, int> stations = new Dictionary<int, int>();
            stations.Add(0, 0);
            stations.Add(1, 1);
            stations.Add(2, 2);
            stations.Add(3, 3);
            stations.Add(4, 4);

            List<Bus> buses = new List<Bus>() { new Bus(1), new Bus(2), new Bus(3), new Bus(4), new Bus(5) };

            // handle time = 3 s.
            // max buses = 3
            // 

            Route route = new Route(buses, stations, maxBus, handleTime, toAnotherStation);
            route.Starting();
        }
    }

    class Route
    {
        private List<Bus> _buses;
        private Dictionary<int, int> _stations;
        private int _stations_len;
        private int _handleTime;
        private int _toAnotherStation;
        private int _maxBus;
        
        public Route(List<Bus> buses, Dictionary<int, int> stations,
            int maxBus,
            int handleTime, int toAnotherStation)
        {
            _maxBus = maxBus;
            _handleTime = handleTime;
            _toAnotherStation = toAnotherStation;
            _buses = buses;
            _stations = stations;
            _stations_len = stations.Count;
        }

        public void Starting()
        {
            foreach (var bus in _buses)
            {
                new Thread(() => this._go(bus)).Start();
                Thread.Sleep(1000);
            }
        }

        private void _go(Bus bus)
        {
            while (true)
            {
                if (_stations[bus.CurrentStation] == _maxBus)
                {
                    while (true)
                    {
                        if (_stations[bus.CurrentStation] < _maxBus)
                        {
                            break; // waititng
                        }
                    }
                }    
                
                Console.WriteLine($"Bus #{bus.Id} come to station #{bus.CurrentStation}");
                _stations[bus.CurrentStation]++;
                Thread.Sleep(this._handleTime);
                _stations[bus.CurrentStation]--;
                bus.Iter++;
                bus.CurrentStation = bus.Iter % this._stations_len;
                Console.WriteLine($"Bus #{bus.Id} start move to next station");
                Thread.Sleep(_toAnotherStation);
            }
        }
        
    }

    class Bus
    {
        public Bus(int id)
        {
            Id = id;
            CurrentStation = 0;
            Iter = 0;
        }
        
        public int Id { get; private set; }

        public int Iter;
        
        public int CurrentStation { get; set; }
    }
}