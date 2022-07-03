namespace TDDKatas.StringCalculator.XUnit {
    public class StringCalculatorSeries1 {
        
        public object Add(string numbers) {
            
            var splitNumbers = numbers
                .Split(new char[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
                       
            return splitNumbers.Sum();                        
        }
    }
}
