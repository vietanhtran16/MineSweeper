namespace MineSweeperKata
{
    public class MineSweeper
    {
        private readonly FieldSplitter _fieldSplitter;
        private readonly FieldFormatter _fieldFormatter;

        public MineSweeper()
        {
            _fieldSplitter = new FieldSplitter();
            _fieldFormatter = new FieldFormatter();
        }

        public string Sweep(string fields)
        {
            var processedFields = _fieldSplitter.TransformRawFields(fields);
            return _fieldFormatter.Format(processedFields);
        }
    }
}