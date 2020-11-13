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
    /// ExtractFilesRequestBody
    /// </summary>
    [DataContract]
        public partial class ExtractFilesRequestBody :  IEquatable<ExtractFilesRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractFilesRequestBody" /> class.
        /// </summary>
        /// <param name="resource">Resource identifier of zip archive to be extracted. (required).</param>
        /// <param name="parentResource">Resource identifier for folder files should be extracted to. (required).</param>
        public ExtractFilesRequestBody(string resource = default(string), string parentResource = default(string))
        {
            // to ensure "resource" is required (not null)
            if (resource == null)
            {
                throw new InvalidDataException("resource is a required property for ExtractFilesRequestBody and cannot be null");
            }
            else
            {
                this.Resource = resource;
            }
            // to ensure "parentResource" is required (not null)
            if (parentResource == null)
            {
                throw new InvalidDataException("parentResource is a required property for ExtractFilesRequestBody and cannot be null");
            }
            else
            {
                this.ParentResource = parentResource;
            }
        }
        
        /// <summary>
        /// Resource identifier of zip archive to be extracted.
        /// </summary>
        /// <value>Resource identifier of zip archive to be extracted.</value>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public string Resource { get; set; }

        /// <summary>
        /// Resource identifier for folder files should be extracted to.
        /// </summary>
        /// <value>Resource identifier for folder files should be extracted to.</value>
        [DataMember(Name="parentResource", EmitDefaultValue=false)]
        public string ParentResource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtractFilesRequestBody {\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  ParentResource: ").Append(ParentResource).Append("\n");
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
            return this.Equals(input as ExtractFilesRequestBody);
        }

        /// <summary>
        /// Returns true if ExtractFilesRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtractFilesRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtractFilesRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.ParentResource == input.ParentResource ||
                    (this.ParentResource != null &&
                    this.ParentResource.Equals(input.ParentResource))
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
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.ParentResource != null)
                    hashCode = hashCode * 59 + this.ParentResource.GetHashCode();
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