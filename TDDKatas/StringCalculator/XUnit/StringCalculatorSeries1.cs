namespace TDDKatas.StringCalculator.XUnit {
    public class StringCalculatorSeries1 {
        
        public object Add(string numbers) {
            Int32 value = 0;

            var splitNumbers = numbers.Split(",", StringSplitOptions.RemoveEmptyEntries);

            if (splitNumbers.Any() && splitNumbers.Length > 0) {

                foreach (var number in splitNumbers) {                     
                        value += Convert.ToInt32(number);
                }

            }

            return value;
        }
    }
}
