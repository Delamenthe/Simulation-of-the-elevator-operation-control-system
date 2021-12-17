using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories {
    public static class ConfigData {
        public static int countOfElevator {get; set; }
        public static int countOfFloor { get; set; }
        public static bool stategy { get; set; }
        public static int maxWeightOfElevator { get; set; }
        public static int speedOfElevator { get; set; }
        public static int accelerationOfElevator { get; set; }
        public static string [] rule { get; set; }
    }
}
