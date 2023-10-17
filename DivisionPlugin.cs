namespace ds.test.impl
{
    public class DivisionPlugin : PluginBase
    {
        public override string PluginName => "DivisionPlugin";
        public override string Version => "1.0";
        public override Image Image => null; // Подставьте изображение
        public override string Description => "This plugin performs division.";

        public override int Run(int input1, int input2)
        {
            if (input2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return input1 / input2;
        }
    }
}
