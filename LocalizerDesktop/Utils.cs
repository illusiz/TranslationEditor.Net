using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace LocalizerDesktop
{
    public class TranslationDictionary : Dictionary<string, string>
    {
        public string Name;
    }

    public class RowCellIndex
    {
        public int RowIndex { get; set; }
        public int CellIndex { get; set; }  
    }

    public static class Utils
    {
        public static ColorScheme CurrentColorScheme { get; set; }
        public static ColorScheme GetCurrentColorScheme()
        {
            var settings = Utils.LoadConfig();
            SetCurrentColorScheme(settings.CurrentColorScheme);
            return CurrentColorScheme;
        }

        public static int[] GetRgbFromString(this string colorString)
        {
            var splitArray = colorString.Trim().Split(',');

            return new int[] { int.Parse(splitArray[0]) , int.Parse(splitArray[1]), int.Parse(splitArray[2]) };
        }

        public static void SetCurrentColorScheme(string colorScheme)
        {
            switch (colorScheme)
            {
                case "Light":
                    CurrentColorScheme = LoadColorSchemes()[0];
                    break;
                case "Dark":
                    CurrentColorScheme = LoadColorSchemes()[1];
                    break;
                case "Alternate":
                    CurrentColorScheme = LoadColorSchemes()[2];
                    break;
                case "Custom":
                    CurrentColorScheme = LoadColorSchemes()[3];
                    break;
            }
        }

        public static Settings LoadConfig()
        {
            var serializer = new XmlSerializer(typeof(Settings));
            Settings settings;
            using (var reader = XmlReader.Create("Settings.xml"))
            {
                settings = (Settings)serializer.Deserialize(reader);
            }
            return settings;
        }

        public static void SaveConfig(Settings settings)
        {
            var serializer = new XmlSerializer(settings.GetType());
            using (var writer = XmlWriter.Create("Settings.xml"))
            {
                serializer.Serialize(writer, settings);
            }
        }

        public static List<ColorScheme> LoadColorSchemes()
        {
            var colorSchemesList = new List<ColorScheme>();
            var serializer = new XmlSerializer(typeof(ColorScheme));

            using (var reader = XmlReader.Create("LightScheme.xml"))
            {
                var colorScheme = (ColorScheme)serializer.Deserialize(reader);
                colorSchemesList.Add(colorScheme);
            }
            using (var reader = XmlReader.Create("DarkScheme.xml"))
            {
                var colorScheme = (ColorScheme)serializer.Deserialize(reader);
                colorSchemesList.Add(colorScheme);
            }
            using (var reader = XmlReader.Create("AlternateScheme.xml"))
            {
                var colorScheme = (ColorScheme)serializer.Deserialize(reader);
                colorSchemesList.Add(colorScheme);
            }
            using (var reader = XmlReader.Create("CustomScheme.xml"))
            {
                var colorScheme = (ColorScheme)serializer.Deserialize(reader);
                colorSchemesList.Add(colorScheme);
            }
            return colorSchemesList;
        }

        public static void SaveCustomColorScheme(ColorScheme colorScheme)
        {
            var serializer = new XmlSerializer(colorScheme.GetType());
            using (var writer = XmlWriter.Create("CustomScheme.xml"))
            {
                serializer.Serialize(writer, colorScheme);
            }
        }


        public static bool Contains(this DataGridView dataGridView,string columnName, string key, out int rowIndex)
        {
            foreach (DataGridViewRow keyRow in dataGridView.Rows)
            {
                if ((keyRow.Cells[columnName].Value==null ? string.Empty : keyRow.Cells[columnName].Value.ToString()) == key)
                {
                    rowIndex = keyRow.Index;
                    return true;
                }
            }
            rowIndex = -1;
            return false;
        }
    }
}
