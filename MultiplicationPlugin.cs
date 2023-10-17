namespace ds.test.impl
{
    /// <summary>
    /// Метод реализующий операцию умножения над двумя целыми числами
    /// </summary>
    public class MultiplicationPlugin : PluginBase
    {
        public override string PluginName => "MultiplicationPlugin";
        public override string Version => "1.0";
        public override Image Image => null;
        public override string Description => "Этот плагин выполняет умножение двух целых чисел";

        public override int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
