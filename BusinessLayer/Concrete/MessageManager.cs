using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDAL _messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public Message GetById(int id)
        {
            return _messageDAL.Get(x => x.MessageId == id);
        }

        public List<Message> GetListInbox()
        {
            return _messageDAL.List(x => x.RecieverMail == "admin@gmail.com");
        }

     

        public List<Message> GetListSendbox()
        {
            return _messageDAL.List(x => x.SenderMail == "admin@gmail.com");

        }

        public void MessageAddBL(Message message)
        {
            _messageDAL.Insert(message);
        }

        public void MessageDelete(Message category)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message category)
        {
            throw new NotImplementedException();
        }
    }
}
