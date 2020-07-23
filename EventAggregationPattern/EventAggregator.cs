using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.EventAggregationPattern
{
	class EventAggregator : IEventAggregator
	{
		List<IParticipant> participants;
		Dictionary<string, List<IParticipant>> eventSubscribers;

		public void Subsribe(string eventName, IParticipant participant)
		{
			participants.Add(participant);
			eventSubscribers[eventName].Add(participant);
		}

		public void Unsubscribe(string eventName, IParticipant participant)
		{
			eventSubscribers[eventName].Remove(participant);
		}

		public void Publish(string eventName)
		{
			//publish event
		}
	}
}
