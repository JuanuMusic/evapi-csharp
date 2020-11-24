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
    /// An object defining what a not-logged-in visitor can do with the share contents
    /// </summary>
    [DataContract]
        public partial class AccessMode :  IEquatable<AccessMode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessMode" /> class.
        /// </summary>
        /// <param name="download">Whether share allows visitors to download.</param>
        /// <param name="upload">Whether share allows visitors to upload.</param>
        /// <param name="modify">Whether share allows visitors to rename or move contents..</param>
        /// <param name="delete">Whether share allows visitors to delete contents.</param>
        public AccessMode(bool? download = default(bool?), bool? upload = default(bool?), bool? modify = default(bool?), bool? delete = default(bool?))
        {
            this.Download = download;
            this.Upload = upload;
            this.Modify = modify;
            this.Delete = delete;
        }
        
        /// <summary>
        /// Whether share allows visitors to download
        /// </summary>
        /// <value>Whether share allows visitors to download</value>
        [DataMember(Name="download", EmitDefaultValue=false)]
        public bool? Download { get; set; }

        /// <summary>
        /// Whether share allows visitors to upload
        /// </summary>
        /// <value>Whether share allows visitors to upload</value>
        [DataMember(Name="upload", EmitDefaultValue=false)]
        public bool? Upload { get; set; }

        /// <summary>
        /// Whether share allows visitors to rename or move contents.
        /// </summary>
        /// <value>Whether share allows visitors to rename or move contents.</value>
        [DataMember(Name="modify", EmitDefaultValue=false)]
        public bool? Modify { get; set; }

        /// <summary>
        /// Whether share allows visitors to delete contents
        /// </summary>
        /// <value>Whether share allows visitors to delete contents</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessMode {\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  Upload: ").Append(Upload).Append("\n");
            sb.Append("  Modify: ").Append(Modify).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
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
            return this.Equals(input as AccessMode);
        }

        /// <summary>
        /// Returns true if AccessMode instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessMode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessMode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Download == input.Download ||
                    (this.Download != null &&
                    this.Download.Equals(input.Download))
                ) && 
                (
                    this.Upload == input.Upload ||
                    (this.Upload != null &&
                    this.Upload.Equals(input.Upload))
                ) && 
                (
                    this.Modify == input.Modify ||
                    (this.Modify != null &&
                    this.Modify.Equals(input.Modify))
                ) && 
                (
                    this.Delete == input.Delete ||
                    (this.Delete != null &&
                    this.Delete.Equals(input.Delete))
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
                if (this.Download != null)
                    hashCode = hashCode * 59 + this.Download.GetHashCode();
                if (this.Upload != null)
                    hashCode = hashCode * 59 + this.Upload.GetHashCode();
                if (this.Modify != null)
                    hashCode = hashCode * 59 + this.Modify.GetHashCode();
                if (this.Delete != null)
                    hashCode = hashCode * 59 + this.Delete.GetHashCode();
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