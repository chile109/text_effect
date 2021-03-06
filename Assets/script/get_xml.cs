﻿using System.Xml;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class get_xml : MonoBehaviour {
    public static string url = "https://www.google.com.tw/";
    Text msg ;
    private int id = 0;
    public string file = "/my2.xml";
    public int xml_max;
    void Start()
    {
        msg = this.GetComponent<Text>();

        int i = UnityEngine.Random.Range(1, xml_max + 1);
        id = i;
        
        string filepath = Application.dataPath + "/StreamingAssets" + file;
        //string filepath = "jar:file://" + Application.dataPath + "!/assets/" + file;

        if (File.Exists(filepath))
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("transforms").ChildNodes;

            foreach (XmlElement xe in nodeList)
            {
                if (xe.GetAttribute("id") == id.ToString())
                {
                    foreach (XmlElement x1 in xe.ChildNodes)   //遍歷
                    {
                        if (x1.Name == "poem")                 //獲取名為poem節點的資料
                        {
                            Debug.Log("VALUE :" + x1.InnerText);
                            msg.text = x1.InnerText;

                            //textComp.text = x1.InnerText;
                        }
                        if (x1.Name == "url")                   ////獲取名為url節點的資料
                        {

                            url = x1.InnerText;
                            Debug.Log("url :" + x1.InnerText);
                        }
                    }
                }
            }
            Debug.Log("all = " + xmlDoc.OuterXml);

        }
    }
   
}
