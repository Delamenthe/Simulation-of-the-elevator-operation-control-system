using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
using Model.Entities;
using Model.Repositories;
using Model;
namespace Presenters {
    public class SimulationPresenter  {
        ISimulationView _simulationView;
        
        public SimulationPresenter(ISimulationView simulationView) {
            _simulationView = simulationView;
        }
        public void AddFloors() {
            _simulationView.DrawFloors(ConfigData.countOfFloor, ConfigData.countOfElevator);
        }
        public void TimeSet() {
            SimulationSystem.CountTime();
        }
        public void AddElevator() {
            if (Elevator.elevator!=null)
                for (int num = 0; num < ConfigData.countOfElevator; num++) {
                _simulationView.DrawElevator(num, Elevator.elevator[num].position);
            }
        }
        public void AddHuman() {
            if (Human.humans!=null)
                for (int num = 0; num < Human.humans.Count(); num++) {
                    _simulationView.DrawHuman(Human.humans[num].startFloor, Human.humans[num].position, Human.humans[num].state, Human.humans[num].currFrame, Human.humans[num].targetFloor);
                }
        }
        public void Pause() {
            if (GlobalParametrs.pause) {
                GlobalParametrs.pause = false;
            }
            else {
                GlobalParametrs.pause = true;
            }
        }
        public void FireAlarm() {
            if (GlobalParametrs.fireAlarm) {
                GlobalParametrs.fireAlarm = false;
            }
            else {
                GlobalParametrs.fireAlarm = true;
            }
        }
    }
}