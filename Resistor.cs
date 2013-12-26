namespace ResistorCalculator {
    internal sealed class Resistor {
        public readonly string Color;
        public readonly bool IsBelowZero;
        public readonly ulong Value;
        public readonly double Value2;

        public Resistor(string color, ulong value) {
            Color = color;
            Value = value;
            IsBelowZero = false;
        }

        public Resistor(string color, double value) {
            Color = color;
            Value2 = value;
            IsBelowZero = true;
        }

        public override string ToString() { return Color; }
    }
}