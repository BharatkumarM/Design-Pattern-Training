using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.EventAggregationPattern
{
	class ParticipantB : IParticipant
	{
		public ParticipantB(IEventAggregator eventAggregator)
		{
			eventAggregator.Subsribe("OnSearchCompleted", this);
			eventAggregator.Subsribe("OnUpdate", this);
		}

		public void RaiseEvent(IEventAggregator eventAggregator)
		{
			eventAggregator.Publish("OnItemSelected");
		}
	}
}
