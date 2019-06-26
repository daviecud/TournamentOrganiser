using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrganiserLibrary.DataAccess.TextHelpers;

namespace OrganiserLibrary
{
    public class TextConnector : IDataConnection
    {
        //PRivate variable set to const so no changes can be made to PrizesFile variable
        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonsFile = "PersonModels.csv";

        //TODO - Wire CreatePrze data save to text file
        /// <summary>
        /// This saves the prizes information to text file
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //This creates a List<PrizeModel> takes the PrizeFile, finds FullFilePath method, then Loads the file, 
            //converts to PrizeModel List & then returns to variable prize

            List<PrizeModel> prize = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //This finds List<PrizeModel> ids, then First will pick the first id value in List in descending order
            //This will find the highest Id and then + 1 will add to the current Id

            int currentId = 1; 

            if (prize.Count > 0) 
            {
                currentId = prize.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId; //will allocated new entry to the currentId after it is increased.

            prize.Add(model);

           
            //SAve the list<string> to the text file
            prize.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public PersonModel CreatePerson(PersonModel model)

            //takes file name, convert to full file path(from app.config), load files making sure exits, then converts file/list to list<PersonModel> 
        {
            List<PersonModel> person = PersonsFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1; //set default current id

            if(person.Count > 0)
            {
                currentId = person.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            person.Add(model);

            person.SaveToPersonsFile(PersonsFile); //Method is in TextConnectorProcessor

            return model;

        }

        public List<PersonModel> GetPerson_All()
        {
            return PersonsFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }
    }
}
