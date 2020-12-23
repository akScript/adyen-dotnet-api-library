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
    /// VisaCheckoutDetails
    /// </summary>
    [DataContract]
        public partial class VisaCheckoutDetails :  IEquatable<VisaCheckoutDetails>, IValidatableObject
    {
        /// <summary>
        /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
        /// </summary>
        /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FundingSourceEnum
        {
            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")]
            Debit = 1        }
        /// <summary>
        /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
        /// </summary>
        /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
        [DataMember(Name="fundingSource", EmitDefaultValue=false)]
        public FundingSourceEnum? FundingSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VisaCheckoutDetails" /> class.
        /// </summary>
        /// <param name="fundingSource">The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**..</param>
        /// <param name="type">**visacheckout** (default to &quot;visacheckout&quot;).</param>
        /// <param name="visaCheckoutCallId">visaCheckoutCallId (required).</param>
        public VisaCheckoutDetails(FundingSourceEnum? fundingSource = default(FundingSourceEnum?), string type = "visacheckout", string visaCheckoutCallId = default(string))
        {
            // to ensure "visaCheckoutCallId" is required (not null)
            if (visaCheckoutCallId == null)
            {
                throw new InvalidDataException("visaCheckoutCallId is a required property for VisaCheckoutDetails and cannot be null");
            }
            else
            {
                this.VisaCheckoutCallId = visaCheckoutCallId;
            }
            this.FundingSource = fundingSource;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "visacheckout";
            }
            else
            {
                this.Type = type;
            }
        }
        

        /// <summary>
        /// **visacheckout**
        /// </summary>
        /// <value>**visacheckout**</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets VisaCheckoutCallId
        /// </summary>
        [DataMember(Name="visaCheckoutCallId", EmitDefaultValue=false)]
        public string VisaCheckoutCallId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VisaCheckoutDetails {\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VisaCheckoutCallId: ").Append(VisaCheckoutCallId).Append("\n");
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
            return this.Equals(input as VisaCheckoutDetails);
        }

        /// <summary>
        /// Returns true if VisaCheckoutDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of VisaCheckoutDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VisaCheckoutDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FundingSource == input.FundingSource ||
                    (this.FundingSource != null &&
                    this.FundingSource.Equals(input.FundingSource))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.VisaCheckoutCallId == input.VisaCheckoutCallId ||
                    (this.VisaCheckoutCallId != null &&
                    this.VisaCheckoutCallId.Equals(input.VisaCheckoutCallId))
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
                if (this.FundingSource != null)
                    hashCode = hashCode * 59 + this.FundingSource.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VisaCheckoutCallId != null)
                    hashCode = hashCode * 59 + this.VisaCheckoutCallId.GetHashCode();
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