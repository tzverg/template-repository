using System;
using UnityEngine;

namespace TemplateNamespace.Core.Installers.Params
{
    [Serializable] internal struct GameLogicInstallerParams
    {
        [SerializeField] private Camera _mainCamera;

        public Camera MainCamera { get => _mainCamera; set => _mainCamera = value; }
    }
}