using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerUnauthorized : ActionBool
	{
		[Ordinal(38)] 
		[RED("isLiftDoor")] 
		public CBool IsLiftDoor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerUnauthorized()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
