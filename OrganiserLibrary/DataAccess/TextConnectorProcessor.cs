using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Load the text
//Convert the text to List<PrizeModel>
//Find the max ID
//Convert the prizes to List<string>
//SAve the List<string> to the text file

namespace OrganiserLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        //Get full path of text file
        public static string FullFilePath(this string filename)
        {
            // C:\Users\david\source\repos\Tournament\PrizeModels.csv
            return $"{ConfigurationManager.AppSettings["filePath"] }\\{filename}";
        }

        //THis method is used to Load data to text file
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        //Method to convert text to List<PrizeModel>
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel prizes = new PrizeModel();
                prizes.Id = int.Parse(cols[0]);
                prizes.PlaceNumber = int.Parse(cols[1]);
                prizes.PlaceName = cols[2];
                prizes.PrizeAmount = decimal.Parse(cols[3]);
                prizes.PrizePercentage = double.Parse(cols[4]);

                output.Add(prizes);

            }
            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split('|');

                PersonModel person = new PersonModel();
                person.Id = int.Parse(cols[0]);
                person.Firstname = cols[1];
                person.Lastname = cols[2];
                person.Email = cols[3];
                person.TelNumber = cols[4];

                output.Add(person);
            }

            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPersonsFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.Id },{p.Firstname},{p.Lastname},{p.Email},{p.TelNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);//writes all the lines above to the file
        }
    }
}
