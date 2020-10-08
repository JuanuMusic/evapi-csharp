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
    /// PreviewFileAttributes
    /// </summary>
    [DataContract]
        public partial class PreviewFileAttributes :  IEquatable<PreviewFileAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewFileAttributes" /> class.
        /// </summary>
        /// <param name="image">Binary image content, base64 encoded..</param>
        /// <param name="size">Size of the image in bytes..</param>
        /// <param name="imageHash">hash of the image..</param>
        /// <param name="pageCount">Amount of pages available in the file. Used only for multipage documents..</param>
        public PreviewFileAttributes(string image = default(string), long? size = default(long?), string imageHash = default(string), int? pageCount = default(int?))
        {
            this.Image = image;
            this.Size = size;
            this.ImageHash = imageHash;
            this.PageCount = pageCount;
        }
        
        /// <summary>
        /// Binary image content, base64 encoded.
        /// </summary>
        /// <value>Binary image content, base64 encoded.</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Size of the image in bytes.
        /// </summary>
        /// <value>Size of the image in bytes.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// hash of the image.
        /// </summary>
        /// <value>hash of the image.</value>
        [DataMember(Name="imageHash", EmitDefaultValue=false)]
        public string ImageHash { get; set; }

        /// <summary>
        /// Amount of pages available in the file. Used only for multipage documents.
        /// </summary>
        /// <value>Amount of pages available in the file. Used only for multipage documents.</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreviewFileAttributes {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ImageHash: ").Append(ImageHash).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
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
            return this.Equals(input as PreviewFileAttributes);
        }

        /// <summary>
        /// Returns true if PreviewFileAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of PreviewFileAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreviewFileAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ImageHash == input.ImageHash ||
                    (this.ImageHash != null &&
                    this.ImageHash.Equals(input.ImageHash))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
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
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ImageHash != null)
                    hashCode = hashCode * 59 + this.ImageHash.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
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
