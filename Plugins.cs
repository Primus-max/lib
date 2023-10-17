namespace ds.test.impl
{
    public static class Plugins
    {
        private static IPlugin[] plugins = { new AdditionPlugin(), new MultiplicationPlugin() };

        public static int PluginsCount => plugins.Length;

        public static string[] GetPluginNames()
        {
            string[] names = new string[PluginsCount];
            for (int i = 0; i < PluginsCount; i++)
            {
                names[i] = plugins[i].PluginName;
            }
            return names;
        }

        public static IPlugin GetPlugin(string pluginName)
        {
            foreach (var plugin in plugins)
            {
                if (plugin.PluginName == pluginName)
                {
                    return plugin;
                }
            }
            return null;
        }
    }

}