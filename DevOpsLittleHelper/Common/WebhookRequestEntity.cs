﻿using Newtonsoft.Json;
using System;

namespace DevOpsLittleHelper
{
    public class WebhookRequestEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("notificationId")]
        public int NotificationId { get; set; }

        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("resource")]
        public WebhookResource Resource { get; set; }

        [JsonProperty("resourceContainers")]
        public WebhookResourceContainer ResourceContainers { get; set; }

        public class WebhookResourceContainer
        {
            [JsonProperty("collection")]
            public WebhookIdRef Collection { get; set; }

            [JsonProperty("account")]
            public WebhookIdRef Account { get; set; }

            [JsonProperty("project")]
            public WebhookIdRef Project { get; set; }
        }

        public class WebhookResource
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("buildNumber")]
            public string BuildNumber { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("uri")]
            public string Uri { get; set; }
        }

        public class WebhookIdRef
        {
            [JsonProperty("id")]
            public string Id { get; set; }
        }
    }
}
