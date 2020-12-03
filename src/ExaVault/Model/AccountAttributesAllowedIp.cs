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
    /// AccountAttributesAllowedIp
    /// </summary>
    [DataContract]
        public partial class AccountAttributesAllowedIp :  IEquatable<AccountAttributesAllowedIp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAttributesAllowedIp" /> class.
        /// </summary>
        /// <param name="ipStart">ipStart.</param>
        /// <param name="ipEnd">ipEnd.</param>
        public AccountAttributesAllowedIp(string ipStart = default(string), string ipEnd = default(string))
        {
            this.IpStart = ipStart;
            this.IpEnd = ipEnd;
        }
        
        /// <summary>
        /// Gets or Sets IpStart
        /// </summary>
        [DataMember(Name="ipStart", EmitDefaultValue=false)]
        public string IpStart { get; set; }

        /// <summary>
        /// Gets or Sets IpEnd
        /// </summary>
        [DataMember(Name="ipEnd", EmitDefaultValue=false)]
        public string IpEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountAttributesAllowedIp {\n");
            sb.Append("  IpStart: ").Append(IpStart).Append("\n");
            sb.Append("  IpEnd: ").Append(IpEnd).Append("\n");
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
            return this.Equals(input as AccountAttributesAllowedIp);
        }

        /// <summary>
        /// Returns true if AccountAttributesAllowedIp instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountAttributesAllowedIp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountAttributesAllowedIp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpStart == input.IpStart ||
                    (this.IpStart != null &&
                    this.IpStart.Equals(input.IpStart))
                ) && 
                (
                    this.IpEnd == input.IpEnd ||
                    (this.IpEnd != null &&
                    this.IpEnd.Equals(input.IpEnd))
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
                if (this.IpStart != null)
                    hashCode = hashCode * 59 + this.IpStart.GetHashCode();
                if (this.IpEnd != null)
                    hashCode = hashCode * 59 + this.IpEnd.GetHashCode();
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
