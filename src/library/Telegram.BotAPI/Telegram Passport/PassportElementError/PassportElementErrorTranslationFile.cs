// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>Represents an issue with one of the files that constitute the translation of a document. The error is considered resolved when the file changes.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class PassportElementErrorTranslationFile : PassportElementError, IEquatable<PassportElementErrorTranslationFile>
{
	/// <summary>Error source, must be translation_file.</summary>
	[JsonPropertyName(PropertyNames.Source)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Source => PassportElementErrorSource.TranslationFile;
	/// <summary>Type of element of the user's Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type { get; set; }
	/// <summary>Base64-encoded file hash.</summary>
	[JsonPropertyName(PropertyNames.FileHash)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string FileHash { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as PassportElementErrorTranslationFile);
	}
	/// <inheritdoc/>
	public bool Equals(PassportElementErrorTranslationFile? other)
	{
		return other != null &&
			   this.Source == other.Source &&
			   this.Type == other.Type &&
			   this.Message == other.Message &&
			   this.Source == other.Source &&
			   this.Type == other.Type &&
			   this.FileHash == other.FileHash;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -539630311;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Message);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Source);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileHash);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(PassportElementErrorTranslationFile? left, PassportElementErrorTranslationFile? right)
	{
		return EqualityComparer<PassportElementErrorTranslationFile>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(PassportElementErrorTranslationFile? left, PassportElementErrorTranslationFile? right)
	{
		return !(left == right);
	}

}