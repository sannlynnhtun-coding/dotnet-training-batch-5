using DotNetTrainingBatch5.ChartWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch5.ChartWebApp.Controllers
{
    public class ApexChartController : Controller
    {
        public IActionResult PieChart()
        {
            ApexChartPieChartModel model = new ApexChartPieChartModel();
            model.Series = new int[] { 44, 55, 13, 43, 22 };
            model.Labels = new string[] { "Team A", "Team B", "Team C", "Team D", "Team E" };
            return View(model);
        }

        public IActionResult MixedChart()
        {
            var model = new ApexChartMixedChartModel
            {
                Series = new List<SeriesData>
            {
                new SeriesData
                {
                    Name = "TEAM A",
                    Type = "column",
                    Data = new int[] { 23, 11, 22, 27, 13, 22, 37, 21, 44, 22, 30 }
                },
                new SeriesData
                {
                    Name = "TEAM B",
                    Type = "area",
                    Data = new int[] { 44, 55, 41, 67, 22, 43, 21, 41, 56, 27, 43 }
                },
                new SeriesData
                {
                    Name = "TEAM C",
                    Type = "line",
                    Data = new int[] { 30, 25, 36, 30, 45, 35, 64, 52, 59, 36, 39 }
                }
            },
                Labels = new string[] { "01/01/2003", "02/01/2003", "03/01/2003", "04/01/2003", "05/01/2003", "06/01/2003", "07/01/2003", "08/01/2003", "09/01/2003", "10/01/2003", "11/01/2003" }
            };

            return View(model);
        }
    }
}
