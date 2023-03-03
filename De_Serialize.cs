using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Wpf_Diary
{
    internal class De_Serialize
    {
        public static void Serialize<T>(T obj)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(path: @"..\..\..\db.xml", FileMode.Create))
            {
                xml.Serialize(fs, obj);
            }
        }
        public static T Deserialize<T>()
        {
            T obj;
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(path: @"..\..\..\db.xml", FileMode.Open))
            {
                obj = (T?)xml.Deserialize(fs);
            }
            return obj;
        }
    }
}
