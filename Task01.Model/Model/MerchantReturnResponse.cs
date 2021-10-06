/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.8
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;


namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// MerchantReturnResponse
    /// </summary>
    [DataContract(Name = "MerchantReturnResponse")]
    public partial class MerchantReturnResponse : IEquatable<MerchantReturnResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "Reason", EmitDefaultValue = false)]
        public ReturnReason? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnResponse" /> class.
        /// </summary>
        /// <param name="merchantOrderNo">The unique order reference used by the Merchant..</param>
        /// <param name="channelOrderNo">The unique order reference used by the Channel..</param>
        /// <param name="lines">lines.</param>
        /// <param name="createdAt">The date at which the return was created in ChannelEngine..</param>
        /// <param name="updatedAt">The date at which the return was last modified in ChannelEngine..</param>
        /// <param name="merchantReturnNo">The unique return reference used by the Merchant, will be empty in case of a channel or unacknowledged return..</param>
        /// <param name="channelReturnNo">The unique return reference used by the Channel, will be empty in case of a merchant return..</param>
        /// <param name="id">The unique return reference used by ChannelEngine..</param>
        /// <param name="reason">reason.</param>
        /// <param name="customerComment">Optional. Comment of customer on the (reason of) the return..</param>
        /// <param name="merchantComment">Optional. Comment of merchant on the return..</param>
        /// <param name="refundInclVat">Refund amount incl. VAT..</param>
        /// <param name="refundExclVat">Refund amount excl. VAT..</param>
        public MerchantReturnResponse(string merchantOrderNo = default(string), string channelOrderNo = default(string), List<MerchantReturnLineResponse> lines = default(List<MerchantReturnLineResponse>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string merchantReturnNo = default(string), string channelReturnNo = default(string), int id = default(int), ReturnReason? reason = default(ReturnReason?), string customerComment = default(string), string merchantComment = default(string), decimal refundInclVat = default(decimal), decimal refundExclVat = default(decimal))
        {
            this.MerchantOrderNo = merchantOrderNo;
            this.ChannelOrderNo = channelOrderNo;
            this.Lines = lines;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.MerchantReturnNo = merchantReturnNo;
            this.ChannelReturnNo = channelReturnNo;
            this.Id = id;
            this.Reason = reason;
            this.CustomerComment = customerComment;
            this.MerchantComment = merchantComment;
            this.RefundInclVat = refundInclVat;
            this.RefundExclVat = refundExclVat;
        }

        /// <summary>
        /// The unique order reference used by the Merchant.
        /// </summary>
        /// <value>The unique order reference used by the Merchant.</value>
        [DataMember(Name = "MerchantOrderNo", EmitDefaultValue = true)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// The unique order reference used by the Channel.
        /// </summary>
        /// <value>The unique order reference used by the Channel.</value>
        [DataMember(Name = "ChannelOrderNo", EmitDefaultValue = true)]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        /// The id of the channel.
        /// </summary>
        /// <value>The id of the channel.</value>
        [DataMember(Name = "ChannelId", EmitDefaultValue = true)]
        public int? ChannelId { get; private set; }

        /// <summary>
        /// Returns false as ChannelId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChannelId()
        {
            return false;
        }

        /// <summary>
        /// The id of the Global Channel.
        /// </summary>
        /// <value>The id of the Global Channel.</value>
        [DataMember(Name = "GlobalChannelId", EmitDefaultValue = true)]
        public int? GlobalChannelId { get; private set; }

        /// <summary>
        /// Returns false as GlobalChannelId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGlobalChannelId()
        {
            return false;
        }

        /// <summary>
        /// The name of the Global Channel.
        /// </summary>
        /// <value>The name of the Global Channel.</value>
        [DataMember(Name = "GlobalChannelName", EmitDefaultValue = true)]
        public string GlobalChannelName { get; private set; }

        /// <summary>
        /// Returns false as GlobalChannelName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGlobalChannelName()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "Lines", EmitDefaultValue = true)]
        public List<MerchantReturnLineResponse> Lines { get; set; }

        /// <summary>
        /// The date at which the return was created in ChannelEngine.
        /// </summary>
        /// <value>The date at which the return was created in ChannelEngine.</value>
        [DataMember(Name = "CreatedAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date at which the return was last modified in ChannelEngine.
        /// </summary>
        /// <value>The date at which the return was last modified in ChannelEngine.</value>
        [DataMember(Name = "UpdatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The unique return reference used by the Merchant, will be empty in case of a channel or unacknowledged return.
        /// </summary>
        /// <value>The unique return reference used by the Merchant, will be empty in case of a channel or unacknowledged return.</value>
        [DataMember(Name = "MerchantReturnNo", EmitDefaultValue = true)]
        public string MerchantReturnNo { get; set; }

        /// <summary>
        /// The unique return reference used by the Channel, will be empty in case of a merchant return.
        /// </summary>
        /// <value>The unique return reference used by the Channel, will be empty in case of a merchant return.</value>
        [DataMember(Name = "ChannelReturnNo", EmitDefaultValue = true)]
        public string ChannelReturnNo { get; set; }

        /// <summary>
        /// The unique return reference used by ChannelEngine.
        /// </summary>
        /// <value>The unique return reference used by ChannelEngine.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Optional. Comment of customer on the (reason of) the return.
        /// </summary>
        /// <value>Optional. Comment of customer on the (reason of) the return.</value>
        [DataMember(Name = "CustomerComment", EmitDefaultValue = true)]
        public string CustomerComment { get; set; }

        /// <summary>
        /// Optional. Comment of merchant on the return.
        /// </summary>
        /// <value>Optional. Comment of merchant on the return.</value>
        [DataMember(Name = "MerchantComment", EmitDefaultValue = true)]
        public string MerchantComment { get; set; }

        /// <summary>
        /// Refund amount incl. VAT.
        /// </summary>
        /// <value>Refund amount incl. VAT.</value>
        [DataMember(Name = "RefundInclVat", EmitDefaultValue = false)]
        public decimal RefundInclVat { get; set; }

        /// <summary>
        /// Refund amount excl. VAT.
        /// </summary>
        /// <value>Refund amount excl. VAT.</value>
        [DataMember(Name = "RefundExclVat", EmitDefaultValue = false)]
        public decimal RefundExclVat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantReturnResponse {\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  ChannelOrderNo: ").Append(ChannelOrderNo).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  GlobalChannelId: ").Append(GlobalChannelId).Append("\n");
            sb.Append("  GlobalChannelName: ").Append(GlobalChannelName).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  MerchantReturnNo: ").Append(MerchantReturnNo).Append("\n");
            sb.Append("  ChannelReturnNo: ").Append(ChannelReturnNo).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  CustomerComment: ").Append(CustomerComment).Append("\n");
            sb.Append("  MerchantComment: ").Append(MerchantComment).Append("\n");
            sb.Append("  RefundInclVat: ").Append(RefundInclVat).Append("\n");
            sb.Append("  RefundExclVat: ").Append(RefundExclVat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MerchantReturnResponse);
        }

        /// <summary>
        /// Returns true if MerchantReturnResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantReturnResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.ChannelOrderNo == input.ChannelOrderNo ||
                    (this.ChannelOrderNo != null &&
                    this.ChannelOrderNo.Equals(input.ChannelOrderNo))
                ) && 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.GlobalChannelId == input.GlobalChannelId ||
                    (this.GlobalChannelId != null &&
                    this.GlobalChannelId.Equals(input.GlobalChannelId))
                ) && 
                (
                    this.GlobalChannelName == input.GlobalChannelName ||
                    (this.GlobalChannelName != null &&
                    this.GlobalChannelName.Equals(input.GlobalChannelName))
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    input.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.MerchantReturnNo == input.MerchantReturnNo ||
                    (this.MerchantReturnNo != null &&
                    this.MerchantReturnNo.Equals(input.MerchantReturnNo))
                ) && 
                (
                    this.ChannelReturnNo == input.ChannelReturnNo ||
                    (this.ChannelReturnNo != null &&
                    this.ChannelReturnNo.Equals(input.ChannelReturnNo))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
                ) && 
                (
                    this.CustomerComment == input.CustomerComment ||
                    (this.CustomerComment != null &&
                    this.CustomerComment.Equals(input.CustomerComment))
                ) && 
                (
                    this.MerchantComment == input.MerchantComment ||
                    (this.MerchantComment != null &&
                    this.MerchantComment.Equals(input.MerchantComment))
                ) && 
                (
                    this.RefundInclVat == input.RefundInclVat ||
                    this.RefundInclVat.Equals(input.RefundInclVat)
                ) && 
                (
                    this.RefundExclVat == input.RefundExclVat ||
                    this.RefundExclVat.Equals(input.RefundExclVat)
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
                if (this.MerchantOrderNo != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNo.GetHashCode();
                if (this.ChannelOrderNo != null)
                    hashCode = hashCode * 59 + this.ChannelOrderNo.GetHashCode();
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.GlobalChannelId != null)
                    hashCode = hashCode * 59 + this.GlobalChannelId.GetHashCode();
                if (this.GlobalChannelName != null)
                    hashCode = hashCode * 59 + this.GlobalChannelName.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.MerchantReturnNo != null)
                    hashCode = hashCode * 59 + this.MerchantReturnNo.GetHashCode();
                if (this.ChannelReturnNo != null)
                    hashCode = hashCode * 59 + this.ChannelReturnNo.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.CustomerComment != null)
                    hashCode = hashCode * 59 + this.CustomerComment.GetHashCode();
                if (this.MerchantComment != null)
                    hashCode = hashCode * 59 + this.MerchantComment.GetHashCode();
                hashCode = hashCode * 59 + this.RefundInclVat.GetHashCode();
                hashCode = hashCode * 59 + this.RefundExclVat.GetHashCode();
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
            // CustomerComment (string) maxLength
            if(this.CustomerComment != null && this.CustomerComment.Length > 4001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerComment, length must be less than 4001.", new [] { "CustomerComment" });
            }

            // CustomerComment (string) minLength
            if(this.CustomerComment != null && this.CustomerComment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerComment, length must be greater than 0.", new [] { "CustomerComment" });
            }

            // MerchantComment (string) maxLength
            if(this.MerchantComment != null && this.MerchantComment.Length > 4001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantComment, length must be less than 4001.", new [] { "MerchantComment" });
            }

            // MerchantComment (string) minLength
            if(this.MerchantComment != null && this.MerchantComment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantComment, length must be greater than 0.", new [] { "MerchantComment" });
            }

            yield break;
        }
    }

}
