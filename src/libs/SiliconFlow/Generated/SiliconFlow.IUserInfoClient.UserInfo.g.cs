#nullable enable

namespace SiliconFlow
{
    public partial interface IUserInfoClient
    {
        /// <summary>
        /// 获取用户信息<br/>
        /// 获取用户信息，包括余额和状态
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.UserInfoResponse> UserInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}