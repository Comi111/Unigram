﻿using Telegram.Td.Api;
using Unigram.Common;
using Unigram.Services;

namespace Unigram.ViewModels.Gallery
{
    public class GalleryMessage : GalleryContent
    {
        protected readonly Message _message;
        protected readonly bool _hasProtectedContent;

        public GalleryMessage(IClientService clientService, Message message)
            : base(clientService)
        {
            _message = message;

            var chat = clientService.GetChat(message.ChatId);
            if (chat != null)
            {
                _hasProtectedContent = chat.Type is ChatTypeSecret || chat.HasProtectedContent;
            }
        }

        public Message Message => _message;

        public long ChatId => _message.ChatId;
        public long Id => _message.Id;

        public override File GetFile()
        {
            return _message.GetFile();
        }

        public override File GetThumbnail()
        {
            var thumbnail = _message.GetThumbnail();
            if (thumbnail == null)
            {
                var photo = _message.GetPhoto();
                if (photo != null)
                {
                    return photo.GetSmall()?.Photo;
                }
            }

            if (thumbnail?.Format is ThumbnailFormatJpeg)
            {
                return thumbnail.File;
            }

            return null;
        }

        public override object Constraint => _message.Content;

        public override object From
        {
            get
            {
                if (_message.ForwardInfo != null)
                {
                    // TODO: ...
                }

                if (_message.SenderId is MessageSenderChat senderChat)
                {
                    return _clientService.GetChat(senderChat.ChatId);
                }
                else if (_message.SenderId is MessageSenderUser senderUser)
                {
                    return _clientService.GetUser(senderUser.UserId);
                }

                return null;
            }
        }

        public override string Caption => _message.GetCaption()?.Text;
        public override int Date => _message.Date;

        public override bool IsVideo
        {
            get
            {
                if (_message.Content is MessageVideo or MessageAnimation or MessageVideoNote)
                {
                    return true;
                }
                else if (_message.Content is MessageGame game)
                {
                    return game.Game.Animation != null;
                }
                else if (_message.Content is MessageInvoice invoice)
                {
                    return invoice.ExtendedMedia is MessageExtendedMediaVideo;
                }
                else if (_message.Content is MessageText text)
                {
                    return text.WebPage?.Video != null
                        || text.WebPage?.Animation != null
                        || text.WebPage?.VideoNote != null;
                }

                return false;
            }
        }

        public override bool IsLoop
        {
            get
            {
                if (_message.Content is MessageAnimation or MessageVideoNote)
                {
                    return true;
                }
                else if (_message.Content is MessageGame game)
                {
                    return game.Game.Animation != null;
                }
                else if (_message.Content is MessageText text)
                {
                    return text.WebPage?.Animation != null
                        || text.WebPage?.VideoNote != null;
                }

                return false;
            }
        }

        public override bool IsVideoNote
        {
            get
            {
                if (_message.Content is MessageVideoNote)
                {
                    return true;
                }
                else if (_message.Content is MessageText text)
                {
                    return text.WebPage?.VideoNote != null;
                }

                return false;
            }
        }

        public override bool HasStickers
        {
            get
            {
                if (_message.Content is MessagePhoto photo)
                {
                    return photo.Photo.HasStickers;
                }
                else if (_message.Content is MessageVideo video)
                {
                    return video.Video.HasStickers;
                }

                return false;
            }
        }



        public override bool CanView => true;
        public override bool CanCopy => !_hasProtectedContent && !_message.IsSecret() && IsPhoto;
        public override bool CanSave => !_hasProtectedContent && !_message.IsSecret();
        public override bool CanShare => CanSave;

        public override bool IsProtected => _hasProtectedContent || _message.IsSecret();

        public override int Duration
        {
            get
            {
                if (_message.Content is MessageVideo video)
                {
                    return video.Video.Duration;
                }
                else if (_message.Content is MessageAnimation animation)
                {
                    return animation.Animation.Duration;
                }
                else if (_message.Content is MessageVideoNote videoNote)
                {
                    return videoNote.VideoNote.Duration;
                }
                else if (_message.Content is MessageGame game)
                {
                    return game.Game.Animation?.Duration ?? 0;
                }
                else if (_message.Content is MessageInvoice invoice)
                {
                    if (invoice.ExtendedMedia is MessageExtendedMediaVideo extendedVideo)
                    {
                        return extendedVideo.Video.Duration;
                    }
                }
                else if (_message.Content is MessageText text)
                {
                    if (text.WebPage?.Video != null)
                    {
                        return text.WebPage.Video.Duration;
                    }
                    else if (text.WebPage?.Animation != null)
                    {
                        return text.WebPage.Video.Duration;
                    }
                    else if (text.WebPage?.VideoNote != null)
                    {
                        return text.WebPage.VideoNote.Duration;
                    }
                }

                return 0;
            }
        }

        public override string MimeType
        {
            get
            {
                if (_message.Content is MessageVideo video)
                {
                    return video.Video.MimeType;
                }
                else if (_message.Content is MessageAnimation animation)
                {
                    return animation.Animation.MimeType;
                }
                else if (_message.Content is MessageVideoNote videoNote)
                {
                    return "video/mp4"; // videoNote.VideoNote.MimeType;
                }
                else if (_message.Content is MessageGame game)
                {
                    return game.Game.Animation?.MimeType;
                }
                else if (_message.Content is MessageInvoice invoice)
                {
                    if (invoice.ExtendedMedia is MessageExtendedMediaVideo extendedVideo)
                    {
                        return extendedVideo.Video.MimeType;
                    }
                }
                else if (_message.Content is MessageText text)
                {
                    if (text.WebPage?.Video != null)
                    {
                        return text.WebPage.Video.MimeType;
                    }
                    else if (text.WebPage?.Animation != null)
                    {
                        return text.WebPage.Video.MimeType;
                    }
                }

                return null;
            }
        }
    }
}
