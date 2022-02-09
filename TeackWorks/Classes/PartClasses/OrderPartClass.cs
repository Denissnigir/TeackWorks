using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeackWorks.Model
{
    public partial class Order
    {
        public byte[] GetPhoto
        {
            get
            {
                var firstPhoto = Context._con.OrderPicture.ToList().Where(p => p.IdOrder == Id).FirstOrDefault();
                byte[] photo = null;
                if(firstPhoto == null)
                {
                }
                else
                {
                    photo = firstPhoto.PhotoOrder;
                }
                return photo;
            }
        }
    }
}
