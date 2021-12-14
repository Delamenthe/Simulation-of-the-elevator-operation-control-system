using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using Model.Repositories;
namespace Model.Servises {
    public class ElevatorServise {
        private double time0;
        private double lenght;
        private double tExpect;
        private double position0;
        private double tUniform;
        private double tExpectUn;
        public int numberElevator { get; set; }
        private Elevator elevator { get; set; }
        public ElevatorServise(int _numberElevator) {
            numberElevator = _numberElevator;
 
        }
        public void MoveElevator(int targetFloor) {
            elevator = Elevator.elevator[numberElevator];
            if (elevator.position != targetFloor && !elevator.isMove) {
                elevator.isMove = true;
                time0 = GlobalParametrs.time;
                lenght = (targetFloor - elevator.position) * GlobalParametrs.floorHeight;

                tExpect = 2 * Math.Sqrt(Math.Abs(lenght) / Elevator.acc);
                position0 = elevator.position;

                tExpectUn = 2 * ConfigData.speedOfElevator / Elevator.acc;
                tUniform = (Math.Abs(lenght) - ConfigData.speedOfElevator * tExpectUn / 2) / ConfigData.speedOfElevator;
            }
            else if (elevator.isMove && (ConfigData.speedOfElevator > Math.Sqrt(Elevator.acc * Math.Abs(lenght)))) {
                double delteTime = GlobalParametrs.time - time0;
                if (delteTime < tExpect) {
                    delteTime = GlobalParametrs.time - time0;
                    if (delteTime < tExpect / 2) {
                        elevator.position = position0 + (lenght / Math.Abs(lenght)) * (Elevator.acc * Math.Pow((delteTime), 2) / 2) / GlobalParametrs.floorHeight;
                    }
                    else {
                        elevator.position = position0 + (lenght / Math.Abs(lenght)) * ((lenght / Math.Abs(lenght)) * lenght / 2 + tExpect * Elevator.acc * (delteTime - tExpect / 2) / 2 - Elevator.acc * Math.Pow((delteTime - tExpect / 2), 2) / 2) / GlobalParametrs.floorHeight;
                    }

                }
                else {
                    elevator.position = targetFloor;
                    elevator.isMove = false;
                }
            }
            else if (elevator.isMove && (ConfigData.speedOfElevator <= Math.Sqrt(Elevator.acc * Math.Abs(lenght)))) {
                double delteTime = GlobalParametrs.time - time0;
                if (delteTime < tExpectUn + tUniform) {
                    if (delteTime < tExpectUn / 2) {
                        elevator.position = position0 + (lenght / Math.Abs(lenght)) * (Elevator.acc * Math.Pow((delteTime), 2) / 2) / GlobalParametrs.floorHeight;
                    }
                    else if (delteTime < (tExpectUn / 2 + tUniform)) {
                        elevator.position = position0 + (lenght / Math.Abs(lenght)) * (Elevator.acc * Math.Pow(tExpectUn / 2, 2) / 2 + ConfigData.speedOfElevator * (delteTime - tExpectUn / 2)) / GlobalParametrs.floorHeight;
                    }
                    else {
                        elevator.position = position0 + (lenght / Math.Abs(lenght)) * (Elevator.acc * Math.Pow(tExpectUn / 2, 2) / 2 + ConfigData.speedOfElevator * tUniform + ConfigData.speedOfElevator * (delteTime - tUniform - tExpectUn / 2) - Elevator.acc * Math.Pow((delteTime - tUniform - tExpectUn / 2), 2) / 2) / GlobalParametrs.floorHeight;
                    }
                }
                else {
                    elevator.position = targetFloor;
                    elevator.isMove = false;

                }
            }
        }
    }
}
