namespace ds.test.impl
{
    /// <summary>
    /// Метод реализующий операцию вычисления процента над двумя целыми числами
    /// </summary>
    /// <returns>Возвращает процент от вычисления от значения input1 как часть от input2. </returns>
    public class PercentagePlugin : PluginBase
    {
        public override string PluginName => "PercentagePlugin";
        public override string Version => "1.0";
        public override Image Image => null; 
        public override string Description => "This plugin calculates percentages.";

        public override int Run(int input1, int input2)
        {
            if (input2 == 0)
            {
                throw new ArgumentException("Второй параметр не может быть 0");
            }
            double result = (double)input1 * input2 / 100.0;
            return (int)Math.Round(result);
        }
    }
}
