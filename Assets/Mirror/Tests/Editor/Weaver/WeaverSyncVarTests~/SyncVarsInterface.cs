using Mirror;

namespace WeaverSyncVarTests.SyncVarsInterface
{
    class SyncVarsInterface : NetworkBehaviour
    {
        [SyncVar(hook = nameof(OnChangeHealth))]
        int health;

        interface MySyncVar
        {
            void interfaceMethod();
        }
        [SyncVar]
        MySyncVar invalidVar;

        public void TakeDamage(int amount)
        {
            if (!isServer)
                return;

            health -= amount;
        }

        void OnChangeHealth(int oldHealth, int newHealth)
        {
            // do things with your health bar
        }
    }
}
