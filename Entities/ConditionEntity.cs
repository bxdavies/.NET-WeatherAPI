using NETWeatherAPI.Schema;
using Newtonsoft.Json;

namespace NETWeatherAPI.Entities
{
    public class ConditionEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the weather code.
        /// </summary>
        [JsonProperty("code")]
        public Condition Code { get; set; }

        /// <summary>
        /// Gets or sets the weather condition description.
        /// </summary>
        [JsonProperty("text")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the WeatherAPI.NET icon URL, without protocol.
        /// </summary>
        [JsonProperty("icon")]
        public string IconURL { get; set; }
        #endregion
    }
}
