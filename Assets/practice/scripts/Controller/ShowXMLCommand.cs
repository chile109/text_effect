using strange.extensions.command.impl;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace TextEffect
{
    public class ShowXMLCommand : Command
    {
        [Inject]
        public ISomeManager manager { get; set; }
        
        public override void Execute()
        {
            manager.showXml();           
        }
        
       
    }
}
