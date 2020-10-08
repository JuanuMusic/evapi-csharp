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
    /// MasterUser
    /// </summary>
    [DataContract]
        public partial class MasterUser :  IEquatable<MasterUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MasterUser" /> class.
        /// </summary>
        /// <param name="masterUser">masterUser.</param>
        public MasterUser(MasterUserMasterUser masterUser = default(MasterUserMasterUser))
        {
            this._MasterUser = masterUser;
        }
        
        /// <summary>
        /// Gets or Sets _MasterUser
        /// </summary>
        [DataMember(Name="masterUser", EmitDefaultValue=false)]
        public MasterUserMasterUser _MasterUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MasterUser {\n");
            sb.Append("  _MasterUser: ").Append(_MasterUser).Append("\n");
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
            return this.Equals(input as MasterUser);
        }

        /// <summary>
        /// Returns true if MasterUser instances are equal
        /// </summary>
        /// <param name="input">Instance of MasterUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MasterUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._MasterUser == input._MasterUser ||
                    (this._MasterUser != null &&
                    this._MasterUser.Equals(input._MasterUser))
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
                if (this._MasterUser != null)
                    hashCode = hashCode * 59 + this._MasterUser.GetHashCode();
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
