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
        public double position { get; set; }
        public int state { get; set; }
        public static List<Human> humans = new List<Human>();

        public void Wait() {
            while (true) {
                Thread.Sleep(100);
                if (GlobalParametrs.time - timeStart > waitTime && !pressedButton) {
                    state = 0;
                    PressButton();
                }
                if (GlobalParametrs.time - timeStart < waitTime) {
                    position = (GlobalParametrs.time - timeStart) / waitTime;
                }
            }
        }
        public Human(int _targetFloor,int _startFloor) {
            state = 1;
            position = 0;
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
            
        }

        public void Move() {
            while (true) {
                Thread.Sleep(100);
              
            }
        }

    }
}
