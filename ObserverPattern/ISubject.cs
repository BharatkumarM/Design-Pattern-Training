using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ObserverPattern
{
	interface ISubject
	{
		void Subscribe(IObserver observer);
		void UnSubscribe(IObserver observer);
	}
}
