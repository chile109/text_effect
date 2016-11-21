using UnityEngine;
using strange.extensions.mediation.impl;
using System.Collections;
using UnityEngine.UI;


namespace TextEffect
{
    public class HelloWorldMediator : Mediator
    {
        [Inject]//这就是注入
        public TextEffectView view { get; set; }
        [Inject]
        public ShowXmlSignal Xml { get; set; }
        public override void OnRegister()
        {
            view.clickSignal.AddListener(Xml.Dispatch);//监听点击按钮信号并响应信号
            
            view.AddUI();
        }
       
    }
}
