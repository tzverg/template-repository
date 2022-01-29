using TemplateNamespace.Core.Installers.Params;
using UnityEngine;
using Zenject;

namespace TemplateNamespace.Core.Installers
{
    public class GameLogicInstaller : MonoInstaller
    {
        [SerializeField] private GameLogicInstallerParams _params;

        public override void InstallBindings()
        {
            Container.Bind<Camera>().FromInstance(_params.MainCamera).AsSingle();
        }
    }
}