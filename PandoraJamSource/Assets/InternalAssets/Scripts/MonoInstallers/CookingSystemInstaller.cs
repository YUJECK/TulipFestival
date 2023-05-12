using AYellowpaper.SerializedCollections;
using InternalAssets.Scripts.CookSystem;
using Zenject;

namespace InternalAssets.Scripts.MonoInstallers
{
    public class CookingSystemInstaller : MonoInstaller
    {
        public SerializedDictionary<Ingredient[], Meal> MealsRecipes = new();

        public override void InstallBindings()
        {
            MealContainer mealContainer = new(MealsRecipes);

            Container
                .Bind<MealContainer>()
                .FromInstance(mealContainer)
                .AsSingle();
        }
    }
}