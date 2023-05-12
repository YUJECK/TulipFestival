using InternalAssets.Scripts.InventorySystem;
using Zenject;

namespace InternalAssets.Scripts.MonoInstallers
{
    public sealed class InventoryInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<Inventory>()
                .FromInstance(new Inventory())
                .AsSingle();
        }
    }
}