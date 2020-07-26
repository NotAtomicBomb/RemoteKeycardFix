using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace RemoteKeycard
{
	// Token: 0x02000003 RID: 3
	internal class EventHandlers
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002A1C File Offset: 0x00000C1C
		public void OnDoorAccess(InteractingDoorEventArgs ev)
		{
			bool allow = ev.IsAllowed;
			if (!allow)
			{
				foreach (Inventory.SyncItemInfo syncItemInfo in ev.Player.Inventory.items)
				{
					bool flag = ev.Player.Inventory.GetItemByID(syncItemInfo.id).permissions.Contains(ev.Door.permissionLevel);
					if (flag)
					{
						ev.IsAllowed= true;
						break;
					}
				}
			}
		}
		public void OnGenAccess(UnlockingGeneratorEventArgs ev)
		{
			bool allow = ev.IsAllowed;
			if (!allow)
			{
				foreach (Inventory.SyncItemInfo syncItemInfo in ev.Player.Inventory.items)
				{
					bool flag = ev.Player.Inventory.GetItemByID(syncItemInfo.id).permissions.Contains("ARMORY_LVL_2");
					if (flag)
					{
						ev.IsAllowed = true;
						break;
					}
				}
			}
		}
		public void OnLockerAccess(InteractingLockerEventArgs ev)
		{
			bool allow = ev.IsAllowed;
			if (!allow)
			{
				foreach (Inventory.SyncItemInfo syncItemInfo in ev.Player.Inventory.items)
				{
					bool flag = ev.Player.Inventory.GetItemByID(syncItemInfo.id).permissions.Contains("CONT_LVL_2") && ev.Player.Inventory.GetItemByID(syncItemInfo.id).permissions.Contains("CHCKPOINT_ACC");
					if (flag)
					{
						ev.IsAllowed = true;
						break;
					}
				}
			}
		}
		public void OnNukeAccess(ActivatingWarheadPanelEventArgs ev)
		{
			bool allow = ev.IsAllowed;
			if (!allow)
			{
				foreach (Inventory.SyncItemInfo syncItemInfo in ev.Player.Inventory.items)
				{
					bool flag = ev.Player.Inventory.GetItemByID(syncItemInfo.id).permissions.Contains("CONT_LVL_3");
					if (flag)
					{
						ev.IsAllowed = true;
						break;
					}
				}
			}
		}
	}
	
}
