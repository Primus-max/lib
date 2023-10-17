namespace ds.test.impl
{
    /// <summary>
    /// Базовый статический класс реализующий интерйфейс PluginFactory
    /// </summary>
    public static class Plugins
    {
        /// <summary>
        /// Список хранящий доступные плагины библиотеки
        /// </summary>
        private static IPlugin[] plugins = { new AdditionPlugin(), new MultiplicationPlugin() };

        /// <summary>
        /// Свойство возвращает количество доступных плагинов
        /// </summary>
        /// <returns>int</returns>
        public static int PluginsCount => plugins.Length;

        /// <summary>
        ///  Метод получает список имён плагинов.
        /// </summary>
        /// <returns>Массив строк, содержащий имена плагинов.</returns>
        public static string[] GetPluginNames()
        {
            string[] names = new string[PluginsCount];
            for (int i = 0; i < PluginsCount; i++)
            {
                names[i] = plugins[i].PluginName;
            }
            return names;
        }

        /// <summary>
        /// Метод получает плагин по имени
        /// </summary>
        /// <param name="pluginName">Строка, имя плагина</param>
        /// <returns>Возвращает объект, реализующий интерфейс IPlugin, или null, если плагин с указанным именем не найден.</returns>
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