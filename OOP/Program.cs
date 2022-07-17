using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Building Bild1 = new Building( 5, 20, 2);

     var Bild2 = new Building( 8, 40, 3);


Console.WriteLine($"Здание №:{Bild1.Number} высотой:{Bild1.GetHeight()}м., этажи :{Bild1.Floors}, количество квартир:{Bild1.Flat}, количество подъездов:{Bild1.Entrance}, квартир на этаж:{Bild1.FlatsInFloors()}, квартир на подъезд:{Bild1.FlatsInEntrance()}");
Console.WriteLine($"Здание №:{Bild2.Number} высотой:{Bild2.GetHeight()}м., этажи: {Bild2.Floors}, количество квартир:{Bild2.Flat}, количество подъездов:{Bild1.Entrance}, квартир на этаж:{Bild2.FlatsInFloors()}, квартир на подъезд:{Bild2.FlatsInEntrance()}");

Console.ReadKey();



