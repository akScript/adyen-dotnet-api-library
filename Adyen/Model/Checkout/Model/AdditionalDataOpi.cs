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
    /// AdditionalDataOpi
    /// </summary>
    [DataContract]
        public partial class AdditionalDataOpi :  IEquatable<AdditionalDataOpi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataOpi" /> class.
        /// </summary>
        /// <param name="opiIncludeTransToken">Optional boolean indicator. Set to **true** if you want an ecommerce transaction to return an &#x60;opi.transToken&#x60; as additional data in the response.  You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce)..</param>
        public AdditionalDataOpi(string opiIncludeTransToken = default(string))
        {
            this.OpiIncludeTransToken = opiIncludeTransToken;
        }
        
        /// <summary>
        /// Optional boolean indicator. Set to **true** if you want an ecommerce transaction to return an &#x60;opi.transToken&#x60; as additional data in the response.  You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce).
        /// </summary>
        /// <value>Optional boolean indicator. Set to **true** if you want an ecommerce transaction to return an &#x60;opi.transToken&#x60; as additional data in the response.  You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce).</value>
        [DataMember(Name="opi.includeTransToken", EmitDefaultValue=false)]
        public string OpiIncludeTransToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalDataOpi {\n");
            sb.Append("  OpiIncludeTransToken: ").Append(OpiIncludeTransToken).Append("\n");
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
            return this.Equals(input as AdditionalDataOpi);
        }

        /// <summary>
        /// Returns true if AdditionalDataOpi instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataOpi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataOpi input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpiIncludeTransToken == input.OpiIncludeTransToken ||
                    (this.OpiIncludeTransToken != null &&
                    this.OpiIncludeTransToken.Equals(input.OpiIncludeTransToken))
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
                if (this.OpiIncludeTransToken != null)
                    hashCode = hashCode * 59 + this.OpiIncludeTransToken.GetHashCode();
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