namespace ds.test.impl
{
    /// <summary>
    /// Метод реализующий операцию деления над двумя целыми числами
    /// </summary>
    public class DivisionPlugin : PluginBase
    {
        public override string PluginName => "DivisionPlugin";
        public override string Version => "1.0";
        public override Image Image => null; 
        public override string Description => "This plugin performs division.";

        public override int Run(int input1, int input2)
        {
            if (input2 == 0)
            {
                throw new DivideByZeroException("Делить на ноль нельзя");
            }
            return input1 / input2;
        }
    }
}
