using System;

namespace App8
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Patient patient1 = new Patient( 1, "Max", "Ilchishin", 12 );
            Patient patient2 = new Patient( 2, "Andrei", "Andrich", 5 );
            Patient patient3 = new Patient( 3, "Petya", "Sergeev",30 );
            Patient patient4 = new Patient( 4, "Nikolas", "Tkachuk", 9);
            QueuePatients queuePatients = new QueuePatients();
            
            // Добавление пациентов в список;
            queuePatients.AddPatient(patient1);
            queuePatients.AddPatient(patient2);
            queuePatients.AddPatient(patient3);
            queuePatients.AddPatient(patient4);


            string pathToJsonFile = "patients.json";
            string pathToBinaryFile = "patients.bin";
            
            // Запись и чтение из бинарного файла;
            Console.WriteLine("Сериализация в бинарный файл: ");
            SerializerDeserializer.SaveBinFile(pathToBinaryFile, queuePatients);
            QueuePatients binLoadPatient = SerializerDeserializer.LoadFromBin(pathToBinaryFile);
            Console.WriteLine(binLoadPatient);
            
            // Чтение и запись из JSON файла;
            Console.WriteLine("Сериализация в JSON файл: ");
            SerializerDeserializer.SaveToJson(pathToJsonFile, queuePatients);
            QueuePatients jsonLoadPatient = SerializerDeserializer.LoadFromJson(pathToJsonFile);
            Console.WriteLine(jsonLoadPatient);

        }
    }
}