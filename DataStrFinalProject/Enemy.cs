namespace DataStrFinalProject
{
    internal class Enemy
    {
        
        public Enemy(IEnemyModel em, int strBuff, int spdBuff, int hthBuff)
        {
            enemyModel = em;
            STRBuff = strBuff;
            SPDBuff = spdBuff;
            HTHBuff = hthBuff;
            // or maybe do buff right in here 
            em.Strength = em.Strength + STRBuff;
            em.Speed = em.Speed + SPDBuff;
            em.Health = em.Health + HTHBuff;
        }
        /*
        public void buffEnemy(EnemyModel em) // method for buffing enemies 
        {
            em.Strength = em.Strength + STRBuff;
            em.Speed = em.Speed + SPDBuff;
            em.Health = em.Health + HTHBuff;
        }
        */

        public IEnemyModel enemyModel { get; }
        public static int STRBuff { get; set; }
        public static int SPDBuff { get; set; }
        public static int HTHBuff { get; set; } // made static to ref other places 
    public void attack()
    {

    }

    /*
    public void defend(MainPlayer mp) // maybe place main player in here to weaken attack 
    {
        mp.attck(); // not sure about this, need to think about it 
    }
    */
    public void heal()
    {
            string Spear = "Spear Man";
            EnemyModelFactory emf = EnemyModelFactory.getEnemyModelFactory();
            EnemyModel em = new EnemyModel();
            if (Spear == em.Type)
            {
                int hCheck = emf.getHealth("Spear");
                if (enemyModel.Health == hCheck)
                {
                    System.Console.WriteLine(em.Type + " can not heal anymore");
                }
                else
                {
                    enemyModel.Health += 10; // may heal more than their max atm 
                }
            }
            
            

            // simple heal below - no check to see max health 
            //enemyModel.Health += 10;
    }
  }    
}