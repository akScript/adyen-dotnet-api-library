/* 
 * Adyen Checkout API
 *
 * Adyen Checkout API provides a simple and flexible way to initiate and authorise online payments. You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).  This API reference provides information on available endpoints and how to interact with them. To learn more about the API, visit [Checkout documentation](https://docs.adyen.com/checkout).  ## Authentication Each request to the Checkout API must be signed with an API key. For this, obtain an API Key from your Customer Area, as described in [How to get the API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key). Then set this key to the `X-API-Key` header value, for example:  ``` curl -H \"Content-Type: application/json\" \\ -H \"X-API-Key: Your_Checkout_API_key\" \\ ... ``` Note that when going live, you need to generate a new API Key to access the [live endpoints](https://docs.adyen.com/development-resources/live-endpoints).  ## Versioning Checkout API supports versioning of its endpoints through a version suffix in the endpoint URL. This suffix has the following format: \"vXX\", where XX is the version number.  For example: ``` https://checkout-test.adyen.com/v66/payments ```
 *
 * OpenAPI spec version: 66
 * Contact: developer-experience@adyen.com
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
    /// SDKEphemPubKey
    /// </summary>
    [DataContract]
        public partial class SDKEphemPubKey :  IEquatable<SDKEphemPubKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDKEphemPubKey" /> class.
        /// </summary>
        /// <param name="crv">The &#x60;crv&#x60; value as received from the 3D Secure 2 SDK..</param>
        /// <param name="kty">The &#x60;kty&#x60; value as received from the 3D Secure 2 SDK..</param>
        /// <param name="x">The &#x60;x&#x60; value as received from the 3D Secure 2 SDK..</param>
        /// <param name="y">The &#x60;y&#x60; value as received from the 3D Secure 2 SDK..</param>
        public SDKEphemPubKey(string crv = default(string), string kty = default(string), string x = default(string), string y = default(string))
        {
            this.Crv = crv;
            this.Kty = kty;
            this.X = x;
            this.Y = y;
        }
        
        /// <summary>
        /// The &#x60;crv&#x60; value as received from the 3D Secure 2 SDK.
        /// </summary>
        /// <value>The &#x60;crv&#x60; value as received from the 3D Secure 2 SDK.</value>
        [DataMember(Name="crv", EmitDefaultValue=false)]
        public string Crv { get; set; }

        /// <summary>
        /// The &#x60;kty&#x60; value as received from the 3D Secure 2 SDK.
        /// </summary>
        /// <value>The &#x60;kty&#x60; value as received from the 3D Secure 2 SDK.</value>
        [DataMember(Name="kty", EmitDefaultValue=false)]
        public string Kty { get; set; }

        /// <summary>
        /// The &#x60;x&#x60; value as received from the 3D Secure 2 SDK.
        /// </summary>
        /// <value>The &#x60;x&#x60; value as received from the 3D Secure 2 SDK.</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public string X { get; set; }

        /// <summary>
        /// The &#x60;y&#x60; value as received from the 3D Secure 2 SDK.
        /// </summary>
        /// <value>The &#x60;y&#x60; value as received from the 3D Secure 2 SDK.</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public string Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SDKEphemPubKey {\n");
            sb.Append("  Crv: ").Append(Crv).Append("\n");
            sb.Append("  Kty: ").Append(Kty).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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
            return this.Equals(input as SDKEphemPubKey);
        }

        /// <summary>
        /// Returns true if SDKEphemPubKey instances are equal
        /// </summary>
        /// <param name="input">Instance of SDKEphemPubKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SDKEphemPubKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Crv == input.Crv ||
                    (this.Crv != null &&
                    this.Crv.Equals(input.Crv))
                ) && 
                (
                    this.Kty == input.Kty ||
                    (this.Kty != null &&
                    this.Kty.Equals(input.Kty))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
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
                if (this.Crv != null)
                    hashCode = hashCode * 59 + this.Crv.GetHashCode();
                if (this.Kty != null)
                    hashCode = hashCode * 59 + this.Kty.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
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