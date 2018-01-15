using System.Collections.Generic;
using System.Text;

namespace MineSweeperKata
{
    public class FieldFormatter
    {
        private readonly MineAnalyser _mineAnalyser;
        private string _fieldSeparator = "~~~\n";

        public FieldFormatter()
        {
            _mineAnalyser = new MineAnalyser();
        }

        public string Format(IEnumerable<DTO.Field> processedFields)
        {
            var result = new StringBuilder();
            var fieldCount = 1;
            foreach (var processedField in processedFields)
            {
                result.Append(_fieldSeparator);
                result.Append($"Field #{fieldCount}:\n");
                result.Append(_mineAnalyser.Read(processedField));
                result.Append(_fieldSeparator);
                result.Append("\n");
                fieldCount++;
            }
            return result.ToString();
        }
    }
}