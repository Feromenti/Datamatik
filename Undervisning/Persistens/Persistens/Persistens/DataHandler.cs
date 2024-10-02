﻿namespace persistens
{
    public class DataHandler
    {
        public string DataFileName { get; }

        public DataHandler(string dataFileName)
        {
            DataFileName = dataFileName;
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

            string[] data = File.ReadAllText(DataFileName).Split(';');

 
            return new Person(
                data[0],
                DateTime.ParseExact(data[1], "dd-MM-yyyy HH:mm:ss", null), 
                double.Parse(data[2]), 
                bool.Parse(data[3]), 
                int.Parse(data[4])
            );
        }
    }
}
