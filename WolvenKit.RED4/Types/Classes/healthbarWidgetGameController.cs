using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class healthbarWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("bbPlayerStats")] 
		public CWeakHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(10)] 
		[RED("bbPlayerEventId")] 
		public CHandle<redCallbackObject> BbPlayerEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("bbMuppetStats")] 
		public CWeakHandle<gameIBlackboard> BbMuppetStats
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(12)] 
		[RED("bbMuppetEventId")] 
		public CHandle<redCallbackObject> BbMuppetEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("bbRightWeaponInfo")] 
		public CWeakHandle<gameIBlackboard> BbRightWeaponInfo
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(14)] 
		[RED("bbRightWeaponEventId")] 
		public CHandle<redCallbackObject> BbRightWeaponEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("bbLeftWeaponInfo")] 
		public CWeakHandle<gameIBlackboard> BbLeftWeaponInfo
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(16)] 
		[RED("bbLeftWeaponEventId")] 
		public CHandle<redCallbackObject> BbLeftWeaponEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("bbPSceneTierEventId")] 
		public CHandle<redCallbackObject> BbPSceneTierEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("visionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("combatModeBlackboardId")] 
		public CHandle<redCallbackObject> CombatModeBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("bbQuickhacksMemeoryEventId")] 
		public CHandle<redCallbackObject> BbQuickhacksMemeoryEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("healthPath")] 
		public inkWidgetPath HealthPath
		{
			get => GetPropertyValue<inkWidgetPath>();
			set => SetPropertyValue<inkWidgetPath>(value);
		}

		[Ordinal(22)] 
		[RED("healthBarPath")] 
		public inkWidgetPath HealthBarPath
		{
			get => GetPropertyValue<inkWidgetPath>();
			set => SetPropertyValue<inkWidgetPath>(value);
		}

		[Ordinal(23)] 
		[RED("armorPath")] 
		public inkWidgetPath ArmorPath
		{
			get => GetPropertyValue<inkWidgetPath>();
			set => SetPropertyValue<inkWidgetPath>(value);
		}

		[Ordinal(24)] 
		[RED("armorBarPath")] 
		public inkWidgetPath ArmorBarPath
		{
			get => GetPropertyValue<inkWidgetPath>();
			set => SetPropertyValue<inkWidgetPath>(value);
		}

		[Ordinal(25)] 
		[RED("overshieldBarRef")] 
		public inkWidgetReference OvershieldBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("expBar")] 
		public inkWidgetReference ExpBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("expBarSpacer")] 
		public inkWidgetReference ExpBarSpacer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("levelUpArrow")] 
		public inkWidgetReference LevelUpArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("levelUpFrame")] 
		public inkWidgetReference LevelUpFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("barsLayoutPath")] 
		public inkCompoundWidgetReference BarsLayoutPath
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("buffsHolder")] 
		public inkCompoundWidgetReference BuffsHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("invulnerableTextPath")] 
		public inkTextWidgetReference InvulnerableTextPath
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("levelTextPath")] 
		public inkTextWidgetReference LevelTextPath
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("nextLevelTextPath")] 
		public inkTextWidgetReference NextLevelTextPath
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("healthTextPath")] 
		public inkTextWidgetReference HealthTextPath
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("maxHealthTextPath")] 
		public inkTextWidgetReference MaxHealthTextPath
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("quickhacksContainer")] 
		public inkCompoundWidgetReference QuickhacksContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("expText")] 
		public inkTextWidgetReference ExpText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("expTextLabel")] 
		public inkTextWidgetReference ExpTextLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("lostHealthAggregationBar")] 
		public inkWidgetReference LostHealthAggregationBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("levelUpRectangle")] 
		public inkWidgetReference LevelUpRectangle
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("damegePreview")] 
		public inkWidgetReference DamegePreview
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("fullBar")] 
		public inkWidgetReference FullBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("healthController")] 
		public CWeakHandle<NameplateBarLogicController> HealthController
		{
			get => GetPropertyValue<CWeakHandle<NameplateBarLogicController>>();
			set => SetPropertyValue<CWeakHandle<NameplateBarLogicController>>(value);
		}

		[Ordinal(45)] 
		[RED("armorController")] 
		public CWeakHandle<ProgressBarSimpleWidgetLogicController> ArmorController
		{
			get => GetPropertyValue<CWeakHandle<ProgressBarSimpleWidgetLogicController>>();
			set => SetPropertyValue<CWeakHandle<ProgressBarSimpleWidgetLogicController>>(value);
		}

		[Ordinal(46)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(47)] 
		[RED("buffWidget")] 
		public CWeakHandle<inkWidget> BuffWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(48)] 
		[RED("HPBar")] 
		public CWeakHandle<inkWidget> HPBar
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(49)] 
		[RED("armorBar")] 
		public CWeakHandle<inkWidget> ArmorBar
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(50)] 
		[RED("invulnerableText")] 
		public CWeakHandle<inkTextWidget> InvulnerableText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(51)] 
		[RED("animHideTemp")] 
		public CHandle<inkanimDefinition> AnimHideTemp
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(52)] 
		[RED("animShortFade")] 
		public CHandle<inkanimDefinition> AnimShortFade
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(53)] 
		[RED("animLongFade")] 
		public CHandle<inkanimDefinition> AnimLongFade
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(54)] 
		[RED("animHideHPProxy")] 
		public CHandle<inkanimProxy> AnimHideHPProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(55)] 
		[RED("delayAnimation")] 
		public CHandle<inkanimDefinition> DelayAnimation
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(56)] 
		[RED("animCreated")] 
		public CBool AnimCreated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("aggregatingActive")] 
		public CBool AggregatingActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("countingStartHealth")] 
		public CInt32 CountingStartHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(59)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(60)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(61)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(62)] 
		[RED("quickhacksMemoryPercent")] 
		public CFloat QuickhacksMemoryPercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(63)] 
		[RED("currentArmor")] 
		public CInt32 CurrentArmor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(64)] 
		[RED("maximumArmor")] 
		public CInt32 MaximumArmor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(65)] 
		[RED("quickhackBarArray")] 
		public CArray<CWeakHandle<inkWidget>> QuickhackBarArray
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(66)] 
		[RED("spawnedMemoryCells")] 
		public CInt32 SpawnedMemoryCells
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(67)] 
		[RED("usedQuickhacks")] 
		public CInt32 UsedQuickhacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(68)] 
		[RED("buffsVisible")] 
		public CBool BuffsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(69)] 
		[RED("isUnarmedRightHand")] 
		public CBool IsUnarmedRightHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("isUnarmedLeftHand")] 
		public CBool IsUnarmedLeftHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("currentVisionPSM")] 
		public CEnum<gamePSMVision> CurrentVisionPSM
		{
			get => GetPropertyValue<CEnum<gamePSMVision>>();
			set => SetPropertyValue<CEnum<gamePSMVision>>(value);
		}

		[Ordinal(72)] 
		[RED("combatModePSM")] 
		public CEnum<gamePSMCombat> CombatModePSM
		{
			get => GetPropertyValue<CEnum<gamePSMCombat>>();
			set => SetPropertyValue<CEnum<gamePSMCombat>>(value);
		}

		[Ordinal(73)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(74)] 
		[RED("godModeStatListener")] 
		public CHandle<GodModeStatListener> GodModeStatListener
		{
			get => GetPropertyValue<CHandle<GodModeStatListener>>();
			set => SetPropertyValue<CHandle<GodModeStatListener>>(value);
		}

		[Ordinal(75)] 
		[RED("memoryStatListener")] 
		public CHandle<HealthbarMemoryStatListener> MemoryStatListener
		{
			get => GetPropertyValue<CHandle<HealthbarMemoryStatListener>>();
			set => SetPropertyValue<CHandle<HealthbarMemoryStatListener>>(value);
		}

		[Ordinal(76)] 
		[RED("playerStatsBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(77)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(78)] 
		[RED("levelUpBlackboard")] 
		public CWeakHandle<gameIBlackboard> LevelUpBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(79)] 
		[RED("playerLevelUpListener")] 
		public CHandle<redCallbackObject> PlayerLevelUpListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(80)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(81)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(82)] 
		[RED("playerDevelopmentSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentSystem>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentSystem>>(value);
		}

		[Ordinal(83)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(84)] 
		[RED("foldingAnimProxy")] 
		public CHandle<inkanimProxy> FoldingAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(85)] 
		[RED("memoryFillCells")] 
		public CFloat MemoryFillCells
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(86)] 
		[RED("memoryMaxCells")] 
		public CInt32 MemoryMaxCells
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(87)] 
		[RED("pendingRequests")] 
		public CInt32 PendingRequests
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(88)] 
		[RED("spawnTokens")] 
		public CArray<CWeakHandle<inkAsyncSpawnRequest>> SpawnTokens
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkAsyncSpawnRequest>>>(value);
		}

		[Ordinal(89)] 
		[RED("overshieldListener")] 
		public CHandle<OvershieldListener> OvershieldListener
		{
			get => GetPropertyValue<CHandle<OvershieldListener>>();
			set => SetPropertyValue<CHandle<OvershieldListener>>(value);
		}

		[Ordinal(90)] 
		[RED("overshieldBarController")] 
		public CWeakHandle<NameplateBarLogicController> OvershieldBarController
		{
			get => GetPropertyValue<CWeakHandle<NameplateBarLogicController>>();
			set => SetPropertyValue<CWeakHandle<NameplateBarLogicController>>(value);
		}

		[Ordinal(91)] 
		[RED("useOevershield")] 
		public CBool UseOevershield
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(92)] 
		[RED("currentOvershieldValue")] 
		public CInt32 CurrentOvershieldValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(93)] 
		[RED("currentOvershieldValuePercent")] 
		public CFloat CurrentOvershieldValuePercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(94)] 
		[RED("overclockListener")] 
		public CHandle<OverclockListener> OverclockListener
		{
			get => GetPropertyValue<CHandle<OverclockListener>>();
			set => SetPropertyValue<CHandle<OverclockListener>>(value);
		}

		[Ordinal(95)] 
		[RED("isInOverclockedState")] 
		public CBool IsInOverclockedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(96)] 
		[RED("pulseBar")] 
		public CHandle<PulseAnimation> PulseBar
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(97)] 
		[RED("pulseText")] 
		public CHandle<PulseAnimation> PulseText
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(98)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(99)] 
		[RED("healthMemoryJumpAnim")] 
		public CHandle<inkanimProxy> HealthMemoryJumpAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(100)] 
		[RED("healthMemoryFlashAnim")] 
		public CHandle<inkanimProxy> HealthMemoryFlashAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(101)] 
		[RED("healthbarWidget")] 
		public CWeakHandle<inkWidget> HealthbarWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public healthbarWidgetGameController()
		{
			HealthPath = new inkWidgetPath { Names = new() };
			HealthBarPath = new inkWidgetPath { Names = new() };
			ArmorPath = new inkWidgetPath { Names = new() };
			ArmorBarPath = new inkWidgetPath { Names = new() };
			OvershieldBarRef = new inkWidgetReference();
			ExpBar = new inkWidgetReference();
			ExpBarSpacer = new inkWidgetReference();
			LevelUpArrow = new inkWidgetReference();
			LevelUpFrame = new inkWidgetReference();
			BarsLayoutPath = new inkCompoundWidgetReference();
			BuffsHolder = new inkCompoundWidgetReference();
			InvulnerableTextPath = new inkTextWidgetReference();
			LevelTextPath = new inkTextWidgetReference();
			NextLevelTextPath = new inkTextWidgetReference();
			HealthTextPath = new inkTextWidgetReference();
			MaxHealthTextPath = new inkTextWidgetReference();
			QuickhacksContainer = new inkCompoundWidgetReference();
			ExpText = new inkTextWidgetReference();
			ExpTextLabel = new inkTextWidgetReference();
			LostHealthAggregationBar = new inkWidgetReference();
			LevelUpRectangle = new inkWidgetReference();
			DamegePreview = new inkWidgetReference();
			FullBar = new inkWidgetReference();
			QuickhackBarArray = new();
			IsUnarmedRightHand = true;
			IsUnarmedLeftHand = true;
			GameInstance = new ScriptGameInstance();
			SpawnTokens = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
