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
            dataTable.Columns.Add("Лайки", typeof(string));
            for(int i = 0; i < routes.Count; i++)
            {
                dataTable.Rows.Add(i + 1, routes[i].Duration, routes[i].Budget, routes[i].Seasonality, routes[i].Likes);
            }
            return dataTable;
        }
    }
}
