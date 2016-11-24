using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine.UI;

namespace TextEffect
{
    public class loadTextCommand : Command
    {
       
        [Inject(ContextKeys.CONTEXT_VIEW)]//也是注入
        public GameObject contextView { get; set; }
        public override void Execute()
        {

            contextView.AddComponent<TextEffectView>();   //添加VIEW

        }
    }
}

