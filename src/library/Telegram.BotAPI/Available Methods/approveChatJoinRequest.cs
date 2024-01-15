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
	/// <summary>Use this method to approve a chat join request. The bot must be an administrator in the chat for this to work and must have the can_invite_users administrator right. Returns True on success.</summary>
	/// <param name="client">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="ChatInviteLink"/></returns>
	public static bool ApproveChatJoinRequest(this ITelegramBotClient client, long chatId, long userId)
	{
		if (client is null)
		{
			throw new ArgumentNullException(nameof(client));
		}
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return client.CallMethod<bool>(MethodNames.ApproveChatJoinRequest, stream);
	}
	/// <summary>Use this method to approve a chat join request. The bot must be an administrator in the chat for this to work and must have the can_invite_users administrator right. Returns True on success.</summary>
	/// <param name="client">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="ChatInviteLink"/></returns>
	public static bool ApproveChatJoinRequest(this ITelegramBotClient client, string chatId, long userId)
	{
		if (client is null)
		{
			throw new ArgumentNullException(nameof(client));
		}
		if (string.IsNullOrEmpty(chatId))
		{
			throw new ArgumentNullException(nameof(chatId));
		}
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return client.CallMethod<bool>(MethodNames.ApproveChatJoinRequest, stream);
	}
	/// <summary>Use this method to approve a chat join request. The bot must be an administrator in the chat for this to work and must have the can_invite_users administrator right. Returns True on success.</summary>
	/// <param name="client">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="ChatInviteLink"/></returns>
	public static async Task<bool> ApproveChatJoinRequestAsync(this ITelegramBotClient client, long chatId, long userId, CancellationToken cancellationToken = default)
	{
		if (client is null)
		{
			throw new ArgumentNullException(nameof(client));
		}
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		await json.FlushAsync().ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await client.CallMethodAsync<bool>(MethodNames.ApproveChatJoinRequest, stream, cancellationToken).ConfigureAwait(false);
	}
	/// <summary>Use this method to approve a chat join request. The bot must be an administrator in the chat for this to work and must have the can_invite_users administrator right. Returns True on success.</summary>
	/// <param name="client">BotClient</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns><see cref="ChatInviteLink"/></returns>
	public static async Task<bool> ApproveChatJoinRequest(this ITelegramBotClient client, string chatId, long userId, CancellationToken cancellationToken = default)
	{
		if (client is null)
		{
			throw new ArgumentNullException(nameof(client));
		}
		if (string.IsNullOrEmpty(chatId))
		{
			throw new ArgumentNullException(nameof(chatId));
		}
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		json.WriteEndObject();
		await json.FlushAsync().ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await client.CallMethodAsync<bool>(MethodNames.ApproveChatJoinRequest, stream, cancellationToken).ConfigureAwait(false);
	}
}