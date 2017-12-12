namespace MineSweeperKata
{
    public class MineSweeper
    {
        private FieldConverter _fieldConverter;
        private MineAnalyser _mineAnalyser;

        public MineSweeper()
        {
            _fieldConverter = new FieldConverter();
            _mineAnalyser = new MineAnalyser();
        }

        public string Sweep(string fields)
        {
            var processedField = _fieldConverter.ConvertFrom(fields);
            var fieldWithMineInfo = _mineAnalyser.ReadMine(processedField);
            return "~~~\n" +
                   "Field #1: \n" +
                   fieldWithMineInfo +
                   "~~~";
        }
    }
}