using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayers.Core.Interfaces
{
    public interface IProgressBar
    {
        int ProgressBarCurrentTime { get; set; }
        IMediaPlayer PlayerProgressBar { get; set; }
        double GetTime();
        void SetTime(double time);
    }
}
