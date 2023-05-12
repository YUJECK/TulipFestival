using InternalAssets.Scripts.Helpers;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace InternalAssets.Scripts.MonoInstallers
{
    public sealed class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Transform _startPoint;

        public override void InstallBindings()
        {
            GameObject playerPrefab = Resources.Load<GameObject>(AssetsPaths.PlayerPrefab);
            Container.InstantiatePrefab(playerPrefab, _startPoint.position, Quaternion.identity, null);
        }
    }
}