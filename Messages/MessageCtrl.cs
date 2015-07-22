using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class MessageCtrl
    {
        private IMessageModel Model;

        public MessageCtrl(IMessageModel model)
        {
            Model = model;
        }

        public int AddMessage(Message message)
        {
            if (!IsMessageValid(message)) return -1;
            else if(!IsIdValid(message)) return -1;

            return Model.AddMessage(message);
        }

        private bool IsIdValid(Message message)
        {
            if (message.Id <= 0)
                throw new ArgumentException("Message Id should be positive");

            return true;
        }

        private bool IsDateValid(Message message)
        {
            if (message.Date == null)
                message.Date = DateTime.Now;
            if(message.Date.)


            return true;
        }
        private bool IsMessageValid(Message message)
        {
            
            if (message.Text == null)
            {
                throw new ArgumentNullException("message", "message.Text should not be null");
            }

            if (message.Text.Length <= 0)
            {
                throw new ArgumentOutOfRangeException("message", "message text should not be empty");
            }

            if (message.Text.Length > 20)
            {
                throw new ArgumentOutOfRangeException("message", "message text length should not be > 20");
            }
            return true;
        }

        public int RemoveMessage(int id)
        {
            return Model.RemoveMessage(id);
        }

        public List<Message> GetMessages()
        {
            return Model.Messages;
        }
    }
}
