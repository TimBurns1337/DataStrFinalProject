namespace DataStrFinalProject
{
    internal interface IEnemyModel // adapter pattern 
    {
        public string Type { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
    }
}
