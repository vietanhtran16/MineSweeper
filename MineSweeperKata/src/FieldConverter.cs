using System.Collections.Generic;
using System.Linq;
using MineSweeperKata.DTO;

namespace MineSweeperKata
{
    public class FieldConverter
    {
        public Field ConvertFrom(string fields)
        {
            var rowAndColumn = GetRowAndColumn(fields);
            var cleansedFieldValue = RemoveUnneedSymbols(fields);
            var fieldValue = RemoveRowAndColumn(cleansedFieldValue, rowAndColumn);
            
            return new Field()
            {
                NoOfRows = rowAndColumn.First(),
                NoOfColumns = rowAndColumn.Last(),
                Value = fieldValue,
            };
        }

        private List<int> GetRowAndColumn(string fields)
        {
            var rowAndColumn = new List<int>();
            foreach (var c in fields)
            {
                if (int.TryParse(c.ToString(), out var parsedChar))
                    rowAndColumn.Add(parsedChar);
            }

            return rowAndColumn;
        }

        private string RemoveUnneedSymbols(string fields)
        {
            return fields.Replace("~", "").Replace("\n", "").Replace(" ", "");
        }

        private string RemoveRowAndColumn(string cleansedFieldValue, IEnumerable<int> rowAndColumn)
        {
            foreach (var i in rowAndColumn)
                cleansedFieldValue = cleansedFieldValue.Replace(i.ToString(), "");

            return cleansedFieldValue;
        }
    }
}