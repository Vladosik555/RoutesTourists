using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesTourists.Classes
{
    public static class Tables
    {
        public static DataTable GetCharacteristicsTable(List<Route> routes)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Позиция", typeof(int));
            dataTable.Columns.Add("Длительность", typeof(int));
            dataTable.Columns.Add("Стоимость", typeof(int));
            dataTable.Columns.Add("Сезон", typeof(string));
            dataTable.Columns.Add("Лайки", typeof(int));
            if(routes != null)
            {
                for (int i = 0; i < routes.Count; i++)
                {
                    dataTable.Rows.Add(i + 1, routes[i].Duration, routes[i].Budget, routes[i].Seasonality, routes[i].Likes);
                }
            }
            return dataTable;
        }
        public static DataTable GetSelectionTable(List<Selection> selections)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Позиция", typeof(int));
            dataTable.Columns.Add("Название подборки", typeof(string));
            dataTable.Columns.Add("Длительность", typeof(int));
            dataTable.Columns.Add("Стоимость", typeof(int));
            dataTable.Columns.Add("Сезон", typeof(string));
            dataTable.Columns.Add("Лайки", typeof(int));
            using (var context = new RoutesForTouristsContext())
            {
                if (selections != null)
                {
                    for (int i = 0; i < selections.Count; i++)
                    {
                        var route = context.Routes.FirstOrDefault(r => r.Id.Equals(selections[i].IdRoutes));
                        dataTable.Rows.Add(i + 1, selections[i].Name, route.Duration, route.Budget, route.Seasonality, route.Likes);
                    }
                }
                return dataTable;
            }
        }
    }
}
