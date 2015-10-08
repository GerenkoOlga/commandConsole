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
            ///Создание команд для управления сауной
            Hottub hottub = new Hottub();
            Console.WriteLine(hottub.Heat());
            HottubOnCommand HottubOn = new HottubOnCommand(hottub);
            HottubOn.Execute();
            Console.WriteLine(hottub.Cool());
            HottubOffCommand HottubOff = new HottubOffCommand(hottub);
            Console.WriteLine(HottubOff.Execute());
            CeilingFan ceilingFan = new CeilingFan("\nЖилая комната\n");
            Console.WriteLine(ceilingFan.High());
            ///Создание команд управления потолочным вентилятором
            CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            ceilingFanOn.Execute();
                     
             GarageDoor garageDoor = new GarageDoor("\n Дверь гаража\n ");
            Console.WriteLine(garageDoor.Up());
            ///Создание команд для управления дверью гаража
            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            garageDoorUp.Execute();
            Console.WriteLine(garageDoor.LightOn());
            garageDoorUp.Execute();

            Console.WriteLine(garageDoor.Stop());
            garageDoorUp.Execute();
            
            Console.ReadKey();
        }
    }
}
