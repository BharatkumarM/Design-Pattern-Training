using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ObserverPattern
{
	class Subject1 : ISubject
	{
		List<IObserver> observers;
		public void Subscribe(IObserver observer)
		{
			observers.Add(observer);
		}

		public void UnSubscribe(IObserver observer)
		{
			observers.Remove(observer);
		}

		public void NotifyAll()
		{
			observers.ForEach((obs) =>
			{
				obs.update();
			});
		}
	}
}
