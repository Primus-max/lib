using System.Drawing;

namespace ds.test.impl
{
    // Абстрактный класс, реализующий общие части IPlugin
    // Абстрактный класс, реализующий общие части IPlugin
    public abstract class PluginBase : IPlugin
    {
        public abstract string PluginName { get; }
        public abstract string Version { get; }
        public abstract Image Image { get; }
        public abstract string Description { get; }

        public abstract int Run(int input1, int input2);
    }
}
