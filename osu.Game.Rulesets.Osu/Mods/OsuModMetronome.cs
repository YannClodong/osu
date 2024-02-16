using System;
using System.Linq;
using osu.Framework.Localisation;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Osu.Objects;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Osu.Mods
{
    public class OsuModMetronome : Mod, IApplicableToDrawableRuleset<OsuHitObject>
    {
        public void ApplyToDrawableRuleset(DrawableRuleset<OsuHitObject> drawableRuleset)
        {
            drawableRuleset.Overlays.Add(new MetronomeBeat(drawableRuleset.Beatmap.HitObjects.First().StartTime));
        }

        public override String Name { get; } = "Metronome";
        public override LocalisableString Description { get; } = "Beat when you're playing.";
        public override Double ScoreMultiplier { get; } = 1;
        public override String Acronym { get; } = "MT";

        public override ModType Type { get; } = ModType.Training;
    }
}
