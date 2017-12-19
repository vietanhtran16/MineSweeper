using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MineSweeperKata.DTO;

namespace MineSweeperKata
{
    public class FieldSplitter
    {
        private readonly FieldConverter _fieldConverter;

        public FieldSplitter()
        {
            _fieldConverter = new FieldConverter();
        }

        public IEnumerable<Field> TransformRawFields(string fields)
        {
            var splitFields = Split(fields);
            return ConvertMultipleFields(splitFields);
        }

        public IEnumerable<string> Split(string fields)
        {
            const string pattern = @"\~~~(.*?)\~~~";
            var test = Regex.Matches(fields, pattern, RegexOptions.Singleline).Cast<Match>();
            return test.Select(m => m.Value);
        }

        private IEnumerable<Field> ConvertMultipleFields(IEnumerable<string> splitFields)
        {
            return splitFields.Select(field => _fieldConverter.ConvertFrom(field)).ToList();
        }
    }
}