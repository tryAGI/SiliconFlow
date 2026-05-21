#nullable enable

namespace SiliconFlow
{
    public partial interface IUserInfoClient
    {
        /// <summary>
        /// 获取用户信息<br/>
        /// 获取用户信息，包括余额和状态
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.UserInfoResponse> UserInfoAsync(
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 获取用户信息<br/>
        /// 获取用户信息，包括余额和状态
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.AutoSDKHttpResponse<global::SiliconFlow.UserInfoResponse>> UserInfoAsResponseAsync(
            global::SiliconFlow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}