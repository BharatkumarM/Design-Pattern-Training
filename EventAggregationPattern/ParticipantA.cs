namespace ConsoleApp1.EventAggregationPattern
{
	class ParticipantA : IParticipant
	{
		public ParticipantA(IEventAggregator eventAggregator)
		{
			eventAggregator.Subsribe("OnUpdate", this);
		}

		public void RaiseEvent(IEventAggregator eventAggregator)
		{
			eventAggregator.Publish("OnSearchCompleted");
		}
	}
}
