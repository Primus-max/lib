using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Общий интерфейс плагина
    /// </summary>
    public interface IPlugin
    {
        /// <summary>Имя плагина</summary>
        string PluginName { get; }

        /// <summary>Версия плагина</summary>
        string Version { get; }

        /// <summary>Изображение плагина</summary>
        Image Image { get; }

        /// <summary>Описание плагина</summary>
        string Description { get; }

        /// <summary>
        /// Метод (точка входа) выполняет математическую операцию над двумя целыми числами.
        /// </summary>
        /// <param name="input1">Первый операнд, целое число</param>
        /// <param name="input2">Второй операнд, целое число</param>
        /// <returns>Результат операции над входными числами.</returns>
        int Run(int input1, int input2);
    }
}
