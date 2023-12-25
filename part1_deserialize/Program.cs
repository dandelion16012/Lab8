using System.Xml.Serialization;
using AnimalClasses.abstract_classes;
using AnimalClasses.classes;

class Program
{
    static void Main()
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lion));

        using (FileStream fs = new FileStream("C:/Users/Полина/source/repos/lab8/lab8/Buba.xml", FileMode.OpenOrCreate))
        {
            Animal? lion = xmlSerializer.Deserialize(fs) as Lion;
            Console.WriteLine($"Country: {lion?.Country}\nHide from other animals: {lion?.HideFromOtherAnimals}\n" +
                              $"Name: {lion?.Name}\nClassification: {lion?.GetClassificationAnimal}");
        }
    }
}
