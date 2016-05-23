using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_FanGuide
{
    class FileAccess
    {
        public const string File = @".\Data\sportsmens.txt";
        /// <summary>
        /// Загружает магазины с файла
        /// </summary>
        public static PersonList Load()
        {
            PersonList person = new PersonList();
            try
            {
                using (TextReader reader =
                new StreamReader(File, Encoding.Default))
                {
                    int n = int.Parse(reader.ReadLine());
                    for (int i = 0; i < n; ++i)
                    {
                        string name = reader.ReadLine();
                        string surName = reader.ReadLine();
                        string nationality = reader.ReadLine();
                        string age = reader.ReadLine();
                        string height = reader.ReadLine();
                        string width = reader.ReadLine();
                        string careerDuration = reader.ReadLine();

                        Person cache = new Person(name, surName, nationality, age, height, width, careerDuration);

                        person.Add(cache);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("File " +
                File + " could not be read.", ex);
            }
            return person;
        }
        /// <summary>
        /// Загружает данные с конкретного файла
        /// </summary>
        public static PersonList Load(string path)
        {
            PersonList person = new PersonList();
            try
            {
                using (TextReader reader =
                new StreamReader(File, Encoding.Default))
                {
                    int n = int.Parse(reader.ReadLine());
                    for (int i = 0; i < n; ++i)
                    {
                        string name = reader.ReadLine();
                        string surName = reader.ReadLine();
                        string nationality = reader.ReadLine();
                        string age =reader.ReadLine();
                        string height = reader.ReadLine();
                        string width = reader.ReadLine();
                        string careerDuration = reader.ReadLine();

                        Person cache = new Person(name, surName, nationality, age, height, width, careerDuration);

                        person.Add(cache);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("File " +
                File + " could not be read.", ex);
            }
            return person;
        }
        /// <summary>
        /// Сохраняет магазины
        /// </summary>
        public static void Save(PersonList person)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(File, false, Encoding.Default))
                {
                    writer.WriteLine(person.Count);
                    foreach (Person p in person)
                    {
                        writer.WriteLine(p.Name);
                        writer.WriteLine(p.SurName);
                        writer.WriteLine(p.Nationality);
                        writer.WriteLine(p.Age);
                        writer.WriteLine(p.Height);
                        writer.WriteLine(p.Weight);
                        writer.WriteLine(p.CareerDuraction);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("File "
                + File + " could not be wrote down.", ex);
            }
        }
        /// <summary>
        /// Сохраняет данные в конкретное место
        /// </summary>
        public static void Save(PersonList person, string path)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(
                File, false, Encoding.Default))
                {
                    writer.WriteLine(person.Count);
                    foreach (Person p in person)
                    {
                        writer.WriteLine(p.Name);
                        writer.WriteLine(p.SurName);
                        writer.WriteLine(p.Nationality);
                        writer.WriteLine(p.Age);
                        writer.WriteLine(p.Height);
                        writer.WriteLine(p.Weight);
                        writer.WriteLine(p.CareerDuraction);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("File " + path + " could not be wrote down.", ex);
            }
        }
    }
}
