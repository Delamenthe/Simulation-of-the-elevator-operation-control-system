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
    public class AddHumanPresenter {
        IAddHumanView _addHumanView;
        public AddHumanPresenter(IAddHumanView addHumanView) {
            _addHumanView = addHumanView;
        }
        public void CheckCorrect(string cntOfPeople, string startFloor, string endFloor) {
            if (!cntOfPeople.Equals("") && !startFloor.Equals("") && !endFloor.Equals("")) {
                int _cntOfPeople = Int32.Parse(cntOfPeople);
                int _startFloor = Int32.Parse(startFloor);
                int _endFloor = Int32.Parse(endFloor);
                if (_cntOfPeople != 0 && _startFloor >= 1 && _startFloor <= ConfigData.countOfFloor && _endFloor >= 1 && _endFloor <= ConfigData.countOfFloor && _endFloor!=_startFloor) {
                    Human human = new Human(_endFloor, _startFloor);
                } else {
                    _addHumanView.ShowErrorMessage("Uncorrect data");
                }
            }else {
                _addHumanView.ShowErrorMessage("Input data");
            }
        }
    }
}
