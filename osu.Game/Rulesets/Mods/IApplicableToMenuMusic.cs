// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Overlays;

namespace osu.Game.Rulesets.Mods
{
    public interface IMenuMusicController
    {
        double Length { get; }
        void Seek(double position);
    }

    public class MenuMusicController : IMenuMusicController
    {
        private readonly MusicController musicController;

        internal MenuMusicController(MusicController musicController)
        {
            this.musicController = musicController;
        }

        public double Length => musicController.CurrentTrack.Length;
        public void Seek(double position)
        {
            musicController.SeekTo(position);
        }
    }

    public interface IApplicableToMenuMusic
    {
        void ApplyToMenuMusic(IMenuMusicController menuMusicController);
    }
}
