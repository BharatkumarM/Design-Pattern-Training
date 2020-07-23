namespace ConsoleApp1.EventAggregationPattern
{
	interface IEventAggregator
	{
		void Subsribe(string eventName, IParticipant participant);
		void Unsubscribe(string eventName, IParticipant participant);
		void Publish(string eventName);
	}
}
