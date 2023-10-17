namespace ds.test.impl
{
    interface IPluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginNames { get; }
        IPlugin GetPlugin(string pluginName);
    }
}
