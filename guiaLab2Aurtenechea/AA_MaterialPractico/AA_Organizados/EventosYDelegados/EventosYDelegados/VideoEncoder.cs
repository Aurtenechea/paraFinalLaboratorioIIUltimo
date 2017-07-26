using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventosYDelegados
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    class VideoEncoder
    {

        // public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        // para no tener que crear el delegado, se puede crear el evento usando la clase generica:
        // public event EventHandler<VideoEventArgs> VideoEncoded;
        // asi esa linea produce el mismo efecto que las 2 anteriores.

        // tambien si se va a usar un evento que no necesita enviar ningun tipo de dato en especial
        // se puede usar la forma normal. Ej:
        // public event EventHandler VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
            //OnVideoEncoded();
        }
        
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video } );
        }
        
        //protected virtual void OnVideoEncoded()
        //{
        //    if (VideoEncoded != null)
        //        VideoEncoded(this, EventArgs.Empty);
        //}
    
    }
}
