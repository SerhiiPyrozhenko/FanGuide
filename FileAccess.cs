using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOP_FanGuide
{
    [Serializable]
    public class FileAccess
    {
        /// <summary>
        /// Класс, отвечающий за чтение и сохранение данных.
        /// </summary>
        public FootballerList OpenF(string pathF, FootballerList listF)
        {
            /// <summary>
            /// Чтение данных из файла.
            /// </summary>
            /// <returns> Возвращает коллекцию, которая была сохранена по заданному пути.
            /// В случае, если прочесть невозможно, возвращает null. </returns>

            // Проверка на существование файла
            if (File.Exists(pathF))
            {
                Stream stream = File.Open(pathF, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                listF = (FootballerList)b.Deserialize(stream);
                stream.Close();
                return listF;
            }
            else
            {
                Stream stream = File.Create(pathF);
                stream.Close();
                return null;
            }
        }

        public TennisPlayerList OpenT(string pathT, TennisPlayerList listT)
        {
            if (File.Exists(pathT))
            {
                Stream stream = File.Open(pathT, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                listT = (TennisPlayerList)b.Deserialize(stream);
                stream.Close();
                return listT; 
            }
            else
            {
                Stream stream = File.Create(pathT);
                stream.Close();
                return null;
            }
        }

        public BoxerList OpenB(string pathB, BoxerList listB)
        {
            if (File.Exists(pathB))
            {
                Stream stream = File.Open(pathB, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                listB = (BoxerList)b.Deserialize(stream);
                stream.Close();
                return listB;
            }
            else
            {
                Stream stream = File.Create(pathB);
                stream.Close();
                return null;
            }
        }

        /// <summary>
        /// Сохранение объекта.
        /// </summary>

        public void SaveF(string pathF, FootballerList listF)
        {
            BinaryFormatter bf = new BinaryFormatter();

            if (!File.Exists(pathF))
            {
                Stream stream = File.Create(pathF);
                stream.Close();
            }
            using (Stream stream = new FileStream(pathF, FileMode.Open, System.IO.FileAccess.Write, FileShare.None))
            {
                bf.Serialize(stream, listF);
            }
        }

        public void SaveB(string pathB, BoxerList listB)
        {
            BinaryFormatter bf = new BinaryFormatter();

            if (!File.Exists(pathB))
            {
                Stream stream = File.Create(pathB);
                stream.Close();
            }
            using (Stream stream = new FileStream(pathB, FileMode.Open, System.IO.FileAccess.Write, FileShare.None))
            {
                bf.Serialize(stream, listB);
            }
        }

        public void SaveT(string pathT, TennisPlayerList listT)
        {
            BinaryFormatter bf = new BinaryFormatter();

            if (!File.Exists(pathT))
            {
                Stream stream = File.Create(pathT);
                stream.Close();
            }
            using (Stream stream = new FileStream(pathT, FileMode.Open, System.IO.FileAccess.Write, FileShare.None))
            {
                bf.Serialize(stream, listT);
            }
        }
    }
}
