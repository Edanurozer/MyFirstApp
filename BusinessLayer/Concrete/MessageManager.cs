using BusinessLayer.Abstrac;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void DeleteMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public Message GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _messageDal.List(x => x.ReciverMail == "admin@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message messasge)
        {
            throw new NotImplementedException();
        }
    }
}
