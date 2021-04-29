namespace DataStrFinalProject
{
    internal interface IEnemyModel
    {
        public string Type { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
    }
}
