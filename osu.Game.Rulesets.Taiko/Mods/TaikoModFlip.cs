// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Graphics.Sprites;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Taiko.Beatmaps;
using osu.Game.Rulesets.Taiko.Objects;

namespace osu.Game.Rulesets.Taiko.Mods
{
    public class TaikoModFlip : Mod, IApplicableToBeatmap
    {
        public override string Name => "Flip";
        public override string Acronym => "FP";
        public override string Description => @"Dons become kats, kats become dons";
        public override ModType Type => ModType.Conversion;
        public override double ScoreMultiplier => 1;

        public void ApplyToBeatmap(IBeatmap beatmap)
        {
            var taikoBeatmap = (TaikoBeatmap)beatmap;

            foreach (var obj in taikoBeatmap.HitObjects)
            {
                if (obj is Hit hit)
                    hit.Type = hit.Type == HitType.Centre ? HitType.Rim : HitType.Centre; 
            }
        }
    }
}
