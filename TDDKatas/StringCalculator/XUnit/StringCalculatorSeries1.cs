namespace TDDKatas.StringCalculator.XUnit {
    public class StringCalculatorSeries1 {
        
        public object Add(string numbers) {
            var delimiterArray = new List<char> { ',', '\n' };

            if (numbers.StartsWith("//")) { 
                var splitDelimitersFromNumbers = numbers.Split(new char[] { '\n' }, 2);
                delimiterArray.Add(splitDelimitersFromNumbers[0].Replace("//", string.Empty).Single());
                numbers = splitDelimitersFromNumbers[1];
            }

            var splitNumbers = numbers
                .Split(delimiterArray.ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
                       
            return splitNumbers.Sum();                        
        }
    }
}
