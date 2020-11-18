using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.UI.Messages
{
    public static class Messenger<T> where T : IMessage
    {
        private static readonly Dictionary<Type,IList<IObserver<T>>> _subscribers;
        
        static Messenger()
        {
            _subscribers = new Dictionary<Type , IList<IObserver<T>>>();
        }

        public static void Unsubscribe(IObserver<T> subscriber)
        {
            if(_subscribers.TryGetValue(typeof(T),out var subscriberList))
            {
                subscriberList.Remove(subscriber);
            }
        }

        public static void Subscribe(IObserver<T> subscriber)
        {
            if (_subscribers.TryGetValue(typeof(T) , out var subscriberList))
            {
                subscriberList.Add(subscriber);
            }
            else
            {
                subscriberList = new List<IObserver<T>>();
                subscriberList.Add(subscriber);
                _subscribers.Add(typeof(T) , subscriberList);
            }
        }

        public static void Publish(T message) 
        {
            if(message is T && _subscribers.TryGetValue(typeof(T),out var listeners))
            {
                foreach(var listener in listeners)
                {
                    listener.OnNext(message);
                    listener.OnCompleted();
                }
            }
        }
    }
}
