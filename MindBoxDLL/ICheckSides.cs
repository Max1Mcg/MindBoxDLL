using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxDLL.Check
{
    public interface ICheckSides
    {
        /// <summary>
        /// Method for check sides on correct values
        /// </summary>
        /// <param name="a">massive of sides</param>
        /// <returns>correct or not</returns>
        bool CheckSides(params double []a);
    }
}
