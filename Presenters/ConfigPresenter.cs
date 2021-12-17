using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
using Model;
using Model.Entities;
using Model.Repositories;
namespace Presenters {
    public class ConfigPresenter {
        IConfigView _configView;
        
        public ConfigPresenter(IConfigView configView) {
            _configView = configView;
        }

        public void CheckCorrect(string cntOfElevator,string cntOfFloors,bool stategy
            ,string maxWeight,string speed,string acceleration,string rule) {

            if (!cntOfElevator.Equals("")&&!cntOfFloors.Equals("")&&!maxWeight.Equals("")&&!speed.Equals("")&&!acceleration.Equals("")) {
                try {
                    ConfigData.countOfElevator = Int32.Parse(cntOfElevator.Replace(" ", ""));
                    ConfigData.countOfFloor = Int32.Parse(cntOfFloors.Replace(" ", ""));
                    ConfigData.stategy = stategy;
                    ConfigData.maxWeightOfElevator = Int32.Parse(maxWeight.Replace(" ", ""));
                    ConfigData.speedOfElevator = Int32.Parse(speed.Replace(" ", ""));
                    ConfigData.accelerationOfElevator = Int32.Parse(acceleration.Replace(" ", ""));
                }
                catch {

                }
                if (ConfigData.countOfElevator >= 1 && ConfigData.countOfElevator <= 5 &&
                    ConfigData.countOfFloor >= 2 && ConfigData.countOfFloor <= 20 &&
                    ConfigData.maxWeightOfElevator >= 1 &&
                    ConfigData.speedOfElevator >= 1 &&
                    ConfigData.accelerationOfElevator >= 1) {
                    _configView.Confirm();
                    if (!rule.Equals("")) {
                        ConfigData.rule = rule;
                        bool cmd = false;
                        string arg="";
                        for (int i = 0; i <= rule.Length; i++) {
                            if (rule[i].Equals('/')&&!cmd)
                                cmd = true;
                            while (cmd && rule[i].Equals(' ')) {
                                arg += rule[i];
                            }
                            if (arg.Equals("human")) {

                               }
                                    

                            
                        }
                            
                            
                            _configView.ShowErrorMessage("Too few arguments have been entered in the rule field. Please enter the arguments according to the sample provided below the rules field");
                        if (rule[0].Equals("human") && rule.Length == 4) {
                            Human human = new Human(rule[2], rule[1]);
                        }
                    }
                    SimulationSystem.StartTime();
                } else {
                    _configView.ShowErrorMessage("Uncorrect data");
                }
            } else {
                _configView.ShowErrorMessage("Some fields are empty. Please, input data");
            }
        }
    }
}
