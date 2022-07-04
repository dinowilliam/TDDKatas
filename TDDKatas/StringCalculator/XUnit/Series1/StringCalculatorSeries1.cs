namespace TDDKatas.StringCalculator.XUnit.Series1 {
    public class StringCalculatorSeries1 {

        CalculatorValues calculatorValues;

        public object Add(string numbers) {
            calculatorValues = new CalculatorValues();
            
            calculatorValues.DelimiterArray = new List<char> { ',', '\n' };

            calculatorValues = processStringCustomDelimiter(calculatorValues.DelimiterArray, numbers);

            var splitNumbers = calculatorValues.Numbers
                .Split(calculatorValues.DelimiterArray.ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            return splitNumbers.Sum();
        }

        private CalculatorValues processStringCustomDelimiter(List<char> delimiterArray, string numbers) {
            var calculatorValues = new CalculatorValues();

            if (numbers.StartsWith("//")) {
                var splitDelimitersFromNumbers = numbers.Split(new char[] { '\n' }, 2);
                delimiterArray.Add(splitDelimitersFromNumbers[0].Replace("//", string.Empty).Single());
                numbers = splitDelimitersFromNumbers[1];
            }
            
            calculatorValues.DelimiterArray = delimiterArray;
            calculatorValues.Numbers = numbers;

            return calculatorValues;
        }
    }
}
