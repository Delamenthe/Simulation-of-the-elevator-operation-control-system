using System;
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
        public static double acc = (double)ConfigData.accelerationOfElevator / 100;
        public int targetFloor { set; get; }
        public double currentSpeed { get; set; }
        public int currentWeight { get; set; }
        public int numberElevator { get; set; }
        public double position { get; set; }
        public bool isMove { get; set; }
        public ElevatorServise elevatorServise { get; set; }
        
        public Elevator(int num) {
            numberElevator = num;
            position = 1;
            targetFloor = 1;
            isMove = false;
            elevatorServise = new ElevatorServise(num);
            Thread elevatorThread = new Thread(new ThreadStart(Move));
            elevatorThread.Start();
        }
        public bool Check(ref double distance, int _targetFloor, int _startFloor) {
            distance = Math.Abs(_startFloor - position);
            return true;
        }

        public void Move() {
            while (true) {
                Thread.Sleep(100);
                elevatorServise.MoveElevator(targetFloor);
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
