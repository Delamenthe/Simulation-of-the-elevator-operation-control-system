using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.IViews {
    public interface IConfigView {
        void Confirm();
        void ShowErrorMessage(string message);
    }
}
