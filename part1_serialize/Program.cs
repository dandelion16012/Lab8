using System.Xml.Serialization;
using AnimalClasses.abstract_classes;
using AnimalClasses.classes;
using AnimalClasses.enums;

namespace Task1_serialize;

public class Program
{
    public static void Main()
    {
        
        Animal lion = new Lion();
        lion.Country = "Kenia";
        lion.HideFromOtherAnimals = false;
        lion.Name = "Buba";
        lion.GetClassificationAnimal = eClassificationAnimal.Carnivores;
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lion));
        using (FileStream fs = new FileStream("C:/Users/Полина/source/repos/lab8/lab8/Buba.xml", FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(fs, lion);
            Console.WriteLine("Object has been serialized");
        }
    }
}
