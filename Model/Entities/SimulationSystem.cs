using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Repositories;
using Model.Servises;
namespace Model.Entities {
    public static class SimulationSystem {

        public static void CountTime() {
            if (!GlobalParametrs.pause) {
                GlobalParametrs.time += GlobalParametrs.accelaration * 0.1;
            }
        }
        public static void StartTime() {
            GlobalParametrs.accelaration = 1.0;
            GlobalParametrs.time = 0.0;
            GlobalParametrs.pause = false;
            Elevator.Create();
            RuleService.GetRule();
        }
    }
}
