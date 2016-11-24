using System.Xml;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class paint_name : MonoBehaviour
{
    public static string profile = "千秋萬水";
    Text msg;
    public static int n_id;
    
    void Start()
    {
        msg = this.GetComponent<Text>();
        
    }

    void Update()
    {

        string filepath = Application.dataPath + @"/my2.xml";
        if (File.Exists(filepath))
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("transforms").ChildNodes;

            foreach (XmlElement xe in nodeList)
            {
                if (xe.GetAttribute("id") == n_id.ToString())
                {
                    foreach (XmlElement x1 in xe.ChildNodes)
                    {
                        if (x1.Name == "poem")
                        {
                            Debug.Log("VALUE :" + x1.InnerText);
                            msg.text = x1.InnerText;

                            //textComp.text = x1.InnerText;
                        }

                    }
                }
            }
        }
    }
}
