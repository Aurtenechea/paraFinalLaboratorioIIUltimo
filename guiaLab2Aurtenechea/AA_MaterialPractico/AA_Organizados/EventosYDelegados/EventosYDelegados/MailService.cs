using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosYDelegados
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: sending an Email..." + e.Video.Title);
        }

        //public void OnVideoEncoded(object source, EventArgs e)
        //{
        //    Console.WriteLine("MailService: sending an Email...");
        //}
    
    }
}
