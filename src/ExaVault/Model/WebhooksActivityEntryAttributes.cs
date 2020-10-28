/* 
 * ExaVault API
 *
 * See our API reference documentation at https://www.exavault.com/developer/api-docs/
 *
 * OpenAPI spec version: 2.0
 * Contact: support@exavault.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ExaVault.Client.SwaggerDateConverter;

namespace ExaVault.Model
{
    /// <summary>
    /// WebhooksActivityEntryAttributes
    /// </summary>
    [DataContract]
        public partial class WebhooksActivityEntryAttributes :  IEquatable<WebhooksActivityEntryAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksActivityEntryAttributes" /> class.
        /// </summary>
        /// <param name="attempt">attempt.</param>
        /// <param name="created">created.</param>
        /// <param name="endpointUrl">endpointUrl.</param>
        /// <param name="_event">_event.</param>
        /// <param name="response">response.</param>
        /// <param name="responseSize">responseSize.</param>
        /// <param name="status">status.</param>
        public WebhooksActivityEntryAttributes(int? attempt = default(int?), string created = default(string), string endpointUrl = default(string), string _event = default(string), string response = default(string), int? responseSize = default(int?), int? status = default(int?))
        {
            this.Attempt = attempt;
            this.Created = created;
            this.EndpointUrl = endpointUrl;
            this.Event = _event;
            this.Response = response;
            this.ResponseSize = responseSize;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets Attempt
        /// </summary>
        [DataMember(Name="attempt", EmitDefaultValue=false)]
        public int? Attempt { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets EndpointUrl
        /// </summary>
        [DataMember(Name="endpointUrl", EmitDefaultValue=false)]
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string Event { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public string Response { get; set; }

        /// <summary>
        /// Gets or Sets ResponseSize
        /// </summary>
        [DataMember(Name="responseSize", EmitDefaultValue=false)]
        public int? ResponseSize { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhooksActivityEntryAttributes {\n");
            sb.Append("  Attempt: ").Append(Attempt).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  EndpointUrl: ").Append(EndpointUrl).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  ResponseSize: ").Append(ResponseSize).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebhooksActivityEntryAttributes);
        }

        /// <summary>
        /// Returns true if WebhooksActivityEntryAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhooksActivityEntryAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhooksActivityEntryAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attempt == input.Attempt ||
                    (this.Attempt != null &&
                    this.Attempt.Equals(input.Attempt))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.EndpointUrl == input.EndpointUrl ||
                    (this.EndpointUrl != null &&
                    this.EndpointUrl.Equals(input.EndpointUrl))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.ResponseSize == input.ResponseSize ||
                    (this.ResponseSize != null &&
                    this.ResponseSize.Equals(input.ResponseSize))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Attempt != null)
                    hashCode = hashCode * 59 + this.Attempt.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.EndpointUrl != null)
                    hashCode = hashCode * 59 + this.EndpointUrl.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                if (this.ResponseSize != null)
                    hashCode = hashCode * 59 + this.ResponseSize.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}