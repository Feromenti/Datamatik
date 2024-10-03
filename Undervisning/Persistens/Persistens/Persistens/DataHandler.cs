using System.Globalization;
using System.IO;

namespace persistens
{
    public class DataHandler
    {
        private string dataFileName;

        public string DataFileName
        {
            get { return dataFileName; }
        }

        public DataHandler(string DataFileName)
        {
            dataFileName = DataFileName;
        }
        public void SavePerson(Person person)
        {
            using (StreamWriter writer = new StreamWriter(DataFileName))
            {
                writer.WriteLine(person.MakeTitle());
            }
        }
        public Person LoadPerson()
        {
            using (StreamReader reader = new StreamReader(DataFileName))
            {
                string[] data = reader.ReadLine().Split(';');

                return new Person(
                data[0],
                DateTime.ParseExact(data[1], "dd-MM-yyyy HH:mm:ss", null),
                double.Parse(data[2]),
                bool.Parse(data[3]),
                int.Parse(data[4]));
            }
        }

        public void SavePersons(Person[] persons)
        {
            StreamWriter writer = new StreamWriter(DataFileName);
            
            foreach (Person person in persons)
            {
                writer.WriteLine(person.MakeTitle());
            }

            writer.Close();
        }

        public Person[] LoadPersons()
        {
            string[] lines = File.ReadAllLines(DataFileName);
            Person[] loadedPersons = new Person[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(';');
                loadedPersons[i] = new Person(
                    data[0],
                    DateTime.ParseExact(data[1], "dd-MM-yyyy HH:mm:ss", null),
                    double.Parse(data[2]),
                    bool.Parse(data[3]),
                    int.Parse(data[4])
                );
            }

            return loadedPersons;
        }
    }
}
