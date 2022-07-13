using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenRecorder;

namespace screen_recorder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var num = rnd.Next();
            var rec = new Recorder(new RecorderParams("out" + num + ".avi", 10, SharpAvi.KnownFourCCs.Codecs.MotionJpeg, 70));
            Console.WriteLine("Press any key to Stop...");
            Console.ReadKey();

            // Finish Writing
            rec.Dispose();
        }
    }
}