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
    public class AccelerationPresenter {
        IAccelerationView _accelerationView;

        public AccelerationPresenter(IAccelerationView accelerationView) {
            _accelerationView = accelerationView;
        }
        public void CheckCorrect(string amplif_coefficient) {

            if (!amplif_coefficient.Equals("")) {
                if (GlobalParametrs.accelaration >= 0.1 && GlobalParametrs.accelaration <= 10) {
                    GlobalParametrs.accelaration = Double.Parse(amplif_coefficient.Replace(" ", ""));
                    _accelerationView.Confirm();
                }
                else {
                    _accelerationView.ShowErrorMessage("Uncorrect data");
                }
            }
            else {
                _accelerationView.ShowErrorMessage("Input data");
            }
        }
    }
}
