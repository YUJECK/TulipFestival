namespace InternalAssets.Scripts.Player
{
    public sealed class PlayerWallet
    {
        public int CurrentMoney = 0;

        public PlayerWallet(int currentMoney)
        {
            CurrentMoney = currentMoney;
        }
    }
}