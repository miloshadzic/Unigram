// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages
{
	public partial class TLMessagesBotCallbackAnswer : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			Alert = (1 << 1),
			HasUrl = (1 << 3),
			Message = (1 << 0),
			Url = (1 << 2),
		}

		public bool IsAlert { get { return Flags.HasFlag(Flag.Alert); } set { Flags = value ? (Flags | Flag.Alert) : (Flags & ~Flag.Alert); } }
		public bool IsHasUrl { get { return Flags.HasFlag(Flag.HasUrl); } set { Flags = value ? (Flags | Flag.HasUrl) : (Flags & ~Flag.HasUrl); } }
		public bool HasMessage { get { return Flags.HasFlag(Flag.Message); } set { Flags = value ? (Flags | Flag.Message) : (Flags & ~Flag.Message); } }
		public bool HasUrl { get { return Flags.HasFlag(Flag.Url); } set { Flags = value ? (Flags | Flag.Url) : (Flags & ~Flag.Url); } }

		public Flag Flags { get; set; }
		public String Message { get; set; }
		public String Url { get; set; }
		public Int32 CacheTime { get; set; }

		public TLMessagesBotCallbackAnswer() { }
		public TLMessagesBotCallbackAnswer(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesBotCallbackAnswer; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			if (HasMessage) Message = from.ReadString();
			if (HasUrl) Url = from.ReadString();
			CacheTime = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			if (HasMessage) to.WriteString(Message ?? string.Empty);
			if (HasUrl) to.WriteString(Url ?? string.Empty);
			to.WriteInt32(CacheTime);
		}

		private void UpdateFlags()
		{
			HasMessage = Message != null;
			HasUrl = Url != null;
		}
	}
}