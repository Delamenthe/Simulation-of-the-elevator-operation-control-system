using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Model.Repositories;
using Model.Servises;
namespace Model.Entities {
    public class Human {
        public static double waitTime = 3.0;
        public int targetFloor { get; set;}
        public int startFloor { get; set; }
        public double timeStart { get; set; }
        public bool pressedButton { get; set; }
        public static List<Human> humans = new List<Human>() ;
        public void Wait() {
            while (true) {
                Thread.Sleep(100);
                if (GlobalParametrs.time - timeStart > waitTime&&!pressedButton) {
                    PressButton();
                }
            }
        }
        public Human(int _targetFloor,int _startFloor) {
            
            targetFloor = _targetFloor;
            startFloor = _startFloor;
            pressedButton = false;
            timeStart = GlobalParametrs.time;
            humans.Add(this);
            Thread humanThread = new Thread(new ThreadStart(Wait));
            humanThread.Start();
        }
        public void PressButton() {
            pressedButton = true;
            SimulationSystemServise.CallingElevator(targetFloor, startFloor);
            System.Console.WriteLine("Я нажал кнопку");
        }
        
    }
}
