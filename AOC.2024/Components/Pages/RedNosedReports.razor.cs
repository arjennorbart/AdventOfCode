using Microsoft.AspNetCore.Components;

namespace AOC._2024.Components.Pages;

public partial class RedNosedReports : ComponentBase
{
    private int safeReports = 0;
    private bool starCollected = false;

    private void FindSafeReports()
    {
        var file = File.ReadLines("day2.txt");
        foreach (var report in file)
        {
            // List levels
            var array = report.Split(" ");
            var levels = Array.ConvertAll(array, int.Parse).ToList();
            
            // Filter out all increasing/decreasing levels that contain no duplicates
            if (!levels.SequenceEqual(levels.Order().Distinct()) && !levels.SequenceEqual(levels.OrderDescending().Distinct()))
                continue;
            
            // Adjacent level difference cannot be more than 3
            var valid = true;
            for (int i = 1; i < levels.Count; i++)
            {
                if (Math.Abs(levels[i - 1] - levels[i]) > 3)
                    valid = false;
            }

            if (valid)
            {
                safeReports++;
            }
        }
        starCollected = true;
    }
}