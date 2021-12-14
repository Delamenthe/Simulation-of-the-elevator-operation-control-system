using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Repositories;
using Model.Entities;
namespace Model.Servises {
    public static class SimulationSystemServise {
        public static void CallingElevator(int _targetFloor, int _startFloor) {
            int callingElevator=-1;
            double minDistance = 20.0;
            double distance=0.0;
            for (int i = 0; i < ConfigData.countOfElevator; i++) {

                if (Elevator.elevator[i].Check(ref distance, _targetFloor, _startFloor)) {
                    if (minDistance > distance) {
                        minDistance = distance;
                        callingElevator = i;
                    }
                }
            }
            if(callingElevator != -1) {
                Elevator.elevator[callingElevator].targetFloor = _startFloor;
            }

        }
    }
}
