﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Model.Servises;
using Model.Repositories;
namespace Model.Entities {
    public class Elevator {
        public static List<Elevator> elevator;
        public List<Human> human;
        public List<int> targetList;
        public static double acc = (double)ConfigData.accelerationOfElevator / 100;
        public int targetFloor { set; get; }
        public double currentSpeed { get; set; }
        public int currentWeight { get; set; }
        public int numberElevator { get; set; }
        public double position { get; set; }
        public bool isMove { get; set; }
        public int stateElevator { get; set; }
        public ElevatorServise elevatorServise { get; set; }
        
        public Elevator(int num) {
            numberElevator = num;
            stateElevator=0;
            position = 1;
            targetFloor = 1;
            isMove = false;
            human = new List<Human> ();
            targetList = new List<int>();
            elevatorServise = new ElevatorServise(num);
            Thread elevatorThread = new Thread(new ThreadStart(Move));
            elevatorThread.Start();
        }
        public bool Check(ref double distance, int _targetFloor, int _startFloor) {
            if (stateElevator == 0) {
                distance = Math.Abs(_startFloor - position);
                return true;
            }
            return false;
        }

        public void Move() {
            while (true) {
                Thread.Sleep(100);
                elevatorServise.MoveElevator(targetFloor);
                if(stateElevator == 1 && !isMove) {
                    stateElevator = 2;
                }
                if(stateElevator == 2) {
                    SimulationSystemServise.WaitHuman((int)position,this);
                    Thread.Sleep(1000*(int)Human.runTime);
                    stateElevator = 3;
                }
                if (targetList.Count == 0&&stateElevator==3&&!isMove) {
                    stateElevator = 0;
                }
                if (stateElevator == 3 && !isMove) {
                    targetFloor = targetList[0];
                    targetList.RemoveAt(0);
                    
                    }
                }
            }
        
        
        public static void Create() {
            elevator = new List<Elevator>();
            for (int num = 0; num < ConfigData.countOfElevator; num++) {
                elevator.Add(new Elevator(num));
   
            }

            
            


        }
    }
}