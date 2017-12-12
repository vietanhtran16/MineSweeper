using System.Text;

namespace MineSweeperKata
{
    public class MineSweeper
    {
        private readonly FieldSplitter _fieldSplitter;
        private readonly MineAnalyser _mineAnalyser;

        public MineSweeper()
        {
            _fieldSplitter = new FieldSplitter();
            _mineAnalyser = new MineAnalyser();
        }

        public string Sweep(string fields)
        {
            var splitFields = _fieldSplitter.Split(fields);
            var processedFields = _fieldSplitter.ConvertToFields(splitFields);
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