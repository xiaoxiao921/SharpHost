﻿using System.Runtime.InteropServices;

namespace SharpMenu.Rage
{
    [StructLayout(LayoutKind.Explicit)]
    internal unsafe struct netObject
	{
		[FieldOffset(0x0008)]
		short object_type; //0x0008

		[FieldOffset(0x000A)]
		short object_id; //0x000A

		[FieldOffset(0x000C)]
		fixed char pad_000C[61]; //0x000C

		[FieldOffset(0x0049)]
		char owner_id; //0x0049

		[FieldOffset(0x004A)]
		char control_id; //0x004A

		[FieldOffset(0x004B)]
		char next_owner_id; //0x004B

		[FieldOffset(0x004C)]
		bool is_remote; //0x004C

		[FieldOffset(0x004D)]
		bool wants_to_delete; //0x004D

		[FieldOffset(0x004E)]
		fixed char pad_004E[1]; //0x004E

		[FieldOffset(0x004F)]
		bool should_not_be_deleted; //0x004F
		
		[FieldOffset(0x0050)]
		fixed char pad_0050[32]; //0x0050
		
		[FieldOffset(0x0070)]
		uint players_acked; //0x0070
		
		[FieldOffset(0x0074)]
		fixed char pad_0074[116]; //0x0074
	}
}
