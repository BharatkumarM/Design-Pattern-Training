using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.EventAggregationPattern
{
	interface IParticipant
	{
		void RaiseEvent(IEventAggregator eventAggregator);
	}
}
