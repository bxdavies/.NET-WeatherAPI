using NETWeatherAPI.Base;
using NETWeatherAPI.Entities;
using NETWeatherAPI.Operations.Base;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace NETWeatherAPI.Operations
{
    public class SportsOperations : BaseOperations, ISportsOperations
    {
        #region Public Methods
        /// <summary>
        /// Gets local, upcoming sporting events using automatic location.
        /// </summary>
        public virtual Task<SportsResponseEntity> GetSportsAsync(CancellationToken cancellationToken = default)
        {
            return ((ISportsOperations)this).GetSportsAsync<SportsResponseEntity>(cancellationToken);
        }

        /// <summary>
        /// Gets local, upcoming sporting events using automatic location.
        /// </summary>
        public virtual Task<TSportsResponseEntity> GetSportsAsync<TSportsResponseEntity>(CancellationToken cancellationToken = default)
            where TSportsResponseEntity : class
        {
            return ((ISportsOperations)this).GetSportsAsync<TSportsResponseEntity>(new RequestEntity(), cancellationToken);
        }

        /// <summary>
        /// Gets local, upcoming sporting events.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<SportsResponseEntity> GetSportsAsync(RequestEntity request, CancellationToken cancellationToken = default)
        {
            return ((ISportsOperations)this).GetSportsAsync<SportsResponseEntity>(request, cancellationToken);
        }

        /// <summary>
        /// Gets local, upcoming sporting events.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<TSportsResponseEntity> GetSportsAsync<TSportsResponseEntity>(RequestEntity request, CancellationToken cancellationToken = default)
            where TSportsResponseEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TSportsResponseEntity>(HttpMethod.Get, "sports.json", request.GetQueryParameters(), null, cancellationToken);
        }
        #endregion

        #region Constructors
        public SportsOperations(IApiRequestor apiRequestor)
            : base(apiRequestor)
        {
        }
        #endregion
    }
}
