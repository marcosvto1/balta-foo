using System.Collections.Generic;
using System.Linq;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
  public class Student: Base 
  {

    public Student()
    {
      Subscriptions = new List<Subscription>();
    }
    public string Name { get; set; }
    public string Email { get; set; }    
    public User User { get; set; }

    public IList<Subscription> Subscriptions {get; set;}

    public bool isPremium => Subscriptions.Any(x => !x.IsInaActive);

    public void CreateSubscription(Subscription subscription) {
      if (isPremium)
      {
        AddNotification(new NotificationContext.Notification("Premium", "O Aluno já é premium"));
        return;
      }

      Subscriptions.Add(subscription);
    }

  }
}