using System;
using Exiled.API.Features;
using Exiled.Events;

namespace RemoteKeycard
{
	// Token: 0x02000004 RID: 4
	public class RemoteKeycard : Plugin<Config>
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002ACD File Offset: 0x00000CCD
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002AD4 File Offset: 0x00000CD4
		internal static RemoteKeycard plugin { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002ADC File Offset: 0x00000CDC
		public override string Name
		{
			get
			{
				return "RemoteKeycard";
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002AE4 File Offset: 0x00000CE4
		public override void OnDisabled()
		{
			bool flag = !this.enabled;
			if (!flag)
			{
				Exiled.Events.Handlers.Player.InteractingDoor -= LocalEvents.OnDoorAccess;
				Exiled.Events.Handlers.Player.UnlockingGenerator -= LocalEvents.OnGenAccess;
				Exiled.Events.Handlers.Player.InteractingLocker -= LocalEvents.OnLockerAccess;
				Exiled.Events.Handlers.Player.ActivatingWarheadPanel -= LocalEvents.OnNukeAccess;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B1C File Offset: 0x00000D1C
		public override void OnEnabled()
		{
			this.enabled = Config.IsEnabled;
			bool flag = !this.enabled;
			if (!flag)
			{
				RemoteKeycard.plugin = this;
				Log.Warn("Registering events...");
				this.LocalEvents = new EventHandlers();
				Exiled.Events.Handlers.Player.InteractingDoor += LocalEvents.OnDoorAccess;
				Exiled.Events.Handlers.Player.UnlockingGenerator += LocalEvents.OnGenAccess;
				Exiled.Events.Handlers.Player.InteractingLocker += LocalEvents.OnLockerAccess;
				Exiled.Events.Handlers.Player.ActivatingWarheadPanel += LocalEvents.OnNukeAccess;
				ConfigManagers.Manager.ReloadConfig();
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002B8F File Offset: 0x00000D8F
		public override void OnReloaded()
		{
		}

		// Token: 0x0400000D RID: 13
		public const string Version = "V1.2.0";

		// Token: 0x0400000E RID: 14
		private EventHandlers LocalEvents;

		// Token: 0x0400000F RID: 15
		private bool enabled = false;
	}
}
