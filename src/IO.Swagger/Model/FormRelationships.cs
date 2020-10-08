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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Share relationship data of the form. 
    /// </summary>
    [DataContract]
        public partial class FormRelationships :  IEquatable<FormRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormRelationships" /> class.
        /// </summary>
        /// <param name="share">share.</param>
        public FormRelationships(FormRelationshipsShare share = default(FormRelationshipsShare))
        {
            this.Share = share;
        }
        
        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name="share", EmitDefaultValue=false)]
        public FormRelationshipsShare Share { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormRelationships {\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
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
            return this.Equals(input as FormRelationships);
        }

        /// <summary>
        /// Returns true if FormRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of FormRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormRelationships input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Share == input.Share ||
                    (this.Share != null &&
                    this.Share.Equals(input.Share))
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
                if (this.Share != null)
                    hashCode = hashCode * 59 + this.Share.GetHashCode();
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
