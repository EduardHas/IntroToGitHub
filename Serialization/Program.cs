using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

//-------------------------------

namespace Serialization
{
    public class Item //הגדרת מחלקה
    {
        public int Id { get; set; }//הגדרת מאפיינים ניתנים לקבלה והשמה החוצה
        public string Name { get; set; }
        public float Price { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            #region Initialization + placement of values
            Item item = new Item();
            item.Id = 8651;
            item.Name = "Cola";
            item.Price = 5.56f;
            #endregion

            #region Serialize item
            //string ser = System.Text.Json.JsonSerializer.Serialize(item);
            string ser = JsonSerializer.Serialize(item);
            #endregion

            #region Save as a JSON file locally on your computer
            //System.IO.File.WriteAllText("SerializeItemData.txt", ser);
            #endregion

            #region Uploading a JSON file from the local computer as a string + Deciphering the information for a new variable of an ITEM object

            string loadedStr = System.IO.File.ReadAllText("SerializeItemData.txt");
            Item newItem = System.Text.Json.JsonSerializer.Deserialize<Item>(loadedStr);
            #endregion



        }
    }
}
