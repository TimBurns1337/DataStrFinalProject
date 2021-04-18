namespace DataStrFinalProject
{
    internal class Enemy : IEnemyModel
    {

        public IEnemyModel EnemyModel { get; }
        public static int STRBuff { get; set; }
        public static int SPDBuff { get; set; }
        public static int HTHBuff { get; set; } // made static to ref other places 
        public string Type { get => EnemyModel.Type; set => EnemyModel.Type = value; }
        public int Strength { get => EnemyModel.Strength; set => EnemyModel.Strength = value; }
        public int Speed { get => EnemyModel.Speed; set => EnemyModel.Speed = value; }
        public int Health { get => EnemyModel.Health; set => EnemyModel.Health = value; }

        public Enemy(IEnemyModel enemyModel, int strBuff, int spdBuff, int hthBuff)
        {
            EnemyModel = enemyModel;
            STRBuff = strBuff;
            SPDBuff = spdBuff;
            HTHBuff = hthBuff;
            // or maybe do buff right in here 
            enemyModel.Strength = enemyModel.Strength + STRBuff;
            enemyModel.Speed = enemyModel.Speed + SPDBuff;
            enemyModel.Health = enemyModel.Health + HTHBuff;
        }
        /*
        public void buffEnemy(EnemyModel em) // method for buffing enemies 
        {
            em.Strength = em.Strength + STRBuff;
            em.Speed = em.Speed + SPDBuff;
            em.Health = em.Health + HTHBuff;
        }
        */

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
                if (EnemyModel.Health == hCheck)
                {
                    System.Console.WriteLine(em.Type + " can not heal anymore");
                }
                else
                {
                    EnemyModel.Health += 10; // may heal more than their max atm 
                }
            }
            
            

            // simple heal below - no check to see max health 
            //enemyModel.Health += 10;
    }
  }    
}