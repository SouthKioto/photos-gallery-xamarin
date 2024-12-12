using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace App1.Classes
{
    public class PhotoDataHandlers
    {
        public static void CreateExampleData(string path)
        {
            if (!File.Exists(path))
            {
                var exampleData = new List<string>
                {
                    "1;Laki;Piękne zdjęcie łąki;11-12-2022;",
                    "2;Gory;Piękne zdjęcie gór;12-12-2022;",
                    "3;Lasy;Piękne zdjęcie lasu;13-12-2022;"
                };

                File.WriteAllLines(path, exampleData);
            }
        }

        public static List<PhotoData> GetDataFromTextFile(string path)
        {
            var photoList = new List<PhotoData>();

            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var parts = line.Split(';');

                    if (parts.Length >= 4)
                    {
                        try
                        {
                            var photo = new PhotoData
                            {
                                Photo_id = int.Parse(parts[0]),
                                Photo_Title = parts[1],
                                Photo_Description = parts[2],
                                Photo_ReleaseData = parts[3],
                                Photo_Source = $"{parts[1]}.jpg",
                            };

                            photoList.Add(photo);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Błąd podczas przetwarzania linii: {line}. Szczegóły: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nieprawidłowa linia: {line}");
                    }
                }

            }

            return photoList;
        }
    }
}
