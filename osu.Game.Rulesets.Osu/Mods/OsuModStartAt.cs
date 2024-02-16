// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Linq;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Osu.Beatmaps;

namespace osu.Game.Rulesets.Osu.Mods
{
    public class OsuModStartAt : ModStartAt
    {
        public override void ApplyToBeatmap(IBeatmap beatmap)
        {
            var b = (OsuBeatmap)beatmap;
            b.HitObjects = b.HitObjects.Where(o => o.StartTime > b.BeatmapInfo.Length * StartPosition.Value).ToList();
        }
    }
}
