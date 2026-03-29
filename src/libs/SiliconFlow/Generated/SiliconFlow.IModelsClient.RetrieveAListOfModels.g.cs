#nullable enable

namespace SiliconFlow
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get Model List<br/>
        /// Retrieve models information.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SiliconFlow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SiliconFlow.RetrieveAListOfModelsResponse> RetrieveAListOfModelsAsync(
            global::SiliconFlow.RetrieveAListOfModelsType? type = default,
            global::SiliconFlow.RetrieveAListOfModelsSubType? subType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}