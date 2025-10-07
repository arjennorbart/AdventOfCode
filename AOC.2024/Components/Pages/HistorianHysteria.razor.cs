using Microsoft.AspNetCore.Components;

namespace AOC._2024.Components.Pages;

public partial class HistorianHysteria : ComponentBase
{
    private bool disabled = false;
    private int totalDistance = 0;
    private List<int> leftList = [];
    private List<int> rightList = [];

    private void CalculateDistance()
    {
        // Read the file and fill the lists with the left and right location ID's
        var file = File.ReadLines("day1.csv");
        foreach (var line in file)
        {
            
            // In other cases use TryParse and build in some validation
            var locationIds = line.Split(",");
            leftList.Add(int.Parse(locationIds[0]));
            rightList.Add(int.Parse(locationIds[1]));
        }
        
        // Sort both lists to go from smallest to largest number
        leftList.Sort();
        rightList.Sort();

        // Subtract each "location ID" of the left and right list and use Absolute values
        for (var i = 0; i < leftList.Count; i++)
        {
            totalDistance += Math.Abs(rightList[i] - leftList[i]);
            disabled = true;
        }
    }
}
