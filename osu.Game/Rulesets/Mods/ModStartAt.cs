// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Bindables;
using osu.Framework.Localisation;
using osu.Game.Beatmaps;
using osu.Game.Configuration;

namespace osu.Game.Rulesets.Mods
{
    public abstract class ModStartAt : Mod, IApplicableToBeatmap, IApplicableToMenuMusic
    {
        public override string Name { get; } = "Start At";
        public override LocalisableString Description { get; } = "Define wher to start in the song.";
        public override double ScoreMultiplier { get; } = 1;
        public override string Acronym { get; } = "SA";
        public override ModType Type { get; } = ModType.Training;

        [SettingSource(label: "Position", description: "Define where to start in the song.")]
        public Bindable<double> StartPosition { get; } = new BindableDouble()
        {
            MinValue = 0,
            MaxValue = 1,
            Precision = 0.01f
        };

        public abstract void ApplyToBeatmap(IBeatmap beatmap);

        public void ApplyToMenuMusic(IMenuMusicController menuMusicController)
        {
            StartPosition.ValueChanged += ev => menuMusicController.Seek(menuMusicController.Length * ev.NewValue);
        }
    }
}
