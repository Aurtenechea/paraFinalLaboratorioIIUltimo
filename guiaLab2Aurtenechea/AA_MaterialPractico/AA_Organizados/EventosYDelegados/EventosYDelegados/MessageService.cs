using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosYDelegados
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: sending an Text message..." + args.Video.Title);

        }

        //public void OnVideoEncoded(object source, EventArgs args)
        //{
        //    Console.WriteLine("MessageService: sending an Text message...");

        //}
    }
}
