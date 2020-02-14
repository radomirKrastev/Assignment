namespace Assignment
{
    using System;
    using System.Text;

    public class Logo : ILogo
    {
        private const char LogoPart = '*';
        private const char FieldPart = '-';
        private int size;
        private char[][] field;

        public Logo(int size)
        {
            this.Size = size;
            this.field = new char[this.Size + 1][];
            this.Design();
        }

        public int Size
        {
            get => this.size;
            private set
            {
                if (value <= 2 || value > 10000 || value % 2 == 0)
                {
                    throw new ArgumentException("Entered size does not corresponds to constraints! Please try again.");
                }

                this.size = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            for (int r = 0; r < this.field.GetLength(0); r++)
            {
                builder.Append(string.Join(string.Empty, this.field[r]));
                builder.Append(string.Join(string.Empty, this.field[r]));
                builder.Append(Environment.NewLine);
            }

            return builder.ToString();
        }

        private void Design()
        {
            for (int row = 0; row < this.Size + 1; row++)
            {
                this.field[row] = new char[this.Size * 5];
            }

            for (int r = 0; r < this.field.GetLength(0); r++)
            {
                for (int c = 0; c < this.field[r].Length; c++)
                {
                    this.field[r][c] = this.ValidatePartOfLogo(r, c) ? LogoPart : FieldPart;
                }
            }
        }

        private bool ValidatePartOfLogo(int r, int c)
        {
            Func<int, int, bool> startPoint1 = (row, col) =>
            {
                var start = this.Size - 1 - row;
                return col > start && col <= start + this.Size;
            };

            Func<int, int, bool> startPoint2 = (row, col) =>
            {
                var start = this.Size - 1 + row;
                return col > start && col <= start + this.Size;
            };

            Func<int, int, bool> startPoint3 = (row, col) =>
            {
                var start = (this.Size * 3) - 1 - row;
                return col > start && col <= start + this.Size;
            };

            Func<int, int, bool> startPoint4 = (row, col) =>
            {
                var start = (this.Size * 3) - 1 + row;
                return col > start && col <= start + this.Size;
            };

            return startPoint1(r, c) || startPoint2(r, c) || startPoint3(r, c) || startPoint4(r, c);
        }
    }
}
