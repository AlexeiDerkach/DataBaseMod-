using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace NCE.DataBase
{
    public class XmlExchanger
    {
        #region Поля

        /// <summary> Путь к файлу lot </summary>
        public static string lot = string.Format(Application.StartupPath + "\\" + Const.LotDataFile);
        /// <summary> Путь к директории </summary>
        public static string directoryLotData = lot.Substring(0, lot.LastIndexOf("\\"));
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        private TableInfo instTI = new TableInfo();

        #endregion

        /// <summary> Создаёт dafault XML-файл данных FormLot </summary>
        public void CreateDefaultXml()
        {
            if (!Directory.Exists(directoryLotData))
                Directory.CreateDirectory(directoryLotData);

            if (!File.Exists(lot))
            {
                XElement doc = new XElement("LotData",
                               new XElement("FIO", "Ivan Ivanov"),
                               new XElement("TabelNumb", "001"),
                               new XElement("Shift", "Blue Shift"),
                               new XElement("NormDoc", "ISO"),
                               new XElement("Specification", "Spec"),
                               new XElement("Drawing"),
                               new XElement("SteelType", "Type"),
                               new XElement("SopNumb", "test rail"),
                               new XElement("Lot", "Order"),
                               new XElement("LotNumb", "1"),
                               new XElement("HeatNumb", "1a"),
                               new XElement("BundleNumb", "Humble Bundle"),
                               new XElement("SerialNumb", "00001"),
                               new XElement("AddNumb1", "0"),
                               new XElement("AddNumb2", "0"),
                               new XElement("AddNumb3", "0"),
                               new XElement("AddNumb4", "0"),
                               new XElement("AddNumb5", "0"),
                               new XElement("ObjectLength", "100"),
                               new XElement("ObjectWidth", "100"),
                               new XElement("ObjectHeight", "100"),
                               new XElement("ObjectSpeed", "100"),
                               new XElement("ObjectOuterDiameter", "0"),
                               new XElement("ObjectInnerDiameter", "0"),
                               new XElement("ObjectWallThickness", "0"),
                               new XElement("ObjectA", "0"),
                               new XElement("ObjectB", "0"),
                               new XElement("ObjectC", "0"),
                               new XElement("ObjectD", "0"),
                               new XElement("ObjectE", "0"),
                               new XElement("ObjectF", "0"),
                               new XElement("ObjectG", "0"),
                               new XElement("ObjectH", "0"),
                               new XElement("ObjectI", "0"),
                               new XElement("ObjectJ", "0"),
                               new XElement("ObjectK", "0"),
                               new XElement("ObjectL", "0"),
                               new XElement("ObjectM", "0"),
                               new XElement("ObjectN", "0"),
                               new XElement("ObjectO", "0"),
                               new XElement("ObjectP", "0"),
                               new XElement("ObjectQ", "0"),
                               new XElement("ObjectR", "0"),
                               new XElement("ObjectS", "0"),
                               new XElement("ObjectT", "0"),
                               new XElement("ObjectU", "0"),
                               new XElement("ObjectV", "0"),
                               new XElement("ObjectW", "0"),
                               new XElement("ObjectX", "0"),
                               new XElement("ObjectY", "0"),
                               new XElement("ObjectZ", "0")
                 );
                doc.Save(lot);
            }
        }

        /// <summary>
        /// Чтение XML-файла
        /// </summary>
        /// <returns>Возвращает объект считанный из XML-файла данных FormLot</returns>
        public TableInfo ReadXml()
        {
            doc.Load(lot);
            root = doc.DocumentElement;

            instTI.Fio = root.GetElementsByTagName("FIO")[0].InnerText;
            instTI.TabelNumb = root.GetElementsByTagName("TabelNumb")[0].InnerText;
            instTI.Shift = root.GetElementsByTagName("Shift")[0].InnerText;
            instTI.NormDoc = root.GetElementsByTagName("NormDoc")[0].InnerText;
            instTI.Specification = root.GetElementsByTagName("Specification")[0].InnerText;
            instTI.Drawing = root.GetElementsByTagName("Drawing")[0].InnerText;
            instTI.SteelType = root.GetElementsByTagName("SteelType")[0].InnerText;
            instTI.SopNumb = root.GetElementsByTagName("SopNumb")[0].InnerText;
            instTI.Lot = root.GetElementsByTagName("Lot")[0].InnerText;
            instTI.LotNumb = root.GetElementsByTagName("LotNumb")[0].InnerText;
            instTI.HeatNumb = root.GetElementsByTagName("HeatNumb")[0].InnerText;
            instTI.BundleNumb = root.GetElementsByTagName("BundleNumb")[0].InnerText;            
            instTI.SerialNumb = root.GetElementsByTagName("SerialNumb")[0].InnerText;
            instTI.AddNumb1 = root.GetElementsByTagName("AddNumb1")[0].InnerText;
            instTI.AddNumb2 = root.GetElementsByTagName("AddNumb2")[0].InnerText;
            instTI.AddNumb3 = root.GetElementsByTagName("AddNumb3")[0].InnerText;
            instTI.AddNumb4 = root.GetElementsByTagName("AddNumb4")[0].InnerText;
            instTI.AddNumb5 = root.GetElementsByTagName("AddNumb5")[0].InnerText;
            instTI.ObjectLength = Convert.ToDouble(root.GetElementsByTagName("ObjectLength")[0].InnerText);
            instTI.ObjectWidth = Convert.ToDouble(root.GetElementsByTagName("ObjectWidth")[0].InnerText);
            instTI.ObjectHeight = Convert.ToDouble(root.GetElementsByTagName("ObjectHeight")[0].InnerText);
            instTI.ObjectSpeed = Convert.ToDouble(root.GetElementsByTagName("ObjectSpeed")[0].InnerText);
            instTI.ObjectOuterDiameter = Convert.ToDouble(root.GetElementsByTagName("ObjectOuterDiameter")[0].InnerText);
            instTI.ObjectInnerDiameter = Convert.ToDouble(root.GetElementsByTagName("ObjectInnerDiameter")[0].InnerText);
            instTI.ObjectWallThickness = Convert.ToDouble(root.GetElementsByTagName("ObjectWallThickness")[0].InnerText);
            instTI.ObjectA = Convert.ToDouble(root.GetElementsByTagName("ObjectA")[0].InnerText);
            instTI.ObjectB = Convert.ToDouble(root.GetElementsByTagName("ObjectB")[0].InnerText);
            instTI.ObjectC = Convert.ToDouble(root.GetElementsByTagName("ObjectC")[0].InnerText);
            instTI.ObjectD = Convert.ToDouble(root.GetElementsByTagName("ObjectD")[0].InnerText);
            instTI.ObjectE = Convert.ToDouble(root.GetElementsByTagName("ObjectE")[0].InnerText);
            instTI.ObjectF = Convert.ToDouble(root.GetElementsByTagName("ObjectF")[0].InnerText);
            instTI.ObjectG = Convert.ToDouble(root.GetElementsByTagName("ObjectG")[0].InnerText);
            instTI.ObjectH = Convert.ToDouble(root.GetElementsByTagName("ObjectH")[0].InnerText);
            instTI.ObjectI = Convert.ToDouble(root.GetElementsByTagName("ObjectI")[0].InnerText);
            instTI.ObjectJ = Convert.ToDouble(root.GetElementsByTagName("ObjectJ")[0].InnerText);
            instTI.ObjectK = Convert.ToDouble(root.GetElementsByTagName("ObjectK")[0].InnerText);
            instTI.ObjectL = Convert.ToDouble(root.GetElementsByTagName("ObjectL")[0].InnerText);
            instTI.ObjectM = Convert.ToDouble(root.GetElementsByTagName("ObjectM")[0].InnerText);
            instTI.ObjectN = Convert.ToDouble(root.GetElementsByTagName("ObjectN")[0].InnerText);
            instTI.ObjectO = Convert.ToDouble(root.GetElementsByTagName("ObjectO")[0].InnerText);
            instTI.ObjectP = Convert.ToDouble(root.GetElementsByTagName("ObjectP")[0].InnerText);
            instTI.ObjectQ = Convert.ToDouble(root.GetElementsByTagName("ObjectQ")[0].InnerText);
            instTI.ObjectR = Convert.ToDouble(root.GetElementsByTagName("ObjectR")[0].InnerText);
            instTI.ObjectS = Convert.ToDouble(root.GetElementsByTagName("ObjectS")[0].InnerText);
            instTI.ObjectT = Convert.ToDouble(root.GetElementsByTagName("ObjectT")[0].InnerText);
            instTI.ObjectU = Convert.ToDouble(root.GetElementsByTagName("ObjectU")[0].InnerText);
            instTI.ObjectV = Convert.ToDouble(root.GetElementsByTagName("ObjectV")[0].InnerText);
            instTI.ObjectW = Convert.ToDouble(root.GetElementsByTagName("ObjectW")[0].InnerText);
            instTI.ObjectX = Convert.ToDouble(root.GetElementsByTagName("ObjectX")[0].InnerText);
            instTI.ObjectY = Convert.ToDouble(root.GetElementsByTagName("ObjectY")[0].InnerText);
            instTI.ObjectZ = Convert.ToDouble(root.GetElementsByTagName("ObjectZ")[0].InnerText);

            return instTI;
        }

        /// <summary>
        /// Заполняет XML-файл данных FormLot
        /// </summary>
        /// <param name="tableInfo">Таблица Info</param>
        public void FillXml(TableInfo tableInfo)
        {
            XElement doc = new XElement("LotData",

                           new XElement("FIO", tableInfo.Fio),
                           new XElement("TabelNumb", tableInfo.TabelNumb),
                           new XElement("Shift", tableInfo.Shift),
                           new XElement("NormDoc", tableInfo.NormDoc),
                           new XElement("Specification", tableInfo.Specification),
                           new XElement("Drawing", tableInfo.Drawing),
                           new XElement("SteelType", tableInfo.SteelType),
                           new XElement("SopNumb", tableInfo.SopNumb),
                           new XElement("Lot", tableInfo.Lot),
                           new XElement("LotNumb", tableInfo.LotNumb),
                           new XElement("HeatNumb", tableInfo.HeatNumb),
                           new XElement("BundleNumb", tableInfo.BundleNumb),
                           new XElement("SerialNumb", tableInfo.SerialNumb),
                           new XElement("AddNumb1", tableInfo.AddNumb1),
                           new XElement("AddNumb2", tableInfo.AddNumb2),
                           new XElement("AddNumb3", tableInfo.AddNumb3),
                           new XElement("AddNumb4", tableInfo.AddNumb4),
                           new XElement("AddNumb5", tableInfo.AddNumb5),
                           new XElement("ObjectLength", tableInfo.ObjectLength),
                           new XElement("ObjectWidth", tableInfo.ObjectWidth),
                           new XElement("ObjectHeight", tableInfo.ObjectHeight),
                           new XElement("ObjectSpeed", tableInfo.ObjectSpeed),
                           new XElement("ObjectOuterDiameter", tableInfo.ObjectOuterDiameter),
                           new XElement("ObjectInnerDiameter", tableInfo.ObjectInnerDiameter),
                           new XElement("ObjectWallThickness", tableInfo.ObjectWallThickness),
                           new XElement("ObjectA", tableInfo.ObjectA),
                           new XElement("ObjectB", tableInfo.ObjectB),
                           new XElement("ObjectC", tableInfo.ObjectC),
                           new XElement("ObjectD", tableInfo.ObjectD),
                           new XElement("ObjectE", tableInfo.ObjectE),
                           new XElement("ObjectF", tableInfo.ObjectF),
                           new XElement("ObjectG", tableInfo.ObjectG),
                           new XElement("ObjectH", tableInfo.ObjectH),
                           new XElement("ObjectI", tableInfo.ObjectI),
                           new XElement("ObjectJ", tableInfo.ObjectJ),
                           new XElement("ObjectK", tableInfo.ObjectK),
                           new XElement("ObjectL", tableInfo.ObjectL),
                           new XElement("ObjectM", tableInfo.ObjectM),
                           new XElement("ObjectN", tableInfo.ObjectN),
                           new XElement("ObjectO", tableInfo.ObjectO),
                           new XElement("ObjectP", tableInfo.ObjectP),
                           new XElement("ObjectQ", tableInfo.ObjectQ),
                           new XElement("ObjectR", tableInfo.ObjectR),
                           new XElement("ObjectS", tableInfo.ObjectS),
                           new XElement("ObjectT", tableInfo.ObjectT),
                           new XElement("ObjectU", tableInfo.ObjectU),
                           new XElement("ObjectV", tableInfo.ObjectV),
                           new XElement("ObjectW", tableInfo.ObjectW),
                           new XElement("ObjectX", tableInfo.ObjectX),
                           new XElement("ObjectY", tableInfo.ObjectY),
                           new XElement("ObjectZ", tableInfo.ObjectZ)
                );
            doc.Save(lot);
        }
    }
}
