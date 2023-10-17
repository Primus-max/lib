using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Метод реализующий операцию сложения над двумя целыми числами
    /// </summary>
    public class AdditionPlugin : PluginBase
    {
        public override string PluginName => "AdditionPlugin";
        public override string Version => "1.0";
        public override Image Image => null!; 
        public override string Description => "This plugin performs addition.";

        public override int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
