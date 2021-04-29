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
            enemyModel.Strength = enemyModel.Strength * STRBuff;
            enemyModel.Speed = enemyModel.Speed * SPDBuff;
            enemyModel.Health = enemyModel.Health * HTHBuff;
        } 
  }    
}