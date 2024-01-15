// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>
	/// Use this method to get the current bot short description for the given user language. Returns <see cref="BotShortDescription"/> on success.
	/// </summary>
	/// <param name="bot">BotClient</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static BotShortDescription GetMyShortDescription(this ITelegramBotClient bot, [Optional] string? languageCode)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		if (!string.IsNullOrEmpty(languageCode))
		{
			json.WriteString(PropertyNames.LanguageCode, languageCode);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.CallMethod<BotShortDescription>(MethodNames.GetMyShortDescription, stream);
	}

	/// <summary>
	/// Use this method to get the current bot short description for the given user language. Returns <see cref="BotShortDescription"/> on success.
	/// </summary>
	/// <param name="bot">BotClient</param>
	/// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<BotShortDescription> GetMyShortDescriptionAsync(this ITelegramBotClient bot, [Optional] string? languageCode, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		if (!string.IsNullOrEmpty(languageCode))
		{
			json.WriteString(PropertyNames.LanguageCode, languageCode);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.CallMethodAsync<BotShortDescription>(MethodNames.GetMyShortDescription, stream, cancellationToken).ConfigureAwait(false);
	}
}