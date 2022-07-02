namespace TDDKatas.StringCalculator.XUnit {
    public class StringCalculatorSeries1 {
        
        public object Add(string numbers) {
            Int32 value = 0;

            var splitNumbers = numbers.Split(",");

            if (splitNumbers.Any() && splitNumbers.Length > 0) {

                foreach (var number in splitNumbers) { 
                    if(!String.IsNullOrWhiteSpace(number))
                        value += Convert.ToInt32(number);
                }

            }

            return value;
        }
    }
}
