using System;
using System.Collections.Generic;


namespace RemoteKeycard
{
	// Token: 0x02000002 RID: 2
	public class ConfigManagers
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		// (set) Token: 0x06000002 RID: 2 RVA: 0x0000204F File Offset: 0x0000024F
		public static bool RKCDebug { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00000258
		public static ConfigManagers Manager
		{
			get
			{
				bool flag = ConfigManagers.singleton == null;
				if (flag)
				{
					ConfigManagers.singleton = new ConfigManagers();
				}
				return ConfigManagers.singleton;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002087 File Offset: 0x00000287
		internal void ReloadConfig()
		{
			
		}

		// Token: 0x04000002 RID: 2
		private static ConfigManagers singleton;

		// Token: 0x04000003 RID: 3
		private readonly List<string> DoorPerms = new List<string>
		{
			"CONT_LVL_1",
			"CONT_LVL_2",
			"CONT_LVL_3",
			"ARMORY_LVL_1",
			"ARMORY_LVL_2",
			"ARMORY_LVL_3",
			"CHCKPOINT_ACC",
			"EXIT_ACC",
			"INCOM_ACC"
		};

		// Token: 0x04000004 RID: 4
		private readonly List<string> NameDoors = new List<string>
		{
			"HCZ_ARMORY",
			"914",
			"012_BOTTOM",
			"106_BOTTOM",
			"LCZ_ARMORY",
			"GATE_A",
			"106_SECONDARY",
			"GATE_B",
			"012",
			"079_SECOND",
			"106_PRIMARY",
			"049_ARMORY",
			"NUKE_SURFACE",
			"NUKE_ARMORY",
			"CHECKPOINT_ENT",
			"CHECKPOINT_LCZ_B",
			"HID_RIGHT",
			"173_ARMORY",
			"CHECKPOINT_LCZ_A",
			"173",
			"ESCAPE",
			"HID_LEFT",
			"HID",
			"096",
			"372",
			"ESCAPE_INNER",
			"SURFACE_GATE",
			"INTERCOM",
			"079_FIRST"
		};

		// Token: 0x04000005 RID: 5
		internal readonly Dictionary<int, ConfigManagers.PList> DefaultCardAccess = new Dictionary<int, ConfigManagers.PList>
		{
			{
				0,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1",
					"CONT_LVL_2",
					"CONT_LVL_3",
					"ARMORY_LVL_1",
					"ARMORY_LVL_2",
					"ARMORY_LVL_3",
					"CHCKPOINT_ACC",
					"EXIT_ACC",
					"INCOM_ACC"
				}))
			},
			{
				1,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1",
					"CONT_LVL_2",
					"ARMORY_LVL_1",
					"ARMORY_LVL_2",
					"ARMORY_LVL_3",
					"CHCKPOINT_ACC",
					"EXIT_ACC",
					"INCOM_ACC"
				}))
			},
			{
				2,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1",
					"CONT_LVL_2",
					"CONT_LVL_3",
					"CHCKPOINT_ACC",
					"EXIT_ACC",
					"INCOM_ACC"
				}))
			},
			{
				3,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1",
					"CONT_LVL_2",
					"ARMORY_LVL_1",
					"ARMORY_LVL_2",
					"ARMORY_LVL_3",
					"CHCKPOINT_ACC",
					"EXIT_ACC",
					"INCOM_ACC"
				}))
			},
			{
				4,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1",
					"CONT_LVL_2",
					"ARMORY_LVL_1",
					"ARMORY_LVL_2",
					"CHCKPOINT_ACC",
					"EXIT_ACC"
				}))
			},
			{
				5,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1",
					"CONT_LVL_2",
					"CONT_LVL_3",
					"CHCKPOINT_ACC",
					"INCOM_ACC"
				}))
			},
			{
				6,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1",
					"CONT_LVL_2",
					"ARMORY_LVL_1",
					"ARMORY_LVL_2",
					"CHCKPOINT_ACC"
				}))
			},
			{
				7,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1",
					"ARMORY_LVL_1",
					"CHCKPOINT_ACC"
				}))
			},
			{
				8,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CHCKPOINT_ACC"
				}))
			},
			{
				9,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1",
					"CONT_LVL_2",
					"CHCKPOINT_ACC"
				}))
			},
			{
				10,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1",
					"CONT_LVL_2"
				}))
			},
			{
				11,
				new ConfigManagers.PList(new List<string>(new string[]
				{
					"CONT_LVL_1"
				}))
			}
		};

		// Token: 0x04000006 RID: 6
		internal readonly Dictionary<string, string> DefaultDoorAccess = new Dictionary<string, string>
		{
			{
				"HCZ_ARMORY",
				"ARMORY_LVL_1"
			},
			{
				"106_SECONDARY",
				"CONT_LVL_3"
			},
			{
				"914",
				"CONT_LVL_1"
			},
			{
				"LCZ_ARMORY",
				"ARMORY_LVL_1"
			},
			{
				"079_SECOND",
				"CONT_LVL_3"
			},
			{
				"GATE_A",
				"EXIT_ACC"
			},
			{
				"GATE_B",
				"EXIT_ACC"
			},
			{
				"106_BOTTOM",
				"CONT_LVL_3"
			},
			{
				"106_PRIMARY",
				"CONT_LVL_3"
			},
			{
				"NUKE_ARMORY",
				"ARMORY_LVL_2"
			},
			{
				"012",
				"CONT_LVL_2"
			},
			{
				"049_ARMORY",
				"ARMORY_LVL_2"
			},
			{
				"CHECKPOINT_ENT",
				"CHCKPOINT_ACC"
			},
			{
				"NUKE_SURFACE",
				"CONT_LVL_3"
			},
			{
				"CHECKPOINT_LCZ_A",
				"CHCKPOINT_ACC"
			},
			{
				"CHECKPOINT_LCZ_B",
				"CHCKPOINT_ACC"
			},
			{
				"HID",
				"ARMORY_LVL_3"
			},
			{
				"079_FIRST",
				"CONT_LVL_3"
			},
			{
				"096",
				"CONT_LVL_2"
			},
			{
				"INTERCOM",
				"INCOM_ACC"
			}
		};

		// Token: 0x04000007 RID: 7
		internal readonly Dictionary<string, ConfigManagers.CList> DefaultDoorList = new Dictionary<string, ConfigManagers.CList>
		{
			{
				"HCZ_ARMORY",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					3,
					4,
					6,
					7
				}))
			},
			{
				"106_SECONDARY",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					2,
					5
				}))
			},
			{
				"914",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11
				}))
			},
			{
				"LCZ_ARMORY",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					3,
					4,
					6,
					7
				}))
			},
			{
				"079_SECOND",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					2,
					5
				}))
			},
			{
				"GATE_A",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					2,
					3,
					4
				}))
			},
			{
				"GATE_B",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					2,
					3,
					4
				}))
			},
			{
				"106_BOTTOM",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					2,
					5
				}))
			},
			{
				"106_PRIMARY",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					2,
					5
				}))
			},
			{
				"NUKE_ARMORY",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					3,
					4,
					6
				}))
			},
			{
				"012",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					9,
					10
				}))
			},
			{
				"049_ARMORY",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					3,
					4,
					6
				}))
			},
			{
				"CHECKPOINT_ENT",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9
				}))
			},
			{
				"NUKE_SURFACE",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					2,
					5
				}))
			},
			{
				"CHECKPOINT_LCZ_A",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9
				}))
			},
			{
				"CHECKPOINT_LCZ_B",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9
				}))
			},
			{
				"HID",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					3
				}))
			},
			{
				"079_FIRST",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					2
				}))
			},
			{
				"096",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					9,
					10
				}))
			},
			{
				"INTERCOM",
				new ConfigManagers.CList(new List<int>(new int[]
				{
					0,
					1,
					2,
					3,
					5
				}))
			}
		};

		// Token: 0x04000008 RID: 8
		internal readonly List<int> CardsList = new List<int>();

		// Token: 0x04000009 RID: 9
		internal readonly Dictionary<int, ConfigManagers.PList> CustomCardAccess = new Dictionary<int, ConfigManagers.PList>();

		// Token: 0x0400000A RID: 10
		internal readonly Dictionary<string, string> CustomDoorAccess = new Dictionary<string, string>();

		// Token: 0x0400000B RID: 11
		internal readonly Dictionary<string, ConfigManagers.CList> CustomDoorList = new Dictionary<string, ConfigManagers.CList>();

		// Token: 0x02000006 RID: 6
		internal class PList
		{
			// Token: 0x0600000F RID: 15 RVA: 0x00002BA2 File Offset: 0x00000DA2
			public PList(List<string> perms)
			{
				this.perms = perms;
			}

			// Token: 0x04000017 RID: 23
			public List<string> perms;
		}

		// Token: 0x02000007 RID: 7
		internal class CList
		{
			// Token: 0x06000010 RID: 16 RVA: 0x00002BB3 File Offset: 0x00000DB3
			public CList(List<int> ints)
			{
				this.ints = ints;
			}

			// Token: 0x04000018 RID: 24
			public List<int> ints;
		}
	}
}
