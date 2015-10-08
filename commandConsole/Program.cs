using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            LightOffCommand livingRoomLightOff, kitchenLightOff;
            LightOnCommand livingRoomLightOn, kitchenLightOn;

            Light livingRoomLight = new Light("\nЖилая комната\n");
            Console.WriteLine(livingRoomLight.On());
            Light kitchenLight = new Light("\nКухня\n");
            Console.WriteLine(kitchenLight.On());
            ///Создание команд для управления освещением
            livingRoomLightOn = new LightOnCommand(livingRoomLight);
            livingRoomLightOn.Execute();
            kitchenLightOn = new LightOnCommand(kitchenLight);
            kitchenLightOn.Execute();
            Console.WriteLine(livingRoomLight.Off());
            Console.WriteLine(kitchenLight.Off());
            ///Создание команд для управления освещением
            livingRoomLightOff = new LightOffCommand(livingRoomLight);
            livingRoomLightOn.Execute();
            kitchenLightOff= new LightOffCommand(kitchenLight);
            kitchenLightOff.Execute();
            Console.ReadKey();
        }
    }
}
