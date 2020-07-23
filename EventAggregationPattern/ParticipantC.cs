using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.EventAggregationPattern
{
	class ParticipantC : IParticipant
	{
		public ParticipantC(IEventAggregator eventAggregator)
		{
			eventAggregator.Subsribe("OnItemSelected", this);
		}

		public void RaiseEvent(IEventAggregator eventAggregator)
		{
			eventAggregator.Publish("OnUpdate");
		}
	}
}
