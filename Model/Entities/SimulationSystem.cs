using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Repositories;
namespace Model.Entities {
    public static class SimulationSystem {

        public static void CountTime() {
            GlobalParametrs.time += GlobalParametrs.accelaration * 0.1;
        }
        public static void StartTime() {
            GlobalParametrs.accelaration = 1.0;
            GlobalParametrs.time = 0.0;
            Elevator.Create();
        }
    }
}
