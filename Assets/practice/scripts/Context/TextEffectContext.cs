using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.command.api;

namespace TextEffect
{
    public class TextEffectContext : MVCSContext
    {
        public TextEffectContext(MonoBehaviour view)
            : base(view)
        {
        }
        protected override void addCoreComponents()
        {
            base.addCoreComponents();
            injectionBinder.Unbind<ICommandBinder>();
            injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
        }
        override public IContext Start()
        {
            base.Start();
            StartSignal startSignal = (StartSignal)injectionBinder.GetInstance<StartSignal>();
            startSignal.Dispatch();
            return this;
        }
        protected override void mapBindings()
        {
            mediationBinder.Bind<TextEffectView>().To<HelloWorldMediator>();
            injectionBinder.Bind<ISomeManager>().To<XmlManager>().ToSingleton();

            commandBinder.Bind<StartSignal>().To<loadTextCommand>().Once();
            commandBinder.Bind<ShowXmlSignal>().To<ShowXMLCommand>().Pooled();
        }
    }
}
