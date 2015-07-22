using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public interface IMessageModel
    {
        int AddMessage(Message message);
        int RemoveMessage(int id);
        List<Message> Messages { get; }
    }
}
