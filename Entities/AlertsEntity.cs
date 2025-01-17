﻿using Newtonsoft.Json;

namespace NETWeatherAPI.Entities
{
    public class AlertsEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the weather alerts, if any.
        /// </summary>
        [JsonProperty("alert")]
        public AlertEntity[] Alerts { get; set; }
        #endregion
    }
}
