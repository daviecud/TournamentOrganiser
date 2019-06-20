using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
    public class TextConnector : IDataConnection
    {
        //TODO - Wire CreatePrze data save to text file
        /// <summary>
        /// This saves the prizes information to text file
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
            
        }
    }
}
