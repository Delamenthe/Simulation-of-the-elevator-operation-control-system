﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Model.Repositories;
using Model.Servises;
namespace Model.Entities {
    public class Human {
        public static double waitTime = 3.0;
        public static double runTime = 2.0;
        public int targetFloor { get; set;}
        public int startFloor { get; set; }
        public double timeStart { get; set; }
        public double timeStartRun { get; set; }
        public double position { get; set; }
        public int state { get; set; }
        public int targetElevator { get; set; }
        public static List<Human> humans = new List<Human>();
        public int currFrame { get; set; }
        public bool pressedButton { get; set; }
        public void Wait() {
            while (true) {
                Thread.Sleep(100);
                currFrame = (int)((GlobalParametrs.time - timeStart) * 10)%9 + 3;
                if (GlobalParametrs.time - timeStart > waitTime && !pressedButton) {
                    state = 0;
                    PressButton();
                    pressedButton = true;
                }
                if (GlobalParametrs.time - timeStart < waitTime) {
                    position = (GlobalParametrs.time - timeStart) / waitTime;
                }
                if (state == 0) {
                    PressButton();
                    Thread.Sleep(1000);
                }
                if (state == 2) {
                    state = 3;
                    timeStartRun = GlobalParametrs.time;
                }
                if (state == 3) {
                    position = targetElevator*(GlobalParametrs.time - timeStartRun) / runTime;
                    if(GlobalParametrs.time - timeStartRun > runTime) {
                        state =  4;
                    }
                }
                if (state == 4) {
                    
                }
            }
        }
        public Human(int _targetFloor,int _startFloor) {
            currFrame = 2;
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
            targetElevator = SimulationSystemServise.CallingElevator(targetFloor, startFloor);
        }

        

    }
}