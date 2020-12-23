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
    /// SubInputDetail
    /// </summary>
    [DataContract]
        public partial class SubInputDetail :  IEquatable<SubInputDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubInputDetail" /> class.
        /// </summary>
        /// <param name="configuration">Configuration parameters for the required input..</param>
        /// <param name="items">In case of a select, the items to choose from..</param>
        /// <param name="key">The value to provide in the result..</param>
        /// <param name="optional">True if this input is optional to provide..</param>
        /// <param name="type">The type of the required input..</param>
        /// <param name="value">The value can be pre-filled, if available..</param>
        public SubInputDetail(Dictionary<string, string> configuration = default(Dictionary<string, string>), List<Item> items = default(List<Item>), string key = default(string), bool? optional = default(bool?), string type = default(string), string value = default(string))
        {
            this.Configuration = configuration;
            this.Items = items;
            this.Key = key;
            this.Optional = optional;
            this.Type = type;
            this.Value = value;
        }
        
        /// <summary>
        /// Configuration parameters for the required input.
        /// </summary>
        /// <value>Configuration parameters for the required input.</value>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public Dictionary<string, string> Configuration { get; set; }

        /// <summary>
        /// In case of a select, the items to choose from.
        /// </summary>
        /// <value>In case of a select, the items to choose from.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<Item> Items { get; set; }

        /// <summary>
        /// The value to provide in the result.
        /// </summary>
        /// <value>The value to provide in the result.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// True if this input is optional to provide.
        /// </summary>
        /// <value>True if this input is optional to provide.</value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool? Optional { get; set; }

        /// <summary>
        /// The type of the required input.
        /// </summary>
        /// <value>The type of the required input.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The value can be pre-filled, if available.
        /// </summary>
        /// <value>The value can be pre-filled, if available.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubInputDetail {\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as SubInputDetail);
        }

        /// <summary>
        /// Returns true if SubInputDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SubInputDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubInputDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Configuration == input.Configuration ||
                    this.Configuration != null &&
                    input.Configuration != null &&
                    this.Configuration.SequenceEqual(input.Configuration)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Optional != null)
                    hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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