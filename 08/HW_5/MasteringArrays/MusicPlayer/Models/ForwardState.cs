using System.Threading;
using MusicPlayer.Interface;

namespace MusicPlayer.Models
{
    public class ForwardState : PlayStateBase, IState
    {
        IState IState.RunState()
        {
            HeaderState(StForward);

            var newThreadFind = new Thread(SetIsSeekSong);
            newThreadFind.Start();

            SongHandler(Forward);

            FooterState();
            return new MenuPlay();
        }
    }
}