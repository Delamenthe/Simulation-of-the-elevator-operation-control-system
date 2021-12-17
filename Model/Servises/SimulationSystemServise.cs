using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Repositories;
using Model.Entities;
namespace Model.Servises {
    public static class SimulationSystemServise {
        public static int CallingElevator(int _targetFloor, int _startFloor) {
            int callingElevator=-1;
            double minDistance = 20.0;
            double distance=0.0;
            if (ConfigData.stategy) {
                for (int i = 0; i < ConfigData.countOfElevator; i++) {
                    if (Elevator.elevator[i].stateElevator == 1 && Elevator.elevator[i].targetFloor == _startFloor) {
                        callingElevator = i;
                        break;
                    }
                    if (Elevator.elevator[i].Check(ref distance, _targetFloor, _startFloor)) {
                        if (minDistance > distance) {
                            minDistance = distance;
                            callingElevator = i;
                        }
                    }
                }
            }
            else {
                for (int i = 0; i < ConfigData.countOfElevator; i++) {
                    if (Elevator.elevator[i].stateElevator == 1 && Elevator.elevator[i].targetFloor == _startFloor && (Elevator.elevator[i].direction== (_targetFloor - _startFloor < 0))) {
                        callingElevator = i;
                        break;
                    }
                    if (Elevator.elevator[i].Check(ref distance, _targetFloor, _startFloor)) {
                        if (minDistance > distance) {
                            minDistance = distance;
                            callingElevator = i;
                        }
                    }
                }
            }
            if(callingElevator != -1) {
                if (_targetFloor - _startFloor < 0) {
                    Elevator.elevator[callingElevator].direction = true;
                }
                else {
                    Elevator.elevator[callingElevator].direction = false;
                }
                Elevator.elevator[callingElevator].targetFloor = _startFloor;
                Elevator.elevator[callingElevator].stateElevator = 1;
            }
            return callingElevator;

        }
        public static void WaitHuman(int floor,Elevator elevator) {
            for (int i = 0; i < Human.humans.Count; i++) {
                if (Human.humans[i].state == 0 && Human.humans[i].startFloor == floor&&elevator.human.Count<ConfigData.maxWeightOfElevator&& Human.humans[i].targetElevator==elevator.numberElevator) {
                    Human.humans[i].state = 2;
                    elevator.human.Add(Human.humans[i]);
                    if (elevator.targetList.IndexOf(Human.humans[i].targetFloor) == -1) {
                        elevator.targetList.Add(Human.humans[i].targetFloor);
                    }
                }

                
            }
            elevator.targetList.Sort();
            if (elevator.direction) { 
                elevator.targetList.Reverse();
            }
            
        }
        public static void WaitHumanExit(int floor,Elevator elevator) {
            foreach(Human hum in elevator.human) {
                hum.ExitElevator(floor);
                   
              
            }
        }
    }
}
