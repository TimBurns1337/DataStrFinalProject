internal interface IEnemyModel
{
    public string Type { get; set; }
    public int Strength { get; set; }
    public int Speed { get; set; }
    public int Health { get; set; }
}
// doesnt like the below for some reason 
/*
namespace DataStrFinalProject
{
    internal interface IEnemyModel
    {
        public string Type { get; }
        public int Strength { get; }
        public int Speed { get; }
        public int Health { get; }
    }
}
*/