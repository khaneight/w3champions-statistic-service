﻿namespace W3ChampionsStatisticService.PlayerStats.RaceOnMapVersusRaceStats
{
    public class WinRate
    {
        public WinRate(in int wins, in int losses)
        {
            Rate = losses + wins != 0 ? wins / (double) (wins + losses) : 0;
        }

        public double Rate { get; set; }
    }
}