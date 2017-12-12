using System;
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

        public IEnumerable<string> Split(string field)
        {
            const string pattern = @"\~~~(.*?)\~~~";
            var test = Regex.Matches(field, pattern, RegexOptions.Singleline).Cast<Match>();
            return test.Select(m => m.Value);
        }

        public IEnumerable<Field> ConvertToFields(IEnumerable<string> splitFields)
        {
            return splitFields.Select(field => _fieldConverter.ConvertFrom(field)).ToList();
        }
    }
}