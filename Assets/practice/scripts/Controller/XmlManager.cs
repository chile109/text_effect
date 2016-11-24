using System.Xml;
using System.IO;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace TextEffect
{
    public class XmlManager : MonoBehaviour, ISomeManager
    {

        #region showXml()
        public static string url = "https://www.google.com.tw/";

        private int id = 0;
        public void showXml()
        {
          
            int i = UnityEngine.Random.Range(1, 7);
            print(i);
            id = i;
            string filepath = Application.dataPath + @"/my2.xml";
            if (File.Exists(filepath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filepath);
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("transforms").ChildNodes;

                foreach (XmlElement xe in nodeList)
                {
                    if (xe.GetAttribute("id") == id.ToString())
                    {
                        foreach (XmlElement x1 in xe.ChildNodes)
                        {
                            if (x1.Name == "poem")
                            {
                                Debug.Log("VALUE :" + x1.InnerText);
                                text.msg = x1.InnerText;

                                //textComp.text = x1.InnerText;
                            }
                            if (x1.Name == "url")
                            {

                                url = x1.InnerText;
                                Debug.Log("url :" + x1.InnerText);
                            }
                        }
                    }
                }
                Debug.Log("all = " + xmlDoc.OuterXml);
                
            }

            text.typtriger = true;
        }
        #endregion
      
    }
}
