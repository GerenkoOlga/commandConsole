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
            Stereo stereo = new Stereo("\nЖилая комната\n");
            Console.WriteLine(stereo.On());
            Console.WriteLine(stereo.SetCD());
            Console.WriteLine(stereo.SetDVD());
            ///создание команд для управления стереосистемами
            StereoOnWithCDCommand stereoOnwithCD = new StereoOnWithCDCommand(stereo);
            stereoOnwithCD.Execute();
            Console.WriteLine(stereo.Off());
            ///создание команд для управления стереосистемами
            StereoOffCommand stereoOffwithCD = new StereoOffCommand(stereo);
            Console.WriteLine(stereoOffwithCD.Execute());
            Stereo stereo2 = new Stereo("\n\nКухня \n");
            Console.WriteLine(stereo2.Off());
            ///создание команд для управления стереосистемами
            StereoOffCommand stereoOffwithCD2 = new StereoOffCommand(stereo2);
            Console.WriteLine(stereoOffwithCD2.Execute());
            Console.ReadKey();
        }
    }
}
