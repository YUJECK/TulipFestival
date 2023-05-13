using InternalAssets.Scripts.Helpers;
using InternalAssets.Scripts.Player;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts.MonoInstallers
{
    public sealed class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Transform _startPoint;
        [SerializeField] private int startMoney;

        public override void InstallBindings()
        {
            GameObject playerPrefab = Resources.Load<GameObject>(AssetsPaths.PlayerPrefab);
            Container.InstantiatePrefab(playerPrefab, _startPoint.position, Quaternion.identity, null);

            Container
                .Bind<CharacterMoney>()
                .FromInstance(new CharacterMoney(startMoney))
                .AsSingle();
        }
    }
}