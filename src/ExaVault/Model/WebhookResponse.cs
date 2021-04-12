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
    /// WebhookResponse
    /// </summary>
    [DataContract]
        public partial class WebhookResponse :  IEquatable<WebhookResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResponse" /> class.
        /// </summary>
        /// <param name="responseStatus">Http status code of the response. .</param>
        /// <param name="data">data.</param>
        /// <param name="included">included.</param>
        public WebhookResponse(int? responseStatus = default(int?), List<Webhook> data = default(List<Webhook>), List<AnyOfWebhookResponseIncludedItems> included = default(List<AnyOfWebhookResponseIncludedItems>))
        {
            this.ResponseStatus = responseStatus;
            this.Data = data;
            this.Included = included;
        }
        
        /// <summary>
        /// Http status code of the response. 
        /// </summary>
        /// <value>Http status code of the response. </value>
        [DataMember(Name="responseStatus", EmitDefaultValue=false)]
        public int? ResponseStatus { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<Webhook> Data { get; set; }

        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name="included", EmitDefaultValue=false)]
        public List<AnyOfWebhookResponseIncludedItems> Included { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookResponse {\n");
            sb.Append("  ResponseStatus: ").Append(ResponseStatus).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
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
            return this.Equals(input as WebhookResponse);
        }

        /// <summary>
        /// Returns true if WebhookResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseStatus == input.ResponseStatus ||
                    (this.ResponseStatus != null &&
                    this.ResponseStatus.Equals(input.ResponseStatus))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Included == input.Included ||
                    this.Included != null &&
                    input.Included != null &&
                    this.Included.SequenceEqual(input.Included)
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
                if (this.ResponseStatus != null)
                    hashCode = hashCode * 59 + this.ResponseStatus.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Included != null)
                    hashCode = hashCode * 59 + this.Included.GetHashCode();
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