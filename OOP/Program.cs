using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Building Bild1 = new Building(120, 50, 3, 2);

     var Bild2 = new Building(150, 80, 4, 3);

Console.WriteLine($"Здание №:{Bild1.Number} высотой:{Bild1.Height}, имеет квартир: {Bild1.Floors}, количество подъездов:{Bild1.Flat}, количество подъездов:{Bild1.Entrance}");
Console.WriteLine($"Здание №:{Bild2.Number} высотой:{Bild2.Height}, имеет квартир: {Bild2.Floors}, количество подъездов:{Bild2.Flat}, количество подъездов:{Bild1.Entrance}");

Console.ReadKey();



