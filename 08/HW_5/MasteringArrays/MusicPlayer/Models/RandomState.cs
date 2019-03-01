using System.Threading;
using MusicPlayer.Interface;

namespace MusicPlayer.Models
{
    public class RandomState : PlayStateBase, IState
    {
        IState IState.RunState()
        {
            HeaderState(StRandom);

            var newThreadFind = new Thread(SetIsSeekSong);
            newThreadFind.Start();

            SongHandler(Random);

            FooterState();
            return new MenuPlay();
        }
    }
}