using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MediaPlayers.Core.Interfaces
{
    public interface IMediaPlayer
    {
        FrameworkElement MediaPlayer { get; set; }
        /// <summary>
        /// Show type video(stream or video from pc)
        /// </summary>
        int VideoType { get; set; }
        /// <summary>
        /// Select type of media player 
        /// 1-VLC
        /// 2-Standart MediaElement
        /// </summary>
        int MediaPlayerType { get; }
        /// <summary>
        /// Show time possition current video
        /// </summary>
        TimeSpan CurrentVideoPossition { get; set; }
        /// <summary>
        /// Length video content
        /// </summary>
        TimeSpan CurrentVideoLength { get; }
        /// <summary>
        /// Path to our video element
        /// </summary>
        string SourceUrl { get; set; }

        void Play();
        void Stop();
        void Pause();
        void FastPlay(int rate);
        void OneFrameForward();
        void OneFrameBackward();
    }
}
