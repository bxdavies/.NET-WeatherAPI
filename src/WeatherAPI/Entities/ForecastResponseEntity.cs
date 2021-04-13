﻿using Newtonsoft.Json;
using WeatherAPI.Entities.Base;

namespace WeatherAPI.Entities
{
    public class ForecastResponseEntity : BaseResponseEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the current weather information for the location.
        /// </summary>
        [JsonProperty("current")]
        public CurrentEntity Current { get; set; }

        /// <summary>
        /// Gets or sets the forecast for the location.
        /// </summary>
        [JsonProperty("forecast")]
        public ForecastEntity Forecast { get; set; }
        #endregion
    }
}