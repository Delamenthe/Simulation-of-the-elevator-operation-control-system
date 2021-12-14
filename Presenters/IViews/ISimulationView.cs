using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.IViews {
    public interface ISimulationView {
        void DrawFloors(int countOfFloor,int countOfElevator);
        
        void DrawElevator(int number, double position);
    }
}
