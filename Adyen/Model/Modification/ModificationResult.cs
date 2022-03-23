#region License

// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */

#endregion

using Adyen.Model.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Util;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Modification
{
    /// <summary>
    /// ModificationResult
    /// </summary>
    [DataContract]
    public partial class ModificationResult : IEquatable<ModificationResult>, IValidatableObject
    {
        /// <summary>
        /// Indicates if the modification request has been received for processing.
        /// </summary>
        /// <value>Indicates if the modification request has been received for processing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResponseEnum
        {
            /// <summary>
            /// Enum CaptureReceived for value: [capture-received]
            /// </summary>
            [EnumMember(Value = "[capture-received]")]
            CaptureReceived = 1,

            /// <summary>
            /// Enum CancelReceived for value: [cancel-received]
            /// </summary>
            [EnumMember(Value = "[cancel-received]")]
            CancelReceived = 2,

            /// <summary>
            /// Enum RefundReceived for value: [refund-received]
            /// </summary>
            [EnumMember(Value = "[refund-received]")]
            RefundReceived = 3,

            /// <summary>
            /// Enum CancelOrRefundReceived for value: [cancelOrRefund-received]
            /// </summary>
            [EnumMember(Value = "[cancelOrRefund-received]")]
            CancelOrRefundReceived = 4,

            /// <summary>
            /// Enum AdjustAuthorisationReceived for value: [adjustAuthorisation-received]
            /// </summary>
            [EnumMember(Value = "[adjustAuthorisation-received]")]
            AdjustAuthorisationReceived = 5,

            /// <summary>
            /// Enum DonationReceived for value: [donation-received]
            /// </summary>
            [EnumMember(Value = "[donation-received]")]
            DonationReceived = 6,

            /// <summary>
            /// Enum TechnicalCancelReceived for value: [technical-cancel-received]
            /// </summary>
            [EnumMember(Value = "[technical-cancel-received]")]
            TechnicalCancelReceived = 7,

            /// <summary>
            /// Enum VoidPendingRefundReceived for value: [voidPendingRefund-received]
            /// </summary>
            [EnumMember(Value = "[voidPendingRefund-received]")]
            VoidPendingRefundReceived = 8
        }

        /// <summary>
        /// Indicates if the modification request has been received for processing.
        /// </summary>
        /// <value>Indicates if the modification request has been received for processing.</value>
        [DataMember(Name = "response", EmitDefaultValue = false)]
        public ResponseEnum Response { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModificationResult" /> class.
        /// </summary>
        /// <param name="additionalData">This field contains additional data, which may be returned in a particular modification response..</param>
        /// <param name="pspReference">Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request. (required).</param>
        /// <param name="response">Indicates if the modification request has been received for processing. (required).</param>
        public ModificationResult(Dictionary<string, string> additionalData = default(Dictionary<string, string>),
            string pspReference = default(string), ResponseEnum response = default(ResponseEnum))
        {
            this.PspReference = pspReference;
            this.Response = response;
            this.AdditionalData = additionalData;
        }

        /// <summary>
        /// This field contains additional data, which may be returned in a particular modification response.
        /// </summary>
        /// <value>This field contains additional data, which may be returned in a particular modification response.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
        /// </summary>
        /// <value>Adyen&#x27;s 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModificationResult {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData.ToCollectionsString()).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
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
            return this.Equals(input as ModificationResult);
        }

        /// <summary>
        /// Returns true if ModificationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ModificationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModificationResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(input.AdditionalData)
                ) &&
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                     this.PspReference.Equals(input.PspReference))
                ) &&
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                     this.Response.Equals(input.Response))
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
                if (this.AdditionalData != null)
                    hashCode = hashCode * 59 + this.AdditionalData.GetHashCode();
                if (this.PspReference != null)
                    hashCode = hashCode * 59 + this.PspReference.GetHashCode();
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}