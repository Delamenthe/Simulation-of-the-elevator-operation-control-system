using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Repositories;
using Model.Entities;

namespace Model.Servises {
    public static class RuleService {
        public static void GetRule() {
            string[] rule = ConfigData.rule;
            if (rule.Length>0) {
                for (int i = 0; i < rule.Length; i++) {
                    if (rule[i].Equals("/human")) {
                        try {
                            for (int j = 0; j < Int32.Parse(rule[i + 1]); j++) {
                                Human human = new Human(Int32.Parse(rule[i + 3]), Int32.Parse(rule[i + 2]));

                            }
                        }
                        catch {

                        }
                       
                    }
                    if (rule[i].Equals("/fireAlarm")) {
                       
                    }
                }
            }
        }

    }
}
