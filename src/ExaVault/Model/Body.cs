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
    /// Body
    /// </summary>
    [DataContract]
        public partial class Body :  IEquatable<Body>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        /// <param name="name">Name of the email list.  (required).</param>
        /// <param name="emails">Array of email addresses to include in the email list.  (required).</param>
        public Body(string name = default(string), List<string> emails = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Body and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "emails" is required (not null)
            if (emails == null)
            {
                throw new InvalidDataException("emails is a required property for Body and cannot be null");
            }
            else
            {
                this.Emails = emails;
            }
        }
        
        /// <summary>
        /// Name of the email list. 
        /// </summary>
        /// <value>Name of the email list. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Array of email addresses to include in the email list. 
        /// </summary>
        /// <value>Array of email addresses to include in the email list. </value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
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
            return this.Equals(input as Body);
        }

        /// <summary>
        /// Returns true if Body instances are equal
        /// </summary>
        /// <param name="input">Instance of Body to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
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