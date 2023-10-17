namespace ds.test.impl
{
    /// <summary>
    /// Метод реализующий операцию вычитания над двумя целыми числами
    /// </summary>
    public class SubtractionPlugin : PluginBase
    {
        public override string PluginName => "SubtractionPlugin";
        public override string Version => "1.0";
        public override Image Image => null; 
        public override string Description => "Этот плагин выполняет вычитание двух целых чисел";

        public override int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}
