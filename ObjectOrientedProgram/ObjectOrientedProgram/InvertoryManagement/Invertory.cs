using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace ObjectOrientedProgram.InvertoryManagement
{
    public class Inventory
    {
        List<InventoryDetails> details = new List<InventoryDetails>();

        public void ReadJsonFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                var json = reader.ReadToEnd();

                this.details = JsonConvert.DeserializeObject<List<InventoryDetails>>(json);
                Console.WriteLine("Name" + "\t" + "Weight" + "\t" + "price" + "\t" + "PricePerKg");
                foreach (var data in details)
                {
                    Console.WriteLine(data.Name + "\t" + data.Weight + "\t" + data.Price + "\t" + data.Weight * data.Price);
                }
            }
        }
    }
}
