namespace FunctionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            FormRange dialog = new FormRange();

            //Я выбрал делать модальное окно. Т.к. оно блокирует главное окно пока
            //пользователь не выполнит действие, не введет интервал. Потому что
            //расчет функции не может быть без введенного интервала.

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                double start = dialog.IntervalStart;
                double end = dialog.IntervalEnd;
                label2.Text = $"Левая граница: {start}, правая граница: {end}";
                CalculatorSin(start, end);
            }
        }
        private void CalculatorSin(double start, double end) //метод расчета sin
        {
            richTextBox1.Clear();
            if (start > end)
            {
                double temp = start;
                start = end;
                end = temp;
            }
            double step = (end - start) / 100;
            if (step == 0) step = 0.1;
            for (double x = start; x <= end; x += step)
            {
                double y = Math.Sin(x);
                string resultLine = $"{x:F2} : {y:F2}";
                richTextBox1.AppendText(resultLine + Environment.NewLine);
            }
        }
    }
}
