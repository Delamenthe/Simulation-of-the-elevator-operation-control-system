using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Model.Entities;
namespace Model.Repositories {
    public static class GlobalParametrs {
        public static double time {set;get;}
        public static double accelaration { set; get; }
        public static double floorHeight = 3.0;
        public static bool pause;
        public static bool fireAlarm = false;
    }
}
