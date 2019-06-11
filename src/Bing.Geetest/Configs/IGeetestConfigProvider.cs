using System.Threading.Tasks;

namespace Bing.Geetest.Configs
{
    /// <summary>
    /// 极验配置提供器
    /// </summary>
    public interface IGeetestConfigProvider
    {
        /// <summary>
        /// 获取配置
        /// </summary>
        GeetestConfig GetConfig();

        /// <summary>
        /// 获取配置
        /// </summary>
        Task<GeetestConfig> GetConfigAsync();
    }
}
