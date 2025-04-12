using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    public class Bicycle
    {
        
            public string Model { get; set; }
            public int Year { get; set; }
            public string Colour { get; set; }
            public double Price { get; set; }
            public int FrameLoadCapacity { get; set; }
            public double Weight { get; set; }
            public bool WasUsed { get; set; }
            public bool WasDamaged { get; set; }

            public double CalculateMaxPassengerWeight()
            {
                return FrameLoadCapacity - Weight;
            }

            public override string ToString()
            {
                return $"Модель: {Model}\r\n" +
                       $"Рік: {Year}\r\n" +
                       $"Колір: {Colour}\r\n" +
                       $"Ціна: {Price:F2} грн\r\n" +
                       $"Макс. навантаження рами: {FrameLoadCapacity} кг\r\n" +
                       $"Вага: {Weight} кг\r\n" +
                       $"Був у використанні: {(WasUsed ? "Так" : "Ні")}\r\n" +
                       $"Пошкоджений: {(WasDamaged ? "Так" : "Ні")}\r\n" +
                       $"Максимальна вага пасажира: {CalculateMaxPassengerWeight():F2} кг\r\n";
            }
        }
    }

