using System.Collections.Generic;
using System.Text;
using MineSweeperKata.DTO;

namespace MineSweeperKata
{
    public class FieldFormatter
    {
        private readonly MineAnalyser _mineAnalyser;

        public FieldFormatter()
        {
            _mineAnalyser = new MineAnalyser();
        }

        public string Format(IEnumerable<Field> processedFields)
        {
            var result = new StringBuilder();
            var fieldCount = 1;
            foreach (var processedField in processedFields)
            {
                const string fieldSeparator = "~~~\n";
                result.Append(fieldSeparator);
                result.Append($"Field #{fieldCount}:\n");
                result.Append(_mineAnalyser.Read(processedField));
                result.Append(fieldSeparator);
                result.Append("\n");
                fieldCount++;
            }
            return result.ToString();
        }
    }
}