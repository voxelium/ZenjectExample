using UnityEngine;
using Zenject;

public class Print_Installer : MonoInstaller
{
    [SerializeField] private SceneManager _printManager;
    public override void InstallBindings()
    {
        Container.Bind<SceneManager>().FromInstance(_printManager);
    }

}