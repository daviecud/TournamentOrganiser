using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserLibrary
{
    public class SQLConnector : IDataConnection
    {
        //TODO - Make the CreatePrize ethod actually save to the data
        /// <summary>
        /// SAves a new prize to the database
        /// </summary>
        /// <param name="model">The prizes information</param>
        /// <returns>THe prizr information, including the unqiue indentifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
