using System.Threading;
using MusicPlayer.Interface;

namespace MusicPlayer.Models
{
    public class BackState : PlayStateBase, IState
    {
        IState IState.RunState()
        {
            HeaderState(StBack);

            var newThreadFind = new Thread(SetIsSeekSong);
            newThreadFind.Start();

            SongHandler(Back);

            FooterState();
            return new MenuPlay();
        }
    }
}