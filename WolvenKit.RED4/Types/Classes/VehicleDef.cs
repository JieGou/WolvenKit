using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("BikeTilt")] 
		public gamebbScriptID_Float BikeTilt
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(1)] 
		[RED("SpeedValue")] 
		public gamebbScriptID_Float SpeedValue
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(2)] 
		[RED("GearValue")] 
		public gamebbScriptID_Int32 GearValue
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(3)] 
		[RED("RPMValue")] 
		public gamebbScriptID_Float RPMValue
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(4)] 
		[RED("RPMMax")] 
		public gamebbScriptID_Float RPMMax
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(5)] 
		[RED("SuspensionTransversalForce")] 
		public gamebbScriptID_Float SuspensionTransversalForce
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(6)] 
		[RED("SuspensionLongitudinalForce")] 
		public gamebbScriptID_Float SuspensionLongitudinalForce
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(7)] 
		[RED("IsAutopilotOn")] 
		public gamebbScriptID_Bool IsAutopilotOn
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(8)] 
		[RED("DeclutchTimer")] 
		public gamebbScriptID_Float DeclutchTimer
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(9)] 
		[RED("HandlingPenalty")] 
		public gamebbScriptID_Float HandlingPenalty
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(10)] 
		[RED("HeadLightMode")] 
		public gamebbScriptID_Int32 HeadLightMode
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(11)] 
		[RED("VehicleState")] 
		public gamebbScriptID_Int32 VehicleState
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(12)] 
		[RED("VehicleReady")] 
		public gamebbScriptID_Bool VehicleReady
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(13)] 
		[RED("VehRadioState")] 
		public gamebbScriptID_Bool VehRadioState
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(14)] 
		[RED("VehRadioStationName")] 
		public gamebbScriptID_CName VehRadioStationName
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(15)] 
		[RED("IsCrowd")] 
		public gamebbScriptID_Bool IsCrowd
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(16)] 
		[RED("IsUIActive")] 
		public gamebbScriptID_Bool IsUIActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(17)] 
		[RED("GameTime")] 
		public gamebbScriptID_String GameTime
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(18)] 
		[RED("Collision")] 
		public gamebbScriptID_Bool Collision
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(19)] 
		[RED("DamageState")] 
		public gamebbScriptID_Int32 DamageState
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(20)] 
		[RED("MeanSlipRatio")] 
		public gamebbScriptID_Float MeanSlipRatio
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(21)] 
		[RED("IsHandbraking")] 
		public gamebbScriptID_Int32 IsHandbraking
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(22)] 
		[RED("EngineTemp")] 
		public gamebbScriptID_Float EngineTemp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(23)] 
		[RED("IsInWater")] 
		public gamebbScriptID_Bool IsInWater
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(24)] 
		[RED("RaceTimer")] 
		public gamebbScriptID_String RaceTimer
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(25)] 
		[RED("IsTargetingFriendly")] 
		public gamebbScriptID_Bool IsTargetingFriendly
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(26)] 
		[RED("ChaseIsChaseDontAvoidPedestrians")] 
		public gamebbScriptID_Bool ChaseIsChaseDontAvoidPedestrians
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(27)] 
		[RED("ChaseMaxRammingTickets")] 
		public gamebbScriptID_Uint32 ChaseMaxRammingTickets
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(28)] 
		[RED("ChaseTimeDelayToLeaveVehicle")] 
		public gamebbScriptID_Float ChaseTimeDelayToLeaveVehicle
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(29)] 
		[RED("MinimapMappinDeleteAnim")] 
		public gamebbScriptID_CName MinimapMappinDeleteAnim
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(30)] 
		[RED("UseCarAlarmStim")] 
		public gamebbScriptID_Bool UseCarAlarmStim
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public VehicleDef()
		{
			BikeTilt = new gamebbScriptID_Float();
			SpeedValue = new gamebbScriptID_Float();
			GearValue = new gamebbScriptID_Int32();
			RPMValue = new gamebbScriptID_Float();
			RPMMax = new gamebbScriptID_Float();
			SuspensionTransversalForce = new gamebbScriptID_Float();
			SuspensionLongitudinalForce = new gamebbScriptID_Float();
			IsAutopilotOn = new gamebbScriptID_Bool();
			DeclutchTimer = new gamebbScriptID_Float();
			HandlingPenalty = new gamebbScriptID_Float();
			HeadLightMode = new gamebbScriptID_Int32();
			VehicleState = new gamebbScriptID_Int32();
			VehicleReady = new gamebbScriptID_Bool();
			VehRadioState = new gamebbScriptID_Bool();
			VehRadioStationName = new gamebbScriptID_CName();
			IsCrowd = new gamebbScriptID_Bool();
			IsUIActive = new gamebbScriptID_Bool();
			GameTime = new gamebbScriptID_String();
			Collision = new gamebbScriptID_Bool();
			DamageState = new gamebbScriptID_Int32();
			MeanSlipRatio = new gamebbScriptID_Float();
			IsHandbraking = new gamebbScriptID_Int32();
			EngineTemp = new gamebbScriptID_Float();
			IsInWater = new gamebbScriptID_Bool();
			RaceTimer = new gamebbScriptID_String();
			IsTargetingFriendly = new gamebbScriptID_Bool();
			ChaseIsChaseDontAvoidPedestrians = new gamebbScriptID_Bool();
			ChaseMaxRammingTickets = new gamebbScriptID_Uint32();
			ChaseTimeDelayToLeaveVehicle = new gamebbScriptID_Float();
			MinimapMappinDeleteAnim = new gamebbScriptID_CName();
			UseCarAlarmStim = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
