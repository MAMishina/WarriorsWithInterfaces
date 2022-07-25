using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsWithInterfaces
{
    class Menu
    {
        public Warior[] wariors;
        private string address;
        private int index;
        private string[] titles;

        public Menu(string address)
        {
            this.address = address;
            this.index = 0;
            this.titles = new string[4];
            this.wariors = new Warior[1];
        }

        public void Add(Warior NewWarior)
        {
            this.ResizeWariorsArray(index >= this.wariors.Length);
            this.wariors[index] = NewWarior;
            this.index++;
        }
        private void ResizeWariorsArray(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.wariors, this.wariors.Length * 2);
            }
        }

        public void WriteTitle() //записывает ту самую строчку
        {
            string forRecord = "ID#Дата добавления записи#Имя Война#Уровень HP";
            try
            {
                using (StreamWriter sw = new StreamWriter(address, append: false))
                {
                    sw.WriteLine(forRecord);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Save()
        {
            string forRecord = " ";

            for (int i = 0; i < index; i++)
            {
                forRecord = string.Empty;
                string dataTime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                forRecord = $"{i + " # " + dataTime + " # " + this.wariors[i].Name + " # " + this.wariors[i].HP}";

                Write(forRecord);
            }
            Console.WriteLine();
            Console.WriteLine("Прогресс сохранен.");
            Console.WriteLine();
        }
        private void CleanArr(Warior[] wariors)
        {
            wariors = new Warior[1];
            this.index = 0;
        }

        public void Removing(string address) //удаление файла
        {
            File.Delete(address);
        }

        private void Write(string forRecord)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(address, append: true))
                {
                    sw.WriteLine(forRecord);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
        /// <summary>
        /// метод предназначен для чтения из файла
        /// </summary>
        /// <param name="address"></param>
        public void Open(string address)
        {
            try
            {
                using (StreamReader sr = new StreamReader(address))
                {
                    CleanArr(wariors);
                    String lineFromFile;
                    lineFromFile = sr.ReadLine();
                    while (lineFromFile != null)
                    {
                        string[] lineToPrint = lineFromFile.Split("#");
                                                                                   // name               HP             
                        Console.WriteLine($"{lineToPrint[0],5} {lineToPrint[1],20} {lineToPrint[2],15} {lineToPrint[3],3} ");
                        lineFromFile = sr.ReadLine();
                        int hp;
                        int.TryParse(lineToPrint[3], out hp);
                        switch (lineToPrint[2])
                        {
                            case "Гоблин":
                                Add(new Goblin(hp));
                                Console.WriteLine($"Добавлен гоблин {index}");
                                break;
                            case "Доктор":
                                Add(new Doctor(hp));
                                Console.WriteLine($"Добавлен доктор {index}");
                                break;
                            case "Орк":
                                Add(new Orc(hp));
                                Console.WriteLine($"Добавлен орк {index}");
                                break;
                            default:
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Файл успешно прочитан.");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
