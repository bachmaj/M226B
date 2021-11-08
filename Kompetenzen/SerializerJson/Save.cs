using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace SerializerJson
{
    public static class Save
    {
        public static void SaveInClass(Animal animal, List<Animal> list, string filename)
        {
            JsonSerializer serializer = new JsonSerializer();

            if (animal.GetType() == typeof(Dog))
            {
               

                using (StreamWriter sw = new StreamWriter(filename))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, list);

                }
            }
            else if(animal.GetType() == typeof(Lion))
            {
                using (StreamWriter sw = new StreamWriter(filename))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, list);

                }
            }
        }
    }
}
