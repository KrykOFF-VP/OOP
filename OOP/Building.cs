using System;
using System.Collections.Generic;
namespace OOP
{
    public class Building
    {
        /// <summary>
        /// Приватные поля
        /// </summary>
        private uint _Number;
        private static uint _Bildnumber = 0;

        private double _Height;
        private static double _Bildcelling = 2.7;

        private uint _Floors;

        private uint _Flat;

        private uint _Entrance;


        /// <summary>
        /// Свойства
        /// </summary>
        public uint Number
        {
            get { return _Number; }
            
        }

        public double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public uint Floors
        {
            get { return _Floors; }
            set { _Floors = value; }
        }

        public uint Flat
        {
            get { return _Flat; }
            set { _Flat = value; }
        }

        public uint Entrance
        {
            get { return _Entrance; }
            set { _Entrance = value; }
        }


        // Конструктор
        internal Building(uint floors, uint flats, uint entrances)
        {
            _Number = GenerateNumb();
            _Floors = floors;
            _Flat = flats; 
            _Entrance = entrances;
             
        }
        /// <summary>
        /// Методы
        /// </summary>
        /// <returns></returns>
        private uint GenerateNumb()
        {
            _Bildnumber ++;
            return _Bildnumber;
        }
        public double GetHeight()
        {
         Height = _Floors * _Bildcelling;
         return Height;
        }
        public uint FlatsInEntrance()
        {
            return _Flat / _Entrance;
            
        }
        public uint FlatsInFloors()
        {
            return _Flat / _Floors;

        }
    }
}
