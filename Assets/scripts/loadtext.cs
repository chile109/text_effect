using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using UnityEngine.UI;
using System;



public class loadtext : MonoBehaviour {
    private Text textComp;
    private int id = 0;
    // Use this for initialization


    public void showXml()
    {
        int i = UnityEngine.Random.Range(1, 7);
        print(i);
        id = i;
        string filepath = Application.dataPath + @"/my.xml";
        if (File.Exists(filepath))
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("transforms").ChildNodes;
            
            foreach (XmlElement xe in nodeList)
            {
                Debug.Log("Attribute :" + xe.GetAttribute("name"));
                Debug.Log("NAME :" + xe.Name);
                foreach (XmlElement x1 in xe.ChildNodes)
                {
                    if (x1.Name == "id" + id.ToString())
                    {
                        Debug.Log("VALUE :" + x1.InnerText);
                        text.msg = x1.InnerText;
                        
                        //textComp.text = x1.InnerText;
                    }
                }
            }
            Debug.Log("all = " + xmlDoc.OuterXml);
            
        }
        StartCoroutine(this.GetComponent<text>().TypeIn());
    }
}
