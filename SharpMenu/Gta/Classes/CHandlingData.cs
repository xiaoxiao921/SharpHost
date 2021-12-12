﻿using SharpMenu.Rage;

namespace SharpMenu.Gta.Classes
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal unsafe struct CHandlingData
	{
		fixed sbyte pad_0000[8]; //0x0000
		internal uint m_model_hash; //0x0008
		internal float m_mass; //0x000C
		internal float m_initial_drag_coeff; //0x0010
		internal float m_downforce_multiplier; //0x0014
		internal float m_popup_light_rotation; //0x0018
		fixed sbyte pad_001C[4]; //0x001C
		internal vector3 m_centre_of_mass; //0x0020
		fixed sbyte pad_002C[4]; //0x002C
		internal vector3 m_inertia_mult; //0x0030
		fixed sbyte pad_003C[4]; //0x003C
		internal float m_buoyancy; //0x0040
		internal float m_drive_bias_rear; //0x0044
		internal float m_drive_bias_front; //0x0048
		internal float m_acceleration; //0x004C
		internal byte m_initial_drive_gears; //0x0050
		fixed sbyte pad_0051[3]; //0x0051
		internal float m_drive_inertia; //0x0054
		internal float m_upshift; //0x0058
		internal float m_downshift; //0x005C
		internal float m_initial_drive_force; //0x0060
		internal float m_drive_max_flat_velocity; //0x0064
		internal float m_initial_drive_max_flat_vel; //0x0068
		internal float m_brake_force; //0x006C
		fixed sbyte pad_0070[4]; //0x0070
		internal float m_brake_bias_front; //0x0074
		internal float m_brake_bias_rear; //0x0078
		internal float m_handbrake_force; //0x007C
		internal float m_steering_lock; //0x0080
		internal float m_steering_lock_ratio; //0x0084
		internal float m_traction_curve_max; //0x0088
		internal float m_traction_curve_lateral; //0x008C
		internal float m_traction_curve_min; //0x0090
		internal float m_traction_curve_ratio; //0x0094
		internal float m_curve_lateral; //0x0098
		internal float m_curve_lateral_ratio; //0x009C
		internal float m_traction_spring_delta_max; //0x00A0
		internal float m_traction_spring_delta_max_ratio; //0x00A4
		internal float m_low_speed_traction_loss_mult; //0x00A8
		internal float m_camber_stiffness; //0x00AC
		internal float m_traction_bias_front; //0x00B0
		internal float m_traction_bias_rear; //0x00B4
		internal float m_traction_loss_mult; //0x00B8
		internal float m_suspension_force; //0x00BC
		internal float m_suspension_comp_damp; //0x00C0
		internal float m_suspension_rebound_damp; //0x00C4
		internal float m_suspension_upper_limit; //0x00C8
		internal float m_suspension_lower_limit; //0x00CC
		internal float m_suspension_raise; //0x00D0
		internal float m_suspension_bias_front; //0x00D4
		internal float m_suspension_bias_rear; //0x00D8
		internal float m_anti_rollbar_force; //0x00DC
		internal float m_anti_rollbar_bias_front; //0x00E0
		internal float m_anti_rollbar_bias_rear; //0x00E4
		internal float m_roll_centre_height_front; //0x00E8
		internal float m_roll_centre_height_rear; //0x00EC
		internal float m_collision_damage_mult; //0x00F0
		internal float m_weapon_damamge_mult; //0x00F4
		internal float m_deformation_mult; //0x00F8
		internal float m_engine_damage_mult; //0x00FC
		internal float m_petrol_tank_volume; //0x0100
		internal float m_oil_volume; //0x0104
		fixed sbyte pad_0108[4]; //0x0108
		internal vector3 m_seat_offset_dist; //0x010C
		internal uint m_monetary_value; //0x0118
		fixed sbyte pad_011C[8]; //0x011C
		internal uint m_model_flags; //0x0124
		internal uint m_handling_flags; //0x0128
		internal uint m_damage_flags; //0x012C
		fixed sbyte pad_0130[12]; //0x0130
		internal uint m_ai_handling_hash; //0x013C
	}
}