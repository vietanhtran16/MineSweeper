using System.Collections.Generic;
using System.Linq;
using MineSweeperKata.DTO;

namespace MineSweeperKata
{
    public class FieldProcessor
    {
        public Field Process(string fields)
        {
            var field = new Field();
            var rowAndColumn = new List<int>();
            foreach (var c in fields)
            {
                int parsedChar;
                var result = int.TryParse(c.ToString(), out parsedChar);
                if(result)
                    rowAndColumn.Add(parsedChar);
            }

            field.NoOfRows = rowAndColumn.First();
            field.NoOfColumns = rowAndColumn.Last();
            field.Value = fields;
            return field;
        }
    }
}