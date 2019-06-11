using System.Threading.Tasks;

namespace Bing.Geetest.Configs
{
    /// <summary>
    /// 极验默认配置提供器
    /// </summary>
    internal class DefaultGeetestConfigProvider : IGeetestConfigProvider
    {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly GeetestConfig _config;

        /// <summary>
        /// 初始化一个<see cref="DefaultGeetestConfigProvider"/>类型的实例
        /// </summary>
        /// <param name="config">极验配置</param>
        public DefaultGeetestConfigProvider(GeetestConfig config)
        {
            _config = config;
        }

        /// <summary>
        /// 获取配置
        /// </summary>
        public GeetestConfig GetConfig()
        {
            return _config;
        }

        /// <summary>
        /// 获取配置
        /// </summary>
        public Task<GeetestConfig> GetConfigAsync()
        {
            return Task.FromResult(_config);
        }
    }
}
