using System.Collections.Generic;
using System.Linq;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public void CreateSubscription(Subscription subscription)
        { 
            if(IsPremium)
            { 
                AddNotification(new Notification("Premium", "The Student has asignature active!"));
                return;
            }

            Subscriptions.Add(subscription);
        }
        public bool IsPremium => Subscriptions.Any(x=> !x.IsInactive);
    }
}